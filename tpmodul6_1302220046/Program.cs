// See https://aka.ms/new-console-template for more information
using System.Diagnostics;
using System.Diagnostics.Contracts;
using System.Linq.Expressions;

public class Program
{
    public static void Main(string[] args)
    {
        SayaTubeVideo video = new SayaTubeVideo("Tutorial Design By Contract – Muhammad Farhan Ismali Fentarto");
        video.IncreasePlayCount(10);
        video.PrintVideoDetails();

        Console.WriteLine(" ");

        SayaTubeVideo test = new SayaTubeVideo("Tutorial Design By Contract – Muhammad Farhan Ismali Fentarto");

        test.IncreasePlayCount(10000001);

        for (int i = 0; i < 214; i++)
        {
            test.IncreasePlayCount(10000000);
        }


        test.PrintVideoDetails();

        Console.WriteLine(" ");

        SayaTubeVideo test2 = new SayaTubeVideo(null);

        test2.PrintVideoDetails();

    }
}
