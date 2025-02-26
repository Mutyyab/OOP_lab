using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore
{
    public class Book
    {
        public string Title;
        public string Author1;
        public string Author2;
        public string Author3;
        public string Author4;
        public string Publisher;
        public int ISBN;    
        public int Price;
        public int Stock;
        public static List<Book> books = new List<Book>();
        public Book(string title, string publisher, int isbn, int price, int stock, string author1 = null , string author2 = null, string author3 = null, string author4 = null) 
        {
            Title=title;
            Author1=author1;
            Author2=author2;
            Author3=author3;
            Author4 = author4;
            Publisher=publisher;
            Stock=stock;
            ISBN = isbn;
            Price = price;
        }

        public Book()
        {

        }


        public void SearchBookByTitle(string title)
        {
            bool isFound = false;
            int index = 0;
            for (int i = 0; i < books.Count; i++)
            {
                if (books[i].Title == title)
                {
                    isFound = true;
                    index = i;
                    break;
                }
            }

            if (isFound == true)
            {
                Console.WriteLine("Book Found");
                Console.WriteLine($"Title: {books[index].Title}");
                Console.WriteLine($"Publisher: {books[index].Publisher}");
                Console.WriteLine($"ISBN: {books[index].ISBN}");
                Console.WriteLine($"Price: {books[index].Price}");
            }
            if (isFound == false)
            {
                Console.WriteLine("Not Found");
            }
        }

        public bool SearchBook(string title)
        {
            bool isFound = false;
            int index = 0;
            for (int i = 0; i < books.Count; i++)
            {
                if (!(books[i].Title == title))
                {
                    isFound = true;
                    index = i;
                    break;
                }
            }

            return isFound;
        }

        public int ReturnBook(string title)
        {
            int index = 0;
            for (int i = 0; i < books.Count; i++)
            {
                if (books[i].Title == title)
                {
                    index = i;
                    break;
                }
            }

            return index;
        }



        public void SearchBookByISBN(int isbn)
        {
            bool isFound = false;
            int index = 0;
            for (int i = 0; i < books.Count; i++)
            {
                if (books[i].ISBN == isbn)
                {
                    isFound = true;
                    index = i;
                    break;
                }
            }

            if (isFound == true)
            {
                Console.WriteLine("Book Found");
                Console.WriteLine($"Title: {books[index].Title}");
                Console.WriteLine($"Publisher: {books[index].Publisher}");
                Console.WriteLine($"ISBN: {books[index].ISBN}");
                Console.WriteLine($"Price: {books[index].Price}");
            }
            if (isFound == false)
            {
                Console.WriteLine("Not Found");
            }
        }

        public void UpdateStock(int isbn)
        {
            for (int i = 0; i < books.Count; i++)
            {
                if (books[i].ISBN == isbn)
                {
                    Console.WriteLine("Book Found");
                    Console.WriteLine("Enter Updated Stock");
                    books[i].Stock = Convert.ToInt32(Console.ReadLine());
                }
                else
                {
                    Console.WriteLine("Not Found");
                }
            }
        }

        public void ViewAll()
        {
            for (int i = 0; i < books.Count; i++)
            {
                Console.WriteLine();
                Console.WriteLine($"Title: {books[i].Title}");
                Console.WriteLine($"Publisher: {books[i].Publisher}");
                Console.WriteLine($"ISBN: {books[i].ISBN}");
                Console.WriteLine($"Price: {books[i].Price}");
                Console.WriteLine($"Stock: {books[i].Stock}");
            }
        }

        public static void AddBook(Book book)
        {
            books.Add( book );
        }
    }
}
