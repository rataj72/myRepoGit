using System.Collections.Generic;
using System.Web.Mvc;
using TonysLibraryBase;

namespace WebApp.Models
{
    public class DBclass
    {
        public int number { get ; set; }

        
        public IEnumerable<SelectListItem> DropList = new List<SelectListItem>()
        {
            new SelectListItem(){Text = "tabONE" ,Value = new DBitems().itemOne.ToString()},
            new SelectListItem(){Text = "ala",Value = "kot"},
            new SelectListItem(){Text = "cosT",Value = "cosV"},
            new SelectListItem(){Text = "Sito",Value = "net"},
        };
    }
}