using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите предложение, в котором программа определит самое длинное слово");
            string input = Console.ReadLine();
            string[] str = input.Split(new Char[] {' '}, StringSplitOptions.RemoveEmptyEntries);
            int max = 0, index = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i].Length > max)
                {
                    max = str[i].Length;
                    index = i;
                }
            }
            Console.Write("Самое длинное слово в предложении - {0}", str[index]);
            Console.ReadKey();
        }
    }
}
