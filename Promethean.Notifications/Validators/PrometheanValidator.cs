namespace Promethean.Notifications.Validators
{
	public partial class PrometheanValidator : Notifiable
	{
		public static implicit operator bool(PrometheanValidator validator) => validator.Valid;

		/// <summary>
		/// Pattern used on email validations.
		/// </summary>

		/// <value>
		/// ^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$
		/// </value>
		public static string EmailValidationPattern => @"^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$";

		/// <summary>
		/// Pattern used on URL validations.
		/// </summary>
		///
		/// <value>
		/// ^(http:\/\/www\.|https:\/\/www\.|http:\/\/|https:\/\/)[a-z0-9]+([\-\.]{1}[a-z0-9]+)*\.[a-z]{2,5}(:[0-9]{1,5})?(\/.*)?$
		/// </value>
		public static string URLValidationPattern => @"^(http:\/\/www\.|https:\/\/www\.|http:\/\/|https:\/\/)[a-z0-9]+([\-\.]{1}[a-z0-9]+)*\.[a-z]{2,5}(:[0-9]{1,5})?(\/.*)?$";
	}
}