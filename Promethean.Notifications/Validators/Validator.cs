namespace Promethean.Notifications.Validators
{
	public partial class Validator : Notifiable
	{
		public static implicit operator bool(Validator validator) => validator.Valid;
	}
}