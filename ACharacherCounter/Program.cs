using System;

namespace ACharacherCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm palub kasutajal sisestada ees-ja perekonnanime
            //programm kuvab mitu A-tähe on kasutaja ees-ja perekonna nimes kokku


            Console.WriteLine("palun sisesta oma eesnimi:");
            string firstName = Console.ReadLine();
            Console.WriteLine("palun sisesta oma perekonnanimi:");
            string lastName = Console.ReadLine();

            string fullName = $"{firstName}{lastName}".ToLower();

            Console.WriteLine(fullName);

           int aCounter = 0;


           for (int i = 0; i < fullName.Length; i++) 
            {
                if (fullName[i] == 'a')
                {

                    aCounter++;

                }

            }

           if (aCounter != 1)

            {
                Console.WriteLine($"Sinu täisnimes on {aCounter} 'a' tähte");
            }

           else
            {
                Console.WriteLine($"Sinu täisnimes on {aCounter} 'a' täht");
            }


        }
    }
}


