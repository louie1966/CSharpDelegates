using System;
using System.Threading;

namespace EventsAndDelegates
{

    public class VideoEncoder
    {


        // 1- Define a delegate
        // 2- Define an event base on that delegate
        // 3- Raise the event

        public delegate void VideoEncodedEventHandler(object source, VideoEventArgs args);

        public event VideoEncodedEventHandler VideoEncoded;



        public void Encode(Video video)
        {
            Console.WriteLine("Encoding Video {0}...", video.Title);
            Thread.Sleep(3000);
            OnVideoEncoded(video);
        }

        protected virtual void OnVideoEncoded(Video video)
        {
            if (VideoEncoded != null)
                VideoEncoded(this, new VideoEventArgs() { Video = video });

        }
    }
}