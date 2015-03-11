using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Bipa.Helper;

namespace Bipa.SearchModels
{
    public class ApplicationSearchModel:Paging
    {
        public string Name { get; set; }
        public string Reg_no { get; set; }
        public string App_no { get; set; }
    }
}