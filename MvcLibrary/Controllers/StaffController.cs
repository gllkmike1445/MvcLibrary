﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcLibrary.Models.Entity;
namespace MvcLibrary.Controllers
{
    public class StaffController : Controller
    {
        DBLIBRARYEntities1 db = new DBLIBRARYEntities1 ();

        // GET: Staff
        public ActionResult Index()
        {
            var values = db.TBLSTAFFs.ToList();
            return View(values);
        }

        [HttpGet]
        public ActionResult AddStaff()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddStaff(TBLSTAFF p)
        {
            if (!ModelState.IsValid)
            {
                return View("AddStaff");
            }
            db.TBLSTAFFs.Add(p);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult DeleteStaff(int id)
        {
            var staff = db.TBLSTAFFs.Find(id);
            db.TBLSTAFFs.Remove(staff);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult GetStaff(int id)
        {

            var staff = db.TBLSTAFFs.Find(id);
            return View("GetStaff", staff);
        }
        public ActionResult UpdateStaff(TBLSTAFF p)
        {
            var staff = db.TBLSTAFFs.Find(p.ID);
            staff.STAFF = p.STAFF;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}