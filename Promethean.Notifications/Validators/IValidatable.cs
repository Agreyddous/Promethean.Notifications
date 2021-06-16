using Promethean.Notifications.Contracts;

namespace Promethean.Notifications.Validators
{
	public interface IValidatable : INotifiable
	{
		void Validate();
	}
}