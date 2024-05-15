# Pandorax.Loqate

Pandorax.Loqate is a .NET library that provides easy integration with the [Loqate API](https://www.loqate.com) for address verification, geocoding, and other location-based services.

## Table of Contents

- [Getting Started](#getting-started)
  - [Prerequisites](#prerequisites)
  - [Installation](#installation)
- [Usage](#usage)

## Getting Started

### Prerequisites
An API key is needed from [Loqate](https://www.loqate.com)

### Installation

You can install Pandorax.Loqate via NuGet Package Manager or .NET CLI.

#### NuGet Package Manager:

```bash
Install-Package Pandorax.Loqate
```

#### .NET CLI:
```bash
dotnet add package Pandorax.Loqate
```

## Usage

To get started using Pandorax.Loqate, follow these steps:

### Configuration

Make sure to have the API key available to your application configuration, whether it be in your user secrets, appsettings.json, or another configuration provider you have configured.

### Adding Services to Dependency Injection Container

To use Pandorax.Loqate with dependency injection, you need to register the required services in your application's dependency injection container.

#### Example for ASP.NET Core:

In an ASP.NET Core application's `Program.cs`, add the following code after initialising the `WebApplicationBuilder`:

```csharp
builder.Services
    .Configure<LoqateOptions>(options =>
    {
        options.Key = builder.Configuration["Loqate:ApiKey"];
    })
    .AddLoqate();
```

#### Injecting the Loqate Service

Once you have registered the LoqateService with the dependency injection container, you can inject it into your classes where needed.

##### Example Usage in a Controller:

```csharp
using Pandorax.Loqate;

[ApiController]
[Route("[controller]")]
public class AddressController : ControllerBase
{
    private readonly ILoqateService _loqateService;

    public AddressController(ILoqateService loqateService)
    {
        _loqateService = loqateService;
    }

    [HttpGet]
    public async Task<IActionResult> FindAddresses(string text)
    {
        FindRequestParameters requestParameters = new(text)
        {
            Countries = ["GB"]
        };

        FindResponse addresses = await _loqateService.FindAddressesAsync(requestParameters);

        return Ok(addresses);
    }
}
```

In this example, the `ILoqateService` is injected into the `AddressController`, allowing the controller to use the Loqate service for address lookup.