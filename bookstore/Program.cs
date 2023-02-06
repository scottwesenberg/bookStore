using System;

namespace bookStore
{
    class book
    {
        private int _Id;
        private string _Title;
        private string _Author;

        public book()
        {
            _Id = 0;
            _Title = "";
            _Author = "";
        }

        public book(int i, string Title, string Author)
        {
            _Id = i;
            _Title = Title;
            _Author = Author;
        }
        // GET FUNCTIONS VVVVV
        public string GetFullBook()
        {
            return _Title + " - Written By: " + _Author;
        }
        public int GetId()
        {
            return _Id;
        }
        public string GetTitle()
        {
            return _Title;
        }
        public string GetAuthor()
        {
            return _Author;
        }
        // SET FUNCTIONS VVVVVVV
        public void SetId(int identification)
        {
            _Id = identification;
        }

        public void SetTitle(string title)
        {
            _Title = title;
        }
        public void SetAuthor(string author)
        {
            _Author = author;
        }
    }
    class myStore
    {
        static void Main(string[] args)
        {

            book member30 = new book();
            member30.SetId(20);
            member30.SetTitle("Gumball Warrior");
            member30.SetAuthor("Princess Bubblegum");
            Console.WriteLine($"ID = {member30.GetId()}, Name = {member30.GetFullBook()}");

            book member20 = new book();
            Console.WriteLine("Please enter the member ID: ");
            member20.SetId(int.Parse(Console.ReadLine()));
            Console.WriteLine("Please enter the book name: ");
            member20.SetTitle(Console.ReadLine());
            Console.WriteLine("Please enter the book author: ");
            member20.SetAuthor(Console.ReadLine());

            book member10 = new book(10, "Shrimp Gumbo", "Bubba Gump");

            Console.WriteLine("Please enter the member ID: ");
            int tempID = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the book name: ");
            string tempTitle = Console.ReadLine();
            Console.WriteLine("Please enter the book author: ");
            string tempAuthor = Console.ReadLine();
            book member40 = new book(tempID, tempTitle, tempAuthor);

            displayMembers(member10);
            displayMembers(member20);
            displayMembers(member30);
            displayMembers(member40);
        }
        static void displayMembers(book member)
        {
            Console.WriteLine("Here's your book information");
            Console.WriteLine($"Book ID: {member.GetId()}");
            Console.WriteLine($"Book information: {member.GetFullBook()}");
            Console.WriteLine();
        }
    }

}
