using System.Text.RegularExpressions;
using Promethean.Notifications.Messages;
using Promethean.Notifications.Messages.Contracts;

namespace Promethean.Notifications.Validators
{
	public partial class PrometheanValidator
	{
		public PrometheanValidator IsNotNullOrEmpty(string value, string property, int code) => IsNotNullOrEmpty(value, property, NotificationMessage.ByCode(code));
		public PrometheanValidator IsNotNullOrEmpty(string value, string property, INotificationMessage notification)
		{
			if (string.IsNullOrEmpty(value?.Trim()))
				AddNotification(property, notification);

			return this;
		}

		public PrometheanValidator IsNullOrEmpty(string value, string property, int code) => IsNullOrEmpty(value, property, NotificationMessage.ByCode(code));
		public PrometheanValidator IsNullOrEmpty(string value, string property, INotificationMessage notification)
		{
			if (!string.IsNullOrEmpty(value?.Trim()))
				AddNotification(property, notification);

			return this;
		}

		public PrometheanValidator HasMinLength(string value, int min, string property, int code) => HasMinLength(value, min, property, NotificationMessage.ByCode(code));
		public PrometheanValidator HasMinLength(string value, int min, string property, INotificationMessage notification)
		{
			if (value == null ? false : value.Length < min)
				AddNotification(property, notification);

			return this;
		}

		public PrometheanValidator HasMaxLength(string value, int max, string property, int code) => HasMaxLength(value, max, property, NotificationMessage.ByCode(code));
		public PrometheanValidator HasMaxLength(string value, int max, string property, INotificationMessage notification)
		{
			if (value == null ? false : value.Length > max)
				AddNotification(property, notification);

			return this;
		}

		public PrometheanValidator HasLength(string value, int length, string property, int code) => HasLength(value, length, property, NotificationMessage.ByCode(code));
		public PrometheanValidator HasLength(string value, int length, string property, INotificationMessage notification)
		{
			if (value == null ? false : value.Length != length)
				AddNotification(property, notification);

			return this;
		}

		public PrometheanValidator Contains(string value, string text, string property, int code) => Contains(value, text, property, NotificationMessage.ByCode(code));
		public PrometheanValidator Contains(string value, string text, string property, INotificationMessage notification)
		{
			if (value == null ? false : !value.Contains(text))
				AddNotification(property, notification);

			return this;
		}

		public PrometheanValidator AreEqual(string value, string text, string property, int code) => AreEqual(value, text, property, NotificationMessage.ByCode(code));
		public PrometheanValidator AreEqual(string value, string text, string property, INotificationMessage notification)
		{
			if (!value?.Equals(text) ?? false)
				AddNotification(property, notification);

			return this;
		}

		public PrometheanValidator AreNotEqual(string value, string text, string property, int code) => AreNotEqual(value, text, property, NotificationMessage.ByCode(code));
		public PrometheanValidator AreNotEqual(string value, string text, string property, INotificationMessage notification)
		{
			if (value?.Equals(text) ?? false)
				AddNotification(property, notification);

			return this;
		}

		public PrometheanValidator IsEmail(string email, string property, int code) => IsEmail(email, property, NotificationMessage.ByCode(code));
		public PrometheanValidator IsEmail(string email, string property, INotificationMessage notification) => Matchs(email, EmailValidationPattern, property, notification);

		public PrometheanValidator IsUrl(string url, string property, int code) => IsUrl(url, property, NotificationMessage.ByCode(code));
		public PrometheanValidator IsUrl(string url, string property, INotificationMessage notification) => Matchs(url, URLValidationPattern, property, notification);

		public PrometheanValidator Matchs(string text, string pattern, string property, int code) => Matchs(text, pattern, property, NotificationMessage.ByCode(code));
		public PrometheanValidator Matchs(string text, string pattern, string property, INotificationMessage notification)
		{
			if (text == null || !Regex.IsMatch(text ?? "", pattern))
				AddNotification(property, notification);

			return this;
		}
	}
}