using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace Harvest.Api
{
    [DebuggerDisplay("{Name}")]
    public class RetainerIdNameModel:IdNameModel
    {
    }

    [DebuggerDisplay("{Name}")]
    public class NullableRetainerIdNameModel
    {
        public long? Id { get; set; }
        public string Name { get; set; }
    }
}
