using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            perser perserFile= new Sjson();
            perserFile.getData(1);
         System.Console.WriteLine(perserFile.getItem());
        }
    }
}
