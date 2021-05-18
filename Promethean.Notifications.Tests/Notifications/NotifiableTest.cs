using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Promethean.Notifications.Tests.Helpers;

namespace Promethean.Notifications.Tests.Notifications
{
	[TestClass]
	public class NotifiableTest
	{
		[TestMethod("Create a valid notifiable object")]
		public void CreateValidNotifiable()
		{
			NotifiableClass notifiableClass = new NotifiableClass(Faker.Internet.UserName(),
														 Faker.RandomNumber.Next(0, 999),
														 Faker.RandomNumber.Next(0, 145),
														 Faker.RandomNumber.Next(0, 999999),
														 Faker.Boolean.Random(),
														 DateTime.UtcNow,
														 new object());

			Assert.IsTrue(notifiableClass.Valid);
		}

		[TestMethod("Create a valid notifiable object")]
		public void CreateInvalidNotifiable()
		{
			NotifiableClass notifiableClass = new NotifiableClass(Faker.Lorem.Paragraph(),
														 Faker.RandomNumber.Next(999, 1999),
														 Faker.RandomNumber.Next(145, 1145),
														 Faker.RandomNumber.Next(1000000, 1999999),
														 Faker.Boolean.Random(),
														 DateTime.UtcNow,
														 null);

			Assert.IsFalse(notifiableClass.Valid);
			Assert.AreEqual(5, notifiableClass.Notifications.Count);
		}
	}
}