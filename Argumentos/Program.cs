using System;

namespace Argumentos
{
    class Program
    {
        static void Main (string[] args)
        {
            int i= 0;
            for (i = 0; i < args.Length; ++i)
            {
                Console.WriteLine(args[i]);
            }

        }

    }
}