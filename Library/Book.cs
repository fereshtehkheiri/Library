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
        public string Prescription { get; set; }
        public string Price { get; set; }
        public Author Author { get; set; }

        //public CategoryType CategoryType { get; set; }
        public List<BookCategory> BookCategories { get; set; } = new List<BookCategory>();

        public override string ToString()
        {
            string categories = string.Empty;
            foreach (var b in BookCategories)
            {
                categories += b.Category.ToString() + ", ";
            }

            if (categories.Length > 0)
            {
                categories = categories.Substring(0, categories.Length - 2);
            }

            return $"{this.Author.FirstName.PadRight(14, ' ')}{this.Author.Surname.PadRight(13, ' ')}" +
                $"{this.Title.PadRight(15, ' ')}{this.Price.PadRight(10, ' ')}{categories}";
        }
    }
}
