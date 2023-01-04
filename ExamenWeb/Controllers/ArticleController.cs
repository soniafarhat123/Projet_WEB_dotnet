using Domain;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Services;

namespace ExamenWeb.Controllers
{
    public class ArticleController : Controller
    {
        private readonly IArticleService ias;
        private readonly IJeuxService ijs;
        public ArticleController(IArticleService ias, IJeuxService ijs)
        {
            this.ias = ias;
            this.ijs = ijs;
        }
        // GET: ArticleController
        public ActionResult Index()
        {
            var articles = ias.GetMany();
            return View(articles);
        }
        // POST: ArticleController
        [HttpPost]
        public ActionResult Index(string SearchString)
        {
            var articles = ias.GetMany();
            if (SearchString != null)
            {
                articles = ias.GetMany(a => a.Titre.Contains(SearchString));
            }
            return View(articles);

        }

        // GET: ArticleController/Details/5
        public ActionResult Details(int id)
        {
            return View(ias.Get(a => a.Id == id));
        }

        // GET: ArticleController/Create
        public ActionResult Create()
        {
            var mygames = ijs.GetMany();
            ViewBag.JeuxList = new SelectList(mygames, "IdJeux", "Nom");
            return View();
        }

        // POST: ArticleController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Article collection)
        {
            ias.Add(collection);
            ias.Commit();

            return RedirectToAction(nameof(Index));
        }

        // GET: ArticleController/Edit/5
        public ActionResult Edit(int id)
        {
            return View(ias.Get(a => a.Id == id));
        }

        // POST: ArticleController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Article collection)
        {
            try
            {
                ias.Update(collection);
                ias.Commit();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ArticleController/Delete/5
        public ActionResult Delete(int id)
        {
            return View(ias.Get(a => a.Id == id));
        }

        // POST: ArticleController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Article collection)
        {
            try
            {
                ias.Delete(collection);
                ias.Commit();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
