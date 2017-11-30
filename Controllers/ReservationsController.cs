using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MRP.Domain.DomainModels;
using MRP.Domain.Interfaces;
using MRP.Domain.DBConnection;

namespace MRP.Controllers
{
    public class ReservationsController : Controller
    {
        private IReservationsRepo repo;
        private IRoomsRepo rrepo;

        public ReservationsController(IReservationsRepo Repo, IRoomsRepo RRepo)
        {
            repo = Repo;
            rrepo = RRepo;
        }
        
        public ViewResult Index(DateTime arrival, DateTime departure, 
            string RoomNum, int NumOfAdults, int NumOfKids)
        {
            return View();
        }

        [HttpPost]
        public ActionResult MakeReservation(string Name, DateTime arrival, DateTime departure,
            string RoomNum, int NumOfAdults, int NumOfKids)
        {
            DateTime arr = Convert.ToDateTime(Request["arrival"].ToString());
            DateTime dep = Convert.ToDateTime(Request["departure"].ToString());
            // int rooms_num = Convert.ToInt32(Request["rooms_num"].ToString());
            string rN = Convert.ToString(Request["roomnum"]);
            int a_m = Convert.ToInt32(Request["adults_num"].ToString());
            int k_m = Convert.ToInt32(Request["kids_num"].ToString());
            int price; 

            return View();
        }
    }
}