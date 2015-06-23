using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProxyTool.RequestFilters
{
    class NullFilter : IRequestFilter
    {
        public bool ShouldFilter(RequestHeaders headers)
        {
            return true;
        }

    }
}
