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

        public void SaveReservation(Reservations reservation)
        {
            if (reservation.ReservationID == 0)
            {
                context.Reservations.Add(reservation);
            }
            else
            {
                Reservations dbEntry = context.Reservations.Find(reservation.ReservationID);
                if (dbEntry != null)
                {
                    dbEntry.Name = reservation.Name;
                    dbEntry.RoomID = reservation.RoomID;
                    dbEntry.Arrival = reservation.Arrival;
                    dbEntry.Departure = reservation.Departure;
                    dbEntry.NumOfAdults = reservation.NumOfAdults;
                    dbEntry.NumOfKids = reservation.NumOfKids;
                    dbEntry.TotalPrice = reservation.TotalPrice;
                }
            }
            context.SaveChanges();
        }

        public Reservations DeleteReservation(int reservationID)
        {
            Reservations dbEntry = context.Reservations.Find(reservationID);
            if (dbEntry != null)
            {
                context.Reservations.Remove(dbEntry);
                context.SaveChanges();
            }
            return dbEntry;
        }
    }
}
