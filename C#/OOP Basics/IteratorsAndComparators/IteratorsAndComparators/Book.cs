using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorsAndComparators
{
    public class Book : IComparable<Book>
    {
        public string Title { get; set; }
        public int Year { get; set; }
        public  List<string> Authors { get; set; }

        public Book(string title, int year, params string[] authors)
        {
            this.Title = title;
            this.Year = year;
            this.Authors = new List<string>(authors);
        }

        public override string ToString()
        {
            return $"{this.Title} - {this.Year}";
        }

        public int CompareTo(Book otherBook)
        {
            int result = this.Year.CompareTo(otherBook.Year);
            if(result == 0)
            {
                result = this.Title.CompareTo(otherBook.Title);
            }

            return result;
        }
    }
}
