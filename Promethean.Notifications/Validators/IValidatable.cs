namespace Promethean.Notifications.Validators
{
	public interface IValidatable : INotifiable
	{
		void Validate();
	}
}