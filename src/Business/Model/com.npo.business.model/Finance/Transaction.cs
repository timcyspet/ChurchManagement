using com.npo.business.model.Association;
using com.npo.business.model.Gift;
using Com.Npo.BaseProject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.npo.business.model.Finance
{
    public class Transaction : BaseObject
    {
        public string? Naration { get; set; }
        public Commitment? Commitment { get; set; }
        public TransactionType? Type { get; set; }
        public decimal? Amount { get; set; }

    }

    public class TransactionType : TemporalBaseObject
    {
        public string? Name { get; set; }
        public string? Code { get; set; }
        public string? Description { get; set; }

    }

    public class TransactionAttribute : BaseObject
    {
        public Transaction? Transaction { get; set; }
        public Base.Attribute? Attribute { get; set; }
    }


}
