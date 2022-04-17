using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BVM.Controllers
{
    public class DashBoardController : Controller
    {
        // GET: DashBoard
        public ActionResult Overview()
        {
            return View();
        }
    }
}