# TIB Finance .NET Framework SDK

![.NET Framework](https://img.shields.io/badge/.NET_Framework-4.7%2B-512BD4)

.NET Framework SDK for the TIB Finance payment processing API.

## Installation

**Option 1 — prebuilt DLL (recommended):**

1. Download `TibDotNetSdk-v<version>-dll.zip` from the latest [GitHub release](https://github.com/TibFinance/TibDotNetSdk/releases) and extract it.
2. Add a reference to `Tib.Api.dll` in your project.
3. Install the NuGet dependency (Visual Studio Package Manager Console):

```powershell
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

## Two-step sign-in (merchant- or service-level users)

The Quick Start signs in with `TibInvoker.Portal.CreateSession`, which opens a client-level session. A user whose access is limited to a merchant or a service signs in with two calls instead:

1. Call `TibInvoker.Portal.GetLoginAccessList` with the client ID, username and password. Each entry in `LoginRelations` is one access the user can open: `InternalReferenceType` gives its level (2 client, 4 merchant, 16 service) and `InternalReferenceId` the ID of that client, merchant or service. `Description` is a label for display only.
2. Call `TibInvoker.Portal.Login` with the same client ID, username and password, and the `LoginsUserRelationsId` of the chosen entry.

Send the returned `SessionId` as `SessionToken` on the following calls, as with `TibInvoker.Portal.CreateSession`. Failed sign-in attempts count toward a temporary lockout, so do not retry in a loop.

```csharp
using System;
using Tib.Api;
using Tib.Api.Model.General;
using Tib.Api.Model.Service;

var accesses = TibInvoker.Portal.GetLoginAccessList(new GetLoginAccessListArgs {
    ClientId = Guid.Parse("00000000-0000-0000-0000-000000000000"), // replace with your client id
    Username = "your_username",
    Password = "your_password"
});
if (accesses.HasError)
{
    Console.WriteLine("Sign-in failed: " + accesses.Messages);
}
else
{
    // Each entry is one access: pick the one to open
    // (InternalReferenceType: 2 client, 4 merchant, 16 service).
    var access = accesses.LoginRelations[0];
    var response = TibInvoker.Portal.Login(new LoginArgs {
        ClientId = Guid.Parse("00000000-0000-0000-0000-000000000000"), // replace with your client id
        Username = "your_username",
        Password = "your_password",
        LoginsUserRelationsId = access.LoginsUserRelationsId
    });
    if (response.HasError)
    {
        Console.WriteLine("Sign-in failed: " + response.Messages);
    }
    else
    {
        var services = TibInvoker.Portal.ListServices(new ListServicesArgs { SessionToken = response.SessionId });
    }
}
```

## Documentation

For the complete API reference and guides, visit [doc.tib.finance](https://doc.tib.finance).

This SDK provides access to **67 API methods** for payment processing, merchant management, and financial operations.

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
