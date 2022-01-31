
  

# Create a payment
In Order To Create a Paymemnt and Pay a bill using the Api
The Following Steps will help you achive your goal
## Get the session token

*The client ID is required for the session creation call. This identification is provided by TIB during the account opening*
```
var sessionArgs = new CreateSessionArgs()
{
	ClientId = new Guid("CLIENT_ID"), // GUID
	Username = "", // String
	Password = "", // String
};
var response = TibInvoker.Portal.CreateSession(sessionArgs);
```
*'response.SessionId' is required for future calls to the Api*

## Create merchant account

By default when Opening the Client Account TibFinance Created a primary merchant Account .

But you Can Create a merchant account with the Api, first understand that the Merchant Account has 2 concepts: **Basic Information** and **Account Information**:

The Following Code Show the MerchantModel object

```
var merchantInfo = new Tib.Api.Model.Service.MerchantModel
{
	EmailCopyTo = "",
	ExternalSystemId = "",
	Email = "",
	FavoriteProvider = ProviderEnum.CA_CreditCard_BankOfAmerica,
	Language = LanguageEnum.English,
	MerchantCurrency = CurrencyEnum.USD,
	MerchantDescription = "",
	MerchantName = "",
	PhoneNumber = "",
	ExternalSystemGroupId = "",
	Address = new AddressModel
	{
		AddressCity = "",
		CountryId = CountryIdEnum.USA,
		PostalZipCode = "",
		ProvinceStateId = ProvinceStateIdEnum.US_Kentucky,
		StreetAddress = ""
	},
	Account = new Tib.Api.Model.PaymentMethod.AccountModel
	{
		AccountName = "",
		AccountNumber = "",
		BankNumber = "",
		CheckDigit = "",
		InstitutionNumber = "",
		Owner = "",
	}
};

```

After filling out the correct information for the merchant creationg you'll need to pass the object to the CreateMerchant Method :

```
var createMerchantArgs = new Tib.Api.Model.Service.CreateMerchantArgs
{
	SessionToken = _session, / Session Guid Gotten earlier
	MerchantInfo = merchantInfo, // Merchant Info
	ServiceId = _service // ServiceId
}

var result = TibInvoker.Portal.CreateMerchant(createMerchantArgs)
```
*save the merchant Id to user it Later when creating bills and*
 

## Create Customer

Customers are the clients of the merchants. They are the one the merchant collect money from, or the one the merchant deposit money to.

The customer is only a container object that identify the entity of a person. This object will then have payment methods attached to it for the account information. The customer ID needs to be used when transmitting payment on the API.

*This ID is a “Guid” formatted hexadecimal*

The Following Code Show the Customer Entity
```
var customer = new Tib.Api.Model.Customer.CustomerEntity
{
	CustomerDescription = "",
	CustomerName = "",
	Language = LanguageEnum.English,
	CustomerExternalId = ""
}
```

This code is the args to create a customer
```
var createCustomerArgs = new Tib.Api.Model.Customer.CreateCustomerArgs
{
	SessionToken = _session,
	ServiceId = _service,
	Customer = customer
}
```
This is the actual api call to create the customer

```
var result = TibInvoker.Portal.CreateCustomer(createCustomerArgs);
```

## Create Payment Methods

The payment methods are financial accounts attached to a customer. A customer can have multiple payment methods. All payment methods have a unique identifier.

This section Explains how to create a payment method and attache it to a customer with the Api.

Currently the TibFinance Support Those 3 payment Method Types:

* Credit card
* Bank account
* Interac 

#### Credit card

Credit card payment method allow the merchant to collect money from the customer’s credit card.

The Following the CreditCardModel
```
var creditCardModel = new Tib.Api.Model.PaymentMethod.CreditCardModel
{
	CardOwner = "",
	CreditCardDescription = "",
	CreditCardRegisteredAddress = new AddressModel
	{
		AddressCity = "",
		CountryId = CountryIdEnum.USA,
		PostalZipCode = "",
		ProvinceStateId = ProvinceStateIdEnum.US_Alabama,
		StreetAddress = ""
	},
	CVD = "",
	ExpirationMonth = 5,
	ExpirationYear = 2029,
	Pan = 1231,
}

```
The Following code is the Arguments for creating Create Credit Card Payment method
```
var args = new Tib.Api.Model.PaymentMethod.CreateCreditCardPaymentMethodArgs
{
	CustomerId = new Guid(), /// ID of the customer you wanna create the payment method for.
	CreditCard = creditCardModel,
	SessionToken = _session,
	Language = LanguageEnum.English,
	IsCustomerAutomaticPaymentMethod = false,
	SkipValidation = true
}
```
And this following code is the call that Creates the Credit Card paymemnt Method.
```
var result = TibInvoker.Portal.CreateCreditCardPaymentMethod(args)
```

