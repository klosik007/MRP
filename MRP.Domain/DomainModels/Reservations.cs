using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MRP.Domain.DomainModels;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MRP.Domain.DomainModels
{   
    [Table("Reservations")]
   public class Reservations
    {
        [Key]
        [Display(Name ="Numer rezerwacji")]
        public int ReservationID { get; set; }
        [Display(Name="Nazwisko")]
        public string Name { get; set; }
        [Display(Name ="Pokój")]
        public string RoomNum { get; set; }
        [Display(Name ="Zameldowanie")]
        public DateTime Arrival { get; set; }
        [Display(Name ="Wymeldowanie")]
        public DateTime Departure { get; set; }
        [Display(Name ="Ilość osób")]
        public int NumOfPeople { get; set; }

        
    }
}
