using Promethean.Notifications.Contracts;

namespace Promethean.Notifications.Validators.Contracts
{
	public interface IValidatable : INotifiable
	{
		void Validate();
	}
}