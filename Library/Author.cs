using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Author
    {
        public string Id { get; set; }
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public string Degree { get; set; }
        public string Experience { get; set; }

        public string FullName { get { return $"{FirstName} {Surname}"; } }

        public List<Book> Books;
    }
}
