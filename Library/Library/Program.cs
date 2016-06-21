using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Book> bookList = new List<Book> { };
            Console.WriteLine("Welcome to the Library, what would you like to do?");
            bool running = true;
            while (running)
            {
                Console.WriteLine("OPTIONS: donate list remove borrow return check exit");
                string choice = Console.ReadLine().ToLower();
                switch (choice)
                {
                    case "donate":
                        Console.WriteLine("What is the title?");
                        string titleIn = Console.ReadLine();
                        Console.WriteLine("Who is the Author?");
                        string authorIn = Console.ReadLine();
                        Console.WriteLine("What is the genre?");
                        string genreIn = Console.ReadLine();
                        Console.WriteLine("Write a quick synopsis");
                        string blurbIn = Console.ReadLine();
                        string referenceIn = "";
                        bool refbool;
                        while (!(referenceIn == "y" || referenceIn == "n"))
                        {
                            Console.WriteLine("is this a reference copy? (Y/N)");
                            referenceIn = Console.ReadLine().ToLower();
                        }
                        switch (referenceIn)
                        {
                            case "y":
                                refbool = true;
                                break;
                            case "n":
                                refbool = false;
                                break;
                            default:
                                refbool = false;
                                break;
                        }
                        bookList.Add(new Book(titleIn, authorIn, blurbIn, genreIn, refbool));
                        break;
                    case "List":
                        Console.WriteLine("Titles: ");
                        foreach(Book b in bookList)
                        {
                            Console.WriteLine(b.title);
                        }
                        break;
                    case "remove":
                        Console.WriteLine("What book would you like to permenantly remove from the library?");
                        string removeIn = Console.ReadLine();
                        int copies = 0;
                        foreach (Book b in bookList)
                        {
                            if(b.title == removeIn)
                            {
                                bookList.Remove(b);
                                Console.WriteLine("book removed");
                                copies += 1;
                            }
                        }
                        if (copies == 0)
                        {
                            Console.WriteLine("Book not in library");
                        }
                        break;
                    case "borrow":


                }
            }

        }
    }
}
