using System;

namespace Delegate
{
    class Program
    {
        static void Main(string[] args)
        {
            var video = new Video { Title = "video 1" };
            var videoEcoder = new VideoEncoder();

            videoEcoder.Encode(video); 
        }
    }
}
