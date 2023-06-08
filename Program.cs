using System;

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

            for (int i = 0; i < str.Length; i++)
            {
                s = str[i].ToString();
                try
                {
                    if (str[i] == str[i + 1])
                    {
                        counter++;
                    }
                    else
                    {
                        s = str[i].ToString();
                        AddToString();
                    }

                    if (i == str.Length - 1)
                    {
                        AddToString();
                    }
                }
                catch
                {
                    AddToString();
                }
            }

            void AddToString()
            {
                if (counter > 1)
                {
                    resultString += counter.ToString();
                }
                resultString += s;

                counter = 1;
                s = null;
            }
            Console.WriteLine(resultString);
        }
    }
}
