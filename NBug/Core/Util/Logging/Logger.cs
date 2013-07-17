﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Logger.cs" company="NBusy Project">
//   Copyright (c) 2010 - 2011 Teoman Soygul. Licensed under LGPLv3 (http://www.gnu.org/licenses/lgpl.html).
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace NBug.Core.Util.Logging
{
	using NBug.Core.UI.Developer;
	using NBug.Core.Util.Exceptions;
	using NBug.Enums;
	using System;
	using System.IO;
	using System.Linq.Expressions;

	/// <summary>
	/// Uses <see cref="System.Diagnostics.Trace.Write(string, string)"/> method to log important messages. Also provides a <see cref="LogWritten"/>
	/// event. If <see cref="NBug.Settings.WriteLogToDisk"/> is set to true, a default "NBug.log" file is written to disk.
	/// </summary>
	/// <example>
	/// A sample trace listener can easily be added to the current application with an app.config file looking as below:
	/// <code>
	/// {?xml version="1.0"?}
	/// {configuration}
	///  {configSections}
	///  {/configSections}
	///  {system.diagnostics}
	///    {trace autoflush="true" indentsize="2"}
	///      {listeners}
	///        {add name="testAppListener" type="System.Diagnostics.TextWriterTraceListener" initializeData="MyApplication.log" /}
	///      {/listeners}
	///    {/trace}
	///  {/system.diagnostics}
	/// {/configuration}
	/// </code>
	/// </example>
	internal static class Logger
	{
		static Logger()
		{
			if (Settings.WriteLogToDisk)
			{
				LogWritten += (message, category) => File.AppendAllText(Path.Combine(Settings.NBugDirectory, "NBug.log"), category + ": " + message + Environment.NewLine);
			}
		}

		/// <summary>
		/// First parameters is message string, second one is the category.
		/// </summary>
		internal static event Action<string, LoggerCategory> LogWritten;

		internal static void Trace(string message)
		{
			Write(message, LoggerCategory.NBugTrace);
		}

		internal static void Info(string message)
		{
			Write(message, LoggerCategory.NBugInfo);
		}

		internal static void Warning(string message)
		{
			Write(message, LoggerCategory.NBugWarning);
		}

		internal static void Error(string message)
		{
			Write(message, LoggerCategory.NBugError);

			if (Settings.DisplayDeveloperUI)
			{
				using (var viewer = new InternalExceptionViewer())
				{
					viewer.ShowDialog(new NBugRuntimeException(message));
				}
			}

			if (Settings.ThrowExceptions)
			{
				throw new NBugRuntimeException(message);
			}
		}

		internal static void Error(string message, Exception exception)
		{
			Write(message + Environment.NewLine + "Exception: " + exception, LoggerCategory.NBugError);

			if (Settings.DisplayDeveloperUI)
			{
				using (var viewer = new InternalExceptionViewer())
				{
					viewer.ShowDialog(exception);
				}
			}

			if (Settings.ThrowExceptions)
			{
				throw new NBugRuntimeException(message, exception);
			}
		}

		internal static void Error<T>(Expression<Func<T>> propertyExpression, string message)
		{
			Write(message + " Misconfigured Property: " + ((MemberExpression)propertyExpression.Body).Member.Name, LoggerCategory.NBugError);

			if (Settings.DisplayDeveloperUI)
			{
				using (var viewer = new InternalExceptionViewer())
				{
					viewer.ShowDialog(NBugConfigurationException.Create(propertyExpression, message));
				}
			}

			if (Settings.ThrowExceptions)
			{
				throw NBugConfigurationException.Create(propertyExpression, message);
			}
		}

		private static void Write(string message, LoggerCategory category)
		{
			System.Diagnostics.Trace.Write(message + Environment.NewLine, category.ToString());

			if (Settings.DisplayDeveloperUI)
			{
				// InternalLogViewer.LogEntry(message, category);
			}

			var handler = LogWritten;
			if (handler != null)
			{
				handler(message, category);
			}
		}
	}
}