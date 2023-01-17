
using System;

namespace Variable
{
    public class Variable
    {
        public static int tralala()
        {

            // utilizzare la parola <var> per identificare in automatico il tipo di dato 
            var dat = "questa e` una variabile che gli si assegna in automatico il tipo di dato";
            string s2 = "concatenazione tra stringa e un int  " + 23423;

            Console.WriteLine(s2);
            Console.WriteLine("********************");

            string s, sd;
            sd = "Inserisci la frase:  ";
            Console.Write(sd);
            s = Console.ReadLine();

            uint d;
            int x;
            char c = 's';
            Int16 n = Convert.ToInt16(s);
            Console.WriteLine(n * n * n);
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }
            System.Console.Write(s);
            return 0;
        }
    }
}

