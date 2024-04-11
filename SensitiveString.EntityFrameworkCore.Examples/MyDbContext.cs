using Microsoft.EntityFrameworkCore;
using TextPrivacy.SensitiveString.EntityFrameworkCore;

namespace SensitiveString.EntityFrameworkCore.Examples;

public class MyDbContext : DbContext
{
    protected override void ConfigureConventions(ModelConfigurationBuilder builder)
    {
        base.ConfigureConventions(builder);
        builder.AddSensitiveStringSupport();
    }
}