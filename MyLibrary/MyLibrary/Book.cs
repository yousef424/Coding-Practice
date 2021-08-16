using System;
using System.Collections.Generic;
using System.Text;

namespace MyLibrary
{
    public abstract class Book
    {
        protected string title;
        protected string author;


        public Book(string _Title, string _Author)
        {
            title = _Title;
            author = _Author;
        }

        public abstract void Display();


    }
}
