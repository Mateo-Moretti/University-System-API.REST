using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversitySystem.Contracts.Models
{
    public abstract class User
    {
        public int id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int PhoneNumber { get; set; }

        public User(int id, string name, string surname, string email, string password, int phoneNumber)
        {
            this.id = id;
            this.Name = name;
            this.Surname = surname;
            this.Email = email;
            this.Password = password;
            this.PhoneNumber = phoneNumber;
        }
    }
}
