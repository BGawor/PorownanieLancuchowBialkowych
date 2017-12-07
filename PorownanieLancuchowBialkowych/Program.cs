using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace PorownanieLancuchowBialkowych
{
    class Program
    {
        public static bool ChangePossible(string firstProtein, string secondProtein) //to do: stop comparing arrays after proteins have been confirmed to be related
        {
            Console.WriteLine(firstProtein);    //debug
            Console.WriteLine(secondProtein);  //debug
            if (firstProtein.Length != secondProtein.Length) return false;
            int[] firstProteinCharCount = new int['T'- 'A'];
            int[] secondProteinCharCount = new int['T' - 'A'];
            for (int i = 0; i < firstProtein.Length; i++)
            {
                firstProteinCharCount[firstProtein[i] - 65]++;
                secondProteinCharCount[secondProtein[i] - 65]++;
            }
           
            for (int i = 0; i < firstProteinCharCount.Length; i++)
            {
                Console.WriteLine(System.Convert.ToChar(i+65) + ": " + firstProteinCharCount[i] + secondProteinCharCount[i]);  // debug
                if (firstProteinCharCount[i] != secondProteinCharCount[i]) return false;
            }
            return true;
        }
        static void Main(string[] args)
        {
            try
            {
                StreamReader fs = new StreamReader(Path.GetFullPath("C:\\Users\\Bartlomiej\\Documents\\lancuchy_bialkowe.txt"));


                while (!fs.EndOfStream)
                {
                    if (ChangePossible(fs.ReadLine(), fs.ReadLine()))
                    {
                        Console.WriteLine("bialka sa permutacja");
                    }
                    else
                    {
                        Console.WriteLine("bialka nie sa powiazane");
                    }
                }
            
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
               // throw;
            }

        
            Console.ReadKey();
        }
    }
}
