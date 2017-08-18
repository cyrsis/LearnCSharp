using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Channels;
using System.ServiceModel.Dispatcher;
using System.Web;

namespace Sixeyed.CarValet.Services.Cors
{
    public class AddResponseHeaderInspector : IDispatchMessageInspector
    {
        private Dictionary<string, string> requiredHeaders;

        public AddResponseHeaderInspector(Dictionary<string, string> headers)
        {
            requiredHeaders = headers ?? new Dictionary<string, string>();
        }

        public object AfterReceiveRequest(ref System.ServiceModel.Channels.Message request, System.ServiceModel.IClientChannel channel, System.ServiceModel.InstanceContext instanceContext)
        {
            return null;
        }

        public void BeforeSendReply(ref System.ServiceModel.Channels.Message reply, object correlationState)
        {
            if (reply.Properties.ContainsKey("httpResponse"))
            {
                var httpHeader = reply.Properties["httpResponse"] as HttpResponseMessageProperty;
                foreach (var item in requiredHeaders)
                {
                    httpHeader.Headers.Add(item.Key, item.Value);
                }
            }
        }
    }
}