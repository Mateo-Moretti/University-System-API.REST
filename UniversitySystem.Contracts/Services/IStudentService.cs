using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversitySystem.Contracts.Models;

namespace UniversitySystem.Contracts.Services
{
    public interface IStudentService
    {
        //BASE
        Task<Student> CreateAsync(string name, string surname, string mail, string password, string phoneNumber);
        Task<Student> UpdateAsync(string name, string surname, string mail, string password, string phoneNumber);
        Task DeleteAsync(int id);
        Task<IEnumerable<Student>> GetAllAsync();

        //SPECIFIC
        Task<Student> GetByIdAsync(int id);
        Task<Student> GetByNameAsync(string name, string surname);
        Task<Student> RegisterUserAsync(string name, string surname, string mail, string password, string phoneNumber);
        Task<IEnumerable<Course>> GetCoursesAsync(int id);
        Task<IEnumerable<Profesor>> GetProfesorsAsync(int id);

    }
}
