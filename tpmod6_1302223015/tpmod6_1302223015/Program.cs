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
                if(videoTitle == null)
                {
                    throw new ArgumentNullException(nameof(videoTitle), "Judul Video Tidak Boleh Kosong");
                }else if(videoTitle.Length > 100)
                {
                    throw new ArgumentException(nameof(videoTitle),"Judul Video Tidak Boleh Lebih dari 100 Karakter");
                }

                Random idRandom = new Random();// id random
                id = idRandom.Next(1000,100000);

                title = videoTitle;
                playCount = 0;
            
            }

            public void IncreasePlayCounting(int Count)
            {
                
                if(Count > 10000000)
                {
                    throw new ArgumentOutOfRangeException(nameof(Count), "Penambahan Play Count Telah Mencapai Jumlah Maksimum");
                }

                try
                {
                    checked
                    {
                        playCount += Count;
                    }
                }
                
                catch (OverflowException)
                {
                    Console.WriteLine("Error: Penambahan Play Count Telah Mencapai Jumlah Maksimum.");
                    playCount = int.MaxValue;
                }
                
            }

            public void PrintVideoDetails()
            {
                Console.WriteLine("ID: " + id + ", Judul: " +  title + ", Play Count: " + playCount);
            }
        }

        static void Main(string[] args)
        {    
            try
            {
                SayaTubeVideo sayaTubeVideo = new SayaTubeVideo("Tutorial Design By Contract - [Galang]");
                sayaTubeVideo.PrintVideoDetails();
                sayaTubeVideo.IncreasePlayCounting(1);

                //Overloop
                for (int i = 0; i < int.MaxValue; i++){
                    sayaTubeVideo.IncreasePlayCounting(int.MaxValue);
                } 
            }

            catch (ArgumentNullException ex)
            {
                Console.WriteLine($"Terjadi Kesalahan Null Exception: {ex.Message}");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Terjadi Kesalahan: Argument exception {ex.Message}");
            }
            
            catch (OverflowException ex)
            {
                Console.WriteLine($"Terjadi Overflow: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Terjadi Kesalahan: {ex.Message}");
            }
             

        }
    }
}
