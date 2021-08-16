using Microsoft.VisualStudio.TestTools.UnitTesting;
using Promethean.Notifications.Messages;
using Promethean.Notifications.Validators;

namespace Promethean.Notifications.Tests.Validators
{
	[TestClass]
	public class BoolValidatorTests
	{
		private PrometheanValidator _validator;

		[TestInitialize]
		public void Setup() => _validator = new PrometheanValidator();

		[TestMethod("Valid IsTrue test, should have no notifications")]
		[TestCategory("Valid Executions")]
		public void ValidIsTrue()
		{
			_validator.IsTrue(true, Faker.Lorem.GetFirstWord(), NotificationMessage.Invalid);

			Assert.IsTrue(_validator.Valid);
		}

		[TestMethod("Valid IsFalse test, should have no notifications")]
		[TestCategory("Valid Executions")]
		public void ValidIsFalse()
		{
			_validator.IsFalse(false, Faker.Lorem.GetFirstWord(), NotificationMessage.Invalid);

			Assert.IsTrue(_validator.Valid);
		}

		[TestMethod("Invalid IsTrue test, should have a notification")]
		[TestCategory("Invalid Executions")]
		public void InvalidIsTrue()
		{
			_validator.IsTrue(false, Faker.Lorem.GetFirstWord(), NotificationMessage.Invalid);

			Assert.IsFalse(_validator.Valid);
			Assert.AreEqual(1, _validator.Notifications.Count);
		}

		[TestMethod("Invalid IsFalse test, should have a notification")]
		[TestCategory("Invalid Executions")]
		public void InvalidIsFalse()
		{
			_validator.IsFalse(true, Faker.Lorem.GetFirstWord(), NotificationMessage.Invalid);

			Assert.IsFalse(_validator.Valid);
			Assert.AreEqual(1, _validator.Notifications.Count);
		}
	}
}