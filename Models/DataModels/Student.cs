using System.ComponentModel.DataAnnotations;

namespace Proyecto_Universidad.Models.DataModels
{
    public class Student: BaseEntity
    {
        [Required, StringLength(50)]
        public String FirstName { get; set; } = String.Empty;

        [Required, StringLength(100)]
        public String LastName { get; set; } = String.Empty;

        [Required]
        public DateTime Dob { get; set; }

        //Estudiante varios cursos
        [Required]
        public ICollection<Course> Courses { get; set; } = new List<Course>();
    }
}
