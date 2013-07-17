﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Feedback.cs" company="NBusy Project">
//   Copyright (c) 2010 - 2011 Teoman Soygul. Licensed under LGPLv3 (http://www.gnu.org/licenses/lgpl.html).
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace NBug.Core.Reporting
{
	using NBug.Core.Reporting.Info;
	using NBug.Core.Util.Logging;
	using System;

	internal class Feedback
	{
		private Report report;

		internal Feedback()
		{
			try
			{
				// ToDo: Wrap and submit the feedback using Submit.Dispatcher()
				this.report = new Report(null);
			}
			catch (Exception exception)
			{
				Logger.Error("An exception occurred while sending a user feedback. See the inner exception for details.", exception);
			}
		}
	}
}