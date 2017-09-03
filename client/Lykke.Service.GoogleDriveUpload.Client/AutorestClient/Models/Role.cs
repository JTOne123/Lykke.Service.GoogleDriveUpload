// Code generated by Microsoft (R) AutoRest Code Generator 1.2.2.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Lykke.Service.GoogleDriveUpload.Client.AutorestClient.Models
{
    using Lykke.Service;
    using Lykke.Service.GoogleDriveUpload;
    using Lykke.Service.GoogleDriveUpload.Client;
    using Lykke.Service.GoogleDriveUpload.Client.AutorestClient;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for Role.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum Role
    {
        [EnumMember(Value = "Unknown")]
        Unknown,
        [EnumMember(Value = "Organizer")]
        Organizer,
        [EnumMember(Value = "Owner")]
        Owner,
        [EnumMember(Value = "Writer")]
        Writer,
        [EnumMember(Value = "Commenter")]
        Commenter,
        [EnumMember(Value = "Reader")]
        Reader
    }
    internal static class RoleEnumExtension
    {
        internal static string ToSerializedValue(this Role? value)  =>
            value == null ? null : ((Role)value).ToSerializedValue();

        internal static string ToSerializedValue(this Role value)
        {
            switch( value )
            {
                case Role.Unknown:
                    return "Unknown";
                case Role.Organizer:
                    return "Organizer";
                case Role.Owner:
                    return "Owner";
                case Role.Writer:
                    return "Writer";
                case Role.Commenter:
                    return "Commenter";
                case Role.Reader:
                    return "Reader";
            }
            return null;
        }

        internal static Role? ParseRole(this string value)
        {
            switch( value )
            {
                case "Unknown":
                    return Role.Unknown;
                case "Organizer":
                    return Role.Organizer;
                case "Owner":
                    return Role.Owner;
                case "Writer":
                    return Role.Writer;
                case "Commenter":
                    return Role.Commenter;
                case "Reader":
                    return Role.Reader;
            }
            return null;
        }
    }
}