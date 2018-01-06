using System;
using System.Threading;

namespace EventsAndDelegates
{
    public class PagerService
    {

        public void OnVideoEncoded(object source, EventArgs args)
        {
            Console.WriteLine("PagerService: Message is paged to pager.");
            Thread.Sleep(3000);
        }
    }
}
