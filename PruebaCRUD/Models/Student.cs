using System.ComponentModel.DataAnnotations;

namespace PruebaCRUD.Models
{
    public class Student
    {

        public int Id { get; set; }

        [Required(ErrorMessage = "El nombre es obligatorio")]
        public string Nombres { get; set; } = string.Empty;

        [Required(ErrorMessage = "El apellido es obligatorio")]
        public string Apellidos { get; set; } = string.Empty;

        [Required(ErrorMessage = "La fecha de nacimiento es obligatoria")]
        public DateTime FechaNacimiento { get; set; }

        [Required(ErrorMessage = "La direccion es obligatoria")]
        public string Direccion { get; set; } = string.Empty;

        [Required(ErrorMessage = "El genero es obligatorio")]
        public string Sexo { get; set; } = string.Empty;

        [Required(ErrorMessage = "El CURP es obligatorio")]
        public string CURP { get; set; } = string.Empty;

        [Required(ErrorMessage = "El teléfono es obligatorio.")]
        public string Telefono { get; set; } = string.Empty;

        [Required(ErrorMessage = "El email es obligatorio.")]
        public string Email { get; set; } = string.Empty;

        [Required(ErrorMessage = "La carrera es obligatoria.")]
        public string Carrera { get; set; } = string.Empty;

        [Required(ErrorMessage = "Debe especificar si es becado o no.")]
        public bool EsBecado { get; set; }

        [Required(ErrorMessage = "Debe seleccionar una modalidad.")]
        public string Modalidad { get; set; } = string.Empty;

        //Opcionales
        public string? Descripcion { get; set; }
        public bool TieneMascotas { get; set; }
        public string? Mascotas { get; set; }
        public string? HorarioComida { get; set; }


    }
}
