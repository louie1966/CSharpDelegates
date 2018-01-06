using System;
using System.Threading;

namespace EventsAndDelegates
{
    public class MailService
    {
        public void OnVideoEncoded(object source, EventArgs args)
        {
            Console.WriteLine("MailService: Sending an email...");
            Thread.Sleep(3000);
        }
    }
}
