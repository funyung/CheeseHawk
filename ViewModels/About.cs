using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheeseHawk.ViewModels;

internal class About
{
	public string Title => AppInfo.Name;
	public string Version => AppInfo.VersionString;
	public string MoreInfoUrl => "https://github.com/funyung/CheeseHawk";
	public string Message => "This is my Code:Louisville project written with .NET MAUI and EFCore using Sqlite"
}
