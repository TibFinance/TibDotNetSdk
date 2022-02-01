
# Tib Dot Net SDK 

This is a technical document on how to use the Tib DotNet SDK.

## Content Table  

[Overview](#overview)

[API Objects Overview](#api-objects-overview)

[Environments](#environments)

[The Set Up](#set-up)

[Methods](#methods)

[Handling Response](#handeling-response)

[General Objects and  Enumerations.](#general-objects-and-enumerations)

## Overview 
Before you start Using the Sdk you'll need to know some basic concept the We Use and the Different Objects and Whats their role in  the app.

### API Objects Overview

To understand how to use the API, you must understand the Different objects of the application. 

For details See the pdf [Documentation](./Documentation/TIB%20API%20ENGLISH%20VERSION_2_1.pdf).

## Environments

Calls to the service are done via a WEB service. There are two URLs for the service:
* Production: https://portal.tib.finance    
* Development: http://sandboxportal.tib.finance

## Set Up 
` Before you using the SDK you need to set the api url up and get a session id. `

`You'll also need to install` [NewtownSoft](https://www.newtonsoft.com/json)

* Initialize the siteurl by using this line under: this Allows the SDK to know which Api to Call the methods from.

*the link can be either the Sandbox or the production Envirement (we are using the sandbox version in this code sample)*

``` TibInvoker.InitializePortal(_siteUrl); ```

* Then Create a session

    ```   
    CreateSessionArgs sessionArgs = new CreateSessionArgs()
    {
        ClientId = new Guid("CLIENT_ID"), // GUID
        Username = "", // String
        Password = "", // String
    };
    CreateSessionResponse response = TibInvoker.Portal.CreateSession(sessionArgs); 
    ```
    
The ``` TibInvoker.Portal.CreateSession(sessionArgs); ``` method return an object containing the SessionId that needs to be passed with each Call.

See [Demo](./Documentation/Demo.md) for a step by step from how to Create a session to Creating a payment for a bill.

## Methods 

` after you set up the api url and created a session you can start Using the Other Methods of the Sdk `

*here you see one Example but you'll see more Examples of Using the SDK in the ```Program.cs``` File*

Ex :

``` 
var createCustomerArgs = new CreateCustomerArgs
{
    SessionToken = _session // Guid,
    ServiceId = _service, // guid, Id of the Service you wanna add the Customer to.
    Customer = new CustomerEntity // the customer Object.
    {
        CustomerDescription = Description, // customer description
        CustomerName = name, // customer name
        Language = (LanguageEnum)lang, // the default language ir for the 
        CustomerExternalId = externalId
    }
}
var result = TibInvoker.Portal.CreateCustomer(createCustomerArgs);
```
*For More Methods Visit [Methods](./Documentation/methods.md)*
## Handling Response 

Each Api Call Return a response Object that Follow the same Object structure 

Ex : this is the base Response that the Sdk use, Every Other Custom response implements this Class Plus it's own properties depending on the Call and it's return 

```
// Client base Response.
public class ClientBaseResponse
{
    public List<BaseServiceError> Errors { get; set; }
    public bool HasError { get; set; }
    public string Messages { get; set; }
}

// base Service Error Class
public class BaseServiceError
{
    public string ErrorMessage { get; set; }
    public int ErrorCode { get; set; }
}
```
We can have many ways to handle the response, now we will focus on how to handle errors here:
- the most important properties of the object when it comes to Error Handling are :
    * "HasError" which is a boolean that tells you either the response has an error or not 
    * "Errors" which is an array of Errors
    * "Messages" the message that somes with the Response (eeven if no error is presented).

- so basicaly you can do something like : 
    ```
    private static void ResponseHandler(ClientBaseResponse obj)
    {
        // check the HasError Propertie if it's true or false.
        if (obj.HasError)
        { 
            // Do something if the response have Error in it.
        }
        else
        {
            // do Something if the Response doesn't have error in it .
        }
    }
    ```
    * This is a Real life Example of how to refresh the session token after the response returns a session expired :
    ```
    private static void ResponseHandler(ClientBaseResponse obj)
    {
        // check the HasError Propertie if it's true or false.
        if (obj.HasError)
        { 
            // Do something if the response have Error in it.
            if (obj.Messages == "Need an authenticated user to perform this action")
            {
              OpenSession();
            }
        }
        else
        {
            // do Something if the Response doesn't have error in it .
        }
    }      
    ```
this is a way to handle a response , you can choose your own way to handle the response you get. 
just keep in mind that every response contains the said properties

For more details about mothods visit [here](./Documentation/methods.md)

## General Objects and  Enumerations. 

### Address global object 
```
var address = new AddressModel
{
    AddressCity = "some Desc ", // City Name 
    CountryId = CountryIdEnum.USA, // User the CountryIdEnum Enumerations Available under Tib.Api.Model.Enums
    PostalZipCode = "", // the zip Code
    ProvinceStateId = ProvinceStateIdEnum.US_Alabama, // Use the ProvinceStateIdEnum Available under Tib.Api.Model.Enums
    StreetAddress = ""
}
```


### LanguageEnum
```
public enum LanguageEnum
{
    Unkown = -1,
    NotSet = 0,
    French = 1,
    English = 2
}
```

### CurrencyEnum
```
public enum CurrencyEnum
{
    Unkown = -1,
    NotSet = 0,
    CAD = 1,
    USD = 2
}
```

### PaymentMethodTypeEnum
```
public enum PaymentMethodTypeEnum
{
    Unkown = -1,
    NotSet = 0,
    CreditCard = 1,
    DirectAccount = 2,
    Interac = 3
}
```

### AutorizedPaymentMethodFlags
```
public enum AutorizedPaymentMethodFlags
{
    Unkown = -1,
    NotSet = 0,
    CreditCard = 1,
    DirectAccount = 2,
    CreditCardPPA = 4,
    DirectAccountPPA = 8
}
```

### CountryIdEnum
```
public enum CountryIdEnum
{
    Unkown = -1,
    NotSet = 0,
    Canada = 1,
    USA = 2
}
```

### Provinces / States enumeration
To see the full ProvinceStateIdEnum Go [Here](./Documentation/CountryandStateEnum.md)

### TransferDirectionEnum
```
public enum TransferDirectionEnum
{
    Unkown = -1,
    NotSet = 0,
    Collect = 1,
    Deposit = 2
}
```

### TransferTypeEnum
```
public enum TransferTypeEnum
{
    Unkown = -1,
    NotSet = 0,
    Payment = 1,
    FreeDeposit = 2,
    FreeCollection = 3,
    Fee = 4,
    Revert = 5
}
```

### TransferFrequencyEnum
```
public enum TransferFrequencyEnum
{
    Unkown = -1,
    Once = 0,
    Daily = 1,
    Weekly = 2,
    EveryTwoWeeks = 3,
    Monthly = 4,
    Trimester = 5,
    BiAnnually = 6,
    Annually = 7
}
```

### DateTypeEnum
```
public enum DateTypeEnum
{
    Unkown = -1,
    NotSet = 0,
    CreatedDate = 1,
    LastModifiedDate = 2
}
```

### OperationTargetEnum
```
public enum OperationTargetEnum
{
    Unkown = -1,
    NotSet = 0,
    Customer = 1,
    Merchant = 2,
    TibClient = 3,
    Tib = 100
}
```

### OperationTypeEnum
```
public enum OperationTypeEnum
{
    Unkown = -1,
    NotSet = 0,
    Validation = 1,
    Transmission = 2,
    StatusCheck = 3,
    PaybackCheck = 4
}
```

### WhiteLabeling Levels Enum  
```
public enum WhitelabelingLevelsEnum
{
    Default = -1,
    NotSet = 0,
    Merchant = 1,
    Service = 2,
    Client = 3,
}
```


