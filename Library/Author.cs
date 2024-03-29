﻿using System;
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
        public Degree Degree { get; set; }
        public string Experience { get; set; }

        //public string FullName { get { return $"{FirstName} {Surname}"; } }

        public List<Book> Books;

        public override string ToString()
        {
            return $"{this.FirstName.PadRight(17, ' ')}{this.Surname.PadRight(15, ' ')}{this.Degree.ToString().PadRight(12, ' ')}";
        }
    }

    public enum Degree
    {
        None,
        Master,
        Phd
    }
}
