using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DzDz9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book("Paradise", "Djoseph Lori", 2005, 650);
            book1.DisplayInfo();
            book1.IsThik();

            Book book2 = new Book("Mini-Lord", "Rozed Inn", 2021, 450);
            book2.DisplayInfo();
            book2.IsThik();


        }

        public class Book
        {
            public string nameBook { get; set; }
            public string autorBook { get; set; }
            public int ageBook { get; set; }
            public int pagesBook { get; set; }

            public Book(string nameBook, string autorBook, int ageBook, int pagesBook)
            {
                this.nameBook = nameBook;
                this.autorBook = autorBook;
                this.ageBook = ageBook;
                this.pagesBook = pagesBook;
            }

            public void DisplayInfo()
            {
                Console.WriteLine($"Name of book:{nameBook} \nAutor:{autorBook} \nYear:{ageBook} \nPages:{pagesBook}");
            }

            public void IsThik()
            {
                if (pagesBook > 500)
                {
                    Console.WriteLine("It's big book!");
                }
                else
                {
                    Console.WriteLine("It's not big book!");
                }
            }
        }


    }
}
