namespace Promethean.Notifications.Validators
{
	public partial class Validator : Notifiable
	{
		public static implicit operator bool(Validator validator) => validator.Valid;

		public static string EmailValidationPattern => @"^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$";
		public static string URLValidationPattern => @"^(http:\/\/www\.|https:\/\/www\.|http:\/\/|https:\/\/)[a-z0-9]+([\-\.]{1}[a-z0-9]+)*\.[a-z]{2,5}(:[0-9]{1,5})?(\/.*)?$";
	}
}