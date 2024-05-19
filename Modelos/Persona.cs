using System.ComponentModel.DataAnnotations;

namespace BdAutomoviles.Modelos
{
    public class Persona
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "El nombre es obligatorio")]
        [StringLength(100, ErrorMessage = "Máximo 100 caracteres")]
        public string? Nombre { get; set; }
        [Required(ErrorMessage = "El correo es obligatorio")]
        [EmailAddress(ErrorMessage = "Debe ser un correo válido")]
        [StringLength(100, ErrorMessage = "Máximo 100 caracteres")]
        public string? Correo { get; set; }
        [Required(ErrorMessage = "El teléfono es requerido")]
        [StringLength(10, ErrorMessage = "Máximo 10 caracteres")]
        public string? Telefono { get; set; }
        [Required(ErrorMessage = "La dirección es requerido")]
        [StringLength(100, ErrorMessage = "Máximo 100 caracteres")]
        public string? Dirección { get; set; }
        [Required(ErrorMessage = "La ciudad es requerido")]
        [StringLength(100, ErrorMessage = "Máximo 100 caracteres")]
        public string? Ciudad {  get; set; }

        //propiedad de navegacion de EntFrame
        [Range(1, int.MaxValue, ErrorMessage ="Debe seleccionar clasificación")]

        public int AutomovilId {  get; set; }

        virtual public Automovil? Automovil { get; set; }

    }
}