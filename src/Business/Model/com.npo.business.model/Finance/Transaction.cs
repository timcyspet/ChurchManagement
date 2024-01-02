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
        public Dictionary<string, string>? ExternalReferance { get; set; }
    }

    public class TransactionType : BaseObject
    {
        public string? Name { get; set; }
        public string? Code { get; set; }
    }


}
