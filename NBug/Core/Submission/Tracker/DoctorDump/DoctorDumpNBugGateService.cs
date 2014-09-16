namespace IdolSoftware.DoctorDump.NBugGate
{
    using System.ServiceModel;
    using System.ServiceModel.Channels;

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name = "ClientLib", Namespace = "https://www.drdump.com/services")]
    [System.SerializableAttribute()]
    internal partial class ClientLib : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged
    {

        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;

        private ushort V1Field;

        private ushort V2Field;

        private ushort V3Field;

        private ushort V4Field;

        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData
        {
            get
            {
                return this.extensionDataField;
            }
            set
            {
                this.extensionDataField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(IsRequired = true)]
        internal ushort V1
        {
            get
            {
                return this.V1Field;
            }
            set
            {
                if ((this.V1Field.Equals(value) != true))
                {
                    this.V1Field = value;
                    this.RaisePropertyChanged("V1");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(IsRequired = true)]
        internal ushort V2
        {
            get
            {
                return this.V2Field;
            }
            set
            {
                if ((this.V2Field.Equals(value) != true))
                {
                    this.V2Field = value;
                    this.RaisePropertyChanged("V2");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(IsRequired = true)]
        internal ushort V3
        {
            get
            {
                return this.V3Field;
            }
            set
            {
                if ((this.V3Field.Equals(value) != true))
                {
                    this.V3Field = value;
                    this.RaisePropertyChanged("V3");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(IsRequired = true)]
        internal ushort V4
        {
            get
            {
                return this.V4Field;
            }
            set
            {
                if ((this.V4Field.Equals(value) != true))
                {
                    this.V4Field = value;
                    this.RaisePropertyChanged("V4");
                }
            }
        }

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name = "Application", Namespace = "https://www.drdump.com/services")]
    [System.SerializableAttribute()]
    internal partial class Application : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged
    {

        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;

        private string AppNameField;

        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<System.Guid> ApplicationGUIDField;

        private string CompanyNameField;

        private string EmailField;

        private string MainModuleField;

        private ushort V1Field;

        private ushort V2Field;

        private ushort V3Field;

        private ushort V4Field;

        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData
        {
            get
            {
                return this.extensionDataField;
            }
            set
            {
                this.extensionDataField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(IsRequired = true)]
        internal string AppName
        {
            get
            {
                return this.AppNameField;
            }
            set
            {
                if ((object.ReferenceEquals(this.AppNameField, value) != true))
                {
                    this.AppNameField = value;
                    this.RaisePropertyChanged("AppName");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        internal System.Nullable<System.Guid> ApplicationGUID
        {
            get
            {
                return this.ApplicationGUIDField;
            }
            set
            {
                if ((this.ApplicationGUIDField.Equals(value) != true))
                {
                    this.ApplicationGUIDField = value;
                    this.RaisePropertyChanged("ApplicationGUID");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(IsRequired = true)]
        internal string CompanyName
        {
            get
            {
                return this.CompanyNameField;
            }
            set
            {
                if ((object.ReferenceEquals(this.CompanyNameField, value) != true))
                {
                    this.CompanyNameField = value;
                    this.RaisePropertyChanged("CompanyName");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(IsRequired = true)]
        internal string Email
        {
            get
            {
                return this.EmailField;
            }
            set
            {
                if ((object.ReferenceEquals(this.EmailField, value) != true))
                {
                    this.EmailField = value;
                    this.RaisePropertyChanged("Email");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(IsRequired = true)]
        internal string MainModule
        {
            get
            {
                return this.MainModuleField;
            }
            set
            {
                if ((object.ReferenceEquals(this.MainModuleField, value) != true))
                {
                    this.MainModuleField = value;
                    this.RaisePropertyChanged("MainModule");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(IsRequired = true)]
        internal ushort V1
        {
            get
            {
                return this.V1Field;
            }
            set
            {
                if ((this.V1Field.Equals(value) != true))
                {
                    this.V1Field = value;
                    this.RaisePropertyChanged("V1");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(IsRequired = true)]
        internal ushort V2
        {
            get
            {
                return this.V2Field;
            }
            set
            {
                if ((this.V2Field.Equals(value) != true))
                {
                    this.V2Field = value;
                    this.RaisePropertyChanged("V2");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(IsRequired = true)]
        internal ushort V3
        {
            get
            {
                return this.V3Field;
            }
            set
            {
                if ((this.V3Field.Equals(value) != true))
                {
                    this.V3Field = value;
                    this.RaisePropertyChanged("V3");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(IsRequired = true)]
        internal ushort V4
        {
            get
            {
                return this.V4Field;
            }
            set
            {
                if ((this.V4Field.Equals(value) != true))
                {
                    this.V4Field = value;
                    this.RaisePropertyChanged("V4");
                }
            }
        }

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name = "ExceptionDescription", Namespace = "https://www.drdump.com/services")]
    [System.SerializableAttribute()]
    internal partial class ExceptionDescription : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged
    {

        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;

        private string ClrVersionField;

        private System.DateTime CrashDateField;

        private ExceptionInfo ExceptionField;

        private string OSField;

        private int PCIDField;

        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData
        {
            get
            {
                return this.extensionDataField;
            }
            set
            {
                this.extensionDataField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(IsRequired = true)]
        internal string ClrVersion
        {
            get
            {
                return this.ClrVersionField;
            }
            set
            {
                if ((object.ReferenceEquals(this.ClrVersionField, value) != true))
                {
                    this.ClrVersionField = value;
                    this.RaisePropertyChanged("ClrVersion");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(IsRequired = true)]
        internal System.DateTime CrashDate
        {
            get
            {
                return this.CrashDateField;
            }
            set
            {
                if ((this.CrashDateField.Equals(value) != true))
                {
                    this.CrashDateField = value;
                    this.RaisePropertyChanged("CrashDate");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(IsRequired = true)]
        internal ExceptionInfo Exception
        {
            get
            {
                return this.ExceptionField;
            }
            set
            {
                if ((object.ReferenceEquals(this.ExceptionField, value) != true))
                {
                    this.ExceptionField = value;
                    this.RaisePropertyChanged("Exception");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(IsRequired = true)]
        internal string OS
        {
            get
            {
                return this.OSField;
            }
            set
            {
                if ((object.ReferenceEquals(this.OSField, value) != true))
                {
                    this.OSField = value;
                    this.RaisePropertyChanged("OS");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(IsRequired = true)]
        internal int PCID
        {
            get
            {
                return this.PCIDField;
            }
            set
            {
                if ((this.PCIDField.Equals(value) != true))
                {
                    this.PCIDField = value;
                    this.RaisePropertyChanged("PCID");
                }
            }
        }

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name = "ExceptionInfo", Namespace = "https://www.drdump.com/services")]
    [System.SerializableAttribute()]
    internal partial class ExceptionInfo : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged
    {

        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;

        private int HResultField;

        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private ExceptionInfo InnerExceptionField;

        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string MessageField;

        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string SourceField;

        private string StackTraceField;

        private string TypeField;

        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData
        {
            get
            {
                return this.extensionDataField;
            }
            set
            {
                this.extensionDataField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(IsRequired = true)]
        internal int HResult
        {
            get
            {
                return this.HResultField;
            }
            set
            {
                if ((this.HResultField.Equals(value) != true))
                {
                    this.HResultField = value;
                    this.RaisePropertyChanged("HResult");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        internal ExceptionInfo InnerException
        {
            get
            {
                return this.InnerExceptionField;
            }
            set
            {
                if ((object.ReferenceEquals(this.InnerExceptionField, value) != true))
                {
                    this.InnerExceptionField = value;
                    this.RaisePropertyChanged("InnerException");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        internal string Message
        {
            get
            {
                return this.MessageField;
            }
            set
            {
                if ((object.ReferenceEquals(this.MessageField, value) != true))
                {
                    this.MessageField = value;
                    this.RaisePropertyChanged("Message");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        internal string Source
        {
            get
            {
                return this.SourceField;
            }
            set
            {
                if ((object.ReferenceEquals(this.SourceField, value) != true))
                {
                    this.SourceField = value;
                    this.RaisePropertyChanged("Source");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(IsRequired = true)]
        internal string StackTrace
        {
            get
            {
                return this.StackTraceField;
            }
            set
            {
                if ((object.ReferenceEquals(this.StackTraceField, value) != true))
                {
                    this.StackTraceField = value;
                    this.RaisePropertyChanged("StackTrace");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(IsRequired = true)]
        internal string Type
        {
            get
            {
                return this.TypeField;
            }
            set
            {
                if ((object.ReferenceEquals(this.TypeField, value) != true))
                {
                    this.TypeField = value;
                    this.RaisePropertyChanged("Type");
                }
            }
        }

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name = "Response", Namespace = "https://www.drdump.com/services")]
    [System.SerializableAttribute()]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(NeedReportResponse))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(StopResponse))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(ErrorResponse))]
    internal partial class Response : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged
    {

        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;

        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ClientIDField;

        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private byte[] ContextField;

        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int DumpGroupIDField;

        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int DumpIDField;

        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private byte[] GarbageField;

        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int ProblemIDField;

        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string UrlToProblemField;

        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData
        {
            get
            {
                return this.extensionDataField;
            }
            set
            {
                this.extensionDataField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        internal string ClientID
        {
            get
            {
                return this.ClientIDField;
            }
            set
            {
                if ((object.ReferenceEquals(this.ClientIDField, value) != true))
                {
                    this.ClientIDField = value;
                    this.RaisePropertyChanged("ClientID");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        internal byte[] Context
        {
            get
            {
                return this.ContextField;
            }
            set
            {
                if ((object.ReferenceEquals(this.ContextField, value) != true))
                {
                    this.ContextField = value;
                    this.RaisePropertyChanged("Context");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        internal int DumpGroupID
        {
            get
            {
                return this.DumpGroupIDField;
            }
            set
            {
                if ((this.DumpGroupIDField.Equals(value) != true))
                {
                    this.DumpGroupIDField = value;
                    this.RaisePropertyChanged("DumpGroupID");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        internal int DumpID
        {
            get
            {
                return this.DumpIDField;
            }
            set
            {
                if ((this.DumpIDField.Equals(value) != true))
                {
                    this.DumpIDField = value;
                    this.RaisePropertyChanged("DumpID");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        internal byte[] Garbage
        {
            get
            {
                return this.GarbageField;
            }
            set
            {
                if ((object.ReferenceEquals(this.GarbageField, value) != true))
                {
                    this.GarbageField = value;
                    this.RaisePropertyChanged("Garbage");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        internal int ProblemID
        {
            get
            {
                return this.ProblemIDField;
            }
            set
            {
                if ((this.ProblemIDField.Equals(value) != true))
                {
                    this.ProblemIDField = value;
                    this.RaisePropertyChanged("ProblemID");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        internal string UrlToProblem
        {
            get
            {
                return this.UrlToProblemField;
            }
            set
            {
                if ((object.ReferenceEquals(this.UrlToProblemField, value) != true))
                {
                    this.UrlToProblemField = value;
                    this.RaisePropertyChanged("UrlToProblem");
                }
            }
        }

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name = "NeedReportResponse", Namespace = "https://www.drdump.com/services")]
    [System.SerializableAttribute()]
    internal partial class NeedReportResponse : Response
    {
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name = "StopResponse", Namespace = "https://www.drdump.com/services")]
    [System.SerializableAttribute()]
    internal partial class StopResponse : Response
    {
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name = "ErrorResponse", Namespace = "https://www.drdump.com/services")]
    [System.SerializableAttribute()]
    internal partial class ErrorResponse : Response
    {

        private string ErrorField;

        [System.Runtime.Serialization.DataMemberAttribute(IsRequired = true)]
        internal string Error
        {
            get
            {
                return this.ErrorField;
            }
            set
            {
                if ((object.ReferenceEquals(this.ErrorField, value) != true))
                {
                    this.ErrorField = value;
                    this.RaisePropertyChanged("Error");
                }
            }
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name = "DetailedExceptionDescription", Namespace = "https://www.drdump.com/services")]
    [System.SerializableAttribute()]
    internal partial class DetailedExceptionDescription : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged
    {

        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;

        private ExceptionDescription ExceptionField;

        private byte[] ReportField;

        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string UserDescriptionField;

        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData
        {
            get
            {
                return this.extensionDataField;
            }
            set
            {
                this.extensionDataField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(IsRequired = true)]
        internal ExceptionDescription Exception
        {
            get
            {
                return this.ExceptionField;
            }
            set
            {
                if ((object.ReferenceEquals(this.ExceptionField, value) != true))
                {
                    this.ExceptionField = value;
                    this.RaisePropertyChanged("Exception");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(IsRequired = true)]
        internal byte[] Report
        {
            get
            {
                return this.ReportField;
            }
            set
            {
                if ((object.ReferenceEquals(this.ReportField, value) != true))
                {
                    this.ReportField = value;
                    this.RaisePropertyChanged("Report");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        internal string UserDescription
        {
            get
            {
                return this.UserDescriptionField;
            }
            set
            {
                if ((object.ReferenceEquals(this.UserDescriptionField, value) != true))
                {
                    this.UserDescriptionField = value;
                    this.RaisePropertyChanged("UserDescription");
                }
            }
        }

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Name = "IdolSoftware.DoctorDump.NBugGate.INBugReportUploader", Namespace = "https://www.drdump.com/services", ConfigurationName = "DoctorDump.IdolSoftwareDoctorDumpNBugGateINBugReportUploader")]
    internal interface INBugReportUploader
    {

        [System.ServiceModel.OperationContractAttribute(Action = "https://www.drdump.com/services/IdolSoftware.DoctorDump.NBugGate.INBugReportUploa" +
            "der/SendAnonymousReport", ReplyAction = "https://www.drdump.com/services/IdolSoftware.DoctorDump.NBugGate.INBugReportUploa" +
            "der/SendAnonymousReportResponse")]
        Response SendAnonymousReport(ClientLib clientLib, Application app, ExceptionDescription exception);

        [System.ServiceModel.OperationContractAttribute(Action = "https://www.drdump.com/services/IdolSoftware.DoctorDump.NBugGate.INBugReportUploa" +
            "der/SendAdditionalData", ReplyAction = "https://www.drdump.com/services/IdolSoftware.DoctorDump.NBugGate.INBugReportUploa" +
            "der/SendAdditionalDataResponse")]
        Response SendAdditionalData(byte[] context, DetailedExceptionDescription addInfo);
    }


    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    internal partial class NBugReportUploaderClient : System.ServiceModel.ClientBase<INBugReportUploader>, INBugReportUploader
    {
        private static CustomBinding GetBinding()
        {
            var mtomSoap12 = new MtomMessageEncodingBindingElement(MessageVersion.Soap12, System.Text.Encoding.UTF8);
            mtomSoap12.ReaderQuotas.MaxArrayLength = 1024 * 1024 * 1024;
            BindingElement https = GetServiceUrl().Scheme != "http"
                ? new HttpsTransportBindingElement() { MaxReceivedMessageSize = 1024 * 1024 * 1024 }
                : new HttpTransportBindingElement() { MaxReceivedMessageSize = 1024 * 1024 * 1024 };
            var binding = new CustomBinding(mtomSoap12, https);
            return binding;
        }

        private static System.Uri GetServiceUrl()
        {
            var serviceUrl = new System.UriBuilder("https://drdump.com/Service/NBugReportUploader.svc");

            string configOverride = Microsoft.Win32.Registry.GetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Idol Software\DumpUploader", "ServiceURL", null) as string;
            if (!string.IsNullOrEmpty(configOverride))
            {
                var config = new System.Uri(configOverride);
                serviceUrl.Scheme = config.Scheme;
                serviceUrl.Host = config.Host;
                serviceUrl.Port = config.Port;
            }
            return serviceUrl.Uri;
        }

        public NBugReportUploaderClient() :
            base(GetBinding(), new EndpointAddress(GetServiceUrl()))
        {
        }

        public Response SendAnonymousReport(ClientLib clientLib, Application app, ExceptionDescription exception)
        {
            return base.Channel.SendAnonymousReport(clientLib, app, exception);
        }

        public Response SendAdditionalData(byte[] context, DetailedExceptionDescription addInfo)
        {
            return base.Channel.SendAdditionalData(context, addInfo);
        }
    }
}
