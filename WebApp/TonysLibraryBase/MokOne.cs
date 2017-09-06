using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web.Mvc;

namespace TonysLibraryBase
{
    public class MokOne : IEnumerable
    {
        public IEnumerable<SelectListItem> DepList = new List<SelectListItem>()
        {
            new SelectListItem(){Text = "one",Value = "ONE"},
            new SelectListItem(){Text = "two",Value = "TWO"},
            new SelectListItem(){Text = "three",Value = "THREE"},
            new SelectListItem(){Text = "four",Value = "FOUR "},
        };

        public IEnumerable<SelectListItem> makeDepList()
        {
            return DepList;
        }

        public IEnumerator GetEnumerator()
        {
            throw new System.NotImplementedException();
        }
    }
}