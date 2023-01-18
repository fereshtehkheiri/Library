using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class BookCategory
    {
        public Book Book { get; set; }
        public CategoryType Category { get; set; }
        //public Category Category { get; set; }
        public int BookId { get; set; }
        //public int CategoryId { get; set; }

    }
}
