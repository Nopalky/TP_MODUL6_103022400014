using System;
using System.Diagnostics;

class SayaMusicTrack {
    private int id;
    private string playcount;
    private string title;

    public SayaMusicTrack(string title) {
        this.title = title;

        Debug.Assert(title != null);
        Debug.Assert(title.Length <= 100);

        Random play = new Random();
        this.id = play.Next(10000, 100000);
        this.playcount = "0";
    }

    public void IncreasePlayCount(int count)
    {
        Debug.Assert(count <= 10000000);

        if (count < 0)
        {
            Console.WriteLine("Jumlah Memutar tidak boleh negatif");
            return;
        }

        try { 
            checked {
                int currentPlayCount = int.Parse(this.playcount);
                int newPlayCount = currentPlayCount + count;
                this.playcount = newPlayCount.ToString();
            }
        }

        catch(OverflowException ex) { 
            Console.WriteLine("Error: Jumlah Memutar melebihi batas maksimum. " + ex.Message);
            throw;
        }
    }

    public void PrintTrackDetails() {
        Console.WriteLine("==================================");
        Console.WriteLine($"Title: {title}");
        Console.WriteLine($"ID: {id}");
        Console.WriteLine($"Jumlah Putar: {playcount}");
    }

    public class main
    {
        public static void Main(string[] args)
        {
            SayaMusicTrack track1 = new SayaMusicTrack("Chase by Heart2Heart");
            track1.IncreasePlayCount(13);
            track1.PrintTrackDetails();
            SayaMusicTrack track2 = new SayaMusicTrack("Guilty As Sin? by Taylor Swift");
            track2.IncreasePlayCount(2);
            track2.PrintTrackDetails();
            SayaMusicTrack track3 = new SayaMusicTrack("Harvey by Her's");
            track3.IncreasePlayCount(50);
            track3.PrintTrackDetails();

            Console.WriteLine("==================================");
            Console.WriteLine("Testing Negative Play Count:");
            track1.IncreasePlayCount(-3);

            Console.WriteLine("=========Testing Error==========");
            SayaMusicTrack myTrack = new SayaMusicTrack("Heavy Day");

            try {
                for (int i = 0; i < 300; i++) {
                    myTrack.IncreasePlayCount(10000000); 
                }
            } 
            catch (Exception e) {
                Console.WriteLine("Terjadi error di Main: " + e.Message);
            }

            myTrack.PrintTrackDetails();
        
            
        }
    }
}