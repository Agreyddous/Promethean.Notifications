using Promethean.Notifications.Messages;
using Promethean.Notifications.Messages.Contracts;

namespace Promethean.Notifications.Validators
{
	public partial class PrometheanValidator
	{
		public PrometheanValidator IsGreaterThan(float value, float comparer, string property, int code) => IsGreaterThan(value, comparer, property, NotificationMessage.ByCode(code));
		public PrometheanValidator IsGreaterThan(float value, float comparer, string property, INotificationMessage notification) => IsGreaterThan((decimal)value, (decimal)comparer, property, notification);

		public PrometheanValidator IsGreaterOrEqualTo(float value, float comparer, string property, int code) => IsGreaterOrEqualTo(value, comparer, property, NotificationMessage.ByCode(code));
		public PrometheanValidator IsGreaterOrEqualTo(float value, float comparer, string property, INotificationMessage notification) => IsGreaterOrEqualTo((decimal)value, (decimal)comparer, property, notification);

		public PrometheanValidator IsLowerThan(float value, float comparer, string property, int code) => IsLowerThan(value, comparer, property, NotificationMessage.ByCode(code));
		public PrometheanValidator IsLowerThan(float value, float comparer, string property, INotificationMessage notification) => IsLowerThan((decimal)value, (decimal)comparer, property, notification);

		public PrometheanValidator IsLowerOrEqualTo(float value, float comparer, string property, int code) => IsLowerOrEqualTo(value, comparer, property, NotificationMessage.ByCode(code));
		public PrometheanValidator IsLowerOrEqualTo(float value, float comparer, string property, INotificationMessage notification) => IsLowerOrEqualTo((decimal)value, (decimal)comparer, property, notification);

		public PrometheanValidator AreEqual(float value, float comparer, string property, int code) => AreEqual(value, comparer, property, NotificationMessage.ByCode(code));
		public PrometheanValidator AreEqual(float value, float comparer, string property, INotificationMessage notification) => AreEqual((decimal)value, (decimal)comparer, property, notification);

		public PrometheanValidator IsBetween(float value, float from, float to, string property, int code) => IsBetween(value, from, to, property, NotificationMessage.ByCode(code));
		public PrometheanValidator IsBetween(float value, float from, float to, string property, INotificationMessage notification) => IsBetween((decimal)value, (decimal)from, (decimal)to, property, notification);
	}
}