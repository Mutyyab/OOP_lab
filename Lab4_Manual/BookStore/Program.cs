using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Book book;
            string title;
            string publisher;
            string author1;
            string author2;
            string author3;
            string author4;
            int isbn;
            int price;
            int stock;
            int option = Menu();
            while(option != 6)
            {
                switch(option)
                {
                    case 1:
                        Console.WriteLine("Enter Book Title:");
                        title = Console.ReadLine();
                        Console.WriteLine("Enter author 1");
                        author1 = Console.ReadLine();
                        Console.WriteLine("Enter author 2");
                        author2 = Console.ReadLine();
                        Console.WriteLine("Enter author 3");
                        author3 = Console.ReadLine();
                        Console.WriteLine("Enter author 4");
                        author4 = Console.ReadLine();
                        Console.WriteLine("Enter the Publisher Name:");
                        publisher = Console.ReadLine();
                        Console.WriteLine("Enter ISBN:");
                        isbn = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter Price of Book");
                        price = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter Stock of Book");
                        stock = Convert.ToInt32(Console.ReadLine());


                        book = new Book(title, author1, author2, author3, author4, publisher, isbn, price, stock);
                        Book.AddBook(book);
                        break;
                    case 2:
                        Console.WriteLine("Enter the Book Title");
                        title = Console.ReadLine();

                        book = new Book();
                        book.SearchBookByTitle(title);
                        break;
                    case 3:
                        Console.WriteLine("Enter the Book ISBN");
                        isbn = Convert.ToInt32(Console.ReadLine());

                        book = new Book();
                        book.SearchBookByISBN(isbn);
                        break;
                    case 4:
                        Console.WriteLine("Enter the Book ISBN Whose Stock you want to update");
                        isbn = Convert.ToInt32(Console.ReadLine());

                        book = new Book();
                        book.UpdateStock(isbn);
                        break;
                    case 5:
                        book = new Book();
                        book.ViewAll();
                        break;
                    default:
                        Console.WriteLine("Invalid Input");
                        break;
                }
                Console.ReadKey();
                option = Menu();
            }
        }

        public static int Menu()
        {
            Console.Clear();
            Console.WriteLine("1) ADD A BOOK");
            Console.WriteLine("2) Search Book By Title");
            Console.WriteLine("3) Search Book by ISBN");
            Console.WriteLine("4) Edit a Book Stock");
            Console.WriteLine("5) View All Books");
            Console.WriteLine("6) Exit");
            int options = Convert.ToInt32(Console.ReadLine());

            return options;
        }


        //public static void ViewAll(List<Book> books)
        //{
        //    for (int i = 0; i < books.Count; i++)
        //    {
        //        Console.WriteLine();
        //        Console.WriteLine($"Title: {books[i].Title}");
        //        Console.WriteLine($"Publisher: {books[i].Publisher}");
        //        Console.WriteLine($"ISBN: {books[i].ISBN}");
        //        Console.WriteLine($"Price: {books[i].Price}");
        //    }
        //}
    }
}
