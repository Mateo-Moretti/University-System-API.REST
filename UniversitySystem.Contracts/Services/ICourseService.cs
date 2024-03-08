using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversitySystem.Contracts.Models;

namespace UniversitySystem.Contracts.Services
{
    public interface ICourseService
    {
        //BASE
        Task<Course> CreateAsync(string name);
        Task<Course> UpdateAsync(string name);
        Task DeleteAsync(string name);
        Task<IEnumerable<Course>> GetAllAsync();

        //SPECIFIC
        Task<Course> GetByIdAsync(int id);
    }
}
