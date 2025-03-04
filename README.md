# SensitiveString.EntityFrameworkCore
[![NuGet Version](http://img.shields.io/nuget/v/SensitiveString.EntityFrameworkCore.svg?style=for-the-badge&logo=nuget)](https://www.nuget.org/packages/SensitiveString.EntityFrameworkCore/) [![NuGet Downloads](https://img.shields.io/nuget/dt/SensitiveString.EntityFrameworkCore.svg?style=for-the-badge&logo=nuget)](https://www.nuget.org/packages/SensitiveString.EntityFrameworkCore/)

This package extends [SensitiveString](https://www.nuget.org/packages/SensitiveString) to seamlessly integrate it with [EntityFrameworkCore](https://www.nuget.org/packages/Microsoft.EntityFrameworkCore) entities.

## Example

```c#
using Microsoft.EntityFrameworkCore;
using TextPrivacy.SensitiveString.EntityFrameworkCore;

public class MyDbContext : DbContext
{
    protected override void ConfigureConventions(ModelConfigurationBuilder builder)
    {
        base.ConfigureConventions(builder);
        builder.AddSensitiveStringSupport();
    }
}
```

