using Microsoft.IdentityModel.Tokens;
using Proyecto_Universidad.Models.DataModels;

namespace Proyecto_Universidad
{
    public class Services
    {
        //Buscar usuarios por email
        public static void buscarUsuarioEmail()
        {
            var usuarios = new List<User>();

            var usuarioEmail = usuarios.Select(usuario => usuario.Email);
        }

        //Buscar Alumnos mayores de edad
        public static void alumnoMayorEdad()
        {
            var alumnos = new List<Student>();
            
            var alumnoMayor = alumnos.Select(alumno => alumno.Dob);
        }

        //Buscar Alumnos que tengan al menos un curso
        public static void alumnoCurso()
        {
            var alumnos = new List<Student>();

            var cursos = new List<Course>();

            var buscar = alumnos.Any(curso => curso.Courses.Any());
        }

        //Buscar cursos de un nivel determinado que al menos tengan un alumno inscrito
        public static void alumnoCursoNivel()
        {
            var alumnos = new List<Student>();

            var cursos = new List<Course>();

            var buscar = cursos.Any(alumno => alumno.Students.Any());
        }

        //Buscar cursos de un nivel determinado que sean de una categoría determinada
        public static void cursoCategoria()
        {
            var cursos = new List<Course>();
            var categoria = new List<Category>();

            var buscar = cursos.Any(categoria => categoria.Categories.Any());
        }

        //Buscar cursos sin alumnos

        public static void curso()
        {
            var cursos = new List<Course>();

            var cursoSinAlumnos = cursos.Any(curso => curso.Students.IsNullOrEmpty());
        }
        
    }
}
