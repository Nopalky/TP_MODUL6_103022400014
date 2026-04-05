
class SayaMusicTrack {
    private int id;
    private string playcount;
    private string title;

    public SayaMusicTrack(string title) {
        this.title = title;

        Random play = new Random();
        this.id = play.Next(101, 102);
        this.playcount = "0";
    }

    public void IncreasePlayCount(int count)
    {
        if (count < 0) {
            Console.WriteLine("Jumlah Memutar tidak boleh negatif");
            return;
        }
        playcount = (int.Parse(playcount) + count).ToString();
    }

    public void PrintTrackDetails() {
        Console.WriteLine($"Title: {title} dengan ID:{id} , Jumlah Memutar: {playcount}");
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

            Console.WriteLine("\nTesting Negative Play Count:");
            track1.IncreasePlayCount(-3); // Testing negative play count
        }
    }
}