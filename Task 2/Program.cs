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
            private Title _bookTitle;
            private Author _bookAuthor;
            private Content _bookContent;
            
            public Book(string _title, string _author, string _content)
            {
                _bookTitle = new Title();
                _bookAuthor = new Author();
                _bookContent = new Content();
                _bookTitle.titleStr = _title;
                _bookAuthor.authorStr = _author;
                _bookContent.сontentStr = _content;
            }

            public void ShowInfo()
            {
                _bookTitle.Show();
                _bookAuthor.Show();
                _bookContent.Show();
            }

            public void ShowTitle()
            {
                _bookTitle.Show();
            }

            public void ShowAuthor()
            {
                _bookAuthor.Show();
            }

            public void ShowContent()
            {
                _bookContent.Show();
            }
        }

        class Title
        {
            public string titleStr { get; set; }
            public void Show()
            {
                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Title: " + this.titleStr);
            }
        }

        class Author
        {
            public string authorStr { get; set; }
            public void Show()
            {
                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Author: " + this.authorStr);
            }
        }

        class Content
        {
            public string сontentStr { get; set; }
            public void Show()
            {
                Console.BackgroundColor = ConsoleColor.Yellow;
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Content: " + this.сontentStr);
            }
        }
        static void Main(string[] args)
        {
            Console.Write("Input Author: ");
            string author = Console.ReadLine();
            Console.Write("Input Title: ");
            string title = Console.ReadLine();
            Console.Write("Input Content: ");
            string content = Console.ReadLine();

            Book book = new Book(title, author, content);
            book.ShowInfo();
        }
    }
}
