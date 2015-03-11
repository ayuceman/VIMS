using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Bipa.Helper
{
    public class Paging
    {
        public int? page { get { return _pg ?? 1; } set { _pg = value; } }
        public int? size { get { return _size ?? 20; } set { _size = value; } }

        protected int? _pg;
        protected int? _size;
    }
}