using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;

namespace CSharp_Exercises
{
    /*2- Write a program that reads a text file and displays the longest 
    word in the file.*/

    class Exercise_2_Files
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the path of a text file: ");
            var path = Console.ReadLine();

            var text = File.ReadAllText(path);
            var words = text.Split(' ');
            List<int> wordLength = new List<int>();

            for (var i =0;i<words.Length;i++)
            {
                wordLength.Add(words[i].Length);
            }
            var index = wordLength.IndexOf(wordLength.Max());
            Console.WriteLine("The largest word in this text is: "+ words[index]);
        }

    }

}
