using System;
namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            String[] städer = new string[3];
            städer[0] = "Göterborg";
            städer[1] = "Stockholm";
            Console.WriteLine("Skriv en stad förutom " + städer[0] + " och " + städer[1]);
            städer[2] = Console.ReadLine();
            Console.WriteLine($"De tre städerna är {städer[0]}, {städer[1]} och {städer[2]}");
        }

    }

}
