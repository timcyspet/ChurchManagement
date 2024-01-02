using Com.Npo.BaseProject.Interface;

namespace Com.Npo.BaseProject
{
    public abstract class BaseObject : IBaseObject
    {
        
        public long Id { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string? ModifiedBy { get; set; }
        public DateTime ModifiedOn { get; set; }
        public bool IsDeleted { get; set; }
        public bool IsActive { get; set; }
    }
}