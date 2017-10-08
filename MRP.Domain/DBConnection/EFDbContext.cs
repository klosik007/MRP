using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MRP.Domain.DomainModels;
using System.Data.Entity;

namespace MRP.Domain.DBConnection//klasa kontekstu
{                                //skojarzenie modelu z bazą danych
    public class EFDbContext : DbContext
    {
        public DbSet<Rooms> Rooms { get; set; }
        //public DbSet<Reservations> Reservations {get; set;}
    }
}
