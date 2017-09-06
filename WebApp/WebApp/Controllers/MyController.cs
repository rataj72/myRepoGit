using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Helpers;
using System.Web.Mvc;
using TonysLibraryBase;
using WebApp.Models;

namespace WebApp.Controllers
{
    public class MyController : Controller
    {
        // GET: My
        public ActionResult MyView(MyModelBase model)
        {
            MokOne mok = new MokOne();
            IEnumerable<SelectListItem> lista = mok.makeDepList();

            model.DropList = lista;

            return View(model);
        }

        public ActionResult BigView(MyModelBase model)
        {
            MokOne mok = new MokOne();
            IEnumerable<SelectListItem> lista = mok.makeDepList();

            model.DropList = lista;

            return View(model);
        }

        public ActionResult TonyJson()
        {
            return  Redirect("https://www.facebook.com/") ;
        }
    }
}