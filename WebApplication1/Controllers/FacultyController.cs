using Microsoft.AspNetCore.Mvc;
using WebApplication1.Services.Interfaces;
using WebApplication1.ViewModels.Faculties;

namespace WebApplication1.Controllers
{
    public class FacultyController : Controller
    {
        private readonly IFacultyService _facultyService;
        public FacultyController(IFacultyService facultyService)
        {
            _facultyService = facultyService;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult AddEdit(int? id)
           
        {
            ViewBag.token = Guid.NewGuid().ToString();
            FacultyAddEdit model = id.HasValue ? _facultyService.GetById(id.Value) : new();
            return View(model);
        }
        [HttpPost]
        public IActionResult AddEdit(FacultyAddEdit facultyAddEdit)
        {
            // validate token

            if(facultyAddEdit.Id == 0)
            {
            _facultyService.Add(facultyAddEdit);
            }
            else
            {

            }
            
            return View();
        }
    }
}
