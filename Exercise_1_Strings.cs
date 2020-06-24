using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Tracing;
using System.Globalization;
using System.Runtime.InteropServices.ComTypes;
using System.Runtime.Serialization.Formatters;

/*
-- If no one likes your post, it doesn't display anything.
-- If only one person likes your post, it displays: [Friend's Name] likes your
post.
-- If two people like your post, it displays: [Friend 1] and[Friend 2] 
like your post.
-- If more than two people like your post, it displays: 
[Friend 1], [Friend 2] and[Number of Other People] others like your post.
*/

/*Write a program and continuously ask the user to enter different names,
until the user presses Enter(without supplying a name). 
Depending on the number of names provided, display a message based on the above pattern.
*/

namespace Cshar_Exercises
{
    class Exercise_1
    {
        static void Main(string[] args)
        {

            var names = new List<string>();

            while (true)
            {
                Console.WriteLine("Please enter a name");
                var input = Console.ReadLine();

                if (!String.IsNullOrWhiteSpace(input))
                {
                    names.Add(input);
                    continue;
                }

                break;


            }

            if (names.Count == 0)
            {
                Console.WriteLine("Be the first to like this post");
            }
            else if (names.Count == 1)
            {
                Console.WriteLine("{0} has liked your post", names[0]);
            }
            else if (names.Count == 2)
            { 
                Console.WriteLine("{0} and {1} liked your post", names[0], names[1]);
            }
            else
            {
                var otherLikers = names.Count - 2;
                if (otherLikers == 1)
                {
                    Console.WriteLine("{0}, {1} and 1 other liked your post!",
                    names[0], names[1]);
                }
                else
                {
                    Console.WriteLine("{0}, {1} and {2} others liked your post!",
                    names[0], names[1], otherLikers);
                }
                
            }


        }






    }
}
