using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Promethean.Notifications.Contracts;

namespace Promethean.Notifications.Json
{
	public class NotifiableJsonConverter : JsonConverter<object>
	{
		public override bool CanConvert(Type typeToConvert) => typeof(INotifiable).IsAssignableFrom(typeToConvert);

		public override object Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options) => JsonSerializer.Deserialize(ref reader, typeToConvert);

		public override void Write(Utf8JsonWriter writer, object value, JsonSerializerOptions options)
		{
			INotifiable notifiableValue = value as INotifiable;

			if (notifiableValue.Valid)
				JsonSerializer.Serialize(writer, value, value.GetType());

			else
			{
				JsonDocument valueDocument = JsonDocument.Parse(JsonSerializer.Serialize(value, value.GetType()));

				writer.WriteStartObject();

				foreach (JsonProperty property in valueDocument.RootElement.EnumerateObject())
					property.WriteTo(writer);

				writer.WriteBoolean(nameof(INotifiable.Valid), notifiableValue.Valid);

				writer.WritePropertyName(nameof(INotifiable.Notifications));
				writer.WriteStartArray();

				foreach (INotification notification in notifiableValue.Notifications)
				{
					writer.WriteStartObject();

					writer.WriteString(nameof(INotification.Property), notification.Property);
					writer.WriteString(nameof(INotification.Message), notification.Message);
					writer.WriteNumber(nameof(INotification.Code), notification.Code);

					writer.WriteEndObject();
				}

				writer.WriteEndArray();

				writer.WriteEndObject();
			}
		}
	}
}