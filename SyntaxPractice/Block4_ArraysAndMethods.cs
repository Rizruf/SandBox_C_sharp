using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SyntaxPractice
{
    public static class Block4_ArraysAndMethods
    {
        public static void PrintArray (int[] arryaToPrint)
        {
            foreach (int i in arryaToPrint)
            {
                Console.Write($"{i} ");
            }
        }
    }
}
