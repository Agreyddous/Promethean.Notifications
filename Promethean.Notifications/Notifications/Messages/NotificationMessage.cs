using Promethean.Notifications.Messages.Contracts;
using Promethean.Notifications.Messages.Enums;

namespace Promethean.Notifications.Messages
{
	public partial class NotificationMessage : INotificationMessage
	{
		public NotificationMessage(ECodes code, string message) : this((int)code, message) { }

		public NotificationMessage(int code, string message)
		{
			Code = code;
			Message = message;

			_messages.Add(code, this);
		}

		public NotificationMessage this[ECodes index] => this[(int)index];
		public NotificationMessage this[int index] => _messages[index];

		public int Code { get; private set; }
		public string Message { get; private set; }
	}
}