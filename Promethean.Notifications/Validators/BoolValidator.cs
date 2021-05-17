namespace Promethean.Notifications.Validators
{
	public partial class Validator
	{
		public Validator IsTrue(bool value, string property, NotificationMessage notification)
		{
			if (!value)
				AddNotification(property, notification);

			return this;
		}

		public Validator IsFalse(bool value, string property, NotificationMessage notification)
		{
			if (value)
				AddNotification(property, notification);

			return this;
		}
	}
}