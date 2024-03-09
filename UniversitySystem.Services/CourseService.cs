using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversitySystem.Contracts.Models;
using UniversitySystem.Contracts.Services;

namespace UniversitySystem.Services
{
    public class CourseService : ICourseService
    {
        public Task<Course> CreateAsync(string name)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(string name)
        {
            throw new NotImplementedException();
        }

        public Task EnrollProfesorAsync(int profesorId, int courseId)
        {
            throw new NotImplementedException();
        }

        public Task EnrollSudentAsync(int studentId, int courseId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Course>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Profesor>> GetAllProfesorsAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Student>> GetAllStudentsAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Course> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task ReleaseProfesorAsync(int profesorId, int courseId)
        {
            throw new NotImplementedException();
        }

        public Task ReleaseSudentAsync(int studentId, int courseId)
        {
            throw new NotImplementedException();
        }

        public Task<Course> UpdateAsync(string name)
        {
            throw new NotImplementedException();
        }
    }
}
