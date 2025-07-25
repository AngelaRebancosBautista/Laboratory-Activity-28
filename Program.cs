using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratory_Activity_28
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a word: ");
            string word = Console.ReadLine();

            var reversed = new StringBuilder(word.Length);
            for (int i = word.Length - 1; i >= 0; i--)
            {
                reversed.Append(word[i]);
            }

            Console.WriteLine("Reversed: " + reversed);
        }
    }
}

        




