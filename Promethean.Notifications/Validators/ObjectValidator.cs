using Promethean.Notifications.Messages;
using Promethean.Notifications.Messages.Contracts;

namespace Promethean.Notifications.Validators
{
	public partial class PrometheanValidator
	{
		public PrometheanValidator IsNull(object obj, string property, int code) => IsNull(obj, property, NotificationMessage.ByCode(code));
		public PrometheanValidator IsNull(object obj, string property, INotificationMessage notification)
		{
			if (obj != null)
				AddNotification(property, notification);

			return this;
		}

		public PrometheanValidator IsNotNull(object obj, string property, int code) => IsNotNull(obj, property, NotificationMessage.ByCode(code));
		public PrometheanValidator IsNotNull(object obj, string property, INotificationMessage notification)
		{
			if (obj == null)
				AddNotification(property, notification);

			return this;
		}

		public PrometheanValidator AreEqual(object obj, object comparer, string property, int code) => AreEqual(obj, comparer, property, NotificationMessage.ByCode(code));
		public PrometheanValidator AreEqual(object obj, object comparer, string property, INotificationMessage notification)
		{
			if (!obj?.Equals(comparer) ?? true)
				AddNotification(property, notification);

			return this;
		}

		public PrometheanValidator AreNotEqual(object obj, object comparer, string property, int code) => AreNotEqual(obj, comparer, property, NotificationMessage.ByCode(code));
		public PrometheanValidator AreNotEqual(object obj, object comparer, string property, INotificationMessage notification)
		{
			if (obj?.Equals(comparer) ?? true)
				AddNotification(property, notification);

			return this;
		}
	}
}