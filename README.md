# TIB Finance .NET Framework SDK

![.NET Framework](https://img.shields.io/badge/.NET_Framework-4.7%2B-512BD4)

.NET Framework SDK for the TIB Finance payment processing API.

## Installation

**Option 1 — prebuilt DLL (recommended):**

1. Download `TibDotNetSdk-v<version>-dll.zip` from the latest [GitHub release](https://github.com/TibFinance/TibDotNetSdk/releases) and extract it.
2. Add a reference to `Tib.Api.dll` in your project.
3. Install the two NuGet dependencies (Visual Studio Package Manager Console):

```powershell
Install-Package BouncyCastle -Version 1.8.9
Install-Package Newtonsoft.Json -Version 13.0.1
```

**Option 2 — build from source:**

```bash
git clone https://github.com/TibFinance/TibDotNetSdk.git
cd TibDotNetSdk
nuget restore
```

Build the `.sln` in Visual Studio, then reference the built `Tib.Api.dll` or add the `Tib.Api` project to your own solution.

## Quick Start

```csharp
using System;
using Tib.Api;
using Tib.Api.Model.General;

TibInvoker.InitializePortal("https://sandboxportal.tib.finance");

var sessionArgs = new CreateSessionArgs {
    ClientId = Guid.Parse("00000000-0000-0000-0000-000000000000"), // replace with your client id
    Username = "your_username",
    Password = "your_password"
};
var response = TibInvoker.Portal.CreateSession(sessionArgs);
if (response.HasError)
{
    Console.WriteLine("Session failed: " + response.Messages);
}
else
{
    Console.WriteLine(response.SessionId);
}
```

## Documentation

For the complete API reference and guides, visit [doc.tib.finance](https://doc.tib.finance).

This SDK provides access to **62 API methods** for payment processing, merchant management, and financial operations.

## Other TIB Finance SDKs

| SDK | Repository |
|-----|------------|
| Python | [TibPythonSdk](https://github.com/TibFinance/TibPythonSdk) |
| Java | [TibJavaSdk](https://github.com/TibFinance/TibJavaSdk) |
| .NET Core | [TibDotNetCoreSdk](https://github.com/TibFinance/TibDotNetCoreSdk) |
| PHP | [TibPhpSdk](https://github.com/TibFinance/TibPhpSdk) |
| JavaScript (Browser) | [TibJavascriptSdk](https://github.com/TibFinance/TibJavascriptSdk) |
| Node.js | [TibNodeJsSdk](https://github.com/TibFinance/TibNodeJsSdk) |

## License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.

## Support

- Documentation: [doc.tib.finance](https://doc.tib.finance)
- Email: support@tib.finance
