#nullable enable

namespace Softplan.Soft.Suite.Codex.Cnj.Sdk.JsonConverters
{
    /// <inheritdoc />
    public sealed class ContadorProcessosSegmentoJusticaNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Softplan.Soft.Suite.Codex.Cnj.Sdk.ContadorProcessosSegmentoJustica?>
    {
        /// <inheritdoc />
        public override global::Softplan.Soft.Suite.Codex.Cnj.Sdk.ContadorProcessosSegmentoJustica? Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            switch (reader.TokenType)
            {
                case global::System.Text.Json.JsonTokenType.String:
                {
                    var stringValue = reader.GetString();
                    if (stringValue != null)
                    {
                        return global::Softplan.Soft.Suite.Codex.Cnj.Sdk.ContadorProcessosSegmentoJusticaExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Softplan.Soft.Suite.Codex.Cnj.Sdk.ContadorProcessosSegmentoJustica)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Softplan.Soft.Suite.Codex.Cnj.Sdk.ContadorProcessosSegmentoJustica?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Softplan.Soft.Suite.Codex.Cnj.Sdk.ContadorProcessosSegmentoJustica? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Softplan.Soft.Suite.Codex.Cnj.Sdk.ContadorProcessosSegmentoJusticaExtensions.ToValueString(value.Value));
            }
        }
    }
}
