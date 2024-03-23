namespace tpmod6_1302223015
{
    internal class Program
    {
        public class SayaTubeVideo
        {
            private int id;
            private String title;
            private int playCount;

            //Konstruktor
            public SayaTubeVideo(String videoTitle)
            {
                Random idRandom = new Random();// id random
                id = idRandom.Next(1000,100000);

                title = videoTitle;
                playCount = 0;
            }

            public void IncreasePlayCounting(int Count)
            {
                playCount += Count;
            }

            public void PrintVideoDetails()
            {
                Console.WriteLine("ID: " + id + ", Judul: " +  title + ", Play Count: " + playCount);
            }
        }

        static void Main(string[] args)
        {
             SayaTubeVideo sayaTubeVideo = new SayaTubeVideo("Tutorial Design By Contract - [Galang]");
            sayaTubeVideo.PrintVideoDetails();

        }
    }
}
