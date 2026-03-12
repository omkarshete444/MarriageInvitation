using MarriageInvitation.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MarriageInvitation.Controllers
{
    public class InvitationController : Controller
    {
        // GET: InvitationController
        public ActionResult Index()
        {
            var model = new Invitation
            {
                GroomName = "Ganesh",
                BrideName = "Nikita",
                InvitationMessage = "YOU ARE INVITED TO THE WEDDING OF",
                Date = "02 December 2025",
                Time = "12:16 PM | Followed by Lunch",
                Venue = "Jagdishshri Lawns & Hall, Konark Nagar, Bijapur Road, Solapur",
                PhotoPath = "/images/invit.jpeg"  // The image you uploaded
            };

            return View(model);
        }

        // GET: InvitationController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: InvitationController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: InvitationController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: InvitationController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: InvitationController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: InvitationController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: InvitationController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
