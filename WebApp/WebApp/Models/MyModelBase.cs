using System.Collections;
using System.Collections.Generic;
using System.Web.Mvc;

namespace WebApp.Models
{
    public class MyModelBase
    {
        public string text { get { return "ala ma kota_  "; } set{} }

        public int number { get; set; }

        public string innyText { get; set; }

        public string DrooopString { get; set; }

        public IEnumerable<SelectListItem> DropList = new List<SelectListItem>()
        {
            new SelectListItem(){Text = "Text",Value = "Value"},
            new SelectListItem(){Text = "ala",Value = "kot"},
            new SelectListItem(){Text = "cosT",Value = "cosV"},
            new SelectListItem(){Text = "Sito",Value = "net"},
        };
    }
}