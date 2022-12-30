using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyYoutubeDowloader
{
    public partial class Form2 : Form
    {
        public string helpItem { get; set; }

        private Dictionary<string, string[]> descriptionMap = new Dictionary<string, string[]>();

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            descriptionMap.Add(
                "YtdlPath", new string[]
                {
                    "youtube-dl.exe 的所在路徑, 如果下面的 \"使用自帶的 youtube-dl 程式\" 有勾起來, 這個路徑可以忽略. ",
                    "youtube-dl.exe 是一個可以在命令列執行的 open source 影片下載工具, 如果想下載最新版的程式, ",
                    "可以在這裡下載: https://github.com/ytdl-org/youtube-dl"
                }
            );

            descriptionMap.Add(
                "CookiePath", new string[]
                {
                    "Cookie 所在位置. 如果你要下載的播放清單是需要權限的, 可以透過 cookie 來達到登入的效果. ",
                    "請先到 Chrome Store 裡搜尋並安裝 Get cookies.txt 這個 plugin, ",
                    "接著登入 Youtube 網站, 並在 Get cookies.txt plugin 的圖示上點右鍵並選擇 Get cookies.txt,",
                    "將下載下來的 txt 檔存起來並在這裡輸入路徑. 如果下面的 \"使用自帶的 youtube-dl 程式\" 有勾起來, ",
                    "則 cookies.txt 檔案要放在這裡: {MyYoutubeDownloader 路徑}\\youtube-dl\\youtube.com_cookies.txt."
                }
            );

            descriptionMap.Add(
                "DownloadPath", new string[]
                {
                    "下載影片的存放位置.",
                }
            );

            descriptionMap.Add(
                "CustFormat", new string[]
                {
                    "這個可以自訂要下載的影片格式及解析度, 預設格式為: best[filesize<50M]/best[filesize<100M]/best, 意義如下:",
                    "   1. 如果存在檔案大小低於 50M 的影片, 則下載其中解析度最佳的影片. 如果找不到這個格式, 則使用第二種格式,",
                    "   2. 如果存在檔案大小低於 100M 的影片, 則下載其中解析度最佳的影片. 如果找不到這個格式, 則使用第三種格式,",
                    "   3. 直接下載解析度最佳的影片.",
                    "如果不指定下載格式, youtube-dl 會自動用最佳解析度下載. ",
                    "如果左邊的 \"下載時使用自訂解析度\" 沒有勾起來, 這個路徑可以忽略."
                }
            );

            descriptionMap.Add(
                "DefaultWatchLaterUrl", new string[]
                {
                    "Youtube 中 \"稍後觀看\" 的網址.",
                    "在 \"下載內容\" 分頁裡按下 新增 \"稍後觀看\" 時會自動加入用這裡的網址."
                }
            );
        }

        private void Form2_Shown(object sender, EventArgs e)
        {
            string desc = "";
            foreach (string d in descriptionMap[helpItem]) desc += d + "\r\n";
            TxtBox_Description.Text = desc;
        }
    }
}
