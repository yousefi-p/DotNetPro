using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using LibraryApp.Models;

namespace LibraryApp.Helper
{
    public class Helper
    {


        public static List<User> ReadUserJsonFile(string path)
        {
            var jsonString = File.ReadAllText(path);
            var userList = JsonSerializer.Deserialize<UserList>(jsonString, new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true,
            });

            if (userList != null)
            {
                List<User> users = userList.Users;
                return users;
            }
            else { return new List<User>(); }
        }

        public static List<Book> ReadBookJsonFile(string path)
        {
            var jsonString = File.ReadAllText(path);
            var bookList = JsonSerializer.Deserialize<BookList>(jsonString, new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true,
            });

            if (bookList != null)
            {
                List<Book> books = bookList.Books;
                return books;
            }
            else { return new List<Book>(); }
        }
    }
}
