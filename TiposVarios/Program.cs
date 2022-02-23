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

            double a = 3.1415;
            float b = 3.1415f;
            decimal c = 3.1415m;

            Console.WriteLine(a +" " + b +" "+ c);

            bool conditionF = false;
            bool condicionT = true;
            

            Console.WriteLine("{0} {1}", conditionF, condicionT);

        }

    }
}
