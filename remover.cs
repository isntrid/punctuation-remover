using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace punctuation_remover
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Input your sentence here.");

            string sentence = Console.ReadLine();

            
            string RemovePunctuation(string a)
            {

                string x = "";


                for (int i = 0; i < a.Length; i++)
                {
                    int asc = (int)a[i];

                    if (asc > 32 && asc <64)
                    {
                        x = x + "";
                    }
                    else
                    {
                        x = x + a[i];
                    }
                }

                return x;

            }
          

            Console.WriteLine(RemovePunctuation(sentence));
        }
    }
}
