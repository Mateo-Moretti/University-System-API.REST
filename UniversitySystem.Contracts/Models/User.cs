using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversitySystem.Contracts.Models
{
    public abstract class User
    {
        public int id;
        public string Name;
        public string Surname;
        public string Email;
        public string Password;
        public int PhoneNumber;

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
