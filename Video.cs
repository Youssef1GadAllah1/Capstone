using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capstone
{
    internal class Video
    {
        public string NameVideo;
        public int TimeVideo;
        public DateTime NowVideo;


        public void UploadVideo(string namevideo, int timevideo)
        {
            TimeVideo = timevideo;
            NameVideo = namevideo;
            NowVideo = DateTime.Now;

        }


    }
}