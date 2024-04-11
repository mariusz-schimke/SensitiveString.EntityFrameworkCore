using Microsoft.EntityFrameworkCore;

namespace TextPrivacy.SensitiveString.EntityFrameworkCore;

public static class SensitiveStringExtensions
{
    /// <summary>
    ///     Adds support for the <see cref="SensitiveString" /> and <see cref="SensitiveEmail" /> types, so they can be used in entities.
    /// </summary>
    /// <param name="builder">
    ///     The builder to add the sensitive string types support to.
    /// </param>
    public static ModelConfigurationBuilder AddSensitiveStringSupport(this ModelConfigurationBuilder builder)
    {
        builder.Properties<SensitiveString>()
           .HaveConversion<SensitiveStringConverter, SensitiveStringComparer>();

        builder.Properties<SensitiveEmail>()
           .HaveConversion<SensitiveEmailConverter, SensitiveStringComparer>();

        return builder;
    }
}