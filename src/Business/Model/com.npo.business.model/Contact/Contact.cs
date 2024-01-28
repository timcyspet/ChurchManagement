using Com.Npo.BaseProject;
using com.npo.business.model.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using com.npo.business.model.Association;

namespace com.npo.business.model.Contact
{
    public class Contact :BaseObject
    {
        public Person? Person { get; set; }
        public string? Email { get; set; }
        public string? PhoneNumber { get; set; }
        public Address? CommunicationAddress { get; set; }
        public Address? PermanentAddress { get; set; }
    }

    public class Address : TemporalBaseObject
    {
        public string? StreetName { get; set; }
        public City? City { get; set; }
        public string? PostalCode { get; set; }
        
    }

    public class ContactAttribute : BaseObject
    {
        public Contact? Contact { get; set; }
        public Base.Attribute? Attribute { get; set; }
    }



}
