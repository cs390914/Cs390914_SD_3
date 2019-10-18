using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Cs390914_SD_3.DAL.MIS4200Context;
using Cs390914_SD_3.Models;

namespace Cs390914_SD_3.Controllers
{
    public class WorkoutDetailsController : Controller
    {
        private MIS4200Context db = new MIS4200Context();

        // GET: WorkoutDetails
        public ActionResult Index()
        {
            var workoutDetails = db.WorkoutDetails.Include(w => w.Trainers).Include(w => w.Workout);
            return View(workoutDetails.ToList());
        }

        // GET: WorkoutDetails/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            WorkoutDetails workoutDetails = db.WorkoutDetails.Find(id);
            if (workoutDetails == null)
            {
                return HttpNotFound();
            }
            return View(workoutDetails);
        }

        // GET: WorkoutDetails/Create
        public ActionResult Create()
        {
            ViewBag.TrainerID = new SelectList(db.Trainers, "TrainerID", "FirstName");
            ViewBag.WorkoutID = new SelectList(db.Workouts, "WorkoutID", "TrainerName");
            return View();
        }

        // POST: WorkoutDetails/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "WorkoutDetailsID,WorkoutTitle,Duration,EquipmentUsed,WorkoutID,TrainerID")] WorkoutDetails workoutDetails)
        {
            if (ModelState.IsValid)
            {
                db.WorkoutDetails.Add(workoutDetails);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.TrainerID = new SelectList(db.Trainers, "TrainerID", "FirstName", workoutDetails.TrainerID);
            ViewBag.WorkoutID = new SelectList(db.Workouts, "WorkoutID", "TrainerName", workoutDetails.WorkoutID);
            return View(workoutDetails);
        }

        // GET: WorkoutDetails/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            WorkoutDetails workoutDetails = db.WorkoutDetails.Find(id);
            if (workoutDetails == null)
            {
                return HttpNotFound();
            }
            ViewBag.TrainerID = new SelectList(db.Trainers, "TrainerID", "FirstName", workoutDetails.TrainerID);
            ViewBag.WorkoutID = new SelectList(db.Workouts, "WorkoutID", "TrainerName", workoutDetails.WorkoutID);
            return View(workoutDetails);
        }

        // POST: WorkoutDetails/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "WorkoutDetailsID,WorkoutTitle,Duration,EquipmentUsed,WorkoutID,TrainerID")] WorkoutDetails workoutDetails)
        {
            if (ModelState.IsValid)
            {
                db.Entry(workoutDetails).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.TrainerID = new SelectList(db.Trainers, "TrainerID", "FirstName", workoutDetails.TrainerID);
            ViewBag.WorkoutID = new SelectList(db.Workouts, "WorkoutID", "TrainerName", workoutDetails.WorkoutID);
            return View(workoutDetails);
        }

        // GET: WorkoutDetails/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            WorkoutDetails workoutDetails = db.WorkoutDetails.Find(id);
            if (workoutDetails == null)
            {
                return HttpNotFound();
            }
            return View(workoutDetails);
        }

        // POST: WorkoutDetails/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            WorkoutDetails workoutDetails = db.WorkoutDetails.Find(id);
            db.WorkoutDetails.Remove(workoutDetails);
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
