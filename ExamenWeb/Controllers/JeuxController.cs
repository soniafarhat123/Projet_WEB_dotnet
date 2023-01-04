using Domain;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Services;

namespace ExamenWeb.Controllers
{
    public class JeuxController : Controller
    {
        readonly IJeuxService jeuxService;
        public JeuxController(IJeuxService jS)
        {
            jeuxService = jS;

        }



        // GET: JeuxController
        public ActionResult Index()
        {
            return View(jeuxService.GetMany());
        }

        // GET: JeuxController/Details/5
        public ActionResult Details(int id)
        {
            return View(jeuxService.GetById(id));
        }

        // GET: JeuxController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: JeuxController/Create
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

        // GET: JeuxController/Edit/5
        public ActionResult Edit(int id)
        {
            return View(jeuxService.GetById(id));
        }

        // POST: JeuxController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Jeux collection)
        {
            try
            {
                jeuxService.Update(collection);
                jeuxService.Commit();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: JeuxController/Delete/5
        public ActionResult Delete(int id)
        {
            return View(jeuxService.GetById(id));
        }

        // POST: JeuxController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Jeux collection)
        {
            try
            {
                jeuxService.Delete(jeuxService.GetById(id));
                jeuxService.Commit();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
