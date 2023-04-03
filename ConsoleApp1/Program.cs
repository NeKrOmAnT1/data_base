using ConsoleApp1.DB;
using Microsoft.EntityFrameworkCore;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");


        Offline ef = new Offline();
        ef.Database.Migrate();
    }
}