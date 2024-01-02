using Com.Npo.BaseProject;
using com.npo.business.model.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.npo.business.model.Contact
{
    public class Contact :BaseObject
    {
        public Person? Person { get; set; }
        public string? Email { get; set; }
        public string? PhoneNumber { get; set; }
        public Address? CommunicationAddress { get; set; }
        public Address? PermanentAddress { get; set; }
        public Dictionary<string, string>? ExternalReferance { get; set; }
    }

    public class Address : BaseObject
    {
        public string? StreetName { get; set; }
        public City? City { get; set; }
        public string? PostalCode { get; set; }
        
    }



}
