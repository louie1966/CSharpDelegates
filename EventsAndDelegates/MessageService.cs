using System;
using System.Threading;

namespace EventsAndDelegates
{
    public class MessageService
    {
        public void OnVideoEncoded(object source, VideoEventArgs args)
        {
            Console.WriteLine("MessageService: Sending a text message...({0})", args.Video.Title);
            Thread.Sleep(3000);
        }
    }
}
