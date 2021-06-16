using System.Text.RegularExpressions;
using Promethean.Notifications.Messages;
using Promethean.Notifications.Messages.Contracts;

namespace Promethean.Notifications.Validators
{
	public partial class Validator
	{
		public Validator IsNotNullOrEmpty(string value, string property, int code) => IsNotNullOrEmpty(value, property, NotificationMessage.ByCode(code));
		public Validator IsNotNullOrEmpty(string value, string property, INotificationMessage notification)
		{
			if (string.IsNullOrEmpty(value?.Trim()))
				AddNotification(property, notification);

			return this;
		}

		public Validator IsNullOrEmpty(string value, string property, int code) => IsNullOrEmpty(value, property, NotificationMessage.ByCode(code));
		public Validator IsNullOrEmpty(string value, string property, INotificationMessage notification)
		{
			if (!string.IsNullOrEmpty(value?.Trim()))
				AddNotification(property, notification);

			return this;
		}

		public Validator HasMinLength(string value, int min, string property, int code) => HasMinLength(value, min, property, NotificationMessage.ByCode(code));
		public Validator HasMinLength(string value, int min, string property, INotificationMessage notification)
		{
			if (value == null ? false : value.Length < min)
				AddNotification(property, notification);

			return this;
		}

		public Validator HasMaxLength(string value, int max, string property, int code) => HasMaxLength(value, max, property, NotificationMessage.ByCode(code));
		public Validator HasMaxLength(string value, int max, string property, INotificationMessage notification)
		{
			if (value == null ? false : value.Length > max)
				AddNotification(property, notification);

			return this;
		}

		public Validator HasLength(string value, int length, string property, int code) => HasLength(value, length, property, NotificationMessage.ByCode(code));
		public Validator HasLength(string value, int length, string property, INotificationMessage notification)
		{
			if (value == null ? false : value.Length != length)
				AddNotification(property, notification);

			return this;
		}

		public Validator Contains(string value, string text, string property, int code) => Contains(value, text, property, NotificationMessage.ByCode(code));
		public Validator Contains(string value, string text, string property, INotificationMessage notification)
		{
			if (value == null ? false : !value.Contains(text))
				AddNotification(property, notification);

			return this;
		}

		public Validator AreEqual(string value, string text, string property, int code) => AreEqual(value, text, property, NotificationMessage.ByCode(code));
		public Validator AreEqual(string value, string text, string property, INotificationMessage notification)
		{
			if (!value?.Equals(text) ?? false)
				AddNotification(property, notification);

			return this;
		}

		public Validator AreNotEqual(string value, string text, string property, int code) => AreNotEqual(value, text, property, NotificationMessage.ByCode(code));
		public Validator AreNotEqual(string value, string text, string property, INotificationMessage notification)
		{
			if (value?.Equals(text) ?? false)
				AddNotification(property, notification);

			return this;
		}

		public Validator IsEmail(string email, string property, int code) => IsEmail(email, property, NotificationMessage.ByCode(code));
		public Validator IsEmail(string email, string property, INotificationMessage notification) => Matchs(email, EmailValidationPattern, property, notification);

		public Validator IsUrl(string url, string property, int code) => IsUrl(url, property, NotificationMessage.ByCode(code));
		public Validator IsUrl(string url, string property, INotificationMessage notification) => Matchs(url, URLValidationPattern, property, notification);

		public Validator Matchs(string text, string pattern, string property, int code) => Matchs(text, pattern, property, NotificationMessage.ByCode(code));
		public Validator Matchs(string text, string pattern, string property, INotificationMessage notification)
		{
			if (text == null || !Regex.IsMatch(text ?? "", pattern))
				AddNotification(property, notification);

			return this;
		}
	}
}