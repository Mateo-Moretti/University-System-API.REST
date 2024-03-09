using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversitySystem.Contracts.Models;

namespace UniversitySystem.Contracts.Services
{
    public interface IProfesorService
    {
        //BASE
        Task<Profesor> CreateAsync(string name, string surname, string mail, string password, string phoneNumber);
        Task<Profesor> UpdateAsync(string name, string surname, string mail, string password, string phoneNumber);
        Task DeleteAsync(int id);
        Task<IEnumerable<Profesor>> GetAllAsync();

        //SPECIFIC
        Task<Profesor> GetByIdAsync(int id);
        Task<Profesor> GetByNameAsync(string name, string surname);
        Task<Profesor> RegisterUserAsync(string name, string surname, string mail, string password, string phoneNumber);
        Task<IEnumerable<Course>> GetCoursesAsync(int id);
        Task<IEnumerable<Student>> GetStudentsAsync(int id);

    }
}
