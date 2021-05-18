using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Promethean.Notifications.Validators;

namespace Promethean.Notifications.Tests.Validators
{
	[TestClass]
	public class DateTimeValidatorTests
	{
		private Validator _validator;

		[TestInitialize]
		public void Setup() => _validator = new Validator();

		[TestMethod("Valid IsGreaterThan test, should have no notifications")]
		[TestCategory("Valid Executions")]
		public void ValidIsGreaterThan()
		{
			_validator.IsGreaterThan(DateTime.UtcNow, new DateTime(), Faker.Lorem.GetFirstWord(), NotificationMessage.Invalid);

			Assert.IsTrue(_validator.Valid);
		}

		[TestMethod("Valid IsGreaterOrEqualTo test, should have no notifications")]
		[TestCategory("Valid Executions")]
		public void ValidIsGreaterOrEqualTo()
		{
			DateTime now = DateTime.UtcNow;

			_validator.IsGreaterOrEqualTo(now, now, Faker.Lorem.GetFirstWord(), NotificationMessage.Invalid);

			Assert.IsTrue(_validator.Valid);
		}

		[TestMethod("Valid IsLowerThan test, should have no notifications")]
		[TestCategory("Valid Executions")]
		public void ValidIsLowerThan()
		{
			_validator.IsLowerThan(new DateTime(), DateTime.UtcNow, Faker.Lorem.GetFirstWord(), NotificationMessage.Invalid);

			Assert.IsTrue(_validator.Valid);
		}

		[TestMethod("Valid IsLowerOrEqualTo test, should have no notifications")]
		[TestCategory("Valid Executions")]
		public void ValidIsLowerOrEqualTo()
		{
			DateTime now = DateTime.UtcNow;

			_validator.IsLowerOrEqualTo(now, now, Faker.Lorem.GetFirstWord(), NotificationMessage.Invalid);

			Assert.IsTrue(_validator.Valid);
		}

		[TestMethod("Valid IsBetween test, should have no notifications")]
		[TestCategory("Valid Executions")]
		public void ValidIsBetween()
		{
			_validator.IsBetween(DateTime.UtcNow, new DateTime(), DateTime.UtcNow, Faker.Lorem.GetFirstWord(), NotificationMessage.Invalid);

			Assert.IsTrue(_validator.Valid);
		}

		[TestMethod("Invalid IsGreaterThan test, should have a notification")]
		[TestCategory("Invalid Executions")]
		public void InvalidIsGreaterThan()
		{
			_validator.IsGreaterThan(new DateTime(), DateTime.UtcNow, Faker.Lorem.GetFirstWord(), NotificationMessage.Invalid);

			Assert.IsFalse(_validator.Valid);
			Assert.AreEqual(1, _validator.Notifications.Count);
		}

		[TestMethod("Invalid IsGreaterOrEqualTo test, should have a notification")]
		[TestCategory("Invalid Executions")]
		public void InvalidIsGreaterOrEqualTo()
		{
			_validator.IsGreaterOrEqualTo(new DateTime(), DateTime.UtcNow, Faker.Lorem.GetFirstWord(), NotificationMessage.Invalid);

			Assert.IsFalse(_validator.Valid);
			Assert.AreEqual(1, _validator.Notifications.Count);
		}

		[TestMethod("Invalid IsLowerThan test, should have a notification")]
		[TestCategory("Invalid Executions")]
		public void InvalidIsLowerThan()
		{
			_validator.IsLowerThan(DateTime.UtcNow, new DateTime(), Faker.Lorem.GetFirstWord(), NotificationMessage.Invalid);

			Assert.IsFalse(_validator.Valid);
			Assert.AreEqual(1, _validator.Notifications.Count);
		}

		[TestMethod("Invalid IsLowerOrEqualTo test, should have a notification")]
		[TestCategory("Invalid Executions")]
		public void InvalidIsLowerOrEqualTo()
		{
			_validator.IsLowerOrEqualTo(DateTime.UtcNow, new DateTime(), Faker.Lorem.GetFirstWord(), NotificationMessage.Invalid);

			Assert.IsFalse(_validator.Valid);
			Assert.AreEqual(1, _validator.Notifications.Count);
		}

		[TestMethod("Invalid IsBetween test, should have a notification")]
		[TestCategory("Invalid Executions")]
		public void InvalidIsBetween()
		{
			_validator.IsBetween(new DateTime(), DateTime.UtcNow, DateTime.UtcNow, Faker.Lorem.GetFirstWord(), NotificationMessage.Invalid);

			Assert.IsFalse(_validator.Valid);
			Assert.AreEqual(1, _validator.Notifications.Count);
		}
	}
}