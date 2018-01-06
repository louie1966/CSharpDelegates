﻿using System;
using System.Threading;

namespace EventsAndDelegates
{
    public class MailService
    {
        public void OnVideoEncoded(object source, VideoEventArgs args)
        {
            Console.WriteLine("MailService: Sending an email...({0})", args.Video.Title);
            Thread.Sleep(3000);
        }
    }
}
