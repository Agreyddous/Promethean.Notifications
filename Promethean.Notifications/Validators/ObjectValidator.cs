using Promethean.Notifications.Messages;
using Promethean.Notifications.Messages.Contracts;

namespace Promethean.Notifications.Validators
{
	public partial class Validator
	{
		public Validator IsNull(object obj, string property, int code) => IsNull(obj, property, NotificationMessage.ByCode(code));
		public Validator IsNull(object obj, string property, INotificationMessage notification)
		{
			if (obj != null)
				AddNotification(property, notification);

			return this;
		}

		public Validator IsNotNull(object obj, string property, int code) => IsNotNull(obj, property, NotificationMessage.ByCode(code));
		public Validator IsNotNull(object obj, string property, INotificationMessage notification)
		{
			if (obj == null)
				AddNotification(property, notification);

			return this;
		}

		public Validator AreEqual(object obj, object comparer, string property, int code) => AreEqual(obj, comparer, property, NotificationMessage.ByCode(code));
		public Validator AreEqual(object obj, object comparer, string property, INotificationMessage notification)
		{
			if (!obj?.Equals(comparer) ?? true)
				AddNotification(property, notification);

			return this;
		}

		public Validator AreNotEqual(object obj, object comparer, string property, int code) => AreNotEqual(obj, comparer, property, NotificationMessage.ByCode(code));
		public Validator AreNotEqual(object obj, object comparer, string property, INotificationMessage notification)
		{
			if (obj?.Equals(comparer) ?? true)
				AddNotification(property, notification);

			return this;
		}
	}
}