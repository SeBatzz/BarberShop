using System.ComponentModel.DataAnnotations;

namespace BarberShop.Web.Data.Entities
{
    public class Barber
    {
        [Key]
        public int Id { get; set; }


        [Display (Name = "Barber")]
        [Required(ErrorMessage = "Este campo '{0}' es obligatorio")]
        public string Name { get; set; }


        [Display (Name = "Descripcion")]
        public string? Description { get; set; }


        [Display(Name = "Calificacion")]
        [Required(ErrorMessage = "Este campo '{0}' es obligatorio")]
        public int Rating { get; set; }



        // ProfilePicture

        [Display(Name = "Disponibilidad Del Barbero")]
        [Required(ErrorMessage = "Este campo '{0}' es obligatorio")]
        public bool Availability { get; set; }



    }
}
