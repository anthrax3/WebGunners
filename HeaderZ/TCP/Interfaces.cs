using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Sockets;

namespace ProxyTool
{
    class RequestHeaders : Dictionary<string, string> 
    {
        string Host { get { return this["Host"]/*.Split(':')[0]*/; } }
    }

    interface IRequestFilter
    {
        bool ShouldFilter(RequestHeaders headers);
    }

    // chain of responsability attempt
    interface IRequestHandler
    {
        void HandleRequest(RequestHeaders headers, NetworkStream ns, IRequestHandler nextHandler);
    }

}
