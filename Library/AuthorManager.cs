using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Library
{
    public class LibraryManager
    {
        public List<Author> Authors { get; set; } 
        public List<Book> Books { get; set; } 

        public LibraryManager()
        {

            var book = JsonSerializer.Serialize(Books);
            //string DbPath = Path.Combine(Environment.CurrentDirectory, "posts.json");

            //using (var fs = File.OpenText(DbPath))
            //{

            //    string content = await fs.ReadToEndAsync();
            //    var posts = JsonSerializer.Deserialize<List<Author>>(content);
            //}

            Books = new List<Book>();   
            Authors = new List<Author>();
            

            List<Book> LewiBookList = new List<Book>()
            {
                new Book(){Title="Datamining", Prescription="5", ReleaseMonth="3" , Price="4200$"},
                new Book(){Title="Aesthetic", Prescription="2", ReleaseMonth="4",Price="500$"},
                new Book(){Title="Python", Prescription="1", ReleaseMonth="1",Price="2200$"},
            };
            var LewiAuthor = new Author() { FirstName = "Lewi", Surname = "Tifani", Degree = Degree.Phd, Experience = "10 years" };
            LewiAuthor.Books = LewiBookList;

            List<Book> MeganBookList = new List<Book>();
            Book book1 = new Book() { Title = "Chemistry", Prescription = "4", ReleaseMonth = "", Price = "1200$" };
            BookCategory bookCategory = new BookCategory { Book = book1, Category = CategoryType.Literature };
            BookCategory bookCategory2 = new BookCategory { Book = book1, Category = CategoryType.Science };
            book1.BookCategories.Add(bookCategory);
            book1.BookCategories.Add(bookCategory2);
            MeganBookList.Add(book1);
            MeganBookList.Add(new Book() { Title = "Astronomy", Prescription = "2", ReleaseMonth = "", Price = "5000$" });
            MeganBookList.Add(new Book() { Title = "Geology", Prescription = "1", ReleaseMonth = "", Price = "3100$" });

            Books.AddRange(MeganBookList);

            var MeganAuthor = new Author() { FirstName = "Megan", Surname = "Lean", Degree = Degree.Master, Experience = "7 years" };
            MeganAuthor.Books = MeganBookList;
            List<Book> PitBookList = new List<Book>()
            {
                new Book(){Title="Art", Prescription="5", ReleaseMonth="3" , Price="4200$"},
                new Book(){Title="Artistic", Prescription="2", ReleaseMonth="4",Price="500$"},
            };

            Books.AddRange(PitBookList);

            var PitAuthor = new Author() { FirstName = "Pit", Surname = "Fellow", Degree = Degree.Phd, Experience = "5 years" };
            PitAuthor.Books = PitBookList;

            Authors.Add(MeganAuthor);
            Authors.Add(LewiAuthor);
            Authors.Add(PitAuthor);
        }


        public Author AddAuthor (string Name, string Surname, Degree Degree)
        {
            Author author = new Author() { FirstName = Name,Surname = Surname, Degree= Degree };
            Authors.Add(author);
            return author;
        }
        public Book AddBook(string Title, string Prescription)
        {
            Book book = new Book() { Title = Title, Prescription = Prescription };
            Books.Add(book);
            return book;
        }

    }
}
