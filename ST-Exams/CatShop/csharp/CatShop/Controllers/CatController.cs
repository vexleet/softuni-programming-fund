namespace CatShop.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using CatShop.Models;
    using System.Linq;

    public class CatController : Controller
    {
        private readonly CatDbContext context;

        public CatController(CatDbContext context)
        {
            this.context = context;
        }

        [HttpGet]
        [Route("")]
        public ActionResult Index()
        {
            using(var db = new CatDbContext())
            {
                var tasks = db.Cats.ToList();

                return View(tasks);
            }
        }

        [HttpGet]
        [Route("create")]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [Route("create")]
        public ActionResult Create(Cat cat)
        {
            if(cat.Nickname == null || cat.Name == null || cat.Price == 0)
            {
                return RedirectToAction("Create", "Cat");
            }
            
            using (var db = new CatDbContext())
            {
                db.Cats.Add(cat);
                db.SaveChanges();
            }

            return RedirectToAction("Index", "Cat");
        }

        [HttpGet]
        [Route("edit/{id}")]
        public ActionResult Edit(int id)
        {
            if(id == null)
            {
                return RedirectToAction("Index", "Cat");
            }

            using(var db = new CatDbContext())
            {
                var cat = db.Cats.Find(id);

                if(cat == null)
                {
                    return RedirectToAction("Index", "Cat");
                }

                return View(cat);
            }
        }

        [HttpPost]
        [Route("edit/{id}")]
        [ValidateAntiForgeryToken]
        public ActionResult EditConfirm(int id, Cat catModel)
        {
            if(id == null)
            {
                return RedirectToAction("Index", "Cat");
            }

            using(var db = new CatDbContext())
            {
                db.Cats.Update(catModel);
                db.SaveChanges();
            }

            return RedirectToAction("Index", "Cat");
        }

        [HttpGet]
        [Route("delete/{id}")]
        public ActionResult Delete(int id)
        {
            if(id == null)
            {
                return RedirectToAction("Index", "Cat");
            }

            using(var db = new CatDbContext())
            {
                var cat = db.Cats.Find(id);

                if(cat == null)
                {
                    return RedirectToAction("Index", "Cat");
                }

                return View(cat);
            }
        }

        [HttpPost]
        [Route("delete/{id}")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirm(int id, Cat catModel)
        {
            if(id == null)
            {
                return RedirectToAction("Index", "Cat");
            }

            using (var db = new CatDbContext())
            {           
                db.Cats.Remove(catModel);
                db.SaveChanges();
            }

            return RedirectToAction("Index", "Cat");
        }
    }
}
