using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace Harvest.Api
{
    [DebuggerDisplay("{Name}")]
    public class ClientIdNameModel
    {
        public long Id { get; set; }
        public string Name { get; set; }
    }

    [DebuggerDisplay("{Name}")]
    public class NullableClientIdNameModel
    {
        public long? Id { get; set; }
        public string Name { get; set; }
    }
}