#### Bank account

Bank account payment method type allow to perform direct deposit and process pre-authorised payment.

The Following code Displays the Arguments to create a BankAccount Payment Method.
```
var directAccountArgs = new Tib.Api.Model.PaymentMethod.CreateDirectAccountPaymentMethodArgs
{
	CustomerId = _customer,
	Account = new Tib.Api.Model.PaymentMethod.AccountModel
    {
		AccountName = "",
		AccountNumber = "",
		BankNumber = "",
		CheckDigit = "",
		InstitutionNumber = "",
		Owner = "",
	},
	IsCustomerAutomaticPaymentMethod = false,
	IsCustomerWithdrawaAuthorized = false,
	Language = LanguageEnum.English,
	SessionToken = _session,
};

var result = TibInvoker.Portal.CreateDirectAccountPaymentMethod(directAccountArgs);
```
#### Interac

This payment method type allows to use Interac to collect or deposit money to a customer account.

The following  code displays the Arguments to Create an Interac Payment Method.
```
var interacArgs = new Tib.Api.Model.PaymentMethod.CreateInteracPaymentMethodArgs
{
	CustomerId = new Guid(),
	InteracInformation = new Tib.Api.Model.PaymentMethod.InteracModel
	{
		Description = "",
		InteracQuestion = "",
		InteracAnswer = "",
		Owner = "",
		TargetEmailAddress = "",
		TargetMobilePhoneNumber = ""
	},
	IsCustomerAutomaticPaymentMethod = false, 
	Language = LanguageEnum.English, 
	SessionToken = _session
}; 
```
Then call the Create Interac Method 
```
var result  = TibInvoker.Portal.CreateInteracPaymentMethod(interacArgs);
```

## Bills and payments.
To begin proccessing payments with the Api you need first to create a bill.

#### Create a bill 
When creating a bill, it will return the created bill ID for further operation on the bill. Save that Id For Further operations on that bill.

*NOTE that the Merchant needs to be authorized to Use the Id to create a bill for.*

The following code displays the information needed for a bill Entitty
```
var bill = new BillEntity
{
	BillAmount = amount,
	BillCurrency = (CurrencyEnum)currency,
	BillDescription = desc,
	BillTitle = title,
	Language = (LanguageEnum)language,
	MerchantId = new Guid(), // Id of the Merchant you wanna create the bill for
	RelatedCustomerId = new Guid(), // Id of the customer you wanna create the bill for.
	UseConvenientFeeRule = false
}
```
Here the Arguments for creating a bill
```
var createBillArgs = new CreateBillArgs
{
	SessionToken = _session,
	BreakIfMerchantNeverBeenAuthorized = true,
	BillData = bill
}
```
Now we call the create bill method
```
var result = **TibInvoker**.Portal.CreateBill(createBillArgs)
```
*Now that we have the bill we can start creating payments for that bill .*

#### Create Payments 
There is multiple way for the system to process the payment. The most common values used are “Auto select easier” and “Anonymous”. 
The first mode will process the payment using the information provided. 
The second will transmit the payment by email to an unknown customer

The following code show the Arguments needed for Creating a payment

*In this Example We are working with Annonymous Payment*
```
var paymentArgs = new CreatePaymentArgs
{
	BillId = _bill, // bill Id For the bill we have just created.
	SessionToken = _session, 
	CustomerEmail = "",
	PaymentInfo = new Tib.Api.Model.PaymentMethod.PaymentEntity
	{
		PaymentFlow = PaymentFlowEnum.AnonymousNeedCustomerEmailPropertySet,
		Language = LanguageEnum.English
	},
	StatementDescription = ""
}
```
> PaymentFlow.AnonymousNeedCustomerEmailPropertySet Makes the CustomerEmail Required

Then Call the create payment method.
```
 var result = TibInvoker.Portal.CreatePayment(paymentArgs)
```

By this you now have created a payment for a bill.