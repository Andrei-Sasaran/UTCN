﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ConsoleAppExercisesClient.srExercices {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.CollectionDataContractAttribute(Name="ArrayOfString", Namespace="http://tempuri.org/", ItemName="string")]
    [System.SerializableAttribute()]
    public class ArrayOfString : System.Collections.Generic.List<string> {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="srExercices.wsExercisesSoap")]
    public interface wsExercisesSoap {
        
        // CODEGEN: Generating message contract since element name HelloWorldResult from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/HelloWorld", ReplyAction="*")]
        ConsoleAppExercisesClient.srExercices.HelloWorldResponse HelloWorld(ConsoleAppExercisesClient.srExercices.HelloWorldRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/HelloWorld", ReplyAction="*")]
        System.Threading.Tasks.Task<ConsoleAppExercisesClient.srExercices.HelloWorldResponse> HelloWorldAsync(ConsoleAppExercisesClient.srExercices.HelloWorldRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ConvertFC", ReplyAction="*")]
        double ConvertFC(double fahrenheit);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ConvertFC", ReplyAction="*")]
        System.Threading.Tasks.Task<double> ConvertFCAsync(double fahrenheit);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ConvertCF", ReplyAction="*")]
        double ConvertCF(double celsius);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ConvertCF", ReplyAction="*")]
        System.Threading.Tasks.Task<double> ConvertCFAsync(double celsius);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/DateTimeNow", ReplyAction="*")]
        System.DateTime DateTimeNow();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/DateTimeNow", ReplyAction="*")]
        System.Threading.Tasks.Task<System.DateTime> DateTimeNowAsync();
        
        // CODEGEN: Generating message contract since element name Build5ItemListResult from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Build5ItemList", ReplyAction="*")]
        ConsoleAppExercisesClient.srExercices.Build5ItemListResponse Build5ItemList(ConsoleAppExercisesClient.srExercices.Build5ItemListRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Build5ItemList", ReplyAction="*")]
        System.Threading.Tasks.Task<ConsoleAppExercisesClient.srExercices.Build5ItemListResponse> Build5ItemListAsync(ConsoleAppExercisesClient.srExercices.Build5ItemListRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ConvertEuroToRon", ReplyAction="*")]
        double ConvertEuroToRon(double e);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ConvertEuroToRon", ReplyAction="*")]
        System.Threading.Tasks.Task<double> ConvertEuroToRonAsync(double e);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ConvertRontoEuro", ReplyAction="*")]
        double ConvertRontoEuro(double r);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ConvertRontoEuro", ReplyAction="*")]
        System.Threading.Tasks.Task<double> ConvertRontoEuroAsync(double r);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class HelloWorldRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="HelloWorld", Namespace="http://tempuri.org/", Order=0)]
        public ConsoleAppExercisesClient.srExercices.HelloWorldRequestBody Body;
        
        public HelloWorldRequest() {
        }
        
        public HelloWorldRequest(ConsoleAppExercisesClient.srExercices.HelloWorldRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class HelloWorldRequestBody {
        
        public HelloWorldRequestBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class HelloWorldResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="HelloWorldResponse", Namespace="http://tempuri.org/", Order=0)]
        public ConsoleAppExercisesClient.srExercices.HelloWorldResponseBody Body;
        
        public HelloWorldResponse() {
        }
        
        public HelloWorldResponse(ConsoleAppExercisesClient.srExercices.HelloWorldResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class HelloWorldResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string HelloWorldResult;
        
        public HelloWorldResponseBody() {
        }
        
        public HelloWorldResponseBody(string HelloWorldResult) {
            this.HelloWorldResult = HelloWorldResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class Build5ItemListRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="Build5ItemList", Namespace="http://tempuri.org/", Order=0)]
        public ConsoleAppExercisesClient.srExercices.Build5ItemListRequestBody Body;
        
        public Build5ItemListRequest() {
        }
        
        public Build5ItemListRequest(ConsoleAppExercisesClient.srExercices.Build5ItemListRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class Build5ItemListRequestBody {
        
        public Build5ItemListRequestBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class Build5ItemListResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="Build5ItemListResponse", Namespace="http://tempuri.org/", Order=0)]
        public ConsoleAppExercisesClient.srExercices.Build5ItemListResponseBody Body;
        
        public Build5ItemListResponse() {
        }
        
        public Build5ItemListResponse(ConsoleAppExercisesClient.srExercices.Build5ItemListResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class Build5ItemListResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public ConsoleAppExercisesClient.srExercices.ArrayOfString Build5ItemListResult;
        
        public Build5ItemListResponseBody() {
        }
        
        public Build5ItemListResponseBody(ConsoleAppExercisesClient.srExercices.ArrayOfString Build5ItemListResult) {
            this.Build5ItemListResult = Build5ItemListResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface wsExercisesSoapChannel : ConsoleAppExercisesClient.srExercices.wsExercisesSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class wsExercisesSoapClient : System.ServiceModel.ClientBase<ConsoleAppExercisesClient.srExercices.wsExercisesSoap>, ConsoleAppExercisesClient.srExercices.wsExercisesSoap {
        
        public wsExercisesSoapClient() {
        }
        
        public wsExercisesSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public wsExercisesSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public wsExercisesSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public wsExercisesSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ConsoleAppExercisesClient.srExercices.HelloWorldResponse ConsoleAppExercisesClient.srExercices.wsExercisesSoap.HelloWorld(ConsoleAppExercisesClient.srExercices.HelloWorldRequest request) {
            return base.Channel.HelloWorld(request);
        }
        
        public string HelloWorld() {
            ConsoleAppExercisesClient.srExercices.HelloWorldRequest inValue = new ConsoleAppExercisesClient.srExercices.HelloWorldRequest();
            inValue.Body = new ConsoleAppExercisesClient.srExercices.HelloWorldRequestBody();
            ConsoleAppExercisesClient.srExercices.HelloWorldResponse retVal = ((ConsoleAppExercisesClient.srExercices.wsExercisesSoap)(this)).HelloWorld(inValue);
            return retVal.Body.HelloWorldResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ConsoleAppExercisesClient.srExercices.HelloWorldResponse> ConsoleAppExercisesClient.srExercices.wsExercisesSoap.HelloWorldAsync(ConsoleAppExercisesClient.srExercices.HelloWorldRequest request) {
            return base.Channel.HelloWorldAsync(request);
        }
        
        public System.Threading.Tasks.Task<ConsoleAppExercisesClient.srExercices.HelloWorldResponse> HelloWorldAsync() {
            ConsoleAppExercisesClient.srExercices.HelloWorldRequest inValue = new ConsoleAppExercisesClient.srExercices.HelloWorldRequest();
            inValue.Body = new ConsoleAppExercisesClient.srExercices.HelloWorldRequestBody();
            return ((ConsoleAppExercisesClient.srExercices.wsExercisesSoap)(this)).HelloWorldAsync(inValue);
        }
        
        public double ConvertFC(double fahrenheit) {
            return base.Channel.ConvertFC(fahrenheit);
        }
        
        public System.Threading.Tasks.Task<double> ConvertFCAsync(double fahrenheit) {
            return base.Channel.ConvertFCAsync(fahrenheit);
        }
        
        public double ConvertCF(double celsius) {
            return base.Channel.ConvertCF(celsius);
        }
        
        public System.Threading.Tasks.Task<double> ConvertCFAsync(double celsius) {
            return base.Channel.ConvertCFAsync(celsius);
        }
        
        public System.DateTime DateTimeNow() {
            return base.Channel.DateTimeNow();
        }
        
        public System.Threading.Tasks.Task<System.DateTime> DateTimeNowAsync() {
            return base.Channel.DateTimeNowAsync();
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ConsoleAppExercisesClient.srExercices.Build5ItemListResponse ConsoleAppExercisesClient.srExercices.wsExercisesSoap.Build5ItemList(ConsoleAppExercisesClient.srExercices.Build5ItemListRequest request) {
            return base.Channel.Build5ItemList(request);
        }
        
        public ConsoleAppExercisesClient.srExercices.ArrayOfString Build5ItemList() {
            ConsoleAppExercisesClient.srExercices.Build5ItemListRequest inValue = new ConsoleAppExercisesClient.srExercices.Build5ItemListRequest();
            inValue.Body = new ConsoleAppExercisesClient.srExercices.Build5ItemListRequestBody();
            ConsoleAppExercisesClient.srExercices.Build5ItemListResponse retVal = ((ConsoleAppExercisesClient.srExercices.wsExercisesSoap)(this)).Build5ItemList(inValue);
            return retVal.Body.Build5ItemListResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ConsoleAppExercisesClient.srExercices.Build5ItemListResponse> ConsoleAppExercisesClient.srExercices.wsExercisesSoap.Build5ItemListAsync(ConsoleAppExercisesClient.srExercices.Build5ItemListRequest request) {
            return base.Channel.Build5ItemListAsync(request);
        }
        
        public System.Threading.Tasks.Task<ConsoleAppExercisesClient.srExercices.Build5ItemListResponse> Build5ItemListAsync() {
            ConsoleAppExercisesClient.srExercices.Build5ItemListRequest inValue = new ConsoleAppExercisesClient.srExercices.Build5ItemListRequest();
            inValue.Body = new ConsoleAppExercisesClient.srExercices.Build5ItemListRequestBody();
            return ((ConsoleAppExercisesClient.srExercices.wsExercisesSoap)(this)).Build5ItemListAsync(inValue);
        }
        
        public double ConvertEuroToRon(double e) {
            return base.Channel.ConvertEuroToRon(e);
        }
        
        public System.Threading.Tasks.Task<double> ConvertEuroToRonAsync(double e) {
            return base.Channel.ConvertEuroToRonAsync(e);
        }
        
        public double ConvertRontoEuro(double r) {
            return base.Channel.ConvertRontoEuro(r);
        }
        
        public System.Threading.Tasks.Task<double> ConvertRontoEuroAsync(double r) {
            return base.Channel.ConvertRontoEuroAsync(r);
        }
    }
}