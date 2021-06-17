using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Promethean.Notifications.Contracts;

namespace Promethean.Notifications.Json
{
	public class NotifiableJsonConverter : JsonConverter<object>
	{
		public override bool CanConvert(Type typeToConvert) => typeof(INotifiable).IsAssignableFrom(typeToConvert);

		public override object Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options) => JsonSerializer.Deserialize(ref reader, typeToConvert, _removeSelf(options));

		public override void Write(Utf8JsonWriter writer, object value, JsonSerializerOptions options)
		{
			INotifiable notifiableValue = value as INotifiable;
			options = _removeSelf(options);

			if (notifiableValue.Valid)
				JsonSerializer.Serialize(writer, value, value.GetType(), options);

			else
			{
				JsonDocument valueDocument = JsonDocument.Parse(JsonSerializer.Serialize(value, value.GetType(), options));

				writer.WriteStartObject();

				foreach (JsonProperty property in valueDocument.RootElement.EnumerateObject())
					property.WriteTo(writer);

				writer.WriteBoolean(_resolvePropertyName(nameof(INotifiable.Valid), options), notifiableValue.Valid);

				writer.WritePropertyName(_resolvePropertyName(nameof(INotifiable.Notifications), options));
				writer.WriteStartArray();

				foreach (INotification notification in notifiableValue.Notifications)
				{
					writer.WriteStartObject();

					writer.WriteString(_resolvePropertyName(nameof(INotification.Property), options), _resolvePropertyName(notification.Property, options));
					writer.WriteString(_resolvePropertyName(nameof(INotification.Message), options), notification.Message);
					writer.WriteNumber(_resolvePropertyName(nameof(INotification.Code), options), notification.Code);

					writer.WriteEndObject();
				}

				writer.WriteEndArray();

				writer.WriteEndObject();
			}
		}

		private JsonSerializerOptions _removeSelf(JsonSerializerOptions options)
		{
			options = new JsonSerializerOptions(options);

			options.Converters.Remove(this);

			return options;
		}

		private string _resolvePropertyName(string name, JsonSerializerOptions options) => options.PropertyNamingPolicy.ConvertName(name);
	}
}