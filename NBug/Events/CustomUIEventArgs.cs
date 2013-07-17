namespace NBug
{
	using NBug.Core.Reporting.Info;
	using NBug.Core.UI;
	using NBug.Core.Util.Serialization;
	using NBug.Enums;
	using System;

	public class CustomUIEventArgs : EventArgs
	{
		internal CustomUIEventArgs(UIMode uiMode, SerializableException exception, Report report)
		{
			UIMode = uiMode;
			Report = report;
			Exception = exception;
			Result = new UIDialogResult(ExecutionFlow.BreakExecution, SendReport.DoNotSend);
		}

		public UIMode UIMode { get; private set; }

		public Report Report { get; private set; }

		public SerializableException Exception { get; private set; }

		public UIDialogResult Result { get; set; }
	}
}