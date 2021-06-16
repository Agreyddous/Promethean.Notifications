using Promethean.Notifications.Messages;
using Promethean.Notifications.Messages.Contracts;

namespace Promethean.Notifications.Validators
{
	public partial class Validator
	{
		public Validator IsGreaterThan(double value, double comparer, string property, int code) => IsGreaterThan(value, comparer, property, NotificationMessage.ByCode(code));
		public Validator IsGreaterThan(double value, double comparer, string property, INotificationMessage notification) => IsGreaterThan((decimal)value, (decimal)comparer, property, notification);

		public Validator IsGreaterOrEqualTo(double value, double comparer, string property, int code) => IsGreaterOrEqualTo(value, comparer, property, NotificationMessage.ByCode(code));
		public Validator IsGreaterOrEqualTo(double value, double comparer, string property, INotificationMessage notification) => IsGreaterOrEqualTo((decimal)value, (decimal)comparer, property, notification);

		public Validator IsLowerThan(double value, double comparer, string property, int code) => IsLowerThan(value, comparer, property, NotificationMessage.ByCode(code));
		public Validator IsLowerThan(double value, double comparer, string property, INotificationMessage notification) => IsLowerThan((decimal)value, (decimal)comparer, property, notification);

		public Validator IsLowerOrEqualTo(double value, double comparer, string property, int code) => IsLowerOrEqualTo(value, comparer, property, NotificationMessage.ByCode(code));
		public Validator IsLowerOrEqualTo(double value, double comparer, string property, INotificationMessage notification) => IsLowerOrEqualTo((decimal)value, (decimal)comparer, property, notification);

		public Validator AreEqual(double value, double comparer, string property, int code) => AreEqual(value, comparer, property, NotificationMessage.ByCode(code));
		public Validator AreEqual(double value, double comparer, string property, INotificationMessage notification) => AreEqual((decimal)value, (decimal)comparer, property, notification);

		public Validator IsBetween(double value, double from, double to, string property, int code) => IsBetween(value, from, to, property, NotificationMessage.ByCode(code));
		public Validator IsBetween(double value, double from, double to, string property, INotificationMessage notification) => IsBetween((decimal)value, (decimal)from, (decimal)to, property, notification);
	}
}