using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MRP.Domain.DomainModels;
using MRP.Domain.Interfaces;


namespace MRP.Domain.DBConnection
{
    public class EFRooms : IRoomsRepo
    {
        //pobieranie danych o pokojach z bazy danych
        private EFDbContext context = new EFDbContext();

        public IEnumerable<Rooms> Rooms
        {
            get { return context.Rooms; }
        }

        public void SaveRoom(Rooms room)
        {
            if (room.RoomID == 0)
            {
                context.Rooms.Add(room);
            }
            else
            {
                Rooms dbEntry = context.Rooms.Find(room.RoomID);
                if (dbEntry != null)
                {
                    dbEntry.RoomNum = room.RoomNum;
                    dbEntry.RoomMaxCapacity = room.RoomMaxCapacity;
                    dbEntry.Price = room.Price;
                    dbEntry.IsFree = room.IsFree;
                    dbEntry.Floor = room.Floor;
                }
            }
            context.SaveChanges();
        }

        public Rooms DeleteRm(int roomID)
        {
            Rooms dbEntry = context.Rooms.Find(roomID);
            if (dbEntry != null)
            {
                context.Rooms.Remove(dbEntry);
                context.SaveChanges();
            }
            return dbEntry;
        }
    }
}
