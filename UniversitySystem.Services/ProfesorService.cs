using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversitySystem.Contracts.Models;
using UniversitySystem.Contracts.Services;

namespace UniversitySystem.Services
{
    public class ProfesorService : IProfesorService
    {
        public Task<Profesor> CreateAsync(string name, string surname, string mail, string password, string phoneNumber)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Profesor>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Profesor> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Profesor> GetByNameAsync(string name, string surname)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Course>> GetCoursesAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Student>> GetStudentsAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Profesor> RegisterUserAsync(string name, string surname, string mail, string password, string phoneNumber)
        {
            throw new NotImplementedException();
        }

        public Task<Profesor> UpdateAsync(string name, string surname, string mail, string password, string phoneNumber)
        {
            throw new NotImplementedException();
        }
    }
}
