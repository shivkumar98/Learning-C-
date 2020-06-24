using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Text;

namespace CSharp_Exercises
{
    //1- Write a program and ask the user to enter a 
    //few numbers separated by a hyphen.Work out if 
    //the numbers are consecutive.
    class Exercise_1_StringBuilder
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Please enter a few number seperated by hyphens");
            string input = Console.ReadLine();
            Console.WriteLine(input);
            StringBuilder buffer = new StringBuilder();
            List<int> numberList = new List<int>();

            for (int i=0;i<input.Length-1; i++)
            {
                if (input[i] != '-')
                {
                    buffer.Append(input[i]);
                    if(i == input.Length - 1)
                    {
                        int integer = Convert.ToInt32(buffer.ToString());
                        numberList.Add(integer);
                    }
                    continue;
                }
                else
                {
                    int integer = Convert.ToInt32(buffer.ToString());
                    numberList.Add(integer);
                    buffer.Clear();
                    continue;
                }
            }
            
            for (int i=0;i<numberList.Count-2;i++)
            {
                if (numberList[i] < numberList[i+1])
                {
                    if (i==numberList.Count-1)
                    {
                        Console.WriteLine("consecutive");
                        break;
                    }
                    continue;
                }
                else
                {
                    Console.WriteLine("Not consecutive");
                    break;
                }
            }
            Console.WriteLine("consecutive");

        }

    }
}
