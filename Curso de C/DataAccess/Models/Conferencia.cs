using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Curso_de_C.DataAccess.Models
{
    public class Conferencia
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public string Nombre { get; set; }

        public string Compania { get; set; }

        public string Telefono { get; set; }

        public string Email { get; set; }

        public string Direccion { get; set; }

        public string Calles { get; set; }

        public string Ciudad { get; set; }

        public string Region { get; set; }

        public string Codigo { get; set; }

        public string Pais { get; set; }

        public string TituloConferencia { get; set; }

        public string Participacion { get; set; }
    }
}
