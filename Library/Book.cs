using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int AuthorID { get; set; }
        public string ReleaseMonth { get; set; }
        public string  Prescription { get; set; }
        public string Price { get; set; }
        public Author Author { get; set; }

        //public CategoryType CategoryType { get; set; }
        public List<BookCategory> BookCategories { get; set; }
    }
}
