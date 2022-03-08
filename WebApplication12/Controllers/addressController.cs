using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication12.Controllers
{
    public class addressController : Controller
    {
        // GET: addressController
        public ActionResult Index()
        {
            return View();
        }

        // GET: addressController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: addressController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: addressController/Create
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

        // GET: addressController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: addressController/Edit/5
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

        // GET: addressController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: addressController/Delete/5
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
