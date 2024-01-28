using Com.Npo.BaseProject.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Com.Npo.BaseProject
{
    public abstract class TemporalBaseObject : BaseObject, ITemporalBaseObject
    {
        public DateTime EffectiveFromDate { get; set; }
        public DateTime? EffectiveToDate { get; set; }
    }
}
