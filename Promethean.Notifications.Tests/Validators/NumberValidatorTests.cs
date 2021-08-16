using Microsoft.VisualStudio.TestTools.UnitTesting;
using Promethean.Notifications.Messages;
using Promethean.Notifications.Validators;

namespace Promethean.Notifications.Tests.Validators
{
	[TestClass]
	public class NumberValidatorTests
	{
		private PrometheanValidator _validator;

		[TestInitialize]
		public void Setup() => _validator = new PrometheanValidator();

		[TestMethod("Valid IsGreaterThan test, should have no notifications")]
		[TestCategory("Valid Executions")]
		public void ValidIsGreaterThan()
		{
			_validator.IsGreaterThan(1, 0, Faker.Lorem.GetFirstWord(), NotificationMessage.SmallNumber);

			Assert.IsTrue(_validator.Valid);
		}

		[TestMethod("Valid IsGreaterOrEqualTo test, should have no notifications")]
		[TestCategory("Valid Executions")]
		public void ValidIsGreaterOrEqualTo()
		{
			_validator.IsGreaterOrEqualTo(1, 1, Faker.Lorem.GetFirstWord(), NotificationMessage.SmallNumber);

			Assert.IsTrue(_validator.Valid);
		}

		[TestMethod("Valid IsLowerThan test, should have no notifications")]
		[TestCategory("Valid Executions")]
		public void ValidIsLowerThan()
		{
			_validator.IsLowerThan(0, 1, Faker.Lorem.GetFirstWord(), NotificationMessage.BigNumber);

			Assert.IsTrue(_validator.Valid);
		}

		[TestMethod("Valid IsLowerOrEqualTo test, should have no notifications")]
		[TestCategory("Valid Executions")]
		public void ValidIsLowerOrEqualTo()
		{
			_validator.IsLowerOrEqualTo(0, 0, Faker.Lorem.GetFirstWord(), NotificationMessage.BigNumber);

			Assert.IsTrue(_validator.Valid);
		}

		[TestMethod("Valid AreEqual test, should have no notifications")]
		[TestCategory("Valid Executions")]
		public void ValidAreEqual()
		{
			_validator.AreEqual(1, 1, Faker.Lorem.GetFirstWord(), NotificationMessage.Invalid);

			Assert.IsTrue(_validator.Valid);
		}

		[TestMethod("Valid IsBetween test, should have no notifications")]
		[TestCategory("Valid Executions")]
		public void ValidIsBetween()
		{
			_validator.IsBetween(1, 0, 2, Faker.Lorem.GetFirstWord(), NotificationMessage.SmallNumber);

			Assert.IsTrue(_validator.Valid);
		}

		[TestMethod("Invalid IsGreaterThan test, should have a notification")]
		[TestCategory("Invalid Executions")]
		public void InvalidIsGreaterThan()
		{
			_validator.IsGreaterThan(0, 1, Faker.Lorem.GetFirstWord(), NotificationMessage.SmallNumber);

			Assert.IsFalse(_validator.Valid);
			Assert.AreEqual(1, _validator.Notifications.Count);
		}

		[TestMethod("Invalid IsGreaterOrEqualTo test, should have a notification")]
		[TestCategory("Invalid Executions")]
		public void InvalidIsGreaterOrEqualTo()
		{
			_validator.IsGreaterOrEqualTo(0, 1, Faker.Lorem.GetFirstWord(), NotificationMessage.SmallNumber);

			Assert.IsFalse(_validator.Valid);
			Assert.AreEqual(1, _validator.Notifications.Count);
		}

		[TestMethod("Invalid IsLowerThan test, should have a notification")]
		[TestCategory("Invalid Executions")]
		public void InvalidIsLowerThan()
		{
			_validator.IsLowerThan(1, 0, Faker.Lorem.GetFirstWord(), NotificationMessage.BigNumber);

			Assert.IsFalse(_validator.Valid);
			Assert.AreEqual(1, _validator.Notifications.Count);
		}

		[TestMethod("Invalid IsLowerOrEqualTo test, should have a notification")]
		[TestCategory("Invalid Executions")]
		public void InvalidIsLowerOrEqualTo()
		{
			_validator.IsLowerOrEqualTo(1, 0, Faker.Lorem.GetFirstWord(), NotificationMessage.BigNumber);

			Assert.IsFalse(_validator.Valid);
			Assert.AreEqual(1, _validator.Notifications.Count);
		}

		[TestMethod("Invalid AreEqual test, should have a notification")]
		[TestCategory("Invalid Executions")]
		public void InvalidAreEqual()
		{
			_validator.AreEqual(0, 1, Faker.Lorem.GetFirstWord(), NotificationMessage.Invalid);

			Assert.IsFalse(_validator.Valid);
			Assert.AreEqual(1, _validator.Notifications.Count);
		}

		[TestMethod("Invalid IsBetween test, should have a notification")]
		[TestCategory("Invalid Executions")]
		public void InvalidIsBetween()
		{
			_validator.IsBetween(0, 1, 2, Faker.Lorem.GetFirstWord(), NotificationMessage.SmallNumber);

			Assert.IsFalse(_validator.Valid);
			Assert.AreEqual(1, _validator.Notifications.Count);
		}
	}
}