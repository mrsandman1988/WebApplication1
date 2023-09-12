using Microsoft.AspNetCore.Mvc;
using WebApplication1.Services;
using WebApplication1.Services.Interfaces;
using WebApplication1.ViewModels.Students;
namespace WebApplication1.Controllers
{
    public class StudentController : Controller
    {
        private readonly IStudentService _studentService;
        private readonly IFacultyService _facultyService;

        public StudentController(IStudentService studentService, IFacultyService facultyService)
        {
            _studentService= studentService;
            _facultyService= facultyService;
        }
        public IActionResult Index()
        {
           
            return View();
        }

        [HttpGet]
        public IActionResult AddEdit(int? id)
        {
            ViewBag.Faculty = _facultyService.GetListForDropdown();
            StudentAddEditViewModel model = id.HasValue ? 
                _studentService.GetById(id.Value) :
                new StudentAddEditViewModel();
            return View(model);
        }

        [HttpPost]
        public IActionResult AddEdit(StudentAddEditViewModel model)
        { 
            if(model.Id >0)
            {
                _studentService.Update(model);
            }
            else
            {
                _studentService.Add(model);
            }
            return View();
        }
    }
}
