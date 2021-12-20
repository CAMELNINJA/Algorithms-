﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace AlgaritmHaffmana
{
    class Program
    {
        static void Main(string[] args)
        {
            string s;
            string exept;
            ReadText text = new ReadText();
            
            (s, exept) = text.Readtext("D:\\Data\\TIC\\AlgaritmHaffmana\\AlgaritmHaffmana\\testText.txt");
            if (exept == null)
            {
                Console.WriteLine("text={0}", s);
                char[] c = s.ToCharArray();
                Reader read = new Reader();
                List<TreeNode> node = read.Count(c);
                Haffman haffman = new Haffman(node);
                string code = read.Coding(s, haffman.keyValues);
                text.WriteText(haffman.Dictinor, code);
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine(exept);
                Console.ReadLine();
            }
        }

        
    }
}
