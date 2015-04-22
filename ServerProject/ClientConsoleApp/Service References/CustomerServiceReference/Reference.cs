﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34209
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ClientConsoleApp.CustomerServiceReference {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="CustomerServiceReference.ICustomerService")]
    public interface ICustomerService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICustomerService/GetScheduler", ReplyAction="http://tempuri.org/ICustomerService/GetSchedulerResponse")]
        ServerProject.DatabaseLayer.Scheduler GetScheduler(int movieID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICustomerService/GetScheduler", ReplyAction="http://tempuri.org/ICustomerService/GetSchedulerResponse")]
        System.Threading.Tasks.Task<ServerProject.DatabaseLayer.Scheduler> GetSchedulerAsync(int movieID);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICustomerServiceChannel : ClientConsoleApp.CustomerServiceReference.ICustomerService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class CustomerServiceClient : System.ServiceModel.ClientBase<ClientConsoleApp.CustomerServiceReference.ICustomerService>, ClientConsoleApp.CustomerServiceReference.ICustomerService {
        
        public CustomerServiceClient() {
        }
        
        public CustomerServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CustomerServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CustomerServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CustomerServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public ServerProject.DatabaseLayer.Scheduler GetScheduler(int movieID) {
            return base.Channel.GetScheduler(movieID);
        }
        
        public System.Threading.Tasks.Task<ServerProject.DatabaseLayer.Scheduler> GetSchedulerAsync(int movieID) {
            return base.Channel.GetSchedulerAsync(movieID);
        }
    }
}
