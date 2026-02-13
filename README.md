# TIB Finance .NET Framework SDK

![.NET Framework](https://img.shields.io/badge/.NET_Framework-4.7%2B-512BD4)

.NET Framework SDK for the TIB Finance payment processing API.

## Installation

```bash
git clone https://github.com/TibFinance/TibDotNetSdk.git
```

Add a reference to `Tib.Api.dll` in your project.

## Quick Start

```csharp
using Tib.Api;

TibInvoker.InitializePortal("https://sandboxportal.tib.finance");

var sessionArgs = new CreateSessionArgs {
    ClientId = "your_client_id",
    Username = "your_username",
    Password = "your_password"
};
var response = TibInvoker.Portal.CreateSession(sessionArgs);
Console.WriteLine(response.SessionId);
```

## Documentation

For the complete API reference and guides, visit [doc.tib.finance](https://doc.tib.finance).

This SDK provides access to **56 API methods** for payment processing, merchant management, and financial operations.

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
