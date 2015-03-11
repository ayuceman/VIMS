using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Bipa.Helper;

namespace Bipa.SearchModels
{
    public class StudentSearchModel:Paging
    {
        public string Name { get; set; }
        public string sid { get; set; }
    }
}