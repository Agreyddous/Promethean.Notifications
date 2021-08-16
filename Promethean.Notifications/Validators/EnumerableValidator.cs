using System.Collections.Generic;
using System.Linq;
using Promethean.Notifications.Messages;
using Promethean.Notifications.Messages.Contracts;

namespace Promethean.Notifications.Validators
{
	public partial class PrometheanValidator
	{
		/// <summary>
		/// Add a notification for the <paramref name="property"/> with the <paramref name="code"/> if <paramref name="enumerable"/> has elements.
		/// </summary>

		/// <param name="enumerable">Enumerable to evaluate</param>
		/// <param name="property">Name of the property</param>
		/// <param name="code">Code for the notification</param>

		/// <typeparam name="T">The type of elements in the enumerable</typeparam>

		/// <returns>The Validator itself for chaining validations</returns>
		public PrometheanValidator IsNullOrEmpty<T>(IEnumerable<T> enumerable, string property, int code) => IsNullOrEmpty(enumerable, property, NotificationMessage.ByCode(code));

		/// <summary>
		/// Add the <paramref name="notification"/> for the <paramref name="property"/> if <paramref name="enumerable"/> has elements.
		/// </summary>

		/// <param name="enumerable">Enumerable to evaluate</param>
		/// <param name="property">Name of the property</param>
		/// <param name="notification">Code for the notification</param>

		/// <typeparam name="T">The type of elements in the enumerable</typeparam>

		/// <returns>The Validator itself for chaining validations</returns>
		public PrometheanValidator IsNullOrEmpty<T>(IEnumerable<T> enumerable, string property, INotificationMessage notification)
		{
			if ((enumerable?.Count() ?? 0) > 0)
				AddNotification(property, notification);

			return this;
		}

		/// <summary>
		/// Add a notification for the <paramref name="property"/> with the <paramref name="code"/> if <paramref name="enumerable"/> has no elements or is null.
		/// </summary>

		/// <param name="enumerable">Enumerable to evaluate</param>
		/// <param name="property">Name of the property</param>
		/// <param name="code">Code for the notification</param>

		/// <typeparam name="T">The type of elements in the enumerable</typeparam>

		/// <returns>The Validator itself for chaining validations</returns>
		public PrometheanValidator IsNotNullOrEmpty<T>(IEnumerable<T> enumerable, string property, int code) => IsNotNullOrEmpty(enumerable, property, NotificationMessage.ByCode(code));

		/// <summary>
		/// Add the <paramref name="notification"/> for the <paramref name="property"/> if <paramref name="enumerable"/> has no elements or is null.
		/// </summary>

		/// <param name="enumerable">Enumerable to evaluate</param>
		/// <param name="property">Name of the property</param>
		/// <param name="notification">Code for the notification</param>

		/// <typeparam name="T">The type of elements in the enumerable</typeparam>

		/// <returns>The Validator itself for chaining validations</returns>
		public PrometheanValidator IsNotNullOrEmpty<T>(IEnumerable<T> enumerable, string property, INotificationMessage notification)
		{
			if ((enumerable?.Count() ?? 0) == 0)
				AddNotification(property, notification);

			return this;
		}
	}
}