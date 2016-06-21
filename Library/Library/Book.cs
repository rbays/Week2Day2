using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    class Book
    {
        private string _title;
        private string author;
        private string blurb;
        private string genre;
        private bool reference;
        private bool inStock;

        public Book(string title, string author, string blurb, string genre, bool reference)
        {
            this._title = title;
            this.author = author;
            this.blurb = blurb;
            this.genre = genre;
            this.reference = reference;
            this.inStock = true;
        }
        
        public string title { get
            {
                return _title;
            } }

        public void borrowBook()
        {   
            if (reference)
            {
                Console.WriteLine("Book is a reference copy only.");
            }
            else if (this.inStock)
            {
                Console.WriteLine("Enjoy your book.");
                this.inStock = false;
            }
            else
            {
                Console.WriteLine("Book is currently out.");
            }
        }
        public void returnBook()
        {
            if (this.inStock)
            {
                Console.WriteLine("Book is already in stock, you can't return it");
            }
            else
            {
                Console.WriteLine("Thank you, I hope it was a good read");
                this.inStock = true;
            }
        }
        public void getInfo()
        {
            Console.WriteLine("Title: {0}", this._title);
            Console.WriteLine("Author: {0}", this.author);
            Console.WriteLine("Genre: {0}", this.genre);
            Console.WriteLine("Blurb: {0}", this.blurb);
            if (reference)
            {
                Console.WriteLine("This is a reference copy book");
            }
        }
        
    }
}
