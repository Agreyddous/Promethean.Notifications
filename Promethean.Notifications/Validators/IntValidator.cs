using Promethean.Notifications.Messages;
using Promethean.Notifications.Messages.Contracts;

namespace Promethean.Notifications.Validators
{
	public partial class Validator
	{
		public Validator IsGreaterThan(int value, int comparer, string property, int code) => IsGreaterThan(value, comparer, property, NotificationMessage.ByCode(code));
		public Validator IsGreaterThan(int value, int comparer, string property, INotificationMessage notification) => IsGreaterThan((decimal)value, (decimal)comparer, property, notification);

		public Validator IsGreaterOrEqualTo(int value, int comparer, string property, int code) => IsGreaterOrEqualTo(value, comparer, property, NotificationMessage.ByCode(code));
		public Validator IsGreaterOrEqualTo(int value, int comparer, string property, INotificationMessage notification) => IsGreaterOrEqualTo((decimal)value, (decimal)comparer, property, notification);

		public Validator IsLowerThan(int value, int comparer, string property, int code) => IsLowerThan(value, comparer, property, NotificationMessage.ByCode(code));
		public Validator IsLowerThan(int value, int comparer, string property, INotificationMessage notification) => IsLowerThan((decimal)value, (decimal)comparer, property, notification);

		public Validator IsLowerOrEqualTo(int value, int comparer, string property, int code) => IsLowerOrEqualTo(value, comparer, property, NotificationMessage.ByCode(code));
		public Validator IsLowerOrEqualTo(int value, int comparer, string property, INotificationMessage notification) => IsLowerOrEqualTo((decimal)value, (decimal)comparer, property, notification);

		public Validator AreEqual(int value, int comparer, string property, int code) => AreEqual(value, comparer, property, NotificationMessage.ByCode(code));
		public Validator AreEqual(int value, int comparer, string property, INotificationMessage notification) => AreEqual((decimal)value, (decimal)comparer, property, notification);

		public Validator IsBetween(int value, int from, int to, string property, int code) => IsBetween(value, from, to, property, NotificationMessage.ByCode(code));
		public Validator IsBetween(int value, int from, int to, string property, INotificationMessage notification) => IsBetween((decimal)value, (decimal)from, (decimal)to, property, notification);
	}
}