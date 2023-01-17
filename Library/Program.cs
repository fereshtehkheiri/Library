﻿// See https://aka.ms/new-console-template for more information

using Library;
using System;

Console.WriteLine("Welcome to Library app");
Console.WriteLine("For choose the command please click enter...");
Console.ReadLine();
Console.WriteLine("a: The list of authors");
Console.WriteLine("b: The list of books");
Console.WriteLine("c: The list of authors and books");
Console.WriteLine("o: For add or delete operation");
Console.WriteLine("-----------------------------------");
var Authors = new List<Author>();

List<Book> LewiBookList = new List<Book>()
        {
            new Book(){Title="Datamining", Prescription="5", ReleaseMonth="3" , Price="4200$"},
            new Book(){Title="Aesthetic", Prescription="2", ReleaseMonth="4",Price="500$"},
            new Book(){Title="Python", Prescription="1", ReleaseMonth="1",Price="2200$"},
        };
var LewiAuthor = new Author() { FirstName = "Lewi", Surname = "Tifani", Degree = "PhD", Experience = "10 years"};
LewiAuthor.Books = LewiBookList;

List<Book> MeganBookList = new List<Book>()
        {
            new Book(){Title="Chemistry", Prescription="4", ReleaseMonth="", Price="1200$"},
            new Book(){Title="Astronomy", Prescription="2", ReleaseMonth="", Price = "5000$"},
            new Book(){Title="Geology", Prescription="1", ReleaseMonth="", Price = "3100$"},
        };
var MeganAuthor = new Author() { FirstName = "Megan", Surname = "Lean", Degree = "Master", Experience = "7 years" };
MeganAuthor.Books = MeganBookList;
List<Book> PitBookList = new List<Book>()
        {
            new Book(){Title="Art", Prescription="5", ReleaseMonth="3" , Price="4200$"},
            new Book(){Title="Artistic", Prescription="2", ReleaseMonth="4",Price="500$"},
        };
var PitAuthor = new Author() {FirstName = "Pit", Surname = "Fellow", Degree = "PhD", Experience="5 years" };
PitAuthor.Books = PitBookList;

Authors.Add(MeganAuthor);
Authors.Add(LewiAuthor);
Authors.Add(PitAuthor);

string act = Console.ReadLine();

    switch (act)
    {
        case "a":
            Console.WriteLine("FirstName       SurName        Degree       Experience");
            foreach (var author in Authors)
            {
                Console.WriteLine($"{author.FirstName.PadRight(17, ' ')}{author.Surname.PadRight(15, ' ')}{author.Degree.PadRight(12, ' ')}{author.Experience}");
            }
            break;
        case "b":
            Console.WriteLine("-------------LewiBooks-------------");
            Console.WriteLine("Title       Prescription       Price");

            foreach (var LB in LewiBookList)
            {
                Console.WriteLine($"{LB.Title.PadRight(17, ' ')}{LB.Prescription.PadRight(14, ' ')}{LB.Price}");

            }
            Console.WriteLine("-------------MeganBooks-------------");
            Console.WriteLine("Title       Prescription       Price");

            foreach (var MB in MeganBookList)
            {
                Console.WriteLine($"{MB.Title.PadRight(17, ' ')}{MB.Prescription.PadRight(14, ' ')}{MB.Price}");

            }
            Console.WriteLine("-------------PitBooks-------------");
            Console.WriteLine("Title       Prescription       Price");
            foreach (var PB in PitBookList)
            {
                Console.WriteLine($"{PB.Title.PadRight(17, ' ')}{PB.Prescription.PadRight(14, ' ')}{PB.Price}");

            }

            break;
        case "c":
            Console.WriteLine("FirstName     SurName      Book's Name    Price     Category");

            foreach (var author in Authors)
            {
                foreach (var book in author.Books)
                {
                    if (author.FirstName == "Megan" || author.FirstName == "Pit")
                    {
                        Console.WriteLine($"{author.FirstName.PadRight(14, ' ')}{author.Surname.PadRight(13, ' ')}{book.Title.PadRight(15, ' ')}{book.Price.PadRight(10, ' ')}{CategoryType.Science}");
                    }
                    else
                    {
                        Console.WriteLine($"{author.FirstName.PadRight(14, ' ')}{author.Surname.PadRight(13, ' ')}{book.Title.PadRight(15, ' ')}{book.Price.PadRight(10, ' ')}{CategoryType.Tutorial}");
                    }
                }
            }
            break;
        case "o":
            Console.WriteLine("A: Add new author");
            Console.WriteLine("P: Print authors");
            Console.WriteLine("D: Delete author");
            string Action = Console.ReadLine();
            switch (Action)
            {
                case "A":
                    Console.WriteLine($"Please Enter Firstname:");
                    string firstName = Console.ReadLine();
                    Console.WriteLine($"Please Enter Surname:");
                    string surName = Console.ReadLine();
                    Console.WriteLine($"Please choose 'master' or 'phd':");
                    string degree = Console.ReadLine();

                    Authors.Add(new Author { FirstName = firstName, Surname = surName, Degree = degree });
                    goto case "P";
                case "P":
                    Console.WriteLine($"FirstName       Surname        Degree");
                    foreach (var per in Authors)
                    {
                        Console.WriteLine($"{per.FirstName.PadRight(15, ' ')} {per.Surname.PadRight(15, ' ')}{per.Degree}");
                    }
                    break;
                case "D":
                    Authors.RemoveRange(3, 1);
                    goto case "P";
                default:
                    break;
            }
            break;

        default:
            break;
    }
    //Console.WriteLine("If you want to close the app enter EXIT or click enter for go on");


Console.ReadKey();



