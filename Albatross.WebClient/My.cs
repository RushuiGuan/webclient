using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Albatross.WebClient {
	internal static class My {
		public static class ContentTypes {
			public const string Json = "application/json";
			public const string Text = "text/plain";
		}
		public readonly static Lazy<JsonSerializerOptions> DefaultJsonSerializationOptions = new Lazy<JsonSerializerOptions>(() => new JsonSerializerOptions {
			PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
			DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull,
		});
	}
}
