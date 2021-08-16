using System;
using System.Collections.Generic;
using System.Text;

namespace MyLibrary
{
    class MyBook : Book
    {
        public int price;


        public MyBook(string _Title, string _Author, int _Price) : base(_Title, _Author)
        {
            title = _Title;
            author = _Author;
            price = _Price;
        }

        public override void Display()
        {
            Console.WriteLine("Title: " + this.title);
            Console.WriteLine("Author: " + this.author);
            Console.WriteLine("Price: " + this.price);

        }
    }
}
