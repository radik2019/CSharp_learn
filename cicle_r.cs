// using System;

namespace cicle_r
{
    public class For_e
    {
        public static string s = "abcdefghi";
        public static int lenR = s.Length;
        public static void foo1()
        {
            foreach (var item in "abcdefghi")
            {
                System.Console.WriteLine(item);
            }
        }

        public static void foo2(){
            for (int i = 0; i < lenR; i++)
            {
                System.Console.WriteLine(s[i]);
            }
        }
    }
}






