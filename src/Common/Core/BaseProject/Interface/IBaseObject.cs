using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Com.Npo.BaseProject.Interface
{
    internal interface IBaseObject
    {
        long Id { get; set; }
        string? CreatedBy { get; set; }
        DateTime CreatedOn { get; set; }
        string? ModifiedBy { get; set; }
        DateTime ModifiedOn { get; set; }
        bool IsDeleted { get; set; }
        bool IsActive { get; set; }
    }
}
