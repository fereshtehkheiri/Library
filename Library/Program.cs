// See https://aka.ms/new-console-template for more information

using Library;
using System;
using System.ComponentModel;

LibraryManager libraryManager = new LibraryManager();

main:
Console.WriteLine("Welcome to Library app");
Console.WriteLine("For choose the command please click enter...");
Console.WriteLine("a: The list of authors");
Console.WriteLine("b: The list of books");
Console.WriteLine("c: The list of authors and books");
Console.WriteLine("-----------------------------------");
string act = Console.ReadLine();

switch (act)
{
    case "a":
        authors:
        Console.WriteLine("FirstName       SurName        Degree");
        foreach (var author in libraryManager.Authors)
        {
            Console.WriteLine($"{author.FirstName.PadRight(17, ' ')}{author.Surname.PadRight(15, ' ')}{
                author.Degree.ToString().PadRight(12, ' ')}");
        }
        Console.WriteLine("a: Add new author");
        Console.WriteLine("d: Delete author");
        Console.WriteLine("u: update author");
        Console.WriteLine("b: Back to main menu");
        Console.WriteLine("-----------------------------------");
        switch (Console.ReadLine())
        {
            case "a":
              
                Console.WriteLine($"Please Enter Firstname:");
                string firstName = Console.ReadLine();
                Console.WriteLine($"Please Enter Surname:");
                string surName = Console.ReadLine();

            choosedegree:
                Console.WriteLine($"Please choose degree:");
                foreach (var d in Enum.GetValues(typeof(Degree)))
                {
                    Console.WriteLine($"{(int)d} - {d.ToString()}");
                }
                string degreeString = Console.ReadLine();
                int degree = 0;
                if (!int.TryParse(degreeString, out degree))
                {
                    goto choosedegree;
                }
                

                libraryManager.AddAuthor(Name: firstName, surName, (Degree)degree);
                goto authors;
            case "d":
                libraryManager.Authors.RemoveAt(0);
                break;

            case "u":
                break;

            case "b":
                goto main;
                
            default:
                break;
        }
        break;
    case "b":
        Console.WriteLine("Title       Prescription       Price");

        foreach (var LB in libraryManager.Books)
        {
            Console.WriteLine($"{LB.Title.PadRight(17, ' ')}{LB.Prescription.PadRight(14, ' ')}{LB.Price}");

        }
        Console.WriteLine("For choose the command please click enter...");
        Console.WriteLine("a: Add new book");
        Console.WriteLine("d: Delete book");
        Console.WriteLine("u: update book");
        Console.WriteLine("b: Back to main menu");
        Console.WriteLine("-----------------------------------");
        switch (Console.ReadLine())
        {
            case "a":
                Back:
                Console.WriteLine($"Please Enter book's name:");
                string title = Console.ReadLine();
                Console.WriteLine($"Please Enter prescription:");
                string prescription = Console.ReadLine();
                libraryManager.AddBook(title, prescription);
                goto Back;
                
            case "d":
                
                break;

            case "u":
                break;

            case "b":
                goto main;
            default:
                break;
        }
        break;
    case "c":
        Console.WriteLine("FirstName     SurName      Book's Name    Price     Category");

        foreach (var author in libraryManager.Authors)
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
        Console.WriteLine("a: Add new book");
        Console.WriteLine("d: Delete book");
        Console.WriteLine("u: update book");
        Console.WriteLine("b: Back to main menu");
        Console.WriteLine("-----------------------------------");
        switch (Console.ReadLine())
        {
            case "a":
                
                

                break;

            case "d":
                break;

            case "u":
                break;

            case "b":
                goto main;
            default:
                break;
        }
        break;


    default:
        break;
}
//Console.WriteLine("If you want to close the app enter EXIT or click enter for go on");


Console.ReadKey();



