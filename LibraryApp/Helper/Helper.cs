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

        public static bool WriteOnBookJsonFile(List<Book> books)
        {
            var updatedJson = JsonSerializer.Serialize(books, new JsonSerializerOptions
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
            });


            try
            {
                // Write the updated JSON back to the file
                File.WriteAllText("D:\\My Repos\\LibraryApp\\Data\\BookData.json", updatedJson);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
            

        }

        public static bool WriteOnUserJsonFile(List<User> users)
        {
            var updatedJson = JsonSerializer.Serialize(users, new JsonSerializerOptions
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
            });

            try
            {
                
                // Write the updated JSON back to the file
                File.WriteAllText("D:\\My Repos\\LibraryApp\\Data\\UserData.json", updatedJson);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }


        }


        public static bool IsDigit(string str)
        {
            foreach (char c in str)
            {
                if (!char.IsDigit(c))
                {
                    return false;
                }
            }
            return true;
        }

        public static bool IsAlpha(string str)
        {
            foreach(char c in str)
            {
                if (!char.IsLetter(c))
                {
                    return false;
                }
            }
            return true;
        }

        public static bool CheckIsbn(string str)
        {
            if (!string.IsNullOrEmpty(str) && IsDigit(str) && str.Length>=10 && str.Length <= 13)
            {
                return true;
            }
            return false;
        }

        public static bool CheckTxtBox(string str)
        {
            if (!string.IsNullOrEmpty(str))
            {
                return true;
            }
            else return false;
        }

        public static bool CheckYear(string str)
        {
            if (!string.IsNullOrEmpty(str) && IsDigit(str) && str.Length == 4)
            {
                if (int.Parse(str) <= DateTime.Today.Year)
                {
                    return true;
                }

            }
            return false;
        }
    }
}
