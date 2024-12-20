﻿using System;
using System.Collections.Generic;


namespace Arithmetic
{
    class Program
    {
        static void Main(string[] args)
        {
            string s;
            string exept;
            ReadText text = new ReadText();

            (s, exept) = text.Readtext("D:\\Data\\TIC\\Arithmetic\\Arithmetic\\test.txt");
            if (exept == null)
            {

                char[] c = s.ToCharArray();
                var length = c.Length;
                Reader read = new Reader();
                List<Node> node = read.Count(c);
                string dict = "";
                foreach (Node i in node)
                {
                    dict = dict + i.Chars + i.Frequency.ToString() + "\n";
                    Console.WriteLine("Char={0} Frequency={1} Range={2:R}", i.Chars, i.Frequency ,i.Range);
                }
                text.WriteDict(dict);
                text.WriteText(length.ToString());
                
                Arithmetic arithmetic = new Arithmetic(node,text);
                arithmetic.Start();
                decimal low;
                decimal high;
                (low, high) = arithmetic.Count();
                Console.WriteLine("low={0}", low);
                Console.WriteLine("high={0}", high);
                Console.WriteLine(arithmetic.Same);
            }
            else
            {
                Console.WriteLine(exept);
                Console.ReadLine();
            }
            Console.ReadLine();
        }
    }
}
