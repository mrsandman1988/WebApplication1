using System.ComponentModel.DataAnnotations.Schema;
namespace WebApplication1.Data.Entities
{
    public class Student
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        [ForeignKey(nameof(Faculty))]
        public int FacultyId { get; set; }
        public Faculty Faculty { get;set; }
    }
}
