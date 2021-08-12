using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepeatLab2OOP
{
   
    class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public DateTime Published { get; set; }
        public int Pages { get; set; }
        public Genre BookGenre { get; set; }

        public Book(string author, string title, DateTime published,int pages ,Genre bookgenre)
        {
            Title = title;
            Author = author;
            Published = published;
            Pages = pages;
            BookGenre = bookgenre;
        }

        public override string ToString()
        {
            return string.Format($"{Author} {Title} {Published} {Pages} {BookGenre}");
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
