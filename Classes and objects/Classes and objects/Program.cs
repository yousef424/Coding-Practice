using System;

namespace Classes_and_objects
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book("Harry Potter", "JK Rowling", 400 );
            book1.title = "Harry Potter";
            book1.author = "JK Rowling";
            book1.pages = 400;

            Book book2 = new Book("Al Bukhari", "Sahih Al Bukhari", 500);
            book1.title = "Sahih Al Bukhari";
            book1.author = "Al Bukhari";
            book1.pages = 200;
            Console.WriteLine(book2.title);
            Console.ReadLine();
        }
    }
}
