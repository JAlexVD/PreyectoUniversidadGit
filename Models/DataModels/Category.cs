using System.ComponentModel.DataAnnotations;

namespace Proyecto_Universidad.Models.DataModels
{
    public class Category: BaseEntity
    {
        [Required, StringLength(50)]
        public String Name { get; set; } = String.Empty;
        [Required]
        public ICollection<Course> Courses { get; set; }= new List<Course>();

    }
}
