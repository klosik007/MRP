using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MRP.Domain.DomainModels;
using MRP.Domain.Interfaces;
using MRP.Domain.DBConnection;
using System.Text;

namespace MRP.Controllers
{
    public class RoomsController : Controller
    {
        // GET: Home
        private IRoomsRepo repo;
        private IReservationsRepo repores;

        public RoomsController(IRoomsRepo Repo/*, IReservationsRepo repoRes*/)
        {
            repo = Repo;
           // repores = repoRes;
        }

        public ViewResult Rooms()
        {
            return View(repo.Rooms);
        }

        public ActionResult Reservation()
        {
           /* EFDbContext context = new EFDbContext();
            var getRoomList = context.Rooms.ToList();
            SelectList list = new SelectList(getRoomList, "RoomID", "RoomNum");
            ViewBag.roomlist = list;*/
            return View();           
        }

        public PartialViewResult ShowAvailableRooms(DateTime arrival, DateTime departure, 
            int adults_num, int kids_num)
        {
           /* EFDbContext context = new EFDbContext();
            var getRoomList = context.Rooms.ToList();*/
           IEnumerable<Rooms> data = repo.Rooms;
           // IEnumerable<Reservations> data2 = repores.Reservations;
            
              data = repo.Rooms.Where(x => x.RoomMaxCapacity >= adults_num + kids_num)
                               .Where(x => x.IsFree == true)
                               .OrderBy(x => x.RoomMaxCapacity);
           // data2 = repores.Reservations.Where(x => x.Departure <= arrival)
             //                           .Where(x => x.Room.RoomMaxCapacity >= adults_num + kids_num)
               //                         ;
            
            
            /*DateTime arr = Convert.ToDateTime(Request["arrival"].ToString());
            DateTime dep = Convert.ToDateTime(Request["departure"].ToString());
         // int rooms_num = Convert.ToInt32(Request["rooms_num"].ToString());
            int a_m = Convert.ToInt32(Request["adults_num"].ToString());
            int k_m = Convert.ToInt32(Request["kids_num"].ToString());*/

           /* var getRoomList = context.Rooms.ToList()
                .Where(x => x.RoomMaxCapacity >= adults_num + kids_num)
                .Where(x => x.IsFree == true)
                .OrderBy(x => x.RoomMaxCapacity)
                ;*/  
            return PartialView(data);
        }


    }
}

/*          <li>
                    @Html.Label("Wybierz pokój:") 
                    @Html.DropDownList("RoomList", ViewBag.roomlist as SelectList, "Wybierz pokój")

                </li>

       <script>
        document.getElementById('check').onclick = function (event) {
            var Arrival = document.getElementsByName("arrival").item(0).value;
            var Departure = document.getElementsByName("departure").item(0).value;

            var ArrivalDate = new Date(Arrival);
            var DepartureDate = new Date(Departure);

            var Duration = (DepartureDate.getTime() - ArrivalDate.getTime()) / (1000 * 24 * 3600);

            document.writeln("Czas trwania: " + Duration + "</br>");

        }
    </script>
    
      @using (Ajax.BeginForm("CalculatePayment", "Rooms", new AjaxOptions { UpdateTargetId = "price" }))
            {*/
