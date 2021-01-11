using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Delegate
{
    class VideoEncoder
    {
        public void Encode(Video video)
        {
            Console.WriteLine("encoding video....");

            Thread.Sleep(3000);
        }
    }
}
