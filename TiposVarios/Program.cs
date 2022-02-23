using System;

namespace TiposVarios
{
    class Program
    {
        static void Main (string[] args)
        {
            int x = 10;         //inteiro decimal
            int y = 0b1010;     //inteiro binário
            int z = 0xA;        //inteiro hexadecimal

            Console.WriteLine(x +" " + y +" "+ z);

            char Plica ='\u0027';
            char Aspa = '\u0022';
            char BarraInvertida = '\u005C';

            Console.WriteLine(Plica +" " + Aspa +" "+ BarraInvertida);

        }

    }
}
