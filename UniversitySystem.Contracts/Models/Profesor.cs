using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversitySystem.Contracts.Models
{
    public class Profesor : User
    {
        public Profesor(int id, string name, string surname, string email, string password, int phoneNumber) : base(id, name, surname, email, password, phoneNumber)
        {
        }
    }
}
