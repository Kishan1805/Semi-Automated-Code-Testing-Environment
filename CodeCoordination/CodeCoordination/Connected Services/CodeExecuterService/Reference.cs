﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CodeCoordination.CodeExecuterService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="CodeExecuterService.IExecuter")]
    public interface IExecuter {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IExecuter/executeCode", ReplyAction="http://tempuri.org/IExecuter/executeCodeResponse")]
        Errors.error executeCode(SupportedLanguage.language lang, string filename, string input, string output);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IExecuter/executeCode", ReplyAction="http://tempuri.org/IExecuter/executeCodeResponse")]
        System.Threading.Tasks.Task<Errors.error> executeCodeAsync(SupportedLanguage.language lang, string filename, string input, string output);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IExecuterChannel : CodeCoordination.CodeExecuterService.IExecuter, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ExecuterClient : System.ServiceModel.ClientBase<CodeCoordination.CodeExecuterService.IExecuter>, CodeCoordination.CodeExecuterService.IExecuter {
        
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
        
        public Errors.error executeCode(SupportedLanguage.language lang, string filename, string input, string output) {
            return base.Channel.executeCode(lang, filename, input, output);
        }
        
        public System.Threading.Tasks.Task<Errors.error> executeCodeAsync(SupportedLanguage.language lang, string filename, string input, string output) {
            return base.Channel.executeCodeAsync(lang, filename, input, output);
        }
    }
}