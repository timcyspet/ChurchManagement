using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Com.Npo.BaseProject.Interface
{
    internal interface ITemporalBaseObject
    {
        DateTime EffectiveFromDate { get; set; }
        DateTime? EffectiveToDate { get; set; }
    }
}
