using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace TextPrivacy.SensitiveString.EntityFrameworkCore;

/// <summary>
///     Handles <see cref="SensitiveString" /> comparison. Works for descendants such as <see cref="SensitiveEmail" /> too.
/// </summary>
public class SensitiveStringComparer : ValueComparer<SensitiveString>
{
    public SensitiveStringComparer()
        : base(
            (a, b) => SensitiveString.Equals(a, b),
            sensitiveString => sensitiveString.GetHashCode())
    {
    }
}