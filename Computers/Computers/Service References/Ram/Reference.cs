﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Computers.Ram {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="Ram.SRam")]
    public interface SRam {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SRam/NewRam", ReplyAction="http://tempuri.org/SRam/NewRamResponse")]
        void NewRam(string manufacturer, string model, string memory, string clock_Freq, string memory_type);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SRam/NewRam", ReplyAction="http://tempuri.org/SRam/NewRamResponse")]
        System.Threading.Tasks.Task NewRamAsync(string manufacturer, string model, string memory, string clock_Freq, string memory_type);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SRam/Save", ReplyAction="http://tempuri.org/SRam/SaveResponse")]
        void Save();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SRam/Save", ReplyAction="http://tempuri.org/SRam/SaveResponse")]
        System.Threading.Tasks.Task SaveAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SRam/Update", ReplyAction="http://tempuri.org/SRam/UpdateResponse")]
        void Update(string manufacturer, string newmodel, string socket, string clock_Freq, string cache, string oldmodel);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SRam/Update", ReplyAction="http://tempuri.org/SRam/UpdateResponse")]
        System.Threading.Tasks.Task UpdateAsync(string manufacturer, string newmodel, string socket, string clock_Freq, string cache, string oldmodel);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SRam/delete", ReplyAction="http://tempuri.org/SRam/deleteResponse")]
        void delete(string model);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SRam/delete", ReplyAction="http://tempuri.org/SRam/deleteResponse")]
        System.Threading.Tasks.Task deleteAsync(string model);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SRam/toString", ReplyAction="http://tempuri.org/SRam/toStringResponse")]
        string toString();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SRam/toString", ReplyAction="http://tempuri.org/SRam/toStringResponse")]
        System.Threading.Tasks.Task<string> toStringAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SRam/get", ReplyAction="http://tempuri.org/SRam/getResponse")]
        string get();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SRam/get", ReplyAction="http://tempuri.org/SRam/getResponse")]
        System.Threading.Tasks.Task<string> getAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface SRamChannel : Computers.Ram.SRam, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class SRamClient : System.ServiceModel.ClientBase<Computers.Ram.SRam>, Computers.Ram.SRam {
        
        public SRamClient() {
        }
        
        public SRamClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public SRamClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SRamClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SRamClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void NewRam(string manufacturer, string model, string memory, string clock_Freq, string memory_type) {
            base.Channel.NewRam(manufacturer, model, memory, clock_Freq, memory_type);
        }
        
        public System.Threading.Tasks.Task NewRamAsync(string manufacturer, string model, string memory, string clock_Freq, string memory_type) {
            return base.Channel.NewRamAsync(manufacturer, model, memory, clock_Freq, memory_type);
        }
        
        public void Save() {
            base.Channel.Save();
        }
        
        public System.Threading.Tasks.Task SaveAsync() {
            return base.Channel.SaveAsync();
        }
        
        public void Update(string manufacturer, string newmodel, string socket, string clock_Freq, string cache, string oldmodel) {
            base.Channel.Update(manufacturer, newmodel, socket, clock_Freq, cache, oldmodel);
        }
        
        public System.Threading.Tasks.Task UpdateAsync(string manufacturer, string newmodel, string socket, string clock_Freq, string cache, string oldmodel) {
            return base.Channel.UpdateAsync(manufacturer, newmodel, socket, clock_Freq, cache, oldmodel);
        }
        
        public void delete(string model) {
            base.Channel.delete(model);
        }
        
        public System.Threading.Tasks.Task deleteAsync(string model) {
            return base.Channel.deleteAsync(model);
        }
        
        public string toString() {
            return base.Channel.toString();
        }
        
        public System.Threading.Tasks.Task<string> toStringAsync() {
            return base.Channel.toStringAsync();
        }
        
        public string get() {
            return base.Channel.get();
        }
        
        public System.Threading.Tasks.Task<string> getAsync() {
            return base.Channel.getAsync();
        }
    }
}
