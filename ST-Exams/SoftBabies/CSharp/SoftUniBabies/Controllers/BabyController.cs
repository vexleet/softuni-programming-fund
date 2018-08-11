namespace SoftUniBabies.Controllers
{
    using Models;
    using Microsoft.AspNetCore.Mvc;
    using System.Collections.Generic;
    using System.Linq;

    public class BabyController : Controller
    {
        private readonly BabyDbContext dbContext;

        public BabyController(BabyDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        [HttpGet]
        [Route("")]
        public IActionResult Index()
        {
            using(var db = new BabyDbContext())
            {
                var babies = db.Babies.ToList();

                return View(babies);
            }
        }

        [HttpGet]
        [Route("/create")]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [Route("/create")]
        public IActionResult Create(Baby baby)
        {
            using (var db = new BabyDbContext())
            {
                db.Babies.Add(baby);
                db.SaveChanges();
            }

            return RedirectToAction("Index", "Baby");
        }

        [HttpGet]
        [Route("/edit/{id}")]
        public IActionResult Edit(int id)
        {
            if(id == null)
            {
                return RedirectToAction("Index", "Baby");
            }

            using (var db = new BabyDbContext())
            {
                var baby = db.Babies.Find(id);

                if(baby == null)
                {
                    return RedirectToAction("Index", "Baby");
                }

                return View(baby);
            }
        }

        [HttpPost]
        [Route("/edit/{id}")]
        public IActionResult Edit(Baby baby)
        {
            using (var db = new BabyDbContext())
            {
                db.Babies.Update(baby);
                db.SaveChanges();
            }

            return RedirectToAction("Index", "Baby");
        }

        [HttpGet]
        [Route("/delete/{id}")]
        public IActionResult Delete(int id)
        {
            if(id == null)
            {
                return RedirectToAction("Index", "Baby");
            }

            using(var db = new BabyDbContext())
            {
                var baby = db.Babies.Find(id);

                if(baby == null)
                {
                    return RedirectToAction("Index", "Baby");
                }

                return View(baby);
            }
        }

        [HttpPost]
        [Route("/delete/{id}")]
        public IActionResult Delete(Baby baby)
        {
            using (var db = new BabyDbContext())
            {
                db.Babies.Remove(baby);
                db.SaveChanges();
            }

            return RedirectToAction("Index", "Baby");
        }
    }
}
