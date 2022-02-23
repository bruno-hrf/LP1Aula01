using System;

namespace VariasStrings
{
    
    
        class Program
    {
        static void Main (string[] args)
        {

            double xx = 0.12345;
            int ii = 18;

            string xx2 = $"xx={xx:f2}";
            string percentxx = $"xx={xx:p1}";

            string hexaii = $"ii={ii:x}";
            string moedaii = $"ii={ii:c}";

            string a = "Uma Plica \u0027";
            string b = "Uma nova linha \nlinha";
            string c = @"Uma Plica 0x0027 em Unicode";
            string d = @"Literalmente um \n";

            string x = "String "+ "conc" + "atizada";
            string xy = x + "e com texto adicionado!";

            int docesCompra = 3;
            int docesComi =2;
            string y = $"comprei {docesCompra} doces e comi {docesComi}";

            int salario = 500;
            int banco = 2300; 
            string z = $"recebi {salario}€ agora tenho {banco + salario}€";

            string last = String.Format("X = {1} e Y = {0}", salario, banco);

            Console.WriteLine(a +"\n"+ b +"\n"+ c + "\n" + d);
            Console.WriteLine(x +"\n"+ xy +"\n"+ y + "\n" + z + "\n" + last);
            
            Console.WriteLine(@"Sálario = {0}€", salario);

            Console.WriteLine(xx2 + "\n" + percentxx);
            Console.WriteLine(hexaii + "\n" + moedaii);
            
        }

    }
}
