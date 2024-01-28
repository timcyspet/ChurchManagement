using Com.Npo.BaseProject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.npo.business.model.Association
{
    public class MemberShip: TemporalBaseObject
    {
        public List<Member>? Members { get; set; }
        public MemberShipType? MemberShipType { get; set; }
    }


    public class MemberShipType : TemporalBaseObject
    {
        public string? Name { get; set; }
        public string? Code { get; set; }
    }

    public class Member : BaseObject { 

        public Person? Person { get; set; }
        public MemberType? MemberType { get; set; }
    
    }

    public class MemberType: TemporalBaseObject
    { 
        public string? Name { get; set;}
        public string? Code { get; set;}
    }

    public class MemberShipAttribute: BaseObject
    {
        public MemberShip? MemberShip { get; set; }
        public Base.Attribute? Attribute { get; set; }
    }


}
