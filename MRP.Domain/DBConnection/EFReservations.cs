using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MRP.Domain.Interfaces;
using MRP.Domain.DomainModels;

namespace MRP.Domain.DBConnection
{
   public class EFReservations : IReservationsRepo 
    {
        EFDbContext context = new EFDbContext();

        public IEnumerable<Reservations> Reservations
        {
            get { return context.Reservations; }
        }
    }
}
