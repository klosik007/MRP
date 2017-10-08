using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MRP.Domain.DomainModels;

namespace MRP.Domain.DomainModels
{   
   public class Reservations
    {
        public Rooms Room { get; set; }
        public DateTime Arrival { get; set; }
        public DateTime Departure { get; set; }
       // public int NumOfPeople { get; set; }
        public int Duration { get; set; }
    }
}
