using System.Collections.Generic;
using Promethean.Notifications.Messages.Enums;

namespace Promethean.Notifications.Messages
{
	public partial class NotificationMessage
	{
		private static SortedList<int, NotificationMessage> _messages;

		static NotificationMessage()
		{
			_messages = new SortedList<int, NotificationMessage>();

			new NotificationMessage(ECodes.SomethingWrong, "Something went wrong on our side...");
			new NotificationMessage(ECodes.InvalidId, "Id value isn't valid");
			new NotificationMessage(ECodes.Null, "Value is null");
			new NotificationMessage(ECodes.NullOrEmpty, "Value is null or empty");
			new NotificationMessage(ECodes.NotNull, "Value is not null");
			new NotificationMessage(ECodes.NotNullOrEmpty, "Value is not null or empty");
			new NotificationMessage(ECodes.SmallNumber, "Value is too small");
			new NotificationMessage(ECodes.BigNumber, "Value is too big");
			new NotificationMessage(ECodes.NotEnough, "Value is Not Enough");
			new NotificationMessage(ECodes.InvalidFormat, "Format is invalid");
			new NotificationMessage(ECodes.IncorrectLength, "Length is invalid");
			new NotificationMessage(ECodes.TooMany, "Too Many");
			new NotificationMessage(ECodes.TooLittle, "Too Little");
			new NotificationMessage(ECodes.Invalid, "Invalid");
			new NotificationMessage(ECodes.Equal, "Equal");
			new NotificationMessage(ECodes.NotEqual, "Not equal");
			new NotificationMessage(ECodes.AlreadyInUse, "Already in use");
			new NotificationMessage(ECodes.Empty, "Empty");
		}

		public static NotificationMessage ByCode(ECodes code) => ByCode((int)code);
		public static NotificationMessage ByCode(int code) => _messages[code];

		public static NotificationMessage SomethingWrong => ByCode(ECodes.SomethingWrong);
		public static NotificationMessage InvalidId => ByCode(ECodes.InvalidId);
		public static NotificationMessage Null => ByCode(ECodes.Null);
		public static NotificationMessage NullOrEmpty => ByCode(ECodes.NullOrEmpty);
		public static NotificationMessage NotNull => ByCode(ECodes.NotNull);
		public static NotificationMessage NotNullOrEmpty => ByCode(ECodes.NotNullOrEmpty);
		public static NotificationMessage SmallNumber => ByCode(ECodes.SmallNumber);
		public static NotificationMessage BigNumber => ByCode(ECodes.BigNumber);
		public static NotificationMessage NotEnough => ByCode(ECodes.NotEnough);
		public static NotificationMessage InvalidFormat => ByCode(ECodes.InvalidFormat);
		public static NotificationMessage IncorrectLength => ByCode(ECodes.IncorrectLength);
		public static NotificationMessage TooMany => ByCode(ECodes.TooMany);
		public static NotificationMessage TooLittle => ByCode(ECodes.TooLittle);
		public static NotificationMessage Invalid => ByCode(ECodes.Invalid);
		public static NotificationMessage Equal => ByCode(ECodes.Equal);
		public static NotificationMessage NotEqual => ByCode(ECodes.NotEqual);
		public static NotificationMessage AlreadyInUse => ByCode(ECodes.AlreadyInUse);
		public static NotificationMessage Empty => ByCode(ECodes.Empty);
	}
}