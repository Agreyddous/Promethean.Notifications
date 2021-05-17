using System.Collections.Generic;

namespace Promethean.Notifications
{
	public interface INotifiable
	{
		bool Valid { get; }
		IReadOnlyCollection<Notification> Notifications { get; }
	}
}