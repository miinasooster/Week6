using System;

namespace StringReplace
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm asendab kõik tähed 'o' tähed lauses ''Hello World!'' tärniga (*)

            string helloWorld = "Hello World!";

            helloWorld = helloWorld.Replace('o', '*');

            Console.WriteLine(helloWorld);





        }
    }
}
