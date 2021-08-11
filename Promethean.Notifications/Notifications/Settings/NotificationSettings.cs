using System;

namespace Promethean.Notifications.Settings
{
	public static class NotificationSettings
	{
		static NotificationSettings()
		{
			ErrorCode = -1;
			ErrorMessageFormat = exception => exception.Message;
			NestedErrorMessagesSeparator = "\n";
		}

		public static int ErrorCode { get; set; }
		public static Func<Exception, string> ErrorMessageFormat { get; set; }
		public static string NestedErrorMessagesSeparator { get; set; }
	}
}