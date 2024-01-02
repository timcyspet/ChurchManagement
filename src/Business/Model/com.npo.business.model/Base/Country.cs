using Com.Npo.BaseProject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.npo.business.model.Base
{
    public class Country : BaseObject
    {
        public string? Name { get; set; }
        public string? Code { get; set; }
    }

    public class Region : BaseObject
    {
        public string? Name { get; set; }
        public string? Code { get; set; }
        public Country? Country { get; set; }
    }

    public class City : BaseObject
    {
        public string? Name { get; set; }
        public string? Code { get; set; }
        public Region? Region { get; set; }
    }
}
