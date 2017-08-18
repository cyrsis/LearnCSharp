using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Configuration;
using System.ServiceModel.Description;
using System.Web;

namespace Sixeyed.CarValet.Services.Cors
{
    public class CorsBehavior : BehaviorExtensionElement, IEndpointBehavior
    {
        public void AddBindingParameters(ServiceEndpoint endpoint, System.ServiceModel.Channels.BindingParameterCollection bindingParameters)
        {

        }

        public void ApplyClientBehavior(ServiceEndpoint endpoint, System.ServiceModel.Dispatcher.ClientRuntime clientRuntime)
        {

        }

        public void ApplyDispatchBehavior(ServiceEndpoint endpoint, System.ServiceModel.Dispatcher.EndpointDispatcher endpointDispatcher)
        {
            var requiredHeaders = new Dictionary<string, string>();

            requiredHeaders.Add("Access-Control-Allow-Origin", "*");
            requiredHeaders.Add("Access-Control-Request-Method", "POST,GET,PUT,DELETE,OPTIONS");
            requiredHeaders.Add("Access-Control-Allow-Headers", "X-Requested-With,Content-Type,X-Authorization");

            endpointDispatcher.DispatchRuntime.MessageInspectors.Add(new AddResponseHeaderInspector(requiredHeaders));
        }

        public void Validate(ServiceEndpoint endpoint)
        {

        }

        public override Type BehaviorType
        {
            get { return typeof(CorsBehavior); }
        }

        protected override object CreateBehavior()
        {
            return new CorsBehavior();
        }
    }
}