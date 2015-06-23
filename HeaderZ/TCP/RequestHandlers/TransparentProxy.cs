using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;

namespace ProxyTool.RequestHandlers
{
    class TransparentProxyHandler : IRequestHandler
    {
        public void HandleRequest(RequestHeaders headers, System.Net.Sockets.NetworkStream ns, IRequestHandler nextHandler)
        {
            if (nextHandler != null) 
                throw new System.Configuration.ConfigurationException("TransparentProxyHandler must be the last handler in the sequence.");

            var hostTokens = headers["Host"].Split(':');
            var webclient = new WebClient();

            foreach( var k in headers.Keys)
            {
                webclient.Headers[k] = headers[k];
            }

        }

    }
}
