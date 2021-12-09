using System;

namespace HOLCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm kuvab konsoolis mitu H, O, L tähte on lauses ''Hello World''
            //kaasaarvatud suur H täht!

            string helloWorld = "Hello, world!".ToLower();


            int hCounter = 0;

            for (int i = 0; i < helloWorld.Length; i++)
            {
                if (helloWorld[i] == 'h')
                {

                    hCounter++;

                }

            }

            if (hCounter != 1)

            {
                Console.WriteLine($"Hello world! lauses on {hCounter} 'h' tähte");
            }

            else
            {
                Console.WriteLine($"Hello world! lauses on  {hCounter} 'h' täht");
            }


            int oCounter = 0;

            for (int i = 0; i < helloWorld.Length; i++)
            {
                if (helloWorld[i] == 'o')
                {

                    oCounter++;

                }

            }

            if (oCounter != 1)

            {
                Console.WriteLine($"Hello world! lauses on {oCounter} 'o' tähte");
            }

            else
            {
                Console.WriteLine($"Hello world! lauses on  {oCounter} 'o' täht");
            }


            int lCounter = 0;

            for (int i = 0; i < helloWorld.Length; i++)
            {
                if (helloWorld[i] == 'o')
                {

                    lCounter++;

                }

            }

            if (lCounter != 1)

            {
                Console.WriteLine($"Hello world! lauses on {lCounter} 'o' tähte");
            }

            else
            {
                Console.WriteLine($"Hello world! lauses on  {lCounter} 'o' täht");
            }

        }

    }
}

