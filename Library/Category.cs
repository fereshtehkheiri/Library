using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Category
    {
        public int Id { get; set; }

        public string Name { get; set; }

    }
    public enum CategoryType
    {
        None,Literature, Cultural, Historical, Tutorial, Science, Comedy

    }
}
