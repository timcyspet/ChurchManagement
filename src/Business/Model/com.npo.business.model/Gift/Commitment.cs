using Com.Npo.BaseProject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.npo.business.model.Gift
{
    public class Commitment : TemporalBaseObject
    {
        public string? Name { get; set; }
        public string? Description { get; set; }
        public string? Code { get; set; }
        public CommitmentType? Type { get; set; }

    }

    public class CommitmentType : TemporalBaseObject
    {
        public string? Name { get; set; }
        public string? Code { get; set; }
        public bool IsMandatory { get; set; }
        public bool IsRecurring { get; set; }
        public bool IsEvent { get; set; }
    }

}
