using WebApplication1.Data.Repositories.Interfaces;
using WebApplication1.Services.Interfaces;
using WebApplication1.ViewModels.Faculties;
using WebApplication1.Data.Entities;

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
        public void Add(FacultyAddEdit facultyAddEdit)
        {
            Faculty faculty= new Faculty()
            {
                Name = facultyAddEdit.Name,
                RoomCount= facultyAddEdit.RoomCount,
            };
            _facultyRepository.Add(faculty);
        }

        public FacultyAddEdit GetById(int id)
        {
           var entity = _facultyRepository.GetById(id);
           return new FacultyAddEdit { Id = entity.Id,Name = entity.Name, RoomCount = entity.RoomCount };
        }

        public void Update(FacultyAddEdit model)
        {
            var entity = _facultyRepository.GetById(model.Id);
            entity.Name = model.Name;
            entity.RoomCount = model.RoomCount;
            _facultyRepository.SaveChanges();
        }
    }
}
