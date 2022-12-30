using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace MyYoutubeDowloader
{
    public partial class mainForm : Form
    {
        private static string PARAM_TEMPLATE_GET_NAME = " {cookie-file} --flat-playlist {playlist-url}";
        private static string PARAM_TEMPLATE_GET_VIDEOS = " {cookie-file} --get-title {playlist-url}";
        private static string PARAM_TEMPLATE_DOWNLOAD = " {cookie-file} --mark-watched -o {output-path} {cust-format} {playlist-url} --playlist-items {idx}";

        public object lockObj = new object();
        public bool formCosed = false;

        private List<PlaylistObject> list_Playlist = new List<PlaylistObject>();
        private List<VideoObject> list_Video = new List<VideoObject>();
        public List<DldrProperties> propList = null;

        private Thread thread_Playlist;
        private Thread[] thread_Videos;

        private string ytdlCommand = "";
        private string ytdlParam_cookiePath = "";
        private string ytdlParam_custFormat = "";
        private string ytdlCommand_GetPlatlistName = "";
        private string ytdlCommand_GetPlatlistVideo = "";
        private string ytdlCommand_VideoDownload = "";

        public mainForm()
        {
            InitializeComponent();
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            // get default properties by 反序列化
            string propFile = Path.Combine(System.AppContext.BaseDirectory, @"propertes.xml");
            using (Stream fStream = new FileStream(propFile, FileMode.Open, FileAccess.Read))
            {
                XmlSerializer xmlFormat = new XmlSerializer(typeof(List<DldrProperties>));
                fStream.Position = 0;
                propList = (List<DldrProperties>)xmlFormat.Deserialize(fStream);
            }

            // set default value
            if (propList == null)
            {
                // set deault value
                propList = new List<DldrProperties>();
                propList.Add(
                    new DldrProperties()
                    {
                        ytdlExeFilePath = "./youtube-dl/youtube-dl.exe",
                        cookieFilePath = "./youtube-dl/youtube.com_cookies.txt",
                        downloadPath = "D:/download/",
                        custDownloadResolution = "best[filesize<50M]/best[filesize<100M]/best",
                        watchLaterUrl = "https://www.youtube.com/playlist?list=WL",
                        threadCount = 10,
                        useDefaultYtdl = true,
                        skipCookie = false,
                        createSubFolderByPlaylistName = true,
                        skipCreatingSubFolderForWatchLater = true
                    });
            }

            // update properties to GUI
            TxtBox_YtdlPath.Text = propList[0].ytdlExeFilePath;
            TxtBox_CookiePath.Text = propList[0].cookieFilePath;
            TxtBox_DownloadPath.Text = propList[0].downloadPath;
            TxtBox_CustFormat.Text = propList[0].custDownloadResolution;
            TxtBox_DefaultWatchLaterUrl.Text = propList[0].watchLaterUrl;
            ChkBox_UseDefaultYtdl.Checked = propList[0].useDefaultYtdl;
            ChkBox_SkipCookie.Checked = propList[0].skipCookie;
            ChkBox_CreateSubfolderByPlaylistName.Checked = propList[0].createSubFolderByPlaylistName;
            ChkBox_SkipSubfolderForWatchLater.Checked = propList[0].skipCreatingSubFolderForWatchLater;
            ChkBox_CustResolution.Checked = propList[0].useCustDownloadResolution;
            ComBox_ThreadCount.Text = propList[0].threadCount.ToString();
        }

        private void mainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            formCosed = true;

            // terminate all threads
            if (thread_Playlist != null) thread_Playlist.Abort();
            if (thread_Videos != null) foreach (Thread thrd in thread_Videos) thrd.Abort();
            timer.Stop();
        }

        private void mainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // set properties from GUI
            propList[0].ytdlExeFilePath = TxtBox_YtdlPath.Text;
            propList[0].cookieFilePath = TxtBox_CookiePath.Text;
            propList[0].downloadPath = TxtBox_DownloadPath.Text;
            propList[0].custDownloadResolution = TxtBox_CustFormat.Text;
            propList[0].watchLaterUrl = TxtBox_DefaultWatchLaterUrl.Text;
            propList[0].useDefaultYtdl = ChkBox_UseDefaultYtdl.Checked;
            propList[0].skipCookie = ChkBox_SkipCookie.Checked;
            propList[0].createSubFolderByPlaylistName = ChkBox_CreateSubfolderByPlaylistName.Checked;
            propList[0].skipCreatingSubFolderForWatchLater = ChkBox_SkipSubfolderForWatchLater.Checked;
            propList[0].useCustDownloadResolution = ChkBox_CustResolution.Checked;
            propList[0].threadCount = int.Parse(ComBox_ThreadCount.Text);

            // set default properties by 序列化
            string propFile = Path.Combine(System.AppContext.BaseDirectory, @"propertes.xml");
            using (Stream fStream = new FileStream(propFile, FileMode.OpenOrCreate, FileAccess.Write))
            {
                XmlSerializer xmlFormat = new XmlSerializer(typeof(List<DldrProperties>));
                xmlFormat.Serialize(fStream, propList);
            }
        }

        private void AddWatchLater_Click(object sender, EventArgs e)
        {
            // 加入稍後觀看的 url
            String url = TxtBox_DefaultWatchLaterUrl.Text.Trim();
            if (isUrlInPlaylist(url)) MessageBox.Show("\"稍後觀看\" 已加入下載列表");
            else
            {
                PlaylistObject plst = new PlaylistObject();
                plst.url = url;
                plst.name = "稍後觀看";

                lock(lockObj)
                {
                    list_Playlist.Add(plst);
                }
            }
        }

        private void AddPlaylist_Click(object sender, EventArgs e)
        {
            // 加入自訂 Playlist url
            PlaylistUrlForm dlg = new PlaylistUrlForm();
            DialogResult result = dlg.ShowDialog();
            if (result == DialogResult.OK)
            {
                String url = dlg.getUrl().Trim();

                if (isUrlInPlaylist(url)) MessageBox.Show(url + " 已加入下載列表");
                else
                {
                    PlaylistObject plst = new PlaylistObject();
                    plst.url = url;
                    plst.name = "未知";

                    lock (lockObj)
                    {
                        list_Playlist.Add(plst);
                    }
                }
            }
            dlg.Dispose();
        }

        private void DeletePlaylist_Click(object sender, EventArgs e)
        {
            // 刪除選擇的 playlist
            lock(lockObj)
            {
                for (int n = 0; n < LstView_Playlist.SelectedItems.Count; ++n)
                {
                    string url = LstView_Playlist.SelectedItems[n].SubItems[1].Text;
                    removeUrlInPlaylist(url);
                }
            }
        }

        private void ClearPlaylist_Click(object sender, EventArgs e)
        {
            // 刪除全部 Playlist
            //SourceList.Items.Clear();
            lock(lockObj)
            {
                list_Playlist.Clear();
            }
        }

        private void StartDownload_Click(object sender, EventArgs e)
        {
            // disable all buttons
            Btn_AddPlaylist.Enabled = false;
            Btn_AddWatchLater.Enabled = false;
            Btn_ClearPlaylist.Enabled = false;
            Btn_DeletePlaylist.Enabled = false;
            Btn_StartDownload.Enabled = false;

            // set cursor type
            Cursor.Current = Cursors.WaitCursor;

            // 預先把 youtube-dl 的參數準備好
            ytdlCommand = TxtBox_YtdlPath.Text.Trim();
            ytdlParam_cookiePath = TxtBox_CookiePath.Text.Trim();
            ytdlParam_custFormat = "-f \"" + TxtBox_CustFormat.Text.Trim() + "\"";
            if (ChkBox_UseDefaultYtdl.Checked)
            {
                ytdlCommand = "\"" + Path.Combine(System.AppContext.BaseDirectory, @"youtube-dl\youtube-dl.exe") + "\"";
                ytdlParam_cookiePath = "--cookies \"" + Path.Combine(System.AppContext.BaseDirectory, @"youtube-dl\youtube.com_cookies.txt") + "\"";
            }
            if (ChkBox_SkipCookie.Checked) ytdlParam_cookiePath = "";
            if (!ChkBox_CustResolution.Checked) ytdlParam_custFormat = "";

            // 預先把 youtube-dl Command 準備好, 只留執行時才能決定的部分.
            ytdlCommand_GetPlatlistName = PARAM_TEMPLATE_GET_NAME.Replace("{cookie-file}", ytdlParam_cookiePath);
            ytdlCommand_GetPlatlistVideo = PARAM_TEMPLATE_GET_VIDEOS.Replace("{cookie-file}", ytdlParam_cookiePath);
            ytdlCommand_VideoDownload = PARAM_TEMPLATE_DOWNLOAD
                .Replace("{cookie-file}", ytdlParam_cookiePath)
                .Replace("{cust-format}", ytdlParam_custFormat);

            // clear video list in list
            list_Video.Clear();

            // start 1 new thread to get playlist
            if (thread_Playlist != null) thread_Playlist.Abort();
            thread_Playlist = new Thread(getVideoList);
            thread_Playlist.Start();

            // start N new threads to get all videos
            if (thread_Videos != null) foreach (Thread thrd in thread_Videos) thrd.Abort();
            int threadCnt = int.Parse(ComBox_ThreadCount.Text);
            thread_Videos = new Thread[threadCnt];
            for (int n=0; n<threadCnt; ++n)
            {
                thread_Videos[n] = new Thread(downloadVideo);
                thread_Videos[n].Start();
                Thread.Sleep(1000);
            }
        }

        private void getVideoList()
        {
            if (list_Playlist.Count <= 0) return;

            // get playlist name
            //string param1 = PARAM_TEMPLATE_GET_NAME.Replace("{cookie-file}", "\"" + ytdlParam_cookiePath + "\"");
            //string param2 = PARAM_TEMPLATE_GET_VIDEOS.Replace("{cookie-file}", "\"" + ytdlParam_cookiePath + "\"");

            //---
            for (int n=0; n< list_Playlist.Count; ++n)
            {
                PlaylistObject plst = list_Playlist[n];

                // prepare 2 command parameters
                string thisParam1 = ytdlCommand_GetPlatlistName.Replace("{playlist-url}", "\"" + plst.url + "\"");
                string thisParam2 = ytdlCommand_GetPlatlistVideo.Replace("{playlist-url}", "\"" + plst.url + "\"");

                // Get Playlist Name
                ProcessStartInfo cmdsi = new ProcessStartInfo(ytdlCommand);
                cmdsi.Arguments = thisParam1;
                cmdsi.UseShellExecute = false;
                cmdsi.RedirectStandardError = true;
                cmdsi.RedirectStandardInput = true;
                cmdsi.RedirectStandardOutput = true;
                cmdsi.CreateNoWindow = true;
                //cmdsi.StandardOutputEncoding = System.Text.Encoding.UTF8;

                if (plst.url.Equals(TxtBox_DefaultWatchLaterUrl.Text))
                {
                    plst.name = "[稍後觀看]";
                }
                else
                {
                    Process process1 = Process.Start(cmdsi);
                    process1.OutputDataReceived +=
                        (o, e) =>
                        {
                            if (!string.IsNullOrEmpty(e.Data) && e.Data.StartsWith("[download] Downloading playlist:"))
                            {
                                plst.name = e.Data.Substring(33);
                            }
                        };
                    process1.BeginOutputReadLine();
                    process1.WaitForExit();
                }

                if (plst.name.Trim().Length <= 0) plst.name = "[Playlist " + (n+1) + " 名稱取得失敗]";

                // Get Videos in this Playlist
                int id = 0;
                cmdsi.Arguments = thisParam2;
                Process process2 = Process.Start(cmdsi);
                process2.OutputDataReceived +=
                    (o, e) =>
                    {
                        if (!string.IsNullOrEmpty(e.Data))
                        {
                            VideoObject vo = new VideoObject();
                            vo.playlistId = n;
                            vo.videoId = ++id;
                            vo.name = e.Data;
                            vo.progress = "";
                            vo.size = "---";

                            lock(lockObj)
                            {
                                list_Video.Add(vo);
                            }
                        }
                    };
                process2.BeginOutputReadLine();
                process2.WaitForExit();
            }
        }

        private void downloadVideo()
        {
            // go download
            while(true)
            {
                // stop this thread after form close
                if (formCosed) break;

                // get next un-processed video to download
                VideoObject currVideoObj = null;
                lock(lockObj)
                {
                    for (int n = 0; n < list_Video.Count; ++n)
                    {
                        if (list_Video[n].progress.Equals(""))
                        {
                            currVideoObj = list_Video[n];
                            currVideoObj.progress = "0.00%";
                            break;
                        }
                    }
                }

                if (currVideoObj== null)
                {
                    // wait for video input
                    Thread.Sleep(3000);
                    continue;
                }

                // prepare output parameter
                bool isCreateSubFolder = 
                    ChkBox_CreateSubfolderByPlaylistName.Checked && (
                    !ChkBox_SkipSubfolderForWatchLater.Checked || 
                    !list_Playlist[currVideoObj.playlistId].name.Equals("[稍後觀看]"));
                string outPathParam = isCreateSubFolder ?
                    "\"" + TxtBox_DownloadPath.Text.Trim().TrimEnd("/\\".ToArray()) + "/%(playlist_title)s/%(title)s.%(ext)s\"":
                    "\"" + TxtBox_DownloadPath.Text.Trim().TrimEnd("/\\".ToArray()) + "/%(title)s.%(ext)s\"" ;

                string thisParam1 = ytdlCommand_VideoDownload
                    .Replace("{output-path}", outPathParam)
                    .Replace("{playlist-url}", "\"" + list_Playlist[currVideoObj.playlistId].url + "\"")
                    .Replace("{idx}", "" + currVideoObj.videoId);

                // go download...
                ProcessStartInfo cmdsi = new ProcessStartInfo(ytdlCommand);
                cmdsi.Arguments = thisParam1;
                cmdsi.UseShellExecute = false;
                cmdsi.RedirectStandardError = true;
                cmdsi.RedirectStandardInput = true;
                cmdsi.RedirectStandardOutput = true;
                cmdsi.CreateNoWindow = true;
                //cmdsi.StandardOutputEncoding = System.Text.Encoding.UTF8;

                Process process = Process.Start(cmdsi);
                process.OutputDataReceived +=
                    (o, e) =>
                    {
                        if (e.Data != null)
                        {
                            Match match = Regex.Match(e.Data, "\\[download\\]\\s+(.+%) of (.+) at .+");
                            if (match.Success)
                            {
                                Group g1 = match.Groups[1];
                                Group g2 = match.Groups[2];
                                lock (lockObj)
                                {
                                    currVideoObj.progress = g1.ToString();
                                    currVideoObj.size = g2.ToString();
                                }
                            }
                        }
                    };
                process.BeginOutputReadLine();
                process.WaitForExit();

                // update result
                lock (lockObj)
                {
                    currVideoObj.progress = "Done";
                }
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            // update 2 ListView objects
            // 1. update LstView_Playlist
            for (int n=0; n<list_Playlist.Count; ++n)
            {
                if (n < LstView_Playlist.Items.Count)
                {
                    // update current item in list
                    updateLstView(LstView_Playlist, n, 1, list_Playlist[n].url);
                    updateLstView(LstView_Playlist, n, 2, list_Playlist[n].name);
                }
                else
                {
                    // add new items
                    string[] itemVals = new string[3];
                    itemVals[0] = "" + (n + 1);
                    itemVals[1] = list_Playlist[n].url;
                    itemVals[2] = list_Playlist[n].name;
                    ListViewItem lvi = new ListViewItem(itemVals);
                    LstView_Playlist.Items.Add(lvi);
                }
            }
            if (LstView_Playlist.Items.Count > list_Playlist.Count)
            {
                for (int n = LstView_Playlist.Items.Count - 1; n >= list_Playlist.Count; --n)
                {
                    LstView_Playlist.Items.RemoveAt(n);
                }
            }

            // 2. update LstView_Playlist
            int doneCount = 0;
            for (int n = 0; n < list_Video.Count; ++n)
            {
                int pid = list_Video[n].playlistId;
                int vid = list_Video[n].videoId;
                string playlistName = "[" + (pid + 1) + "] " + list_Playlist[pid].name;
                string videoId = "[" + vid + "]";
                if (n < LstView_Video.Items.Count)
                {
                    // update current item in list
                    updateLstView(LstView_Video, n, 0, playlistName);
                    updateLstView(LstView_Video, n, 1, videoId);
                    updateLstView(LstView_Video, n, 2, list_Video[n].name);
                    updateLstView(LstView_Video, n, 3, list_Video[n].size);
                    updateLstView(LstView_Video, n, 4, list_Video[n].progress);
                }
                else
                {
                    // add new items
                    string[] itemVals = new string[5];
                    itemVals[0] = playlistName;
                    itemVals[1] = videoId;
                    itemVals[2] = list_Video[n].name;
                    itemVals[3] = list_Video[n].size;
                    itemVals[4] = list_Video[n].progress;
                    ListViewItem lvi = new ListViewItem(itemVals);
                    LstView_Video.Items.Add(lvi);
                }
                if (list_Video[n].progress.Equals("Done")) ++doneCount;
            }
            if (LstView_Video.Items.Count > list_Video.Count)
            {
                for (int n = LstView_Video.Items.Count - 1; n >= list_Video.Count; --n)
                {
                    LstView_Video.Items.RemoveAt(n);
                }
            }

            // enable all buttons
            if (doneCount == list_Video.Count)
            {
                // enable buttons
                Btn_AddPlaylist.Enabled = true;
                Btn_AddWatchLater.Enabled = true;
                Btn_ClearPlaylist.Enabled = true;
                Btn_DeletePlaylist.Enabled = true;
                Btn_StartDownload.Enabled = true;

                // set cursor type
                Cursor.Current = Cursors.Default;

            }
        }

        private bool isUrlInPlaylist(string url)
        {
            foreach(PlaylistObject plst in list_Playlist)
            {
                if (url.Equals(plst.url)) return true;
            }

            return false;
        }

        private bool removeUrlInPlaylist(string url)
        {
            foreach (PlaylistObject plst in list_Playlist)
            {
                if (url.Equals(plst.url))
                {
                    list_Playlist.Remove(plst);
                    return true;
                }
            }

            return false;
        }

        private bool updateLstView(System.Windows.Forms.ListView lstView, int idx, int sidx, string val)
        {
            if (lstView == null) return false;
            if (lstView.Items.Count <= idx) return false;
            if (lstView.Items[idx].SubItems.Count <= sidx) return false;

            if (lstView.Items[idx].SubItems[sidx].Text.Equals(val)) return true;
            lstView.Items[idx].SubItems[sidx].Text = val;
            return true;
        }

        private void Btn_YtdlPath_Intro_Click(object sender, EventArgs e)
        {
            displayHelpBox("YtdlPath");
        }

        private void Btn_CookiePath_Intro_Click(object sender, EventArgs e)
        {
            displayHelpBox("CookiePath");
        }

        private void Btn_DownloadPath_Intro_Click(object sender, EventArgs e)
        {
            displayHelpBox("DownloadPath");
        }

        private void Btn_CustFormat_Intro_Click(object sender, EventArgs e)
        {
            displayHelpBox("CustFormat");
        }

        private void Btn_DefaultWatchLaterUrl_Intro_Click(object sender, EventArgs e)
        {
            displayHelpBox("DefaultWatchLaterUrl");
        }

        private void displayHelpBox(string helpItem)
        {
            Form2 f = new Form2();
            f.helpItem = helpItem;
            f.ShowDialog();
        }
    }
}
