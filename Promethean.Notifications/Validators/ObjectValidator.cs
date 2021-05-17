namespace Promethean.Notifications.Validators
{
	public partial class Validator
	{
		public Validator IsNull(object obj, string property, NotificationMessage notification)
		{
			if (obj != null)
				AddNotification(property, notification);

			return this;
		}

		public Validator IsNotNull(object obj, string property, NotificationMessage notification)
		{
			if (obj == null)
				AddNotification(property, notification);

			return this;
		}

		public Validator AreEqual(object obj, object comparer, string property, NotificationMessage notification)
		{
			if (obj != comparer)
				AddNotification(property, notification);

			return this;
		}

		public Validator AreNotEqual(object obj, object comparer, string property, NotificationMessage notification)
		{
			if (obj == comparer)
				AddNotification(property, notification);

			return this;
		}
	}
}