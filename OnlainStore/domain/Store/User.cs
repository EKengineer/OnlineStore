using System;
using System.Collections.Generic;
using System.Text;

namespace Store
{
    public class User
    {
        private static int instCounter = 1;

        public int Id { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public string Phone { get; set; }

        public string Name { get; set; }

        public string Address { get; set; }

        public User(string email, string password)
        {
            Id = instCounter;
            Email = email;
            Password = password;
            instCounter += 1;
        }
    }



}
