using Microsoft.VisualStudio.TestTools.UnitTesting;
using Promethean.Notifications.Validators;

namespace Promethean.Notifications.Tests.Validators
{
	[TestClass]
	public class StringValidatorTests
	{
		private Validator _validator;

		[TestInitialize]
		public void Setup()
		{
			_validator = new Validator();
		}

		[TestMethod("Valid IsNotNullOrEmpty test, should have no notifications")]
		[TestCategory("Valid Executions")]
		public void ValidIsNotNullOrEmpty()
		{
			_validator.IsNotNullOrEmpty(Faker.Name.First(), Faker.Lorem.GetFirstWord(), NotificationMessage.NullOrEmpty);

			Assert.IsTrue(_validator.Valid);
		}

		[TestMethod("Valid IsNullOrEmpty test, should have no notifications")]
		[TestCategory("Valid Executions")]
		public void ValidIsNullOrEmpty()
		{
			_validator.IsNullOrEmpty(string.Empty, Faker.Lorem.GetFirstWord(), NotificationMessage.NotNullOrEmpty);

			Assert.IsTrue(_validator.Valid);
		}

		[TestMethod("Valid HasMinLength test, should have no notifications")]
		[TestCategory("Valid Executions")]
		public void ValidHasMinLength()
		{
			_validator.HasMinLength(Faker.Name.FullName(), 1, Faker.Lorem.GetFirstWord(), NotificationMessage.IncorrectLength);

			Assert.IsTrue(_validator.Valid);
		}

		[TestMethod("Valid HasMaxLength test, should have no notifications")]
		[TestCategory("Valid Executions")]
		public void ValidHasMaxLength()
		{
			_validator.HasMaxLength(Faker.Name.First(), 100, Faker.Lorem.GetFirstWord(), NotificationMessage.IncorrectLength);

			Assert.IsTrue(_validator.Valid);
		}

		[TestMethod("Valid HasLength test, should have no notifications")]
		[TestCategory("Valid Executions")]
		public void ValidHasLength()
		{
			string name = Faker.Name.First();

			_validator.HasLength(name, name.Length, Faker.Lorem.GetFirstWord(), NotificationMessage.IncorrectLength);

			Assert.IsTrue(_validator.Valid);
		}

		[TestMethod("Valid Contains test, should have no notifications")]
		[TestCategory("Valid Executions")]
		public void ValidContains()
		{
			string name = Faker.Name.FullName();

			_validator.Contains(name, name.Substring(name.Length / 2), Faker.Lorem.GetFirstWord(), NotificationMessage.Invalid);

			Assert.IsTrue(_validator.Valid);
		}

		[TestMethod("Valid AreEqual test, should have no notifications")]
		[TestCategory("Valid Executions")]
		public void ValidAreEqual()
		{
			string name = Faker.Name.First();

			_validator.AreEqual(name, name, Faker.Lorem.GetFirstWord(), NotificationMessage.NotEqual);

			Assert.IsTrue(_validator.Valid);
		}

		[TestMethod("Valid AreNotEqual test, should have no notifications")]
		[TestCategory("Valid Executions")]
		public void ValidAreNotEqual()
		{
			_validator.AreNotEqual(Faker.Name.First(), Faker.Name.FullName(), Faker.Lorem.GetFirstWord(), NotificationMessage.Equal);

			Assert.IsTrue(_validator.Valid);
		}

		[TestMethod("Valid IsEmail test, should have no notifications")]
		[TestCategory("Valid Executions")]
		public void ValidIsEmail()
		{
			_validator.IsEmail(Faker.Internet.Email(), Faker.Lorem.GetFirstWord(), NotificationMessage.InvalidFormat);

			Assert.IsTrue(_validator.Valid);
		}

		[TestMethod("Valid IsUrl test, should have no notifications")]
		[TestCategory("Valid Executions")]
		public void ValidIsUrl()
		{
			_validator.IsUrl(Faker.Internet.SecureUrl(), Faker.Lorem.GetFirstWord(), NotificationMessage.InvalidFormat);

			Assert.IsTrue(_validator.Valid);
		}

		[TestMethod("Valid Matchs test, should have no notifications")]
		[TestCategory("Valid Executions")]
		public void ValidMatchs()
		{
			_validator.Matchs(Faker.Name.First(), ".", Faker.Lorem.GetFirstWord(), NotificationMessage.InvalidFormat);

			Assert.IsTrue(_validator.Valid);
		}

