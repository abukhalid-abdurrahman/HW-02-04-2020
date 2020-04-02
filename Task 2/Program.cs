/*
 * Developed by Faridun Berdiev
 * Date: 02.04.2020
 * Second Task
*/
using System;

namespace Task_2
{
    class Program
    {
        class Book
        {
            
        }

        class Title
        {
            public string titleStr { get; set; }
            public void Show()
            {
                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Title: " + titleStr);
            }
        }

        class Author
        {
            public string authorStr { get; set; }
            public void Show()
            {
                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Author: " + authorStr);
            }
        }

        class Content
        {
            public string сontentStr { get; set; }
            public void Show()
            {
                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Content: " + сontentStr);
            }
        }
        static void Main(string[] args)
        {
        }
    }
}
