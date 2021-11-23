using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите словосочетание. Программа опредлит, является ли оно палиндромом.");
            string userString = Console.ReadLine().ToLower();
            string[] userStringArray = userString.Split();
            string straightString = String.Join("", userStringArray);
            string[] backStringArray = new string[1];
            for (int i = straightString.Length - 1; i >= 0; i--)
            {
                backStringArray[0] = backStringArray[0] + straightString[i];
            }
            string backString = String.Join("", backStringArray);
            Console.WriteLine();
            int flag = String.Compare(straightString, backString);
            if (flag == 0)
            {
                Console.WriteLine("Это словосочетание - палиндром");
            }
            else
            {
                Console.WriteLine("Это словосочетание - не палиндром");
            }
            Console.ReadKey();
        }
    }
}
