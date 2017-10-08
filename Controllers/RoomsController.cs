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
        public RoomsController(IRoomsRepo Repo)
        {
            repo = Repo;
        }
        public ViewResult Rooms()
        {
            return View(repo.Rooms);
        }

       
        public ActionResult Reservation()
        {
            EFDbContext context = new EFDbContext();
            var getRoomList = context.Rooms.ToList();
            SelectList list = new SelectList(getRoomList, "RoomID", "RoomNum");
            ViewBag.roomlist = list;
            return View();           
        }

        [HttpPost]
        public ActionResult CalculatePayment()
        {
            EFDbContext context = new EFDbContext();
            var getRoomList = context.Rooms.ToList();

            DateTime arrival = Convert.ToDateTime(Request["arrival"].ToString());
            DateTime departure = Convert.ToDateTime(Request["departure"].ToString());
            int duration = Convert.ToInt32(departure.Subtract(arrival));
            int roomprice = 
            int capacity = 

            int cost = duration * roomprice * capacity;

            StringBuilder sbInterest = new StringBuilder();
            sbInterest.Append("<b>Amount :</b> " + principle + "<br/>");
            sbInterest.Append("<b>Rate :</b> " + rate + "<br/>");
            sbInterest.Append("<b>Time(year) :</b> " + time + "<br/>");
            sbInterest.Append("<b>Interest :</b> " + simpleInteresrt);
            return Content(sbInterest.ToString());
        }
    }
}