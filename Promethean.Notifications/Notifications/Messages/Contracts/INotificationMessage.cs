namespace Promethean.Notifications.Messages.Contracts
{
	public interface INotificationMessage
	{
		int Code { get; }
		string Message { get; }
	}
}