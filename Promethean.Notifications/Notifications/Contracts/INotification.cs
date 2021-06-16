namespace Promethean.Notifications.Contracts
{
	public interface INotification
	{
		string Property { get; }
		string Message { get; }
		int Code { get; }
	}
}