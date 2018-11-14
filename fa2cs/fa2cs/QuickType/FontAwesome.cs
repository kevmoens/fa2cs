﻿// <auto-generated />
//
// To parse this JSON data, add NuGet 'Newtonsoft.Json' then do:
//
//    using QuickType;
//
//    var fontAwesome = FontAwesome.FromJson(jsonString);

namespace QuickType
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public partial class FontAwesome
    {
        [JsonProperty("jsonapi", NullValueHandling = NullValueHandling.Ignore)]
        public Jsonapi Jsonapi { get; set; }

        [JsonProperty("data", NullValueHandling = NullValueHandling.Ignore)]
        public Datum[] Data { get; set; }
    }

    public partial class Datum
    {
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public TypeEnum? Type { get; set; }

        [JsonProperty("links", NullValueHandling = NullValueHandling.Ignore)]
        public Links Links { get; set; }

        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        [JsonProperty("attributes", NullValueHandling = NullValueHandling.Ignore)]
        public Attributes Attributes { get; set; }

        public override string ToString()
        {
            return Id;
        }
    }

    public partial class Attributes
    {
        [JsonProperty("sku", NullValueHandling = NullValueHandling.Ignore)]
        public string Sku { get; set; }

        [JsonProperty("short-description", NullValueHandling = NullValueHandling.Ignore)]
        public string ShortDescription { get; set; }

        [JsonProperty("price-formatted", NullValueHandling = NullValueHandling.Ignore)]
        public string PriceFormatted { get; set; }

        [JsonProperty("price", NullValueHandling = NullValueHandling.Ignore)]
        public Price Price { get; set; }

        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        [JsonProperty("icon", NullValueHandling = NullValueHandling.Ignore)]
        public string Icon { get; set; }

        [JsonProperty("details", NullValueHandling = NullValueHandling.Ignore)]
        public string Details { get; set; }

        [JsonProperty("category", NullValueHandling = NullValueHandling.Ignore)]
        public Category? Category { get; set; }

        [JsonProperty("view-order", NullValueHandling = NullValueHandling.Ignore)]
        public long? ViewOrder { get; set; }

        [JsonProperty("updated-at", NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? UpdatedAt { get; set; }

        [JsonProperty("percentage-complete", NullValueHandling = NullValueHandling.Ignore)]
        public long? PercentageComplete { get; set; }

        [JsonProperty("inserted-at", NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? InsertedAt { get; set; }

        [JsonProperty("unicode", NullValueHandling = NullValueHandling.Ignore)]
        public string Unicode { get; set; }

        [JsonProperty("styles", NullValueHandling = NullValueHandling.Ignore)]
        public Style[] Styles { get; set; }

        [JsonProperty("membership", NullValueHandling = NullValueHandling.Ignore)]
        public Membership Membership { get; set; }

        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }
    }

    public partial class Membership
    {
        [JsonProperty("pro", NullValueHandling = NullValueHandling.Ignore)]
        public Style[] Pro { get; set; }

        [JsonProperty("free", NullValueHandling = NullValueHandling.Ignore)]
        public Style[] Free { get; set; }
    }

    public partial class Price
    {
        [JsonProperty("currency", NullValueHandling = NullValueHandling.Ignore)]
        public Currency? Currency { get; set; }

        [JsonProperty("amount", NullValueHandling = NullValueHandling.Ignore)]
        public long? Amount { get; set; }
    }

    public partial class Links
    {
        [JsonProperty("self", NullValueHandling = NullValueHandling.Ignore)]
        public string Self { get; set; }
    }

    public partial class Jsonapi
    {
        [JsonProperty("version", NullValueHandling = NullValueHandling.Ignore)]
        public string Version { get; set; }
    }

    public enum Category { FontAwesome5ProEarlyAccess, FontAwesomePro };

    public enum Style { Brands, Light, Regular, Solid };

    public enum Currency { Usd };

    public enum TypeEnum { Icon, Product, ProductUpdate };

    public partial class FontAwesome
    {
        public static FontAwesome[] FromJson(string json) => JsonConvert.DeserializeObject < FontAwesome[]>(json, QuickType.Converter.Settings);
    }

    public static class Serialize
    {
        public static string ToJson(this FontAwesome[] self) => JsonConvert.SerializeObject(self, QuickType.Converter.Settings);
    }

    internal static class Converter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters =
            {
                CategoryConverter.Singleton,
                StyleConverter.Singleton,
                CurrencyConverter.Singleton,
                TypeEnumConverter.Singleton,
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
        };
    }

    internal class CategoryConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(Category) || t == typeof(Category?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "Font Awesome 5 Pro Early Access":
                    return Category.FontAwesome5ProEarlyAccess;
                case "Font Awesome Pro":
                    return Category.FontAwesomePro;
            }
            throw new Exception("Cannot unmarshal type Category");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (Category)untypedValue;
            switch (value)
            {
                case Category.FontAwesome5ProEarlyAccess:
                    serializer.Serialize(writer, "Font Awesome 5 Pro Early Access");
                    return;
                case Category.FontAwesomePro:
                    serializer.Serialize(writer, "Font Awesome Pro");
                    return;
            }
            throw new Exception("Cannot marshal type Category");
        }

        public static readonly CategoryConverter Singleton = new CategoryConverter();
    }

    internal class StyleConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(Style) || t == typeof(Style?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "brands":
                    return Style.Brands;
                case "light":
                    return Style.Light;
                case "regular":
                    return Style.Regular;
                case "solid":
                    return Style.Solid;
            }
            throw new Exception("Cannot unmarshal type Style");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (Style)untypedValue;
            switch (value)
            {
                case Style.Brands:
                    serializer.Serialize(writer, "brands");
                    return;
                case Style.Light:
                    serializer.Serialize(writer, "light");
                    return;
                case Style.Regular:
                    serializer.Serialize(writer, "regular");
                    return;
                case Style.Solid:
                    serializer.Serialize(writer, "solid");
                    return;
            }
            throw new Exception("Cannot marshal type Style");
        }

        public static readonly StyleConverter Singleton = new StyleConverter();
    }

    internal class CurrencyConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(Currency) || t == typeof(Currency?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            if (value == "USD")
            {
                return Currency.Usd;
            }
            throw new Exception("Cannot unmarshal type Currency");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (Currency)untypedValue;
            if (value == Currency.Usd)
            {
                serializer.Serialize(writer, "USD");
                return;
            }
            throw new Exception("Cannot marshal type Currency");
        }

        public static readonly CurrencyConverter Singleton = new CurrencyConverter();
    }

    internal class TypeEnumConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(TypeEnum) || t == typeof(TypeEnum?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "icon":
                    return TypeEnum.Icon;
                case "product":
                    return TypeEnum.Product;
                case "product-update":
                    return TypeEnum.ProductUpdate;
            }
            throw new Exception("Cannot unmarshal type TypeEnum");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (TypeEnum)untypedValue;
            switch (value)
            {
                case TypeEnum.Icon:
                    serializer.Serialize(writer, "icon");
                    return;
                case TypeEnum.Product:
                    serializer.Serialize(writer, "product");
                    return;
                case TypeEnum.ProductUpdate:
                    serializer.Serialize(writer, "product-update");
                    return;
            }
            throw new Exception("Cannot marshal type TypeEnum");
        }

        public static readonly TypeEnumConverter Singleton = new TypeEnumConverter();
    }
}
