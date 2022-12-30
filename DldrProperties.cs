using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyYoutubeDowloader
{
    [Serializable]
    public class DldrProperties
    {
        public string ytdlExeFilePath { get; set; }
        public string cookieFilePath { get; set; }
        public string downloadPath { get; set; }
        public string custDownloadResolution { get; set; }
        public string watchLaterUrl { get; set; }
        public int threadCount { get; set; }
        public bool useDefaultYtdl { get; set; }
        public bool skipCookie { get; set; }
        public bool createSubFolderByPlaylistName { get; set; }
        public bool skipCreatingSubFolderForWatchLater { get; set; }
        public bool useCustDownloadResolution { get; set; }
    }
}
