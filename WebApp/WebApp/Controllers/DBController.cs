using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TonysLibraryBase;
using WebApp.Models;

namespace WebApp.Controllers
{
    public class DBController : Controller
    {
        // GET: DB
        public ActionResult DBView(DBclass clas)
        {

            if (Session["ja"] != null)
            {
                clas = (DBclass) Session["ja"];
            }

            return View(clas);
        }

        
        public ActionResult SaveIT(DBclass clas)
        {

            // save it
            Session.Add("ja", clas);


            return Redirect("/DB/DBView");
        }

    }
}