// MIT License
// Copyright (c) 2009 Javier Cañon https://www.javiercanon.com
// https://github.com/JavierCanon/Shark.NET-Error-Reporter 
//
namespace NBug.Core.Reporting.SystemInfo
{
	/// <summary>
	/// describes a query to SysInfo (more precisely, the Windows 'WMI' ManagementObjectSearcher)
	/// </summary>
	internal class SysInfoQuery
	{
		private readonly bool _useNameAsDisplayField;

		public SysInfoQuery(string name, string query, bool useNameAsDisplayField)
		{
			Name = name;
			_useNameAsDisplayField = useNameAsDisplayField;
			QueryText = query;
		}

		public string QueryText { get; }

		public string DisplayField
		{
			get { return _useNameAsDisplayField ? "Name" : "Caption"; }
		}

		public string Name { get; }
	}
}
