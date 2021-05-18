using System;
using Promethean.Notifications.Validators;

namespace Promethean.Notifications.Tests.Helpers
{
	public class NotifiableClass : Notifiable, IValidatable
	{
		public NotifiableClass(string username, long points, int level, decimal balance, bool member, DateTime createdAt, object @class)
		{
			Username = username;
			Points = points;
			Level = level;
			Balance = balance;
			Member = member;
			CreatedAt = createdAt;
			Class = @class;

			Validate();
		}

		public string Username { get; private set; }
		public long Points { get; private set; }
		public int Level { get; private set; }
		public decimal Balance { get; private set; }
		public bool Member { get; private set; }
		public DateTime CreatedAt { get; private set; }
		public object Class { get; private set; }

		public void Validate()
		{
			Validator validator = new Validator();

			validator.IsNotNullOrEmpty(Username, nameof(Username), NotificationMessage.NullOrEmpty);
			validator.HasMaxLength(Username, 30, nameof(Username), NotificationMessage.IncorrectLength);

			validator.IsGreaterOrEqualTo(Points, 0, nameof(Points), NotificationMessage.SmallNumber);
			validator.IsLowerOrEqualTo(Points, 999, nameof(Points), NotificationMessage.BigNumber);

			validator.IsGreaterOrEqualTo(Level, 0, nameof(Points), NotificationMessage.SmallNumber);
			validator.IsLowerOrEqualTo(Level, 145, nameof(Points), NotificationMessage.BigNumber);

			validator.IsGreaterOrEqualTo(Balance, 0, nameof(Points), NotificationMessage.SmallNumber);
			validator.IsLowerOrEqualTo(Balance, (decimal)999999.99, nameof(Points), NotificationMessage.BigNumber);

			validator.IsGreaterOrEqualTo(CreatedAt, new DateTime(), nameof(CreatedAt), NotificationMessage.Invalid);

			validator.IsNotNull(Class, nameof(Class), NotificationMessage.Null);

			AddNotifications(validator);
		}
	}
}