using Promethean.Notifications.Messages;
using Promethean.Notifications.Messages.Contracts;

namespace Promethean.Notifications.Validators
{
	public partial class PrometheanValidator
	{
		/// <summary>
		/// Add a notification for the <paramref name="property"/> with the <paramref name="code"/> if <paramref name="value"/> is not true.
		/// </summary>

		/// <param name="enumerable">Bool to evaluate</param>
		/// <param name="property">Name of the property</param>
		/// <param name="code">Code for the notification</param>

		/// <returns>The Validator itself for chaining validations</returns>
		public PrometheanValidator IsTrue(bool value, string property, int code) => IsTrue(value, property, NotificationMessage.ByCode(code));

		/// <summary>
		/// Add the <paramref name="notification"/> for the <paramref name="property"/> if <paramref name="value"/> is not true.
		/// </summary>

		/// <param name="enumerable">Bool to evaluate</param>
		/// <param name="property">Name of the property</param>
		/// <param name="notification">Code for the notification</param>

		/// <returns>The Validator itself for chaining validations</returns>
		public PrometheanValidator IsTrue(bool value, string property, INotificationMessage notification)
		{
			if (!value)
				AddNotification(property, notification);

			return this;
		}

		/// <summary>
		/// Add a notification for the <paramref name="property"/> with the <paramref name="code"/> if <paramref name="value"/> is true.
		/// </summary>

		/// <param name="enumerable">Bool to evaluate</param>
		/// <param name="property">Name of the property</param>
		/// <param name="code">Code for the notification</param>

		/// <returns>The Validator itself for chaining validations</returns>
		public PrometheanValidator IsFalse(bool value, string property, int code) => IsFalse(value, property, NotificationMessage.ByCode(code));

		/// <summary>
		/// Add the <paramref name="notification"/> for the <paramref name="property"/> if <paramref name="value"/> is true.
		/// </summary>

		/// <param name="enumerable">Bool to evaluate</param>
		/// <param name="property">Name of the property</param>
		/// <param name="notification">Code for the notification</param>

		/// <returns>The Validator itself for chaining validations</returns>
		public PrometheanValidator IsFalse(bool value, string property, INotificationMessage notification)
		{
			if (value)
				AddNotification(property, notification);

			return this;
		}
	}
}