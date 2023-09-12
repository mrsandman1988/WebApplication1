using WebApplication1.Data.Entities;

namespace WebApplication1.Data.Repositories.Interfaces
{
    public interface IFacultyRepository
    {
        void Add(Faculty faculty);
        Faculty GetById(int id);
        List<Faculty> GetAll();
        void Delete(Faculty faculty);
        void SaveChanges();
    }
}
