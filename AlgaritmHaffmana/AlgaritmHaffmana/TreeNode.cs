﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgaritmHaffmana
{
    public struct TreeNode
    {
        public char Chars { get; set; }

        public int Frequency { get; set; }

        public TreeNode(char chars, int frequency)
        {
            Chars = chars;
            Frequency = frequency;
            
        }

    
        public TreeNode UpFreeq(int k)
        {
            
            Frequency = k;
            return this;
        }
    }
}
