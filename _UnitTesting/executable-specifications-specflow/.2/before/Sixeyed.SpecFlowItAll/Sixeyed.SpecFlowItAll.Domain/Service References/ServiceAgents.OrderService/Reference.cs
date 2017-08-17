﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18063
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sixeyed.SpecFlowItAll.Domain.ServiceAgents.OrderService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceAgents.OrderService.OrderService")]
    public interface OrderService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/OrderService/Place", ReplyAction="http://tempuri.org/OrderService/PlaceResponse")]
        void Place(string customerId, string productCode);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/OrderService/Place", ReplyAction="http://tempuri.org/OrderService/PlaceResponse")]
        System.Threading.Tasks.Task PlaceAsync(string customerId, string productCode);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface OrderServiceChannel : Sixeyed.SpecFlowItAll.Domain.ServiceAgents.OrderService.OrderService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class OrderServiceClient : System.ServiceModel.ClientBase<Sixeyed.SpecFlowItAll.Domain.ServiceAgents.OrderService.OrderService>, Sixeyed.SpecFlowItAll.Domain.ServiceAgents.OrderService.OrderService {
        
        public OrderServiceClient() {
        }
        
        public OrderServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public OrderServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public OrderServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public OrderServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void Place(string customerId, string productCode) {
            base.Channel.Place(customerId, productCode);
        }
        
        public System.Threading.Tasks.Task PlaceAsync(string customerId, string productCode) {
            return base.Channel.PlaceAsync(customerId, productCode);
        }
    }
}
