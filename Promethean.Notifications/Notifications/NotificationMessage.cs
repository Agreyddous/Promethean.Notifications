using System.Collections.Generic;

namespace Promethean.Notifications
{
	public partial class NotificationMessage
	{
		public NotificationMessage(int code, string message)
		{
			Code = code;
			Message = message;
		}

		public int Code { get; private set; }
		public string Message { get; private set; }
	}
}