using Microsoft.VisualStudio.TestTools.UnitTesting;
using Promethean.Notifications.Validators;

namespace Promethean.Notifications.Tests.Validators
{
	[TestClass]
	public class ObjectValidatorTests
	{
		private Validator _validator;

		[TestInitialize]
		public void Setup() => _validator = new Validator();

		[TestMethod("Valid IsNull test, should have no notifications")]
		[TestCategory("Valid Executions")]
		public void ValidIsNull()
		{
			_validator.IsNull(null, Faker.Lorem.GetFirstWord(), NotificationMessage.NotNull);

			Assert.IsTrue(_validator.Valid);
		}

		[TestMethod("Valid IsNotNull test, should have no notifications")]
		[TestCategory("Valid Executions")]
		public void ValidIsNotNull()
		{
			_validator.IsNotNull(new object(), Faker.Lorem.GetFirstWord(), NotificationMessage.Null);

			Assert.IsTrue(_validator.Valid);
		}

		[TestMethod("Valid AreEqual test, should have no notifications")]
		[TestCategory("Valid Executions")]
		public void ValidAreEqual()
		{
			object obj = new object();

			_validator.AreEqual(obj, obj, Faker.Lorem.GetFirstWord(), NotificationMessage.NotEqual);

			Assert.IsTrue(_validator.Valid);
		}

		[TestMethod("Valid AreNotEqual test, should have no notifications")]
		[TestCategory("Valid Executions")]
		public void ValidAreNotEqual()
		{
			_validator.AreNotEqual(new object(), new object(), Faker.Lorem.GetFirstWord(), NotificationMessage.Equal);

			Assert.IsTrue(_validator.Valid);
		}

		[TestMethod("Invalid IsNull test, should have a notification")]
		[TestCategory("Invalid Executions")]
		public void InvalidIsNull()
		{
			_validator.IsNull(new object(), Faker.Lorem.GetFirstWord(), NotificationMessage.NotNull);

			Assert.IsFalse(_validator.Valid);
			Assert.AreEqual(1, _validator.Notifications.Count);
		}

		[TestMethod("Invalid IsNotNull test, should have a notification")]
		[TestCategory("Invalid Executions")]
		public void InvalidIsNotNull()
		{
			_validator.IsNotNull(null, Faker.Lorem.GetFirstWord(), NotificationMessage.Null);

			Assert.IsFalse(_validator.Valid);
			Assert.AreEqual(1, _validator.Notifications.Count);
		}

		[TestMethod("Invalid AreEqual test, should have a notification")]
		[TestCategory("Invalid Executions")]
		public void InvalidAreEqual()
		{
			_validator.AreEqual(new object(), new object(), Faker.Lorem.GetFirstWord(), NotificationMessage.Equal);

			Assert.IsFalse(_validator.Valid);
			Assert.AreEqual(1, _validator.Notifications.Count);
		}

		[TestMethod("Invalid AreNotEqual test, should have a notification")]
		[TestCategory("Invalid Executions")]
		public void InvalidAreNotEqual()
		{
			object obj = new object();

			_validator.AreNotEqual(obj, obj, Faker.Lorem.GetFirstWord(), NotificationMessage.NotEqual);

			Assert.IsFalse(_validator.Valid);
			Assert.AreEqual(1, _validator.Notifications.Count);
		}
	}
}