		[TestMethod("Invalid IsNotNullOrEmpty test, should have a notification")]
		[TestCategory("Invalid Executions")]
		public void InvalidIsNotNullOrEmpty()
		{
			_validator.IsNotNullOrEmpty(string.Empty, Faker.Lorem.GetFirstWord(), NotificationMessage.NullOrEmpty);

			Assert.IsFalse(_validator.Valid);
		}

		[TestMethod("Invalid IsNullOrEmpty test, should have a notification")]
		[TestCategory("Invalid Executions")]
		public void InvalidIsNullOrEmpty()
		{
			_validator.IsNullOrEmpty(Faker.Name.First(), Faker.Lorem.GetFirstWord(), NotificationMessage.NotNullOrEmpty);

			Assert.IsFalse(_validator.Valid);
		}

		[TestMethod("Invalid HasMinLength test, should have a notification")]
		[TestCategory("Invalid Executions")]
		public void InvalidHasMinLength()
		{
			_validator.HasMinLength(Faker.Name.First(), 100, Faker.Lorem.GetFirstWord(), NotificationMessage.IncorrectLength);

			Assert.IsFalse(_validator.Valid);
		}

		[TestMethod("Invalid HasMaxLength test, should have a notification")]
		[TestCategory("Invalid Executions")]
		public void InvalidHasMaxLength()
		{
			_validator.HasMaxLength(Faker.Name.FullName(), 1, Faker.Lorem.GetFirstWord(), NotificationMessage.IncorrectLength);

			Assert.IsFalse(_validator.Valid);
		}

		[TestMethod("Invalid HasLength test, should have a notification")]
		[TestCategory("Invalid Executions")]
		public void InvalidHasLength()
		{
			_validator.HasLength(Faker.Name.First(), 1, Faker.Lorem.GetFirstWord(), NotificationMessage.IncorrectLength);

			Assert.IsFalse(_validator.Valid);
		}

		[TestMethod("Invalid Contains test, should have a notification")]
		[TestCategory("Invalid Executions")]
		public void InvalidContains()
		{
			_validator.Contains(Faker.Name.First(), Faker.Lorem.Sentence(), Faker.Lorem.GetFirstWord(), NotificationMessage.Invalid);

			Assert.IsFalse(_validator.Valid);
		}

		[TestMethod("Invalid AreEqual test, should have a notification")]
		[TestCategory("Invalid Executions")]
		public void InvalidAreEqual()
		{
			_validator.AreEqual(Faker.Name.First(), Faker.Name.FullName(), Faker.Lorem.GetFirstWord(), NotificationMessage.NotEqual);

			Assert.IsFalse(_validator.Valid);
		}

		[TestMethod("Invalid AreNotEqual test, should have a notification")]
		[TestCategory("Invalid Executions")]
		public void InvalidAreNotEqual()
		{
			string name = Faker.Name.First();

			_validator.AreNotEqual(name, name, Faker.Lorem.GetFirstWord(), NotificationMessage.Equal);

			Assert.IsFalse(_validator.Valid);
		}

		[TestMethod("Invalid IsEmail test, should have a notification")]
		[TestCategory("Invalid Executions")]
		public void InvalidIsEmail()
		{
			_validator.IsEmail(Faker.Internet.SecureUrl(), Faker.Lorem.GetFirstWord(), NotificationMessage.InvalidFormat);

			Assert.IsFalse(_validator.Valid);
		}

		[TestMethod("Invalid IsUrl test, should have a notification")]
		[TestCategory("Invalid Executions")]
		public void InvalidIsUrl()
		{
			_validator.IsUrl(Faker.Internet.Email(), Faker.Lorem.GetFirstWord(), NotificationMessage.InvalidFormat);

			Assert.IsFalse(_validator.Valid);
		}

		[TestMethod("Invalid Matchs test, should have a notification")]
		[TestCategory("Invalid Executions")]
		public void InvalidMatchs()
		{
			_validator.Matchs(string.Empty, Faker.Name.First(), Faker.Lorem.GetFirstWord(), NotificationMessage.InvalidFormat);

			Assert.IsFalse(_validator.Valid);
		}
	}
}