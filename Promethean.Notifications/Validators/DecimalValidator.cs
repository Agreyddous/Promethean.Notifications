using Promethean.Notifications.Messages;
using Promethean.Notifications.Messages.Contracts;

namespace Promethean.Notifications.Validators
{
	public partial class PrometheanValidator
	{
		public PrometheanValidator IsGreaterThan(decimal value, decimal comparer, string property, int code) => IsGreaterThan(value, comparer, property, NotificationMessage.ByCode(code));
		public PrometheanValidator IsGreaterThan(decimal value, decimal comparer, string property, INotificationMessage notification)
		{
			if (value <= comparer)
				AddNotification(property, notification);

			return this;
		}

		public PrometheanValidator IsGreaterOrEqualTo(decimal value, decimal comparer, string property, int code) => IsGreaterOrEqualTo(value, comparer, property, NotificationMessage.ByCode(code));
		public PrometheanValidator IsGreaterOrEqualTo(decimal value, decimal comparer, string property, INotificationMessage notification)
		{
			if (value < comparer)
				AddNotification(property, notification);

			return this;
		}

		public PrometheanValidator IsLowerThan(decimal value, decimal comparer, string property, int code) => IsLowerThan(value, comparer, property, NotificationMessage.ByCode(code));
		public PrometheanValidator IsLowerThan(decimal value, decimal comparer, string property, INotificationMessage notification)
		{
			if (value >= comparer)
				AddNotification(property, notification);

			return this;
		}

		public PrometheanValidator IsLowerOrEqualTo(decimal value, decimal comparer, string property, int code) => IsLowerOrEqualTo(value, comparer, property, NotificationMessage.ByCode(code));
		public PrometheanValidator IsLowerOrEqualTo(decimal value, decimal comparer, string property, INotificationMessage notification)
		{
			if (value > comparer)
				AddNotification(property, notification);

			return this;
		}

		public PrometheanValidator AreEqual(decimal value, decimal comparer, string property, int code) => AreEqual(value, comparer, property, NotificationMessage.ByCode(code));
		public PrometheanValidator AreEqual(decimal value, decimal comparer, string property, INotificationMessage notification)
		{
			if (!value.Equals(comparer))
				AddNotification(property, notification);

			return this;
		}

		public PrometheanValidator IsBetween(decimal value, decimal from, decimal to, string property, int code) => IsBetween(value, from, to, property, NotificationMessage.ByCode(code));
		public PrometheanValidator IsBetween(decimal value, decimal from, decimal to, string property, INotificationMessage notification)
		{
			if (value < from || value > to)
				AddNotification(property, notification);

			return this;
		}
	}
}