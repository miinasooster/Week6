using System;

namespace FirstOrLast
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm palun kasutajal sisestada ees-ja perekonnanime
            //programm kontrollib andmete pikkust eraldi
            //programm kuvab kumb nedest on pikem kas ees või perekonna nimi

            Console.WriteLine("tere");

            //EESNIMI
            Console.WriteLine("palun sisesta oma eesnimi:");
            string firstName = Console.ReadLine();

            Console.WriteLine($"Sinu eesnimes on {firstName.Length} sümbolit.");


            //PEREKONNANIMI
            Console.WriteLine("palun sisesta oma perekonnanimi:");
            string lastName = Console.ReadLine();

            Console.WriteLine($"Sinu perekonnanimes on {firstName.Length} sümbolit.");


            if (firstName.Length > lastName.Length)
            {
                Console.WriteLine("Sinu eesnimi on pikem kui sinu perekonnanimi");
            }

            else if (firstName.Length < lastName.Length)
            {
                Console.WriteLine("Sinu eesnimi on lühem kui sinu perekonnanimi");
            }

            else
            {
                Console.WriteLine("Sinu eesnimi on sama pikk kui sinu perekonnanimi");
            }


        }
    }
}
