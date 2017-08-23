using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Euro_Africa.Models;

namespace Euro_Africa.Controllers
{
    public class CollaboratorController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: /Collaborator/
        [Authorize]
        public ActionResult Index()
        {
            return View(db.Collaborators.ToList());
        }
        public ActionResult ListColl()
        {
            return View(db.Collaborators.ToList());
        }


        // GET: /Collaborator/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Collaborator collaborator = db.Collaborators.Find(id);
            if (collaborator == null)
            {
                return HttpNotFound();
            }
            return View(collaborator);
        }

        // GET: /Collaborator/Create
        [Authorize]
        public ActionResult Create()
        {
            return View();
        }

        // POST: /Collaborator/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [Authorize]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include="Collaborator_Id,Name,Logo,Description")] Collaborator collaborator,HttpPostedFileBase file)
        {
            if (ModelState.IsValid)
            {
                if (file != null)
                {
                    string pic = System.IO.Path.GetFileName(file.FileName);
                    string path = System.IO.Path.Combine(Server.MapPath("~/Uploads"), pic);
                    file.SaveAs(path);
                    collaborator.Logo = file.FileName;
                }
                db.Collaborators.Add(collaborator);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(collaborator);
        }

        // GET: /Collaborator/Edit/5
        [Authorize]
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Collaborator collaborator = db.Collaborators.Find(id);
            if (collaborator == null)
            {
                return HttpNotFound();
            }
            return View(collaborator);
        }

        // POST: /Collaborator/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [Authorize]
        [HttpPost]

        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include="Collaborator_Id,Name,Logo,Description")] Collaborator collaborator,HttpPostedFileBase file)
        {
            if (ModelState.IsValid)
            {
            
                if (file != null)
                {
                    string pic = System.IO.Path.GetFileName(file.FileName);
                    string path = System.IO.Path.Combine(Server.MapPath("~/Uploads"), pic);
                    file.SaveAs(path);
                    collaborator.Logo = file.FileName;
                }
                db.Entry(collaborator).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(collaborator);
        }

        // GET: /Collaborator/Delete/5
        [Authorize]
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Collaborator collaborator = db.Collaborators.Find(id);
            if (collaborator == null)
            {
                return HttpNotFound();
            }
            return View(collaborator);
        }

        // POST: /Collaborator/Delete/5
        [Authorize]
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Collaborator collaborator = db.Collaborators.Find(id);
            db.Collaborators.Remove(collaborator);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
