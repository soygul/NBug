namespace NBug.Core.Submission.Tracker.DoctorDump
{
    using IdolSoftware.DoctorDump.NBugGate;
    using NBug.Core.Reporting.Info;
    using NBug.Core.Util.Logging;
    using NBug.Core.Util.Serialization;

    public class DoctorDumpFactory : IProtocolFactory
    {
        public string SupportedType
        {
            get
            {
                return "DoctorDump";
            }
        }

        public IProtocol FromConnectionString(string connectionString)
        {
            return new DoctorDump(connectionString);
        }
    }

    public class DoctorDump : ProtocolBase
    {
        public string ApplicationGUID { get; set; }

        public string Email { get; set; }

        private DoctorDumpService _uploader = new DoctorDumpService();
        private System.Threading.Tasks.Task<Response> _sendAnonymousReportResult;

        public DoctorDump(string connectionString)
            : base(connectionString)
        {
        }

        public DoctorDump()
        {
        }

        public override bool Send(string fileName, System.IO.Stream file, Report report, SerializableException exception)
        {
            var response = _uploader.SendAnonymousReport(ApplicationGUID, Email, exception, report);

            if (response is ErrorResponse)
            {
                string error = ((ErrorResponse)response).Error;
                Logger.Error(string.Format("Failed to send anonymous report, Doctor Dump: {0}", error));
                return false;
            }

            if (!(response is NeedReportResponse))
            {
                // We already have enough reports with this problem
                return true;
            }

            file.Position = 0;
            _uploader.SendAdditionalData(response.Context, ApplicationGUID, Email, file, exception, report);

            return true;
        }
    }
}
