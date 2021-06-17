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
		private JsonSerializerOptions _serializerOptionsWithConverter;
		private JsonSerializerOptions _serializerOptionsWithoutConverter;

		[TestInitialize]
		public void Setup()
		{
			_serializerOptionsWithoutConverter = new JsonSerializerOptions
			{
				IgnoreNullValues = true,
				PropertyNameCaseInsensitive = true,
				PropertyNamingPolicy = JsonNamingPolicy.CamelCase
			};

			_serializerOptionsWithConverter = new JsonSerializerOptions(_serializerOptionsWithoutConverter);
			_serializerOptionsWithConverter.Converters.Add(new NotifiableJsonConverter());
		}

		[TestMethod("Serialize a valid Notifiable object, resulted json should not display the properties Valid and Notifications")]
		public void SerializeValidNotifiableObject()
		{
			string resultedJson = _serialize(new NotifiableClass(Faker.Internet.UserName(),
														Faker.RandomNumber.Next(0, 999),
														Faker.RandomNumber.Next(0, 145),
														Faker.RandomNumber.Next(0, 999999),
														Faker.Boolean.Random(),
														DateTime.UtcNow,
														new object())).ToLower();

			Assert.IsFalse(string.IsNullOrEmpty(resultedJson?.Trim()));
			Assert.IsFalse(resultedJson.Contains($"\"{nameof(INotifiable.Valid)}\"".ToLower()));
			Assert.IsFalse(resultedJson.Contains($"\"{nameof(INotifiable.Notifications)}\"".ToLower()));
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
														new object())).ToLower();

			Assert.IsFalse(string.IsNullOrEmpty(resultedJson?.Trim()));
			Assert.IsTrue(resultedJson.Contains($"\"{nameof(INotifiable.Valid)}\"".ToLower()));
			Assert.IsTrue(resultedJson.Contains($"\"{nameof(INotifiable.Notifications)}\"".ToLower()));
		}

		[TestMethod("Deserialize a valid Notifiable object, resulted object should not have any notifications")]
		public void DeserializeValidNotifiableObject()
		{
			NotifiableClass initialObject = new NotifiableClass(Faker.Internet.UserName(),
													   Faker.RandomNumber.Next(0, 999),
													   Faker.RandomNumber.Next(0, 145),
													   Faker.RandomNumber.Next(0, 999999),
													   Faker.Boolean.Random(),
													   DateTime.UtcNow,
													   new object());

			string json = _serialize(initialObject);

			NotifiableClass resultedObject = _deserialize<NotifiableClass>(json);

			Assert.IsNotNull(resultedObject);
			Assert.IsTrue(resultedObject.Valid);
			Assert.AreEqual(initialObject.Username, resultedObject.Username);
		}

		[TestMethod("Deserialize an invalid Notifiable object, resulted object should have notifications")]
		public void DeserializeInvalidNotifiableObject()
		{
			NotifiableClass initialObject = new NotifiableClass(Faker.Internet.UserName(),
													   Faker.RandomNumber.Next(1000, 1001),
													   Faker.RandomNumber.Next(146, 147),
													   Faker.RandomNumber.Next(1999999, 2999999),
													   Faker.Boolean.Random(),
													   DateTime.UtcNow,
													   new object());

			string json = _serialize(initialObject);

			NotifiableClass resultedObject = _deserialize<NotifiableClass>(json);

			Assert.IsNotNull(resultedObject);
			Assert.IsFalse(resultedObject.Valid);
			Assert.AreEqual(initialObject.Username, resultedObject.Username);
		}

		private string _serialize(object value) => JsonSerializer.Serialize(value, _serializerOptionsWithConverter);
		private TNotifiable _deserialize<TNotifiable>(string value) where TNotifiable : INotifiable => JsonSerializer.Deserialize<TNotifiable>(value, _serializerOptionsWithConverter);
	}
}