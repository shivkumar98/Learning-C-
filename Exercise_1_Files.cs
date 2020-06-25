using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace CSharp_Exercises
{
    class Exercise_1_Files
    {
      /*  1- Write a program that reads a text file and displays the number of words.*/
        static void Main(string[] args)
        {
            Console.WriteLine(" Please enter a path:");
            var path = Console.ReadLine();
            var text = File.ReadAllText(path);
            Console.WriteLine( "The text of this file is: ");
            Console.WriteLine(text);

            var stringText = text.Split(' ');
            var numberOfWords = stringText.Count();

            Console.WriteLine("The number of words in this text is: "+numberOfWords);
        }
    }
}
