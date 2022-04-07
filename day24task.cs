using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.Linq;

namespace linq
{
    class day24task
    {
        public static void Main()
        {
            IList<Book> Bookdata = new List<Book>()
            {
                new Book() { BookID = 1300, Title = "INVESTING INTELLIGENCE", Author = " Benjamin Graham", Price = 179},
                        new Book() { BookID = 1303, Title = " Lord of the Rings ", Author = " J. R. R. Tolkien",Price = 1499},
                         new Book() { BookID = 1306, Title = " Rich Dad Poor Dad ", Author = " Robert Kiyosaki",Price = 347},
                          new Book() { BookID = 1307, Title = " Ponniyin Selvan ", Author = " Kalki Krishnamurthy",Price = 305}
            };

            Console.WriteLine("*****************task1****************************");

            var Bqry = from book in Bookdata
                       select book;
            foreach (var v in Bqry)
                Console.WriteLine(v.BookID + " " + v.Title + " " + v.Author + " " + v.Price + " ");

            Console.WriteLine("*****************task2****************************");

            var Bqry3 = from books in Bookdata
                        where books.Author.Contains("Kalki Krishnamurthy")
                        select books;
            foreach (var v in Bqry3)
                Console.WriteLine(v.Title);

            Console.WriteLine("********************task3***************************");

            var Bqry2 = from book in Bookdata
                        orderby book.Price
                        select book;
            foreach (var b in Bqry2)
                Console.WriteLine(b.Price + " " + b.Title);

            Console.WriteLine("******************task4***********************************");


            var Bqry1 = from book in Bookdata
                        orderby book.Author
                        select book;
            foreach (var names in Bqry1)
                Console.WriteLine(names.Author + " " + names.Title);




        }

    }
    class Book
    {
        public int BookID { get; set; }
        public String Title { get; set; }
        public String Author { get; set; }
        public int Price { get; set; }
    }
}