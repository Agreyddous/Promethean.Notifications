using Promethean.Notifications.Messages;
using Promethean.Notifications.Messages.Contracts;

namespace Promethean.Notifications.Validators
{
	public partial class Validator
	{
		public Validator IsTrue(bool value, string property, int code) => IsTrue(value, property, NotificationMessage.ByCode(code));
		public Validator IsTrue(bool value, string property, INotificationMessage notification)
		{
			if (!value)
				AddNotification(property, notification);

			return this;
		}

		public Validator IsFalse(bool value, string property, int code) => IsFalse(value, property, NotificationMessage.ByCode(code));
		public Validator IsFalse(bool value, string property, INotificationMessage notification)
		{
			if (value)
				AddNotification(property, notification);

			return this;
		}
	}
}