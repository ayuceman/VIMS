using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Bipa.Helper;

namespace Bipa.SearchModels
{
    public class TeacherSearchModel:Paging
    {
        public string Name { get; set; }
        public string tid { get; set; }
        
    }
}