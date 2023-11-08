using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TelmaBolossite.Controllers
{
    public class BoloFestaController : Controller
    {
        // GET: BoloFestaController
        public ActionResult Index()
        {
            return View();
        }

        // GET: BoloFestaController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: BoloFestaController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: BoloFestaController/Create
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

        // GET: BoloFestaController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: BoloFestaController/Edit/5
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

        // GET: BoloFestaController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: BoloFestaController/Delete/5
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
