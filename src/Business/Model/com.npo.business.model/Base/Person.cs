using Com.Npo.BaseProject;

namespace com.npo.business.model
{
    public class Person : BaseObject
    {
        public DateTime DateOfBirth { get; set; }
        public string? FirstName { get; set; }
        public string? MiddleName { get; set; }
        public string? LastName { get; set; }
        public string? Gender { get; set; }

    }
    public class PersonAttribute : BaseObject
    {
        public Person? Person { get; set; }
        public Base.Attribute? Attribute { get; set; }
    }


}