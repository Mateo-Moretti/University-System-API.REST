using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversitySystem.Contracts.Models;
using UniversitySystem.Contracts.Services;

namespace UniversitySystem.Services
{
    public class StudentService : IStudentService
    {
        public Task<Student> CreateAsync(string name, string surname, string mail, string password, string phoneNumber)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Student>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Student> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Student> GetByNameAsync(string name, string surname)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Course>> GetCoursesAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Profesor>> GetProfesorsAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Student> RegisterUserAsync(string name, string surname, string mail, string password, string phoneNumber)
        {
            throw new NotImplementedException();
        }

        public Task<Student> UpdateAsync(string name, string surname, string mail, string password, string phoneNumber)
        {
            throw new NotImplementedException();
        }
    }
}
