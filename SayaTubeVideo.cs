using System;
using System.Diagnostics;

namespace SayaTubeVideoApp
{
    class SayaTubeVideo
    {
        private int id;
        private string title;
        private int playCount;

        public SayaTubeVideo(string title)
        {
            Debug.Assert(title != null, "Judul video tidak boleh null.");
            Debug.Assert(title.Length <= 100, "Judul video maksimal 100 karakter.");

            Random random = new Random();
            this.id = random.Next(10000, 99999);
            this.title = title;
            this.playCount = 0;
        }

        public void IncreasePlayCount(int count)
        {
            Debug.Assert(count <= 10000000, "Penambahan play count maksimal 10.000.000.");
            Debug.Assert(count > 0, "Penambahan play count harus lebih dari 0.");

            try
            {
                checked
                {
                    if (this.playCount > int.MaxValue - count)
                    {
                        throw new OverflowException();
                    }
                    this.playCount += count;
                }
            }
            catch (OverflowException)
            {
                Console.WriteLine("Play count maksimum telah tercapai. Tidak bisa menambah lagi.");
            }
        }

        public void PrintVideoDetails()
        {
            Console.WriteLine("ID Video     : " + this.id);
            Console.WriteLine("Judul Video  : " + this.title);
            Console.WriteLine("Play Count   : " + this.playCount);
        }

        static void Main(string[] args)
        {
            SayaTubeVideo video1 = new SayaTubeVideo("Tutorial Design By Contract - Valentino Favian Bimo Khristora");

            for (int i = 0; i < 250; i++)
            {
                video1.IncreasePlayCount(10000000);
            }

            video1.PrintVideoDetails();
        }
    }
}