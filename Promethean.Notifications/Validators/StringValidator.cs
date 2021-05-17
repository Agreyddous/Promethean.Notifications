using System.Text.RegularExpressions;
namespace Promethean.Notifications.Validators
{
	public partial class Validator
	{
		public Validator IsNotNullOrEmpty(string value, string property, NotificationMessage notification)
		{
			if (string.IsNullOrEmpty(value))
				AddNotification(property, notification);

			return this;
		}

		public Validator IsNullOrEmpty(string value, string property, NotificationMessage notification)
		{
			if (!string.IsNullOrEmpty(value))
				AddNotification(property, notification);

			return this;
		}

		public Validator IsNotNullOrWhiteSpace(string value, string property, NotificationMessage notification)
		{
			if (string.IsNullOrWhiteSpace(value))
				AddNotification(property, notification);

			return this;
		}

		public Validator IsNullOrWhiteSpace(string value, string property, NotificationMessage notification)
		{
			if (!string.IsNullOrWhiteSpace(value))
				AddNotification(property, notification);

			return this;
		}

		public Validator HasMinLen(string value, int min, string property, NotificationMessage notification)
		{
			if ((value ?? "").Length < min)
				AddNotification(property, notification);

			return this;
		}

		public Validator HasMaxLen(string value, int max, string property, NotificationMessage notification)
		{
			if ((value ?? "").Length > max)
				AddNotification(property, notification);

			return this;
		}

		public Validator HasLen(string value, int len, string property, NotificationMessage notification)
		{
			if ((value ?? "").Length != len)
				AddNotification(property, notification);

			return this;
		}

		public Validator Contains(string value, string text, string property, NotificationMessage notification)
		{
			if (!(value ?? "").Contains(text))
				AddNotification(property, notification);

			return this;
		}

		public Validator AreEqual(string value, string text, string property, NotificationMessage notification)
		{
			if (value != text)
				AddNotification(property, notification);

			return this;
		}

		public Validator AreNotEqual(string value, string text, string property, NotificationMessage notification)
		{
			if (value == text)
				AddNotification(property, notification);

			return this;
		}

		public Validator IsEmail(string email, string property, NotificationMessage notification)
		{
			const string pattern = @"^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$";
			return Matchs(email, pattern, property, notification);
		}

		public Validator IsEmailOrEmpty(string email, string property, NotificationMessage notification)
		{
			if (string.IsNullOrEmpty(email))
				return this;

			return IsEmail(email, property, notification);
		}

		public Validator IsUrl(string url, string property, NotificationMessage notification)
		{
			const string pattern = @"^(http:\/\/www\.|https:\/\/www\.|http:\/\/|https:\/\/)[a-z0-9]+([\-\.]{1}[a-z0-9]+)*\.[a-z]{2,5}(:[0-9]{1,5})?(\/.*)?$";
			return Matchs(url, pattern, property, notification);
		}

		public Validator IsUrlOrEmpty(string url, string property, NotificationMessage notification)
		{
			if (string.IsNullOrEmpty(url))
				return this;

			return IsUrl(url, property, notification);
		}

		public Validator Matchs(string text, string pattern, string property, NotificationMessage notification)
		{
			if (!Regex.IsMatch(text ?? "", pattern))
				AddNotification(property, notification);

			return this;
		}
	}
}