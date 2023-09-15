using WebApplication1.ViewModels.Faculties;
namespace WebApplication1.Services.Interfaces
{
    public interface IFacultyService
    {
        public List<FacultyDropdownViewModel> GetListForDropdown();
        public void Add(FacultyAddEdit facultyAddEdit);
        FacultyAddEdit GetById(int id);
        public void Update(FacultyAddEdit model);
    }
}
