using System.Collections.Generic;

namespace Promethean.Notifications
{
	public partial class NotificationMessage
	{
		public static NotificationMessage SomethingWrong = new NotificationMessage(-1, "Something went wrong on our side...");
		public static NotificationMessage InvalidId = new NotificationMessage(1, "Id value isn't valid");
		public static NotificationMessage Null = new NotificationMessage(2, "Value is null");
		public static NotificationMessage NullOrEmpty = new NotificationMessage(3, "Value is null or empty");
		public static NotificationMessage NotNull = new NotificationMessage(4, "Value is not null");
		public static NotificationMessage NotNullOrEmpty = new NotificationMessage(5, "Value is not null or empty");
		public static NotificationMessage SmallNumber = new NotificationMessage(6, "Value is too small");
		public static NotificationMessage BigNumber = new NotificationMessage(7, "Value is too big");
		public static NotificationMessage NotEnough = new NotificationMessage(8, "Value is Not Enough");
		public static NotificationMessage InvalidFormat = new NotificationMessage(9, "Format is invalid");
		public static NotificationMessage IncorrectLength = new NotificationMessage(10, "Length is invalid");
		public static NotificationMessage TooMany = new NotificationMessage(11, "Too Many");
		public static NotificationMessage TooLittle = new NotificationMessage(12, "Too Little");
		public static NotificationMessage Invalid = new NotificationMessage(13, "Invalid");
		public static NotificationMessage Equal = new NotificationMessage(14, "Equal");
		public static NotificationMessage NotEqual = new NotificationMessage(15, "Not equal");
	}
}