using LibraryApp.Models;

namespace LibraryApp
{
    internal static class Program
    {
        public static  List<Book> books;
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            books = new List<Book> {
                new Book { Isbn="1803237805", Title="C# 11 and .NET 7 – Modern Cross-Platform Development Fundamentals: Start building websites and services with ASP.NET Core 7", Author="Mark J Price", Publisher="Packt Publishing", Year=DateOnly.ParseExact("2022","yyyy"), Available=true},
                new Book { Isbn="1491976705", Title="Head First C#: A Learner's Guide to Real-World Programming with C# and .NET Core", Author="Andrew Stellman", Publisher="O'Reilly Media", Year=DateOnly.ParseExact("2021","yyyy"), Available=true}
            };
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}