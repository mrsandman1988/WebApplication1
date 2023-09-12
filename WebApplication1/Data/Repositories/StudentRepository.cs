using WebApplication1.Data.Entities;
using WebApplication1.Data.Repositories.Interfaces;

namespace WebApplication1.Data.Repositories
{
    public class StudentRepository : IStudentRepository
    {
        private readonly UniversityDataContext _context;
        public StudentRepository(UniversityDataContext context)
        {
            _context = context;
        }

        public void Add(Student student)
        {
            _context.Students.Add(student);
            _context.SaveChanges();
        }

        public void Delete(Student student)
        {
            _context.Students.Remove(student);
            _context.SaveChanges();
        }

        public List<Student> GetAll()
        {
            return _context.Students.ToList();
        }

        public Student GetById(int id)
        {
            return _context.Students.Find(id);
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }
    }
}
