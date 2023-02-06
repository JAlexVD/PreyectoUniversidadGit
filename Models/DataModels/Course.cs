using System.ComponentModel.DataAnnotations;

namespace Proyecto_Universidad.Models.DataModels
{
    public enum Level
    {
        Basic,
        Medium,
        Advanced,
        Expert
    }
    public class Course: BaseEntity
    {
        [Required, StringLength(50)]
        public String Name { get; set; } = String.Empty;

        [Required, StringLength(280)]
        public String ShortDescription { get; set; } = String.Empty;

        [Required]
        public String Description { get; set; } = String.Empty;
        public Level Level { get; set; } = Level.Basic;

        //curso varias categorias
        [Required]
        public ICollection<Category> Categories { get; set; } = new List<Category>();

        //curso temario
        [Required]
        public Chapter Chapter { get; set; }= new Chapter();

        //Un curso tiene varios alumnos
        [Required]
        public ICollection<Student> Students { get; set; } = new List<Student>();
    }
}
