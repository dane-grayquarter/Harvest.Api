using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace Harvest.Api
{
    [DebuggerDisplay("{Name}")]
    public class EstimateIdNameModel : IdNameModel
    {

    }

    [DebuggerDisplay("{Name}")]
    public class NullableEstimateIdNameModel
    {
        public long? Id { get; set; }
        public string Name { get; set; }
    }
}
