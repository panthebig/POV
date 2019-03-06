using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POV__Arduino
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] code = { { "*", "*", "*" }, { "*", " ", " " }, { "*", "*", "*" },
                             { "*", "*", "*" } , { " ", "*", " " } , { " ", " ", "*" } ,
                             { "*", "*", "*" } , { "*", " ", "*" } , { "*", " ", "*" } };
            char[] AB = {'a','b','c'};
            string input = Console.ReadLine();
            char[] mnm = input.ToCharArray();
            int[] index = new int[mnm.Length];
            int j = 0;
            foreach (char item in mnm)
            {
                for (int i = 0; i < AB.Length; i++)
                {
                    if(item == AB[i])
                    {
                        index[j] = i;
                        j++;
                    }
                }
            }
            Console.Clear();
            foreach (int item in index)
            {
                for (int i = item * 3; i < (item*3) + 3; i++)
                {
                    for (int n = 0; n < 3; n++)
                    {
                        if (code[i, n] == "*")
                        {
                            Console.WriteLine("*"); //Εδω τα λαμπακια του Arduiono
                        }
                        else
                        {
                            Console.WriteLine();
                        }
                    }
                    System.Threading.Thread.Sleep(500);
                    Console.Clear();
                }
            }


        }
    }
}
