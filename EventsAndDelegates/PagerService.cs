using System;
using System.Threading;

namespace EventsAndDelegates
{
    public class PagerService
    {

        public void OnVideoEncoded(object source, VideoEventArgs args)
        {
            Console.WriteLine("PagerService: Message is paged to pager...({0})", args.Video.Title);
            Thread.Sleep(3000);
        }
    }
}
