using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorsAndComparators
{
    public class Library : IEnumerable<Book>
    {
        public  List<Book> Books { get; set; }

        public Library(params Book[] books)
        {
            this.Books = new List<Book>(books);
        }

        

        public IEnumerator<Book> GetEnumerator()
        {
            
            for(int i = 0; i < this.Books.Count; i++)
            {
                yield return this.Books[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        
    }
}
