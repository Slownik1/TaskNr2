using System;
using System.Collections.Generic;
using System.Text;

namespace TasnNr2
{
    public static class Class1
    {

        static String text;

        public static char Convert(){

            text = Console.ReadLine();

            for(int i=0; i< text.Length; i++)
            {
                if (Char.IsLower(text[i]))
                    Console.Write(Char.ToUpper(text[i]));
                else
                    Console.Write(Char.ToLower(text[i]));
            }

            return '@';

            }

    }
}
