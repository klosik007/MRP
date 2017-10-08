using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MRP.Controllers
{
    public class ReservationsController : Controller
    {
        // GET: Reservations
        public ViewResult Reservations()
        {
            return View();
        }
    }
}