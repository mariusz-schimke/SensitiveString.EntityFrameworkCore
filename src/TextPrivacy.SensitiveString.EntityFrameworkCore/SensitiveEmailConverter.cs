using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace TextPrivacy.SensitiveString.EntityFrameworkCore;

/// <summary>
///     Handles <see cref="SensitiveEmail" /> conversion to and from string.
/// </summary>
public class SensitiveEmailConverter : ValueConverter<SensitiveEmail, string>
{
    public SensitiveEmailConverter()
        : base(
            sensitiveEmail => (string) sensitiveEmail,
            sensitiveEmail => sensitiveEmail.AsSensitiveEmail())
    {
    }
}