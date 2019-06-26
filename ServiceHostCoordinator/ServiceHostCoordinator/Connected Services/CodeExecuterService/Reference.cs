﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ServiceHostCoordinator.CodeExecuterService {
    using System.Runtime.Serialization;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="language", Namespace="http://schemas.datacontract.org/2004/07/SupportedLanguage")]
    public enum language : int {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        cpp = 0,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        c = 1,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        python2 = 2,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        python3 = 3,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        java = 4,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="error", Namespace="http://schemas.datacontract.org/2004/07/Errors")]
    public enum error : int {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        CE = 0,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        RE = 1,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        TLE = 2,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        AC = 3,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="CodeExecuterService.IExecuter")]
    public interface IExecuter {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IExecuter/executeCode", ReplyAction="http://tempuri.org/IExecuter/executeCodeResponse")]
        ServiceHostCoordinator.CodeExecuterService.error executeCode(ServiceHostCoordinator.CodeExecuterService.language lang, string filename, string input, string output);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IExecuter/executeCode", ReplyAction="http://tempuri.org/IExecuter/executeCodeResponse")]
        System.Threading.Tasks.Task<ServiceHostCoordinator.CodeExecuterService.error> executeCodeAsync(ServiceHostCoordinator.CodeExecuterService.language lang, string filename, string input, string output);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IExecuterChannel : ServiceHostCoordinator.CodeExecuterService.IExecuter, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ExecuterClient : System.ServiceModel.ClientBase<ServiceHostCoordinator.CodeExecuterService.IExecuter>, ServiceHostCoordinator.CodeExecuterService.IExecuter {
        
        public ExecuterClient() {
        }
        
        public ExecuterClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ExecuterClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ExecuterClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ExecuterClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public ServiceHostCoordinator.CodeExecuterService.error executeCode(ServiceHostCoordinator.CodeExecuterService.language lang, string filename, string input, string output) {
            return base.Channel.executeCode(lang, filename, input, output);
        }
        
        public System.Threading.Tasks.Task<ServiceHostCoordinator.CodeExecuterService.error> executeCodeAsync(ServiceHostCoordinator.CodeExecuterService.language lang, string filename, string input, string output) {
            return base.Channel.executeCodeAsync(lang, filename, input, output);
        }
    }
}
