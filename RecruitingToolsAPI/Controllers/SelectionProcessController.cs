using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace RecruitingToolsAPI.Controllers
{
    public class SelectionProcessController : Controller
    {
        // GET: SelectionProcessController
        public ActionResult Index()
        {
            return View();
        }

        // GET: SelectionProcessController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: SelectionProcessController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SelectionProcessController/Create
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

        // GET: SelectionProcessController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: SelectionProcessController/Edit/5
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

        // GET: SelectionProcessController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: SelectionProcessController/Delete/5
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
