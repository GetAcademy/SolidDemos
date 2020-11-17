using System;
using System.IO;

namespace SolidDemos
{
    class Program
    {
        static void Main(string[] args)
        {
            //var lines = File.ReadAllText("filnavn.txt");
            var textStatistics = new TextStatistics("jhgdfkjg\njdshg\nfdssd");
            var count = textStatistics.CountLines();
            Console.WriteLine(count);
        }
    }
}
