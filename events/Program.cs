using System;

namespace Events
{
    //define delegate
    public delegate void VideoUploadedEventHandler();
    class Program
    {
        static void Main(string[] args)
        {
            // create objects from classes
            Uploader videoUploader = new Uploader();
            Nachrichten benachrichtiger = new Nachrichten();

            // event abonnieren lassen 
            // VideoUploaded Event wird abnoniert von nachrichten klasse Methode
            videoUploader.VideoUploaded += benachrichtiger.VideoUploaded;

            videoUploader.VideoUpload();
            Console.ReadKey();
        }
    }

    //define a new class
    public class Uploader
    {
        //events
        public event VideoUploadedEventHandler VideoUploaded;
        //method
        public void VideoUpload()
        {
            Console.WriteLine("Das Video wird gerade hochgeladen...");
            //after console writeline
            // call event
            VideoUploaded();

        }
    }

    //define class
    public class Nachrichten
    {
        //method
        public void VideoUploaded()
        {
            Console.WriteLine("Das Video wurde fertig hochgeladen");
        }
    }
}
