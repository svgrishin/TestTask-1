using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace TestTask_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите строку: ");
            string str = Console.ReadLine();
            string s = null;
            string resultString = null;

            int counter = 1;

            for (int i = 0; i < str.Length - 1; i++)
            {
                s = str[i].ToString();
                if (str[i] == str[i + 1])
                {
                    counter++;
                }
                else
                {
                    AddToString();
                }

                if (i == str.Length - 2)
                {
                    AddToString();
                }
            }

            void AddToString()
            {
                resultString += counter.ToString();
                resultString += s;

                counter = 1;
                s = null;
            }
            Console.WriteLine(resultString);
        }
    }
}
