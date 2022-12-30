using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyYoutubeDowloader
{
    internal class VideoObject
    {
        public int playlistId { get; set; }
        public int videoId { get; set; }
        public string name { get; set; }
        public string size { get; set; }
        public string progress { get; set; }
    }
}
