using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Prueba_Colcan.Models
{
    public class Paciente
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public required string TipoDocumento { get; set; }
        public required int NumeroDocumento { get; set; }
        public required string Nombre {  get; set; }
        public DateTime FechaNacimiento { get; set; }
        public required string Email { get; set; }
        public string? Genero {  get; set; }
        public string? Direccion { get; set; }
        public int? NumeroTelefono { get; set; }
        public bool Activo { get; set; }

    }
}
