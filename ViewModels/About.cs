namespace CheeseHawk.ViewModels
{
	public partial class About
	{
		public string Title => AppInfo.Name + " ";
		public string Version => AppInfo.VersionString;
		public string MoreInfoUrl => "https://github.com/funyung/CheeseHawk";
		public string Message => "This is my Code:Louisville project written with .NET MAUI and EFCore using Sqlite";
	}
}