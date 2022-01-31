
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

#### Structure related objects overview.
* Client :
    
    'Client' is what a Tib Account Called in the Api, *The client ID is required for the session creation call*. This identification is provided by TIB during the account opening

    * *This ID is a “Guid” formatted hexadecimal*.

* Services :

    The service layer allows a client to have multiple different contracts with TIB Finance. It is used only when the client act for more than one company. 
    The service determines the limits and fees according to the contract.
    The service ID is required for multiple calls. This identification is provided by TIB during the account opening. 
    
    * *This ID is a “Guid” formatted hexadecimal*.

* Merchants

    The merchant can be understood as the bank account of the client. The client may have multiple accounts to perform transactions. 
    
    The merchant has two concepts: Basic Information and Account Information.
    
    The primary merchant account is created by TIB Finance at the client account opening.

    Most of the call required the related merchant ID to define the transaction bank account. 
    
    When transaction is a collection to a customer account, it defines the money destination account. 
    
    When the transaction is a deposit to a customer account, it defines the money origin account. 
    
    Other merchant can be created through the API, but it requires a validation process.

    * *This ID is a “Guid” formatted hexadecimal.*

#### Customer related objects overview.
* Customer 

    Customers are the clients of the merchants. 
    
    They are the one the merchant collect money from, or the one the merchant deposit money to.

    The customer is only a container object that identify the entity of a person. 
    
    This object will then have payment methods attached to it for the account information. 
    
    The customer ID needs to be used when transmitting payment on the API. 
    
    * The Following Code Shows the Customer information
        ```
        var customer = Customer = new Tib.Api.Model.Customer.CustomerEntity
        {
            CustomerDescription = "", // a description of the customer
            CustomerName = "", // the customer's name
            Language = LanguageEnum.English, // LanguageEnum.English
            CustomerExternalId = "" // an Enxternal Id of the customer is it exists .
        }
        ```
* Payment methods

    The payment methods are financial accounts attached to a customer. A customer can have multiple payment methods. 

    All payment methods have a unique identifier.

    There are three payment method types supported by TIB Finance:

    * Credit card

        Credit card payment method allow the merchant to collect money from the customer’s credit card.
        
        The Following code Displays a new CreditCard payment Method Args ;
        
        ```
        var CreditCardpaymentMethodArgs = new Tib.Api.Model.PaymentMethod.CreateCreditCardPaymentMethodArgs
        {
            CustomerId = _customer,
            CreditCard = new Tib.Api.Model.PaymentMethod.CreditCardModel
            {
            CardOwner = "PlaceHolder for whatever's the card owner's name.",
            CreditCardDescription = "some Desc ",
            CreditCardRegisteredAddress = new AddressModel
            {
                AddressCity = "some Desc ",
                CountryId = CountryIdEnum.USA,
                PostalZipCode = "",
                ProvinceStateId = ProvinceStateIdEnum.US_Alabama,
                StreetAddress = ""
            },
            CVD = "",
            ExpirationMonth = 5,
            ExpirationYear = 2029,
            Pan = 1231,
            },
            SessionToken = _session,
            Language = LanguageEnum.English,
            IsCustomerAutomaticPaymentMethod = false,
            SkipValidation = true
        };
        ```
    
    * Bank account
        Bank account payment method type allow to perform direct deposit and process pre-authorised payment.
        The following Code demonstrates the CreateBankAccountArgs 
        ```
        var Account  = new Tib.Api.Model.PaymentMethod.CreateDirectAccountPaymentMethodArgs
        {
            CustomerId = _customer,
            Account = new Tib.Api.Model.PaymentMethod.AccountModel
            {
                AccountName = "placeholder for whatever name you like.",
                AccountNumber = "000000000000000",
                BankNumber = "1111111",
                CheckDigit = "111",
                InstitutionNumber = "1111111",
                Owner = "placeholder for wheteber the owner's name",
            },
            IsCustomerAutomaticPaymentMethod = false,
            IsCustomerWithdrawaAuthorized = false,
            Language = LanguageEnum.English,
            SessionToken = _session,
        } 
        ```

    * Interac

        This payment method type allows to use Interac to collect or deposit money to a customer account.
        
        The following code shows the InteractModel Properties.
        
        ```
            var InteracModel = new Tib.Api.Model.PaymentMethod.InteracModel
            {
                Description = "", // 
                InteracAnswer = "", //
                InteracQuestion = "", //
                Owner = "", //
                TargetEmailAddress = "", //
                TargetMobilePhoneNumber = "", //
            }
        ```
 

### Transaction related objects overview.

This section explains the payment related objects to help understanding the way to process payment within the API.

#### Bills and payments.  

*It is possible with the API to create a bill and add payments for the bill. This allows the merchant to collect the customer based on bill information.*

* Bill 
* Payment


#### Bills and payments.  
#### Direct Interac  
#### ACP file  
#### Free operations

### Process related objects overview.

#### Operations.  

The operations are multiple money movement in relation with the same logical process. Every transfer requested will generate a minimum of 3 operations.

#### Transactions

All operations have multiple execution transactions. The transactions correspond to execution sequence of the operation.

#### Status  

All the transactions have status and detailed description of the execution. This are required to verify the process status. 

#### Free operations

## Environments

Calls to the service are done via a WEB service. There are two URLs for the service:
* Production: https://portal.tib.finance    
* Development: http://sandboxportal.tib.finance

## Set Up 
` Before you using the SDK you need to set the api url up and get a session id. `
`You'll also need to install [NewtownSoft](https://www.newtonsoft.com/json)`


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
*For More Methods Visit [Methods](./methods.md)*
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

For more details about mothods visit [here](./methods.md)

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
To see the full table of Country states Enumeration Go [Here](./CountryandStateEnum.md)

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


