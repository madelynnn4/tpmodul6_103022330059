using System;

namespace SayaTubeVideoApp
{
    class SayaTubeVideo
    {
        private int id;
        private string title;
        private int playCount;

        public SayaTubeVideo(string title)
        {
            Random random = new Random();
            this.id = random.Next(10000, 99999);
            this.title = title;
            this.playCount = 0;
        }

        public void IncreasePlayCount(int count)
        {
            this.playCount += count;
        }

        public void PrintVideoDetails()
        {
            Console.WriteLine("Video Title: " + this.title);
            Console.WriteLine("Play Count: " + this.playCount);
        }

        static void Main(string[] args)
        {
            SayaTubeVideo video1 = new SayaTubeVideo("Tutorial Design By Contract - Valentino Favian Bimo Khristora");
            video1.IncreasePlayCount(5);
            video1.PrintVideoDetails();
        }
    }
}