﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Hitachi_DotNet_Practical_Assignment.PL.UserServiceWCF {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="UserServiceWCF.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/SignIn", ReplyAction="http://tempuri.org/IService1/SignInResponse")]
        string SignIn(Hitachi_DotNet_Practical_Assignment.DAL.Models.DTOs.SignInDTO user);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/SignIn", ReplyAction="http://tempuri.org/IService1/SignInResponse")]
        System.Threading.Tasks.Task<string> SignInAsync(Hitachi_DotNet_Practical_Assignment.DAL.Models.DTOs.SignInDTO user);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/SignUp", ReplyAction="http://tempuri.org/IService1/SignUpResponse")]
        string SignUp(Hitachi_DotNet_Practical_Assignment.DAL.Models.DTOs.SignUpDTO newUser);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/SignUp", ReplyAction="http://tempuri.org/IService1/SignUpResponse")]
        System.Threading.Tasks.Task<string> SignUpAsync(Hitachi_DotNet_Practical_Assignment.DAL.Models.DTOs.SignUpDTO newUser);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : Hitachi_DotNet_Practical_Assignment.PL.UserServiceWCF.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<Hitachi_DotNet_Practical_Assignment.PL.UserServiceWCF.IService1>, Hitachi_DotNet_Practical_Assignment.PL.UserServiceWCF.IService1 {
        
        public Service1Client() {
        }
        
        public Service1Client(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public Service1Client(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string SignIn(Hitachi_DotNet_Practical_Assignment.DAL.Models.DTOs.SignInDTO user) {
            return base.Channel.SignIn(user);
        }
        
        public System.Threading.Tasks.Task<string> SignInAsync(Hitachi_DotNet_Practical_Assignment.DAL.Models.DTOs.SignInDTO user) {
            return base.Channel.SignInAsync(user);
        }
        
        public string SignUp(Hitachi_DotNet_Practical_Assignment.DAL.Models.DTOs.SignUpDTO newUser) {
            return base.Channel.SignUp(newUser);
        }
        
        public System.Threading.Tasks.Task<string> SignUpAsync(Hitachi_DotNet_Practical_Assignment.DAL.Models.DTOs.SignUpDTO newUser) {
            return base.Channel.SignUpAsync(newUser);
        }
    }
}
