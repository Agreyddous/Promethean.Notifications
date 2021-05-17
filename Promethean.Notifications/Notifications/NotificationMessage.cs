using System.Collections.Generic;

namespace Promethean.Notifications
{
	public partial class NotificationMessage
	{
		private static List<NotificationMessage> _messages = new List<NotificationMessage>();

		public NotificationMessage(int code, string message)
		{
			Code = code;
			Message = message;

			_messages.Add(this);
		}

		public int Code { get; private set; }
		public string Message { get; private set; }
	}
}