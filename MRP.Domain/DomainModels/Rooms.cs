using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace MRP.Domain.DomainModels
{
   [Table("Rooms")]
    public class Rooms
    {
        [Key]
        [HiddenInput(DisplayValue = false)]
        public int RoomID { get; set; }

        [Display(Name ="Numer pokoju")]
        public string RoomNum { get; set; }

        [Display(Name = "Maksymalna ilość osób w pokoju")]
        public int RoomMaxCapacity { get; set; }

        [Display(Name = "Wolny?")]
        public bool IsFree { get; set; }

        [Display(Name = "Cena")]
        public int Price { get; set; }

        [Display(Name = "Piętro")]
        public int Floor { get; set; }

       
       //public virtual Reservations Reservations { get; set; }
    }
}
