using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepeatLab2OOP
{
   
    class Book : IComparable
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public DateTime Published { get; set; }
        public int Pages { get; set; }
        public Genre BookGenre { get; set; }
        public int Age { get; set; }

        public Book(string author, string title, DateTime published,int pages ,Genre bookgenre, int age)
        {
            Title = title;
            Author = author;
            Published = published;
            Pages = pages;
            BookGenre = bookgenre;
            Age = age;
        }

        public override string ToString()
        {
            return string.Format($"{Author} {Title} {Published} {Pages} {BookGenre} {Age}");
        }

        public int CompareTo(object obj)
        {
            Book AuthorIAmComparing = obj as Book;
            int returnValue = this.Author.CompareTo(AuthorIAmComparing.Author);
            return returnValue;

        }
    }
    public enum Genre
    {
        Fiction,
        Biography,
        Computing,
        Literature
    }
}
