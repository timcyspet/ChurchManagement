using Com.Npo.BaseProject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.npo.business.model.Base
{

    public class Attribute : BaseObject
    {
        public AttributeKey? AttributeKey { get; set; }
        public string? Value { get; set; }
    }

    public class AttributeKey : BaseObject
    {
        public string? Key { get; set; }
        public string? Code { get; set; }
        public AttributeType AttributeType { get; set; }
        public string? ValueType { get; set; }
    }

    public class AttributeType : BaseObject
    {
        public string? Name { get; set; }
        public string? Code { get; set; }

    }

}
