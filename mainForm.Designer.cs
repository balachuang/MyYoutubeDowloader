namespace MyYoutubeDowloader
{
    partial class mainForm
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.TxtBox_YtdlPath = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.LstView_Playlist = new System.Windows.Forms.ListView();
            this.index = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.url = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LstView_Video = new System.Windows.Forms.ListView();
            this.Playlist = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Title = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Size = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Progress = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Btn_StartDownload = new System.Windows.Forms.Button();
            this.Btn_ClearPlaylist = new System.Windows.Forms.Button();
            this.Btn_DeletePlaylist = new System.Windows.Forms.Button();
            this.Btn_AddPlaylist = new System.Windows.Forms.Button();
            this.Btn_AddWatchLater = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.ComBox_ThreadCount = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Btn_DefaultWatchLaterUrl_Intro = new System.Windows.Forms.Button();
            this.TxtBox_DefaultWatchLaterUrl = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Btn_CustFormat_Intro = new System.Windows.Forms.Button();
            this.TxtBox_CustFormat = new System.Windows.Forms.TextBox();
            this.ChkBox_CustResolution = new System.Windows.Forms.CheckBox();
            this.ChkBox_SkipSubfolderForWatchLater = new System.Windows.Forms.CheckBox();
            this.ChkBox_CreateSubfolderByPlaylistName = new System.Windows.Forms.CheckBox();
            this.Btn_DownloadPath_Intro = new System.Windows.Forms.Button();
            this.TxtBox_DownloadPath = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ChkBox_SkipCookie = new System.Windows.Forms.CheckBox();
            this.ChkBox_UseDefaultYtdl = new System.Windows.Forms.CheckBox();
            this.Btn_CookiePath_Intro = new System.Windows.Forms.Button();
            this.TxtBox_CookiePath = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Btn_YtdlPath_Intro = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TxtBox_YtdlPath
            // 
            this.TxtBox_YtdlPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtBox_YtdlPath.Location = new System.Drawing.Point(101, 28);
            this.TxtBox_YtdlPath.Name = "TxtBox_YtdlPath";
            this.TxtBox_YtdlPath.Size = new System.Drawing.Size(812, 23);
            this.TxtBox_YtdlPath.TabIndex = 0;
            this.TxtBox_YtdlPath.Text = "D:\\youtube-dl\\youtube-dl.exe";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(977, 492);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.LstView_Playlist);
            this.tabPage1.Controls.Add(this.LstView_Video);
            this.tabPage1.Controls.Add(this.Btn_StartDownload);
            this.tabPage1.Controls.Add(this.Btn_ClearPlaylist);
            this.tabPage1.Controls.Add(this.Btn_DeletePlaylist);
            this.tabPage1.Controls.Add(this.Btn_AddPlaylist);
            this.tabPage1.Controls.Add(this.Btn_AddWatchLater);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(969, 463);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "下載內容";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // LstView_Playlist
            // 
            this.LstView_Playlist.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LstView_Playlist.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.index,
            this.url,
            this.name});
            this.LstView_Playlist.FullRowSelect = true;
            this.LstView_Playlist.GridLines = true;
            this.LstView_Playlist.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.LstView_Playlist.HideSelection = false;
            this.LstView_Playlist.Location = new System.Drawing.Point(11, 34);
            this.LstView_Playlist.Name = "LstView_Playlist";
            this.LstView_Playlist.ShowGroups = false;
            this.LstView_Playlist.Size = new System.Drawing.Size(827, 129);
            this.LstView_Playlist.TabIndex = 8;
            this.LstView_Playlist.UseCompatibleStateImageBehavior = false;
            this.LstView_Playlist.View = System.Windows.Forms.View.Details;
            // 
            // index
            // 
            this.index.Text = "ID";
            this.index.Width = 50;
            // 
            // url
            // 
            this.url.Text = "Url";
            this.url.Width = 500;
            // 
            // name
            // 
            this.name.Text = "Name";
            this.name.Width = 200;
            // 
            // LstView_Video
            // 
            this.LstView_Video.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LstView_Video.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Playlist,
            this.ID,
            this.Title,
            this.Size,
            this.Progress});
            this.LstView_Video.FullRowSelect = true;
            this.LstView_Video.GridLines = true;
            this.LstView_Video.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.LstView_Video.HideSelection = false;
            this.LstView_Video.Location = new System.Drawing.Point(11, 198);
            this.LstView_Video.Name = "LstView_Video";
            this.LstView_Video.Size = new System.Drawing.Size(950, 257);
            this.LstView_Video.TabIndex = 7;
            this.LstView_Video.UseCompatibleStateImageBehavior = false;
            this.LstView_Video.View = System.Windows.Forms.View.Details;
            // 
            // Playlist
            // 
            this.Playlist.Text = "Playlist";
            this.Playlist.Width = 150;
            // 
            // ID
            // 
            this.ID.Text = "ID";
            // 
            // Title
            // 
            this.Title.Text = "Title";
            this.Title.Width = 572;
            // 
            // Size
            // 
            this.Size.Text = "Size";
            this.Size.Width = 85;
            // 
            // Progress
            // 
            this.Progress.Text = "%";
            // 
            // Btn_StartDownload
            // 
            this.Btn_StartDownload.Location = new System.Drawing.Point(11, 169);
            this.Btn_StartDownload.Name = "Btn_StartDownload";
            this.Btn_StartDownload.Size = new System.Drawing.Size(117, 23);
            this.Btn_StartDownload.TabIndex = 6;
            this.Btn_StartDownload.Text = "開始下載";
            this.Btn_StartDownload.UseVisualStyleBackColor = true;
            this.Btn_StartDownload.Click += new System.EventHandler(this.StartDownload_Click);
            // 
            // Btn_ClearPlaylist
            // 
            this.Btn_ClearPlaylist.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_ClearPlaylist.Location = new System.Drawing.Point(844, 121);
            this.Btn_ClearPlaylist.Name = "Btn_ClearPlaylist";
            this.Btn_ClearPlaylist.Size = new System.Drawing.Size(117, 23);
            this.Btn_ClearPlaylist.TabIndex = 5;
            this.Btn_ClearPlaylist.Text = "清空 Playlist";
            this.Btn_ClearPlaylist.UseVisualStyleBackColor = true;
            this.Btn_ClearPlaylist.Click += new System.EventHandler(this.ClearPlaylist_Click);
            // 
            // Btn_DeletePlaylist
            // 
            this.Btn_DeletePlaylist.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_DeletePlaylist.Location = new System.Drawing.Point(844, 92);
            this.Btn_DeletePlaylist.Name = "Btn_DeletePlaylist";
            this.Btn_DeletePlaylist.Size = new System.Drawing.Size(117, 23);
            this.Btn_DeletePlaylist.TabIndex = 4;
            this.Btn_DeletePlaylist.Text = "刪除所選 Playlist";
            this.Btn_DeletePlaylist.UseVisualStyleBackColor = true;
            this.Btn_DeletePlaylist.Click += new System.EventHandler(this.DeletePlaylist_Click);
            // 
            // Btn_AddPlaylist
            // 
            this.Btn_AddPlaylist.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_AddPlaylist.Location = new System.Drawing.Point(844, 63);
            this.Btn_AddPlaylist.Name = "Btn_AddPlaylist";
            this.Btn_AddPlaylist.Size = new System.Drawing.Size(117, 23);
            this.Btn_AddPlaylist.TabIndex = 3;
            this.Btn_AddPlaylist.Text = "新增 Playlist";
            this.Btn_AddPlaylist.UseVisualStyleBackColor = true;
            this.Btn_AddPlaylist.Click += new System.EventHandler(this.AddPlaylist_Click);
            // 
            // Btn_AddWatchLater
            // 
            this.Btn_AddWatchLater.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_AddWatchLater.Location = new System.Drawing.Point(844, 34);
            this.Btn_AddWatchLater.Name = "Btn_AddWatchLater";
            this.Btn_AddWatchLater.Size = new System.Drawing.Size(117, 23);
            this.Btn_AddWatchLater.TabIndex = 2;
            this.Btn_AddWatchLater.Text = "新增 \"稍後觀看\"";
            this.Btn_AddWatchLater.UseVisualStyleBackColor = true;
            this.Btn_AddWatchLater.Click += new System.EventHandler(this.AddWatchLater_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "要下載的 Playlist:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(969, 463);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "設定";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.ComBox_ThreadCount);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.Btn_DefaultWatchLaterUrl_Intro);
            this.groupBox3.Controls.Add(this.TxtBox_DefaultWatchLaterUrl);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Location = new System.Drawing.Point(8, 312);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(953, 155);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "下載設定";
            // 
            // ComBox_ThreadCount
            // 
            this.ComBox_ThreadCount.FormattingEnabled = true;
            this.ComBox_ThreadCount.Items.AddRange(new object[] {
            "1",
            "3",
            "5",
            "10",
            "20",
            "50"});
            this.ComBox_ThreadCount.Location = new System.Drawing.Point(134, 57);
            this.ComBox_ThreadCount.Name = "ComBox_ThreadCount";
            this.ComBox_ThreadCount.Size = new System.Drawing.Size(74, 24);
            this.ComBox_ThreadCount.TabIndex = 7;
            this.ComBox_ThreadCount.Text = "10";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 16);
            this.label6.TabIndex = 6;
            this.label6.Text = "同時下載的影片數:";
            // 
            // Btn_DefaultWatchLaterUrl_Intro
            // 
            this.Btn_DefaultWatchLaterUrl_Intro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_DefaultWatchLaterUrl_Intro.Location = new System.Drawing.Point(919, 28);
            this.Btn_DefaultWatchLaterUrl_Intro.Name = "Btn_DefaultWatchLaterUrl_Intro";
            this.Btn_DefaultWatchLaterUrl_Intro.Size = new System.Drawing.Size(28, 23);
            this.Btn_DefaultWatchLaterUrl_Intro.TabIndex = 5;
            this.Btn_DefaultWatchLaterUrl_Intro.Text = "?";
            this.Btn_DefaultWatchLaterUrl_Intro.UseVisualStyleBackColor = true;
            this.Btn_DefaultWatchLaterUrl_Intro.Click += new System.EventHandler(this.Btn_DefaultWatchLaterUrl_Intro_Click);
            // 
            // TxtBox_DefaultWatchLaterUrl
            // 
            this.TxtBox_DefaultWatchLaterUrl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtBox_DefaultWatchLaterUrl.Location = new System.Drawing.Point(134, 28);
            this.TxtBox_DefaultWatchLaterUrl.Name = "TxtBox_DefaultWatchLaterUrl";
            this.TxtBox_DefaultWatchLaterUrl.Size = new System.Drawing.Size(779, 23);
            this.TxtBox_DefaultWatchLaterUrl.TabIndex = 0;
            this.TxtBox_DefaultWatchLaterUrl.Text = "https://www.youtube.com/playlist?list=WL";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 16);
            this.label5.TabIndex = 1;
            this.label5.Text = "預設 \"稍後觀看\" 網址:";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.Btn_CustFormat_Intro);
            this.groupBox2.Controls.Add(this.TxtBox_CustFormat);
            this.groupBox2.Controls.Add(this.ChkBox_CustResolution);
            this.groupBox2.Controls.Add(this.ChkBox_SkipSubfolderForWatchLater);
            this.groupBox2.Controls.Add(this.ChkBox_CreateSubfolderByPlaylistName);
            this.groupBox2.Controls.Add(this.Btn_DownloadPath_Intro);
            this.groupBox2.Controls.Add(this.TxtBox_DownloadPath);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(8, 148);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(953, 155);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "下載設定";
            // 
            // Btn_CustFormat_Intro
            // 
            this.Btn_CustFormat_Intro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_CustFormat_Intro.Location = new System.Drawing.Point(919, 83);
            this.Btn_CustFormat_Intro.Name = "Btn_CustFormat_Intro";
            this.Btn_CustFormat_Intro.Size = new System.Drawing.Size(28, 23);
            this.Btn_CustFormat_Intro.TabIndex = 14;
            this.Btn_CustFormat_Intro.Text = "?";
            this.Btn_CustFormat_Intro.UseVisualStyleBackColor = true;
            this.Btn_CustFormat_Intro.Click += new System.EventHandler(this.Btn_CustFormat_Intro_Click);
            // 
            // TxtBox_CustFormat
            // 
            this.TxtBox_CustFormat.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtBox_CustFormat.Location = new System.Drawing.Point(220, 83);
            this.TxtBox_CustFormat.Name = "TxtBox_CustFormat";
            this.TxtBox_CustFormat.Size = new System.Drawing.Size(693, 23);
            this.TxtBox_CustFormat.TabIndex = 13;
            this.TxtBox_CustFormat.Text = "best[filesize<50M]/best[filesize<100M]/best";
            // 
            // ChkBox_CustResolution
            // 
            this.ChkBox_CustResolution.AutoSize = true;
            this.ChkBox_CustResolution.Checked = true;
            this.ChkBox_CustResolution.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ChkBox_CustResolution.Location = new System.Drawing.Point(68, 84);
            this.ChkBox_CustResolution.Name = "ChkBox_CustResolution";
            this.ChkBox_CustResolution.Size = new System.Drawing.Size(146, 20);
            this.ChkBox_CustResolution.TabIndex = 12;
            this.ChkBox_CustResolution.Text = "下載時使用自訂解析度";
            this.ChkBox_CustResolution.UseVisualStyleBackColor = true;
            // 
            // ChkBox_SkipSubfolderForWatchLater
            // 
            this.ChkBox_SkipSubfolderForWatchLater.AutoSize = true;
            this.ChkBox_SkipSubfolderForWatchLater.Checked = true;
            this.ChkBox_SkipSubfolderForWatchLater.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ChkBox_SkipSubfolderForWatchLater.Location = new System.Drawing.Point(258, 57);
            this.ChkBox_SkipSubfolderForWatchLater.Name = "ChkBox_SkipSubfolderForWatchLater";
            this.ChkBox_SkipSubfolderForWatchLater.Size = new System.Drawing.Size(234, 20);
            this.ChkBox_SkipSubfolderForWatchLater.TabIndex = 11;
            this.ChkBox_SkipSubfolderForWatchLater.Text = "不要為 \"稍後觀看\" 裡的影片建立子目錄";
            this.ChkBox_SkipSubfolderForWatchLater.UseVisualStyleBackColor = true;
            // 
            // ChkBox_CreateSubfolderByPlaylistName
            // 
            this.ChkBox_CreateSubfolderByPlaylistName.AutoSize = true;
            this.ChkBox_CreateSubfolderByPlaylistName.Checked = true;
            this.ChkBox_CreateSubfolderByPlaylistName.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ChkBox_CreateSubfolderByPlaylistName.Location = new System.Drawing.Point(68, 57);
            this.ChkBox_CreateSubfolderByPlaylistName.Name = "ChkBox_CreateSubfolderByPlaylistName";
            this.ChkBox_CreateSubfolderByPlaylistName.Size = new System.Drawing.Size(184, 20);
            this.ChkBox_CreateSubfolderByPlaylistName.TabIndex = 10;
            this.ChkBox_CreateSubfolderByPlaylistName.Text = "用 Play List 的名字建立子目錄";
            this.ChkBox_CreateSubfolderByPlaylistName.UseVisualStyleBackColor = true;
            // 
            // Btn_DownloadPath_Intro
            // 
            this.Btn_DownloadPath_Intro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_DownloadPath_Intro.Location = new System.Drawing.Point(919, 28);
            this.Btn_DownloadPath_Intro.Name = "Btn_DownloadPath_Intro";
            this.Btn_DownloadPath_Intro.Size = new System.Drawing.Size(28, 23);
            this.Btn_DownloadPath_Intro.TabIndex = 5;
            this.Btn_DownloadPath_Intro.Text = "?";
            this.Btn_DownloadPath_Intro.UseVisualStyleBackColor = true;
            this.Btn_DownloadPath_Intro.Click += new System.EventHandler(this.Btn_DownloadPath_Intro_Click);
            // 
            // TxtBox_DownloadPath
            // 
            this.TxtBox_DownloadPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtBox_DownloadPath.Location = new System.Drawing.Point(68, 28);
            this.TxtBox_DownloadPath.Name = "TxtBox_DownloadPath";
            this.TxtBox_DownloadPath.Size = new System.Drawing.Size(845, 23);
            this.TxtBox_DownloadPath.TabIndex = 0;
            this.TxtBox_DownloadPath.Text = "D:\\MyDownload\\Wait_4_Car";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "下載位置:";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.ChkBox_SkipCookie);
            this.groupBox1.Controls.Add(this.ChkBox_UseDefaultYtdl);
            this.groupBox1.Controls.Add(this.Btn_CookiePath_Intro);
            this.groupBox1.Controls.Add(this.TxtBox_CookiePath);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.Btn_YtdlPath_Intro);
            this.groupBox1.Controls.Add(this.TxtBox_YtdlPath);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(8, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(953, 118);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "youtube-dl 設定";
            // 
            // ChkBox_SkipCookie
            // 
            this.ChkBox_SkipCookie.AutoSize = true;
            this.ChkBox_SkipCookie.Location = new System.Drawing.Point(300, 88);
            this.ChkBox_SkipCookie.Name = "ChkBox_SkipCookie";
            this.ChkBox_SkipCookie.Size = new System.Drawing.Size(105, 20);
            this.ChkBox_SkipCookie.TabIndex = 17;
            this.ChkBox_SkipCookie.Text = "不使用 Cookie";
            this.ChkBox_SkipCookie.UseVisualStyleBackColor = true;
            // 
            // ChkBox_UseDefaultYtdl
            // 
            this.ChkBox_UseDefaultYtdl.AutoSize = true;
            this.ChkBox_UseDefaultYtdl.Checked = true;
            this.ChkBox_UseDefaultYtdl.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ChkBox_UseDefaultYtdl.Location = new System.Drawing.Point(101, 88);
            this.ChkBox_UseDefaultYtdl.Name = "ChkBox_UseDefaultYtdl";
            this.ChkBox_UseDefaultYtdl.Size = new System.Drawing.Size(179, 20);
            this.ChkBox_UseDefaultYtdl.TabIndex = 16;
            this.ChkBox_UseDefaultYtdl.Text = "使用自帶的 youtube-dl 程式";
            this.ChkBox_UseDefaultYtdl.UseVisualStyleBackColor = true;
            // 
            // Btn_CookiePath_Intro
            // 
            this.Btn_CookiePath_Intro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_CookiePath_Intro.Location = new System.Drawing.Point(919, 59);
            this.Btn_CookiePath_Intro.Name = "Btn_CookiePath_Intro";
            this.Btn_CookiePath_Intro.Size = new System.Drawing.Size(28, 23);
            this.Btn_CookiePath_Intro.TabIndex = 9;
            this.Btn_CookiePath_Intro.Text = "?";
            this.Btn_CookiePath_Intro.UseVisualStyleBackColor = true;
            this.Btn_CookiePath_Intro.Click += new System.EventHandler(this.Btn_CookiePath_Intro_Click);
            // 
            // TxtBox_CookiePath
            // 
            this.TxtBox_CookiePath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtBox_CookiePath.Location = new System.Drawing.Point(101, 59);
            this.TxtBox_CookiePath.Name = "TxtBox_CookiePath";
            this.TxtBox_CookiePath.Size = new System.Drawing.Size(812, 23);
            this.TxtBox_CookiePath.TabIndex = 6;
            this.TxtBox_CookiePath.Text = "D:\\youtube-dl\\youtube.com_cookies.txt";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Cookie 檔位置:";
            // 
            // Btn_YtdlPath_Intro
            // 
            this.Btn_YtdlPath_Intro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_YtdlPath_Intro.Location = new System.Drawing.Point(919, 28);
            this.Btn_YtdlPath_Intro.Name = "Btn_YtdlPath_Intro";
            this.Btn_YtdlPath_Intro.Size = new System.Drawing.Size(28, 23);
            this.Btn_YtdlPath_Intro.TabIndex = 5;
            this.Btn_YtdlPath_Intro.Text = "?";
            this.Btn_YtdlPath_Intro.UseVisualStyleBackColor = true;
            this.Btn_YtdlPath_Intro.Click += new System.EventHandler(this.Btn_YtdlPath_Intro_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "主程式位置:";
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 500;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(977, 492);
            this.Controls.Add(this.tabControl1);
            this.Name = "mainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "我的 Youtube 影片下載器";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.mainForm_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.mainForm_FormClosed);
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox TxtBox_YtdlPath;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Btn_CookiePath_Intro;
        private System.Windows.Forms.TextBox TxtBox_CookiePath;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Btn_YtdlPath_Intro;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button Btn_CustFormat_Intro;
        private System.Windows.Forms.TextBox TxtBox_CustFormat;
        private System.Windows.Forms.CheckBox ChkBox_CustResolution;
        private System.Windows.Forms.CheckBox ChkBox_SkipSubfolderForWatchLater;
        private System.Windows.Forms.CheckBox ChkBox_CreateSubfolderByPlaylistName;
        private System.Windows.Forms.Button Btn_DownloadPath_Intro;
        private System.Windows.Forms.TextBox TxtBox_DownloadPath;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox ChkBox_UseDefaultYtdl;
        private System.Windows.Forms.Button Btn_StartDownload;
        private System.Windows.Forms.Button Btn_ClearPlaylist;
        private System.Windows.Forms.Button Btn_DeletePlaylist;
        private System.Windows.Forms.Button Btn_AddPlaylist;
        private System.Windows.Forms.Button Btn_AddWatchLater;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button Btn_DefaultWatchLaterUrl_Intro;
        private System.Windows.Forms.TextBox TxtBox_DefaultWatchLaterUrl;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListView LstView_Video;
        private System.Windows.Forms.ColumnHeader Playlist;
        private System.Windows.Forms.ColumnHeader Title;
        private System.Windows.Forms.ColumnHeader Size;
        private System.Windows.Forms.ColumnHeader Progress;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ComboBox ComBox_ThreadCount;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListView LstView_Playlist;
        private System.Windows.Forms.ColumnHeader index;
        private System.Windows.Forms.ColumnHeader url;
        private System.Windows.Forms.ColumnHeader name;
        private System.Windows.Forms.CheckBox ChkBox_SkipCookie;
    }
}

