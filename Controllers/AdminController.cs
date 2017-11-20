using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MRP.Domain.DomainModels;
using MRP.Domain.Interfaces;

namespace MRP.Controllers
{
    public class AdminController : Controller
    {
        private IRoomsRepo repo;
        private IReservationsRepo repoRes;
        public AdminController(IRoomsRepo Repo, IReservationsRepo RepoRes)
        {
            repo = Repo;
            repoRes = RepoRes;
        }
        // /Admin/Index
        public ViewResult Index()
        {
            return View();
        }
        // /Admin/Rooms
        public ViewResult Rooms()
        {
            return View(repo.Rooms);
        }
        // /Admin/ReservationsEdit
        public ViewResult ReservationsEdit()
        {
            return View(repoRes.Reservations);
        }
        // /Admin/RoomEdit
        public ViewResult RoomEdit(int roomID)
        {
            Rooms rooms = repo.Rooms
                .FirstOrDefault(r => r.RoomID == roomID);
            return View(rooms);
        }

        [HttpPost]
        public ActionResult RoomEdit(Rooms room)
        {
            if (ModelState.IsValid)
            {
                repo.SaveRoom(room);//zapisz pokój
                TempData["message"] = string.Format("Zapisano pokój numer {0}", room.RoomNum);//wyświetl komunikat
                return RedirectToAction("Index");//wróc do listy
            }
            else
            {
                return View(room);//jeżeli jakis blad w danych to zostań w widoku
            }
        }

        // Admin/CreateRoom
        public ViewResult CreateRoom()
        {
            return View("RoomEdit", new Rooms());
        }

        [HttpPost]
        public ActionResult RoomDelete(int roomID)
        {
            Rooms deletedRoom = repo.DeleteRm(roomID);
            
            if (deletedRoom != null)
            {
                TempData["message"] = string.Format("Usunięto pokój numer {0}", deletedRoom.RoomNum);
            }
            return RedirectToAction("Index");
        }

        
    }
}