using WebApplication1.ViewModels;
using WebApplication1.ViewModels.Students;

namespace WebApplication1.Services.Interfaces
{
    public interface IStudentService
    {
        public int Add(StudentAddEditViewModel model);
        public void Delete(int Id);
        public int Update(StudentAddEditViewModel model);
        
        public StudentAddEditViewModel GetById(int Id);
    }
}
