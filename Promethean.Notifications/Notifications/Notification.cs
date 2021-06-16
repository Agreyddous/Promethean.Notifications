using System;
using Promethean.Notifications.Contracts;
using Promethean.Notifications.Messages.Contracts;

namespace Promethean.Notifications
{
	public class Notification : INotification
	{
		protected Notification() { }

		public Notification(string property, INotificationMessage notification)
		{
			Property = property;
			Message = notification.Message;
			Code = notification.Code;
		}

		public Notification(Exception exception)
		{
			Property = "Error";
			Message = ExceptionMessage(exception);
			Code = -1;
		}

		public string Property { get; private set; }
		public string Message { get; private set; }
		public int Code { get; private set; }

		private string ExceptionMessage(Exception exception)
		{
			string message = exception.Message;

			while (exception.InnerException != null)
			{
				exception = exception.InnerException;
				message = $"{message} -> {exception.Message}";
			}

			return message;
		}
	}
}