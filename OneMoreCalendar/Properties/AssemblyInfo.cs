//************************************************************************************************
// Copyright © 2021 Steven M Cohn. All rights reserved.
//************************************************************************************************

using System.Reflection;
using System.Runtime.InteropServices;

[assembly: AssemblyTitle("OneMoreCalendar")]
[assembly: AssemblyDescription("Calendar app companion for OneMore Add-In")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany("River Software")]
[assembly: AssemblyProduct("OneMoreCalendar")]
[assembly: AssemblyCopyright("Copyright \u00a9 2021 Steven M Cohn. All rights reserved.")]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]

[assembly: ComVisible(false)]
[assembly: Guid("1f87159c-b663-4464-b272-e0c57be22306")]

[assembly: AssemblyVersion(OneMoreCalendar.AssemblyInfo.Version)]
[assembly: AssemblyFileVersion(OneMoreCalendar.AssemblyInfo.Version)]

namespace OneMoreCalendar
{
	internal static class AssemblyInfo
	{
		public const string Version = "4.13.3";
	}
}
