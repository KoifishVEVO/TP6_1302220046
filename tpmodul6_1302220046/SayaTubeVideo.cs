using System;
using System.Diagnostics.Contracts;
using System.Linq.Expressions;

class SayaTubeVideo
{
    private int id;
    private string title;
    private int playCount;


    public SayaTubeVideo(string judul)
    {
        Contract.Assert(judul.Length < 100);
        Contract.Assert(!string.IsNullOrEmpty(judul));

        Random random = new Random();
        this.id = random.Next(10000, 99999);
        this.title = judul;
        this.playCount = 0;
    }

    public void IncreasePlayCount(int playCount)
    {
        Contract.Assert(playCount <= 10000000);
        try
        {
            checked
            {
                this.playCount += playCount;
            }

        }
        catch (Exception)
        {
            Console.WriteLine("Playcount terlalu besar");
        }



    }
    public void PrintVideoDetails()
    {
        Console.WriteLine("ID: " + this.id);
        Console.WriteLine("Judul: " + this.title);
        Console.WriteLine("Play Count: " + this.playCount);

    }
}