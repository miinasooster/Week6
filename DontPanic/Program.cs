using System;

namespace DontPanic
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm asendab lauses 'Don't panic!' kõik o-tähed nulliga (0)
            //programm asendab samas lauses kõik a-tähed neljaga (4)

            string dontPanic = "Don't panic!";

            dontPanic = dontPanic.Replace('o', '0');
            dontPanic = dontPanic.Replace ('a','4');

            Console.WriteLine(dontPanic);
        }
    }
}
