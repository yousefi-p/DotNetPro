using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApp.Models
{
    public class User
    {
        public string FullName {  get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string CellPhone { get; set; }
        public int Role { get; set; }
    }

    public class UserList
    { public List<User> Users { get; set; } }
}
