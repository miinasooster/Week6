using System;

namespace HelloWordlReverse
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm kuvab lauset 'Hello world' tagurpidi;

            string helloWorld = "Hello, world!";

            for (int i = helloWorld.Length - 1; i >= 0; i--)
            {
                Console.Write(helloWorld[i]);
            }
        }
    }
}
