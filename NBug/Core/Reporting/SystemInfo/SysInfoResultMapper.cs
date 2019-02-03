// MIT License
// Copyright (c) 2009 Javier Cañon https://www.javiercanon.com
// https://github.com/JavierCanon/Shark.NET-Error-Reporter 
//
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace NBug.Core.Reporting.SystemInfo
{
	///<summary>
	/// Map SysInfoResults to human-readable formats
	///</summary>
	public static class SysInfoResultMapper
	{
		/// <summary>
		/// Add a tree node to an existing parentNode, by passing the SyfInfoResult
		/// </summary>
		public static void AddTreeViewNode(TreeNode parentNode, SysInfoResult result)
		{
			var nodeRoot = new TreeNode(result.Name);

			foreach (var nodeValueParent in result.Nodes)
			{
				var nodeLeaf = new TreeNode(nodeValueParent);
				nodeRoot.Nodes.Add(nodeLeaf);

				foreach (var childResult in result.ChildResults)
				{
					foreach (var nodeValue in childResult.Nodes)
					{
						nodeLeaf.Nodes.Add(new TreeNode(nodeValue));
					}
				}
			}
			parentNode.Nodes.Add(nodeRoot);
		}

		/// <summary>
		/// create a string representation of a list of SysInfoResults, customised specifically (eg 2-level deep)
		/// </summary>
		public static string CreateStringList(IEnumerable<SysInfoResult> results)
		{
			var stringBuilder = new StringBuilder();

			foreach (var result in results)
			{
				stringBuilder.AppendLine(result.Name);

				foreach (var nodeValueParent in result.Nodes)
				{
					stringBuilder.AppendLine("-" + nodeValueParent);

					foreach (var childResult in result.ChildResults)
					{
						foreach (var nodeValue in childResult.Nodes)
						{
							stringBuilder.AppendLine("--" + nodeValue);		// the max no. of levels is 2, ie '--' is as deep as we go
						}
					}
				}
				stringBuilder.AppendLine();
			}

			return stringBuilder.ToString();
		}
	}
}