using System;
using Promethean.Notifications.Messages;
using Promethean.Notifications.Messages.Contracts;

namespace Promethean.Notifications.Validators
{
	public partial class PrometheanValidator
	{
		/// <summary>
		///	Add a notification for the <paramref name="property"/> with the <paramref name="code"/> if <paramref name="value"/> is smaller or equal to <paramref name="comparer"/>.
		/// </summary>

		/// <param name="enumerable">DateTime to evaluate</param>
		/// <param name="comparer">DateTime to compare against <paramref name="value"/></param>
		/// <param name="property">Name of the property</param>
		/// <param name="code">Code for the notification</param>

		/// <returns>The Validator itself for chaining validations</returns>
		public PrometheanValidator IsGreaterThan(DateTime value, DateTime comparer, string property, int code) => IsGreaterThan(value, comparer, property, NotificationMessage.ByCode(code));

		/// <summary>
		///	Add the <paramref name="notification"/> for the <paramref name="property"/> if <paramref name="value"/> is smaller or equal to <paramref name="comparer"/>.
		/// </summary>

		/// <param name="enumerable">DateTime to evaluate</param>
		/// <param name="comparer">DateTime to compare against <paramref name="value"/></param>
		/// <param name="property">Name of the property</param>
		/// <param name="notification">Code for the notification</param>

		/// <returns>The Validator itself for chaining validations</returns>
		public PrometheanValidator IsGreaterThan(DateTime value, DateTime comparer, string property, INotificationMessage notification)
		{
			if (value <= comparer)
				AddNotification(property, notification);

			return this;
		}

		/// <summary>
		///	Add a notification for the <paramref name="property"/> with the <paramref name="code"/> if <paramref name="value"/> is smaller than <paramref name="comparer"/>.
		/// </summary>

		/// <param name="enumerable">DateTime to evaluate</param>
		/// <param name="comparer">DateTime to compare against <paramref name="value"/></param>
		/// <param name="property">Name of the property</param>
		/// <param name="code">Code for the notification</param>

		/// <returns>The Validator itself for chaining validations</returns>
		public PrometheanValidator IsGreaterOrEqualTo(DateTime value, DateTime comparer, string property, int code) => IsGreaterOrEqualTo(value, comparer, property, NotificationMessage.ByCode(code));

		/// <summary>
		///	Add the <paramref name="notification"/> for the <paramref name="property"/> if <paramref name="value"/> is smaller than <paramref name="comparer"/>.
		/// </summary>

		/// <param name="enumerable">DateTime to evaluate</param>
		/// <param name="comparer">DateTime to compare against <paramref name="value"/></param>
		/// <param name="property">Name of the property</param>
		/// <param name="notification">Code for the notification</param>

		/// <returns>The Validator itself for chaining validations</returns>
		public PrometheanValidator IsGreaterOrEqualTo(DateTime value, DateTime comparer, string property, INotificationMessage notification)
		{
			if (value < comparer)
				AddNotification(property, notification);

			return this;
		}

		/// <summary>
		///	Add a notification for the <paramref name="property"/> with the <paramref name="code"/> if <paramref name="value"/> is greater or equal to <paramref name="comparer"/>.
		/// </summary>

		/// <param name="enumerable">DateTime to evaluate</param>
		/// <param name="comparer">DateTime to compare against <paramref name="value"/></param>
		/// <param name="property">Name of the property</param>
		/// <param name="code">Code for the notification</param>

		/// <returns>The Validator itself for chaining validations</returns>
		public PrometheanValidator IsLowerThan(DateTime value, DateTime comparer, string property, int code) => IsLowerThan(value, comparer, property, NotificationMessage.ByCode(code));

		/// <summary>
		///	Add the <paramref name="notification"/> for the <paramref name="property"/> if <paramref name="value"/> is greater or equal to <paramref name="comparer"/>.
		/// </summary>

		/// <param name="enumerable">DateTime to evaluate</param>
		/// <param name="comparer">DateTime to compare against <paramref name="value"/></param>
		/// <param name="property">Name of the property</param>
		/// <param name="notification">Code for the notification</param>

		/// <returns>The Validator itself for chaining validations</returns>
		public PrometheanValidator IsLowerThan(DateTime value, DateTime comparer, string property, INotificationMessage notification)
		{
			if (value >= comparer)
				AddNotification(property, notification);

			return this;
		}

		/// <summary>
		///	Add a notification for the <paramref name="property"/> with the <paramref name="code"/> if <paramref name="value"/> is greater than <paramref name="comparer"/>.
		/// </summary>

		/// <param name="enumerable">DateTime to evaluate</param>
		/// <param name="comparer">DateTime to compare against <paramref name="value"/></param>
		/// <param name="property">Name of the property</param>
		/// <param name="code">Code for the notification</param>

		/// <returns>The Validator itself for chaining validations</returns>
		public PrometheanValidator IsLowerOrEqualTo(DateTime value, DateTime comparer, string property, int code) => IsLowerOrEqualTo(value, comparer, property, NotificationMessage.ByCode(code));

		/// <summary>
		///	Add the <paramref name="notification"/> for the <paramref name="property"/> if <paramref name="value"/> is greater than <paramref name="comparer"/>.
		/// </summary>

		/// <param name="enumerable">DateTime to evaluate</param>
		/// <param name="comparer">DateTime to compare against <paramref name="value"/></param>
		/// <param name="property">Name of the property</param>
		/// <param name="notification">Code for the notification</param>

		/// <returns>The Validator itself for chaining validations</returns>
		public PrometheanValidator IsLowerOrEqualTo(DateTime value, DateTime comparer, string property, INotificationMessage notification)
		{
			if (value > comparer)
				AddNotification(property, notification);

			return this;
		}

		/// <summary>
		///	Add a notification for the <paramref name="property"/> with the <paramref name="code"/> if <paramref name="value"/> is not greater than <paramref name="from"/> and smaller than <paramref name="to"/>.
		/// </summary>

		/// <param name="enumerable">DateTime to evaluate</param>
		/// <param name="from">Stater DateTime</param>
		/// <param name="to">Final DateTime</param>
		/// <param name="property">Name of the property</param>
		/// <param name="code">Code for the notification</param>

		/// <returns>The Validator itself for chaining validations</returns>
		public PrometheanValidator IsBetween(DateTime value, DateTime from, DateTime to, string property, int code) => IsBetween(value, from, to, property, NotificationMessage.ByCode(code));

		/// <summary>
		///	Add the <paramref name="notification"/> for the <paramref name="property"/> if <paramref name="value"/> is not greater than <paramref name="from"/> and smaller than <paramref name="to"/>.
		/// </summary>

		/// <param name="enumerable">DateTime to evaluate</param>
		/// <param name="from">Stater DateTime</param>
		/// <param name="to">Final DateTime</param>
		/// <param name="property">Name of the property</param>
		/// <param name="notification">Code for the notification</param>

		/// <returns>The Validator itself for chaining validations</returns>
		public PrometheanValidator IsBetween(DateTime value, DateTime from, DateTime to, string property, INotificationMessage notification)
		{
			if (!(value > from && value < to))
				AddNotification(property, notification);

			return this;
		}

	}
}