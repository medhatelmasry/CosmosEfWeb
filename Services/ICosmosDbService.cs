using System.Collections.Generic;
using System.Threading.Tasks;
using CosmosEfWeb.Models;

namespace CosmosEfWeb.Services
{
    public interface ICosmosDbService
    {
        Task<IEnumerable<Student>> GetStudentsAsync(string query);
        Task<Student> GetStudentAsync(string id);
        Task AddStudentAsync(Student student);
        Task UpdateStudentAsync(string id, Student student);
        Task DeleteStudentAsync(string id);
    }
}