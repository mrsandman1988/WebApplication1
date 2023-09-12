
using WebApplication1.Data.Entities;

namespace WebApplication1.ViewModels.Students
{
    public class StudentAddEditViewModel
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int FacultyId { get; set; }
        
    }
}
