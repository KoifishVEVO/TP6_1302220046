using System;
using System.Diagnostics.Contracts;

class SayaTubeVideo
{
    private int id;
    private string title;
    private int playCount;


    public SayaTubeVideo(string judul)
    {
        Random random = new Random();
        this.id = random.Next(10000, 99999);
        this.title = judul;
        this.playCount = 0;
    }

    public void IncreasePlayCount(int playCount)
    {
                this.playCount += playCount;
            




    }
    public void PrintVideoDetails()
    {
        Console.WriteLine("ID: " + this.id);
        Console.WriteLine("Judul: " + this.title);
        Console.WriteLine("Play Count: " + this.playCount);

    }
}
