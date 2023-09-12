using WebApplication1.ViewModels.Faculties;
namespace WebApplication1.Services.Interfaces
{
    public interface IFacultyService
    {
        public List<FacultyDropdownViewModel> GetListForDropdown();
    }
}
