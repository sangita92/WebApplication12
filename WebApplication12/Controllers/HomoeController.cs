using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication12.Controllers
{
    public class HomoeController : Controller
    {
        // GET: HomoeController
        public ActionResult Index()
        {
            return View();
        }

        // GET: HomoeController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: HomoeController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: HomoeController/Create
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

        // GET: HomoeController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: HomoeController/Edit/5
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

        // GET: HomoeController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: HomoeController/Delete/5
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
