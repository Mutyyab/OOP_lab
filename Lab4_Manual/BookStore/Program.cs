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
            Book book = new Book();
            Member member = new Member();
            bool isValid;
            bool isFound;
            bool isFound1;
            string title;
            string publisher;
            string author1;
            string author2;
            string author3;
            string author4;
            string memberName;
            string memberID;
            int memberShip_Fee = 0;
            int isbn;
            int Quantity = 0;
            int price;
            int index = 0;
            int index_member = 0;
            int stock;
            int option = Menu();
            while(option != 12)
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

                        book.UpdateStock(isbn);
                        break;
                    case 5:
                        book.ViewAll();
                        break;
                    case 6:
                        Console.WriteLine("Enter your Name: ");
                        memberName = Console.ReadLine();
                        do
                        {
                            Console.WriteLine("Enter your personel member ID (If you want to become a member otherwise enter 0): ");
                            memberID = Console.ReadLine();
                            isValid = member.isValid(memberID);
                        }
                        while (isValid);
                        memberShip_Fee += 10;

                        member = new Member(memberID,memberName);
                        Member.AddMember(member);
                        break;
                    case 7:
                        Console.WriteLine("Enter your Name: ");
                        memberName = Console.ReadLine();

                        member.searchMemberByName(memberName); 
                        break;
                    case 8:
                        Console.WriteLine("Enter your personel member ID: ");
                        memberID = Console.ReadLine();

                        member.searchMemberByID(memberID);
                        break;
                    case 9:
                        Console.WriteLine("Enter your Name: ");
                        memberName = Console.ReadLine();

                        member.updateMemberByName(memberName);
                        break;
                    case 10:
                        do
                        {
                            Console.WriteLine("Enter your Name: ");
                            memberName = Console.ReadLine();
                            Console.WriteLine("Enter your personel member ID (Enter 0 if you are not a member): ");
                            memberID = Console.ReadLine();
                            isFound1 = member.isFound(memberName, memberID);
                            if (isFound1)
                            {
                                Console.WriteLine("Member Not Found");
                                Console.WriteLine();
                            }
                        }
                        while (isFound1);
                        if(isFound1 == false)
                        {
                            index_member = member.ReturnMember(memberName,memberID);
                        }
                        do
                        {
                            Console.WriteLine("Enter the Book You want to Purchase: ");
                            title = Console.ReadLine();
                            isFound = book.SearchBook(title);
                        }
                        while (isFound);
                        if (isFound == false)
                        {
                            index = book.ReturnBook(title);
                        }
                        if (!(isFound))
                        {
                            Console.WriteLine("Enter the quantity of book");
                            Quantity = Convert.ToInt32(Console.ReadLine());
                            Book.books[index].Stock -= Quantity;
                        }
                        if (memberID != "0")
                        {
                            Member.members[index_member].No_of_Books_Bought = Quantity;
                            Member.members[index_member].Money_Spent = Quantity * (Book.books[index].Price - ((Book.books[index].Price * 5) / 100));
                            Console.WriteLine($"Total Price is: {Quantity * (Book.books[index].Price - ((Book.books[index].Price * 5) / 100))}");
                        }
                        else if (memberID == "0")
                        {
                            Console.WriteLine($"Total Price is: {Book.books[index].Price * Quantity}");
                        }
                            break;
                    case 11:
                        Console.WriteLine($"Total Numbers of members are: {Member.members.Count}");
                        Console.WriteLine($"Total Membership fee Collected is {memberShip_Fee}");
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
            Console.WriteLine("1)       ADD A BOOK");
            Console.WriteLine("2)       Search Book By Title");
            Console.WriteLine("3)       Search Book by ISBN");
            Console.WriteLine("4)       Edit a Book Stock");
            Console.WriteLine("5)       View All Books");
            Console.WriteLine("6)       Add Member");
            Console.WriteLine("7)       Search member by Name");
            Console.WriteLine("8)       Search member by ID");
            Console.WriteLine("9)       Update Member Info");
            Console.WriteLine("10)      Purchase Book");
            Console.WriteLine("11)      Stats");
            Console.WriteLine("12)      Exit");
            int options = Convert.ToInt32(Console.ReadLine());

            return options;
        }

    }
}
