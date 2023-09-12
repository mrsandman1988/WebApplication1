using WebApplication1.Data.Entities;

namespace WebApplication1.Data.Repositories.Interfaces
{
    public interface IStudentRepository
    {
        void Add(Student student);
        Student GetById(int id);
        List<Student> GetAll();
        void Delete(Student student);
        void SaveChanges();
    }
}
