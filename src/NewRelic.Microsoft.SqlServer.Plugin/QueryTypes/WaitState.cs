using NewRelic.Microsoft.SqlServer.Plugin.Core;

namespace NewRelic.Microsoft.SqlServer.Plugin.QueryTypes
{
	[Query("WaitStates.sql", "Custom/WaitState/{WaitType}", QueryName = "Wait States", Enabled = true)]
	public class WaitState
	{
		public string WaitType { get; set; }
		public decimal WaitSeconds { get; set; }
		public decimal ResourceSeconds { get; set; }
		public decimal SignalSeconds { get; set; }
		public int WaitCount { get; set; }
		public decimal Percentage { get; set; }
		public decimal AvgWaitSeconds { get; set; }
		public decimal AvgResourceSeconds { get; set; }
		public decimal AvgSignalSeconds { get; set; }
	}
}