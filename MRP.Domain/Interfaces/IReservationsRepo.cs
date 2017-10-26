using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MRP.Domain.DomainModels;

namespace MRP.Domain.Interfaces
{
    public interface IReservationsRepo
    {
        IEnumerable<Reservations> Reservations { get; }

    }
}
