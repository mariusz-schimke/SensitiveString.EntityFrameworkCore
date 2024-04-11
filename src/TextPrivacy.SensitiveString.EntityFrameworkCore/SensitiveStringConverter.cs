using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace TextPrivacy.SensitiveString.EntityFrameworkCore;

/// <summary>
///     Handles <see cref="SensitiveString" /> conversion to and from string.
/// </summary>
public class SensitiveStringConverter : ValueConverter<SensitiveString, string>
{
    public SensitiveStringConverter()
        : base(
            sensitiveString => (string) sensitiveString,
            sensitiveString => sensitiveString.AsSensitive())
    {
    }
}