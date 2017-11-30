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
        [Display(Name ="Zameldowanie")]
        public DateTime Arrival { get; set; }
        [Display(Name ="Wymeldowanie")]
        public DateTime Departure { get; set; }
        [Display(Name ="Ilość osób dorosłych")]
        public int NumOfAdults { get; set; }
        [Display(Name ="Ilość dzieci")]
        public int NumOfKids { get; set; }  
        [Display(Name ="Cena całkowita")]
        public int TotalPrice { get; set; }


       // public int RoomsRefId { get; set; }

        [ForeignKey("RoomID")]
        [Display(Name = "Pokój")]
        public int RoomID { get; set; }
        public virtual Rooms Room { get; set; }

        /*public int CalculateTotalPrice()
        { 
            return ((NumOfAdults * Room.Price) + (NumOfKids * Room.Price / 2));
        }*/
    }
}
