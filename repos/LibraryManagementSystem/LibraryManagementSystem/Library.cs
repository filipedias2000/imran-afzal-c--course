using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem
{
    internal class Library
    {
        private int bookCounts = 0;
        private int bookEntered;
        private string libraryName;

        // Parametric constructor
        public Library(string name, int maxBooks)
        {
            libraryName = name;
            bookEntered = maxBooks;
            Console.WriteLine($"Library Name: '{libraryName}' is created.");
        }

        ~Library()
        {
            Console.WriteLine($"Library '{libraryName}' object is being destroyed.");
        }

        public string LibraryName
        {
            get { return libraryName; }
            set { libraryName = value; }
        }

        public void AddBook(string bookTitle)
        {
            if (bookEntered > 0)
            {
                bookCounts++;
                Console.WriteLine($"Book '{bookTitle}' added to the library.");
                bookEntered--;
            }
            else
            {
                Console.WriteLine("Library is full. Cannot add more books");
            }
        }

        public void DisplayBooks()
        {
            Console.WriteLine($"Books available in the '{libraryName}' are: '{bookCounts}'");
        }
    }
}