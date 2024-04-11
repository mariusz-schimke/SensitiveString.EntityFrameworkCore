using Microsoft.EntityFrameworkCore;
using TextPrivacy.SensitiveString.EntityFrameworkCore;

namespace TextPrivacy.SensitiveString.EntityFrameworkCore.Examples;

public class MyDbContext : DbContext
{
    protected override void ConfigureConventions(ModelConfigurationBuilder builder)
    {
        base.ConfigureConventions(builder);
        builder.AddSensitiveStringSupport();
    }
}