using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Promethean.Notifications.Messages;
using Promethean.Notifications.Validators;

namespace Promethean.Notifications.Tests.Validators
{
	[TestClass]
	public class TimeSpanValidatorTests
	{
		private Validator _validator;

		[TestInitialize]
		public void Setup() => _validator = new Validator();

		[TestMethod("Valid IsGreaterThan test, should have no notifications")]
		[TestCategory("Valid Executions")]
		public void ValidIsGreaterThan()
		{
			_validator.IsGreaterThan(TimeSpan.FromHours(24), new TimeSpan(), Faker.Lorem.GetFirstWord(), NotificationMessage.Invalid);

			Assert.IsTrue(_validator.Valid);
		}

		[TestMethod("Valid IsGreaterOrEqualTo test, should have no notifications")]
		[TestCategory("Valid Executions")]
		public void ValidIsGreaterOrEqualTo()
		{
			TimeSpan value = TimeSpan.FromHours(24);

			_validator.IsGreaterOrEqualTo(value, value, Faker.Lorem.GetFirstWord(), NotificationMessage.Invalid);

			Assert.IsTrue(_validator.Valid);
		}

		[TestMethod("Valid IsLowerThan test, should have no notifications")]
		[TestCategory("Valid Executions")]
		public void ValidIsLowerThan()
		{
			_validator.IsLowerThan(new TimeSpan(), TimeSpan.FromHours(24), Faker.Lorem.GetFirstWord(), NotificationMessage.Invalid);

			Assert.IsTrue(_validator.Valid);
		}

		[TestMethod("Valid IsLowerOrEqualTo test, should have no notifications")]
		[TestCategory("Valid Executions")]
		public void ValidIsLowerOrEqualTo()
		{
			TimeSpan value = TimeSpan.FromHours(24);

			_validator.IsLowerOrEqualTo(value, value, Faker.Lorem.GetFirstWord(), NotificationMessage.Invalid);

			Assert.IsTrue(_validator.Valid);
		}

		[TestMethod("Valid IsBetween test, should have no notifications")]
		[TestCategory("Valid Executions")]
		public void ValidIsBetween()
		{
			_validator.IsBetween(TimeSpan.FromHours(12), new TimeSpan(), TimeSpan.FromHours(24), Faker.Lorem.GetFirstWord(), NotificationMessage.Invalid);

			Assert.IsTrue(_validator.Valid);
		}

		[TestMethod("Invalid IsGreaterThan test, should have a notification")]
		[TestCategory("Invalid Executions")]
		public void InvalidIsGreaterThan()
		{
			_validator.IsGreaterThan(new TimeSpan(), TimeSpan.FromHours(24), Faker.Lorem.GetFirstWord(), NotificationMessage.Invalid);

			Assert.IsFalse(_validator.Valid);
			Assert.AreEqual(1, _validator.Notifications.Count);
		}

		[TestMethod("Invalid IsGreaterOrEqualTo test, should have a notification")]
		[TestCategory("Invalid Executions")]
		public void InvalidIsGreaterOrEqualTo()
		{
			_validator.IsGreaterOrEqualTo(new TimeSpan(), TimeSpan.FromHours(24), Faker.Lorem.GetFirstWord(), NotificationMessage.Invalid);

			Assert.IsFalse(_validator.Valid);
			Assert.AreEqual(1, _validator.Notifications.Count);
		}

		[TestMethod("Invalid IsLowerThan test, should have a notification")]
		[TestCategory("Invalid Executions")]
		public void InvalidIsLowerThan()
		{
			_validator.IsLowerThan(TimeSpan.FromHours(24), new TimeSpan(), Faker.Lorem.GetFirstWord(), NotificationMessage.Invalid);

			Assert.IsFalse(_validator.Valid);
			Assert.AreEqual(1, _validator.Notifications.Count);
		}

		[TestMethod("Invalid IsLowerOrEqualTo test, should have a notification")]
		[TestCategory("Invalid Executions")]
		public void InvalidIsLowerOrEqualTo()
		{
			_validator.IsLowerOrEqualTo(TimeSpan.FromHours(24), new TimeSpan(), Faker.Lorem.GetFirstWord(), NotificationMessage.Invalid);

			Assert.IsFalse(_validator.Valid);
			Assert.AreEqual(1, _validator.Notifications.Count);
		}

		[TestMethod("Invalid IsBetween test, should have a notification")]
		[TestCategory("Invalid Executions")]
		public void InvalidIsBetween()
		{
			_validator.IsBetween(new TimeSpan(), TimeSpan.FromHours(24), TimeSpan.FromHours(24), Faker.Lorem.GetFirstWord(), NotificationMessage.Invalid);

			Assert.IsFalse(_validator.Valid);
			Assert.AreEqual(1, _validator.Notifications.Count);
		}
	}
}