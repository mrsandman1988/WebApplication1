using WebApplication1.Data.Entities;
using WebApplication1.Data.Repositories.Interfaces;
using WebApplication1.Services.Interfaces;
using WebApplication1.ViewModels.Students;

namespace WebApplication1.Services
{
    public class StudentService : IStudentService
    {
        private readonly IStudentRepository _studentRepository;

        public StudentService(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }
        public int Add(StudentAddEditViewModel model)
        {
            //
            Student student = new Student() // object mapping
            {
                FacultyId = model.FacultyId,
                FirstName = model.FirstName,
                LastName = model.LastName,

            };
            _studentRepository.Add(student);
            return student.Id;
        }

        public void Delete(int Id)
        {
            var entity = _studentRepository.GetById(Id);
            _studentRepository.Delete(entity);
        }

        public StudentAddEditViewModel GetById(int Id)
        {
            var entity = _studentRepository.GetById(Id);
            return new StudentAddEditViewModel
            {
                FirstName = entity.FirstName,
                LastName = entity.LastName,
                Id = entity.Id,
                FacultyId = entity.FacultyId
            };
        }

        public int Update(StudentAddEditViewModel model)
        {
            var entity = _studentRepository.GetById(model.Id);
            entity.FirstName = model.FirstName;
            entity.LastName = model.LastName;
            entity.FacultyId = entity.FacultyId;
            _studentRepository.SaveChanges();
            return entity.Id;
        }
    }
}
