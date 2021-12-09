using System;

namespace StringsAndArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutaja käest tema eesnime;
            //programm kuvab kasutaja eesnime pikkust;

            Console.WriteLine("tere! palun sisesta oma nimi:");
            string firstName = Console.ReadLine();

            //int firstNameLenght = firstName.Length;
            //Console.WriteLine($"Sinu eesnimes on {firstNameLenght} sümbolit.");


            Console.WriteLine($"Sinu eesnimes on {firstName.Length} sümbolit.");



        }
    }
}
