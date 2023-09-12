using WebApplication1.Data.Repositories.Interfaces;
using WebApplication1.Services.Interfaces;
using WebApplication1.ViewModels.Faculties;

namespace WebApplication1.Services
{
    public class FacultyService : IFacultyService
    {
        private readonly IFacultyRepository _facultyRepository;
        public FacultyService(IFacultyRepository facultyRepository)
        {
           _facultyRepository= facultyRepository;
        }
        public List<FacultyDropdownViewModel> GetListForDropdown()
        {
            var data = _facultyRepository.GetAll();
            return data.Select(f => new FacultyDropdownViewModel
            {
                Id = f.Id,
                Name = f.Name,
            }).ToList();
        }
    }
}
