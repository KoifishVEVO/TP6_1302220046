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

    }
}