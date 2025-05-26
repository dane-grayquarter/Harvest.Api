using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace Harvest.Api
{
    [DebuggerDisplay("{Name}")]
    public class CreatorIdNameModel : IdNameModel
    {

    }

    [DebuggerDisplay("{Name}")]
    public class NullableCreatorIdNameModel
    {
        public long? Id { get; set; }
        public string Name { get; set; }
    }
}
