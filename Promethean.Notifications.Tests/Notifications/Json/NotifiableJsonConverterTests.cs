using System;
using System.Text.Json;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Promethean.Notifications.Contracts;
using Promethean.Notifications.Json;
using Promethean.Notifications.Tests.Helpers;

namespace Promethean.Notifications.Tests.Notifications.Json
{
	[TestClass]
	public class NotifiableJsonConverterTests
	{
		private JsonSerializerOptions _serializerOptions;

		[TestInitialize]
		public void Setup() => _serializerOptions = new JsonSerializerOptions
		{
			IgnoreNullValues = true,
			Converters = { new NotifiableJsonConverter() }
		};

		[TestMethod("Serialize a valid Notifiable object, resulted json should not display the properties Valid and Notifications")]
		public void SerializeValidNotifiableObject()
		{
			string resultedJson = _serialize(new NotifiableClass(Faker.Internet.UserName(),
														Faker.RandomNumber.Next(0, 999),
														Faker.RandomNumber.Next(0, 145),
														Faker.RandomNumber.Next(0, 999999),
														Faker.Boolean.Random(),
														DateTime.UtcNow,
														new object()));

			Assert.IsFalse(string.IsNullOrEmpty(resultedJson?.Trim()));
			Assert.IsFalse(resultedJson.Contains($"\"{nameof(INotifiable.Valid)}\""));
			Assert.IsFalse(resultedJson.Contains($"\"{nameof(INotifiable.Notifications)}\""));
		}

		[TestMethod("Serialize an invalid Notifiable object, resulted json should display the properties Valid and Notifications")]
		public void SerializeInvalidNotifiableObject()
		{
			string resultedJson = _serialize(new NotifiableClass(Faker.Internet.UserName(),
														Faker.RandomNumber.Next(1000, 1001),
														Faker.RandomNumber.Next(146, 147),
														Faker.RandomNumber.Next(1999999, 2999999),
														Faker.Boolean.Random(),
														DateTime.UtcNow,
														new object()));

			Assert.IsFalse(string.IsNullOrEmpty(resultedJson?.Trim()));
			Assert.IsTrue(resultedJson.Contains($"\"{nameof(INotifiable.Valid)}\""));
			Assert.IsTrue(resultedJson.Contains($"\"{nameof(INotifiable.Notifications)}\""));
		}

		private string _serialize(object value) => JsonSerializer.Serialize(value, _serializerOptions);
	}
}