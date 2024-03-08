using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversitySystem.Contracts.Models
{
    public class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Course(int id, string name)
        {
            this.Id = id;
            this.Name = name;
        }
    }
}
