using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sports_Exercise_Battle.BusinessLayer.Models
{
    public class User
    {
        public string Username { get; }
        public string Password { get; set; }
        
        public int Elo {  get; set; }

        public User(string username, string password) 
        {  
            Username = username; 
            Password = password;
        }
    }
}
