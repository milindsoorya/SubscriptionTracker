using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SubscriptionTracker.Models;

namespace SubscriptionTracker.Controllers
{
    public class SubTrackerController : Controller
    {
        SubTrackerContext db = new SubTrackerContext();
        // GET: SubTracker
        public ActionResult Index()
        {
            db.UsersTable.ToList();
            db.ServicesTable.ToList();
            return View();
        }
    }
}