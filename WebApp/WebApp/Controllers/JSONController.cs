using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApp.Controllers
{
    public class JSONController : Controller
    {
        // GET: JSON
        public ActionResult JsonView()
        {
            var json = new JsonResult();
            //json.Data = new {chmura = "bzdury", sito = "inne bardzo wielkie      bzdury"};  => zle
            json.JsonRequestBehavior = JsonRequestBehavior.AllowGet;


            json.Data = new Dictionary<string,string>()
            {
                {"ala","kota" },
                {"ola","psa" },
                {"viola","kota" },
                {"tola","kota" }
            };


            return json;
        }
    }
}