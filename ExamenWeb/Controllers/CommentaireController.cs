using Domain;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Services;

namespace ExamenWeb.Controllers
{
    public class CommentaireController : Controller
    {
        private readonly ICommentaireService commentaireService;

        public CommentaireController(ICommentaireService cs)
        {
            commentaireService = cs;
        }



        // GET: CommentaireController
        public ActionResult Index()
        {
            return View(commentaireService.GetMany());
        }

        // GET: CommentaireController/Details/5
        public ActionResult Details(int id)
        {
            return View(commentaireService.GetById(id));
        }

        // GET: CommentaireController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CommentaireController/Create
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

        // GET: CommentaireController/Edit/5
        public ActionResult Edit(int id)
        {
            return View(commentaireService.GetById(id));
        }

        // POST: CommentaireController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Commentaire collection)
        {
            try
            {
                commentaireService.Update(collection);
                commentaireService.Commit();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CommentaireController/Delete/5
        public ActionResult Delete(int id)
        {
            return View(commentaireService.GetById(id));
        }

        // POST: CommentaireController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Commentaire collection)
        {
            try
            {
                commentaireService.Delete(commentaireService.GetById(id));
                commentaireService.Commit();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
