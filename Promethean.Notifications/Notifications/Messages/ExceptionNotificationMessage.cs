using System;
using System.Diagnostics.CodeAnalysis;
using Promethean.Notifications.Messages.Contracts;
using Promethean.Notifications.Settings;

namespace Promethean.Notifications.Messages
{
	public class ExceptionNotificationMessage : INotificationMessage
	{
		public ExceptionNotificationMessage([NotNull] Exception exception) => Message = _extractMessage(exception);

		public int Code => NotificationSettings.ErrorCode;

		public string Message { get; private set; }

		private string _extractMessage(Exception exception) => $"{NotificationSettings.ErrorMessageFormat(exception)}{(exception.InnerException != null ? NotificationSettings.NestedErrorMessagesSeparator + _extractMessage(exception.InnerException) : string.Empty)}";
	}
}