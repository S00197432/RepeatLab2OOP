using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepeatLab2OOP
{
    class Program
    {
        
        static void Main(string[] args)
        {
           
            var date1 = new DateTime(1992, 02, 02, 0, 0, 0);
            var date2 = new DateTime(1978, 02, 28, 0, 0, 0);
            var date3 = new DateTime(2011, 10, 24, 0, 0, 0);
            var date4 = new DateTime(1937, 09, 21, 0, 0, 0);
            var date5 = new DateTime(1916, 12, 29, 0, 0, 0);

            var now = new DateTime(2021, 01,01,0,0,0);

            var age1 = now.Year - date1.Year;
            var age2 = now.Year - date2.Year;
            var age3 = now.Year - date3.Year;
            var age4 = now.Year - date4.Year;
            var age5 = now.Year - date5.Year;


            Book B1 = new Book("James Joyce","Ulysses",date1,730,Genre.Literature,age1);
            Book B2 = new Book("a-Kernighan & D-Ritchie","The C Programming Language", date2, 279, Genre.Computing, age2);
            Book B3 = new Book("Walter Isaacson", "Steve Jobs", date3, 627, Genre.Biography, age3);
            Book B4 = new Book("JRR Tolkien", "The Hobbit", date4, 310, Genre.Fiction, age4);
            Book B5 = new Book("James Joyce", "Portait Of The Artist", date5, 299, Genre.Literature, age5);

            List<Book> ReadingList = new List<Book>();

            ReadingList.Add(B1);
            ReadingList.Add(B2);
            ReadingList.Add(B3);
            ReadingList.Add(B4);
            ReadingList.Add(B5);

            Display(ReadingList);

            ReadingList.Sort();

            Display(ReadingList);

            DisplayAge(ReadingList);
        }
        private static void Display(List<Book> ReadingList)
        {
            Console.WriteLine("\n{0,-30}{1,-30}{2,-10}{3,-15}{4,-20}", "Author--", "Title--", "Pages--", "Genre--","Publication Date--");
            foreach (Book book in ReadingList)
            {
                Console.WriteLine($"{book.Author,-30}{book.Title,-30}{book.Pages,-10}{book.BookGenre,-15}{book.Published,-20}");
            }
        }
        private static void DisplayAge(List<Book> ReadingList)
        {
            Console.WriteLine("\n{0,-30}{1,-30}{2,-10}{3,-15}{4,-20}{5,-15}", "Author--", "Title--", "Pages--", "Genre--", "Publication Date--", "Age--");
            foreach (Book book in ReadingList)
            {
                Console.WriteLine($"{book.Author,-30}{book.Title,-30}{book.Pages,-10}{book.BookGenre,-15}{book.Published,-20}{book.Age,-15}");
            }
        }
    }
}
