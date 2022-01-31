
# Methods

## List Of Methods

* #### Customers
	* [Create a customer](#create-customer).
	* [List all service customers](#list-all-service-customers).
	* [Get a customer detail](#get-a-customer-detail).
	* [List the customers based on external identification](#list-the-customers-based-on-external-identification).
	* [Modify an existing customer](#modify-an-existing-customer).
	* [Delete a customer](#delete-a-customer).

* #### Payment methods
	* [Create bank account payment method](#create-bank-account-payment-method).
	* [Create credit card payment method](#create-credit-card-payment-method).
	* [Create Interac payment method](#create-Interac-payment-method).
	* [Change Interac Payment Method Question and Answer](#change-Interac-Payment-Method-Question-and-Answer)
	* [Get a specific payment method](#get-a-specific-payment-method).
	* [List payment methods](#list-payment-methods)
	* [Change the default payment method of a customer](#change-the-default-payment-method-of-a-customer).
	* [Delete payment method](#delete-payment-method).
	* 
* #### Payments / Transfers
	* [Create Bill](#create-bill).
	* [List Bill](#list-bill).
	* [Get Bill](#get-bill).
	* [Delete Bill](#delete-bill).
	* [Create Payment](#create-payment).
	* [Create Direct Deposit](#create-direct-deposit).
	* [Create Interac Transfer](#create-interac-transfer).
	* [Create from ACP File](#create-from-acp-file).
	* [Create Free Operation](#create-free-operation).
	* [Delete Transfer](#delete-transfer).
	* [Revert Transfer](#revert-transfer).
	* [List Recuring](#list-recuring).
	* [Delete Recuring process](#delete-recuring-process).
	* [Reporting of Operation](#reporting-of-operation)
	* [List Executed Operations](#list-executed-operations).

* #### Merchants
	* [Merchant basic information object](#merchant-basic-information-object).

* #### Whitelabeling (UI Looks)
	* [Set WhiteLabeling](#set-whiteLabeling)
	* [Delete WhiteLabeling](#delete-whiteLabeling)
	* [Get WhiteLabeling](#get-whiteLabeling)
	* [Update WhiteLabeling Values](#update-whiteLabeling-alues)
	* [Get List of WhiteLabeling (related Services/Merchants)](#get-list-of-whiteLabeling)
	
* #### Clients
	* [sub-client](#sub-client)
	* [Set client default service fee settings](#set-client-default-service-fee-settings)
	* [Set client settings](#set-client-settings)
	* [Get client settings](#get-client-settings)
  
## Usage

## Customers Methods
` after you set up the api url and created a session you can start Using the Other Methods of the Sdk `

*here you see one Example but you'll see more Examples of Using the SDK in the ```Program.cs``` File*
### Create customer
```
var createCustomerArgs = new CreateCustomerArgs
{
	SessionToken = new Guid("") // Guid You Get For Creating a new Session,
	ServiceId = new Guid(""), // guid, Id of the Service you wanna add the Customer to.
	Customer = new CustomerEntity // the customer Object.
	{
		CustomerDescription = "", // customer description
		CustomerName = "", // customer name
		Language = LanguageEnum.English, // English or Frensh
		CustomerExternalId = "" // an Customer Identifier's if it exists
	}
};
var result = TibInvoker.Portal.CreateCustomer(createCustomerArgs);
```

### List all service customers
```
var GetServiceCustomersArgs = new Tib.Api.Model.Customer.ListCustomersArgs
{
	SessionToken = new Guid(""), // The session token you get when creating a new session.
	ServiceId = new Guid("") // The Service you want the Customers list of.
};
var result = TibInvoker.Portal.ListCustomers(GetServiceCustomersArgs);
```

### Get a customer detail
```
var GetCustomerDetailsArgs = new Tib.Api.Model.Customer.GetCustomerArgs{
	SessionToken = new Guid(""), // session token
	CustomerId = new Guid("") // customer Id
};
var result = TibInvoker.Portal.GetCustomer(GetCustomerDetailsArgs);
```

### List the customers based on external identification
```
var getCustomersByExternalIdArgs=  new Tib.Api.Model.Customer.GetCustomersByExternalIdArgs{
	SessionToken = new Guid(""),
	ExternalCustomerId = "" // External customer Id 
};
var result = TibInvoker.Portal.GetCustomersByExternalId(getCustomersByExternalIdArgs);
```

### Modify an existing customer
```
var updateCustomerArgs = new Tib.Api.Model.Customer.SaveCustomerArgs
{
	SessionToken = new Guid(""),
	Customer = new Tib.Api.Model.Customer.CustomerModel
	{
		CustomerId = new Guid(""),
		CustomerDescription = "",
		CustomerExternalId = "",
		CustomerName = "",
		Language = LanguageEnum.English,
	}
};
var result = TibInvoker.Portal.SaveCustomer(updateCustomerArgs);
```

### Delete a customer
```
var deleteCustomerArgs = new Tib.Api.Model.Customer.DeleteCustomerArgs
{
	SessionToken = new Guid(""),
	CustomerId = new Guid("")
};
var result = TibInvoker.Portal.DeleteCustomer(deleteCustomerArgs);
```

## Payment methods

### Create bank account payment method

```
var createdDirectAccountArgs = new Tib.Api.Model.PaymentMethod.CreateDirectAccountPaymentMethodArgs
{
	CustomerId = new Guid(""), // customer Id to add the payment method to .
	SessionToken = new Guid(""), // Session Id to be able to call the Api
	Account = new Tib.Api.Model.PaymentMethod.AccountModel // information about the payment method
	{
		AccountName = "", // the Account Name
		AccountNumber = "", /: the account number 
		BankNumber = "", // the bank number 
		CheckDigit = "", // the Check digits
		InstitutionNumber = "", // the institution number
		Owner = "", // the owner's name.
	},
	IsCustomerAutomaticPaymentMethod = false,
	IsCustomerWithdrawaAuthorized = false,
	Language = LanguageEnum.English,
}
var result = TibInvoker.Portal.CreateDirectAccountPaymentMethod(createdDirectAccountArgs)
```

### Create credit card payment method
```
var CreateCreditCardArgs = new Tib.Api.Model.PaymentMethod.CreateCreditCardPaymentMethodArgs
{
	CustomerId = new Guid(""),
	CreditCard = new Tib.Api.Model.PaymentMethod.CreditCardModel
	{
		CardOwner = "", // Card Owner Name
		CreditCardDescription = "", // A description to the card
		CreditCardRegisteredAddress = new AddressModel // Address registered for this card
		{
			AddressCity = "",
			CountryId = CountryIdEnum.USA,
			PostalZipCode = "",
			ProvinceStateId = ProvinceStateIdEnum.US_Alabama,
			StreetAddress = ""
		},
		CVD = "",
		ExpirationMonth = 5, // expiration month 
		ExpirationYear = 2029, // expiration Year
		Pan = 1231, // pan number
	},
	SessionToken = new Guid(""),
	Language = LanguageEnum.English,
	IsCustomerAutomaticPaymentMethod = false,
	SkipValidation = true
}
var result = TibInvoker.Portal.CreateCreditCardPaymentMethod(CreateCreditCardArgs)
```


### Create Interac payment method

``` 
var createInteracPaymentMethodArgs = new Tib.Api.Model.PaymentMethod.CreateInteracPaymentMethodArgs{
	CustomerId = new Guid(),
	InteracInformation = new Tib.Api.Model.PaymentMethod.InteracModel
	{
		Description = "", // description of the method
		InteracAnswer = "", // intrac Answer
		InteracQuestion = "", // interac Question
		Owner = "", // the owner name
		TargetEmailAddress = "", // the target email
		TargetMobilePhoneNumber = "" // the target phone number
	},
	IsCustomerAutomaticPaymentMethod = false, 
	Language = LanguageEnum.English, 
        SessionToken = _session
}
var result  = TibInvoker.Portal.CreateInteracPaymentMethod(createInteracPaymentMethodArgs)
```

### Change Interac Payment Method Question and Answer
```
var changeInteracPaymentMethodQuestionAndAnswerArgs = new Tib.Api.Model.PaymentMethod.ChangeInteracPaymentMethodQuestionAndAnswerArgs
{
	SessionToken = new Guid(""),
	InteracAnswer = "",
	InteracPaymentMethodId = new Guid(""),
	InteracQuestion = "",
}; 
var result = TibInvoker.Portal.ChangeInteracPaymentMethodQuestionAndAnswer(changeInteracPaymentMethodQuestionAndAnswerArgs)
```

### Get a specific payment method
```
var getPaymentMethodArgs = new Tib.Api.Model.PaymentMethod.GetPaymentMethodArgs
{
	PaymentMethodId = new Guid(""), // Payment method Id 
	SessionToken = new Guid(""), // session Token
};
var result = TibInvoker.Portal.GetPaymentMethod(getPaymentMethodArgs);
```

### List payment methods
```
var getPaymentMethodArgs = new Tib.Api.Model.PaymentMethod.GetPaymentMethodArgs
{
	PaymentMethodId = new Guid(""), // Payment method Id 
	SessionToken = new Guid(""), // session Token
};
var result = TibInvoker.Portal.GetPaymentMethod(getPaymentMethodArgs);
```

### Change the default payment method of a customer
```
var listPaymentMethodArgs = new Tib.Api.Model.PaymentMethod.ListPaymentMethodsArgs
{
	CustomerId = new Guid(""), // the Id of the customer that we need the payment method list of 
	SessionToken = new Guid(""),
};
var result = TibInvoker.Portal.ListPaymentMethods(listPaymentMethodArgs);
```

### Delete payment method
```
var deletePaymentMethodArgs = new Tib.Api.Model.PaymentMethod.DeletePaymentMethodArgs
{
	PaymentMethodId = new Guid(""), // the payment method Id to delete
	SessionToken = new Guid("")
};
var result = TibInvoker.Portal.DeletePaymentMethod(deletePaymentMethodArgs);
```

## Bills / Payments / Transfers

### Create Bill
```
var createbillsArgs = new CreateBillArgs
{
    SessionToken = _session,
    BreakIfMerchantNeverBeenAuthorized = true,
    BillData = new BillEntity
    {
        BillAmount = amount,
        BillCurrency = (CurrencyEnum)currency,
        BillDescription = desc,
        BillTitle = title,
        Language = (LanguageEnum)language,
        MerchantId = _merchant,
        RelatedCustomerId = _customer,
        UseConvenientFeeRule = false
    }
};
var result = TibInvoker.Portal.CreateBill(createbillsArgs);
```

### List Bills

```
var getbillsArgs = new ListBillsArgs
{
    SessionToken = new Guid(""), // Session token
    ServiceId = new Guid(""), // the service Id
    FromDateTime = new DateTime(2020, 12, 31), // start date of get bills search query
    ToDateTime = DateTime.Now, // end date of the get bill search query
    MerchantId = _merchant // merchant Id 
}
```

### Get Bill

```
var getBillArgs = new GetBillArgs
{
    SessionToken = _session,
    BillId = _bill
}; 
var result = TibInvoker.Portal.GetBill(getBillArgs)
```

### Delete Bill
```
var deleteBillArgs = new DeleteBillArgs
{
    SessionToken = _session,
    BillId = _bill
};
var result = TibInvoker.Portal.DeleteBill();
```
*Keep in mind that you'll have to implement your own verification logic to avoid deleting a bill by mistake*

### Create Payment

```
var createPaymentArgs = new CreatePaymentArgs
{
    BillId = _bill,
    SessionToken = _session,
    CustomerEmail = customerEmail,
    PaymentInfo = new Tib.Api.Model.PaymentMethod.PaymentEntity
    {
        PaymentFlow = paymentFlow,
        Language = language
    },
    StatementDescription = ""
}; 
TibInvoker.Portal.CreatePayment(createPaymentArgs)
```

### Create Direct Deposit
```
var createDirectDipositArgs = new CreateDirectDepositArgs
{
    SessionToken = _session,
    Amount = 1,
    Currency = CurrencyEnum.USD,
    DepositDueDate = DateTime.Now.AddDays(1),
    DestinationAccount = new Tib.Api.Model.PaymentMethod.AccountModel
    {
        AccountName = accountName,
        BankNumber = bankNumber,
        CheckDigit = CheckDegit,
        InstitutionNumber = InsNumber,
        Owner = Owner,
        AccountNumber = accountNumber,
    },
    Language = LanguageEnum.English,
    OriginMerchantId = _merchant,
    StatementDescription = ""
}; 
var result = TibInvoker.Portal.CreateDirectDeposit(createDirectDipositArgs);
```

### Create Interac Transfer

```
var createDirectInteracTransactionArgs = new CreateDirectInteracTransactionArgs
{
    SessionToken = _session,
    Amount = 1,
    Currency = CurrencyEnum.USD,
    DueDate = DateTime.Now.AddDays(1),
    InteracInformation = new Tib.Api.Model.PaymentMethod.InteracModel
    {
        Description = "description of the interac",
        InteracAnswer = "TheAnswer",
        InteracQuestion = "TheQuestion",
        Owner = "the Owner",
        TargetEmailAddress = "theEmail@gmail.com",
        TargetMobilePhoneNumber = "1212302190",
    },
    Language = LanguageEnum.English,
    MerchantId = _merchant,
    ReferenceNumber = "1233029920",
    TransferDirection = TransferDirectionEnum.Deposit,
    StatementDescription = ""
};
var result = TibInvoker.Portal.CreateDirectInteracTransaction(createDirectInteracTransactionArgs)
```
### Create from ACP file
```
var createTransactionFromRawArgs = new Tib.Api.Model.Bill.CreateTransactionFromRawArgs
{
    SessionToken = _session,
    MerchantId = _merchant,
    RawAcpFileContent = "",
}
var result = TibInvoker.Portal.CreateTransactionFromRaw(createTransactionFromRawArgs)
```
### Create Free Operation
```
var createDirectDepositArgs = new CreateDirectDepositArgs
{
    SessionToken = _session,
    Amount = 1,
    Currency = CurrencyEnum.USD,
    DepositDueDate = DateTime.Now.AddDays(1),
    DestinationAccount = new Tib.Api.Model.PaymentMethod.AccountModel
    {
        AccountName = accountName,
        BankNumber = bankNumber,
        CheckDigit = CheckDegit,
        InstitutionNumber = InsNumber,
        Owner = Owner,
        AccountNumber = accountNumber,
    },
    Language = LanguageEnum.English,
    OriginMerchantId = _merchant,
    StatementDescription = ""
}
var result = var result = TibInvoker.Portal.CreateDirectDeposit(createTransactionFromRawArgs)
```
### Delete Transfer
```
var deletePaymentArgs = new DeletePaymentArgs
{
    SessionToken = _session,
    PaymentId = _payment.Value,
};
var result = TibInvoker.Portal.DeletePayment(deletePaymentArgs)
```
### Revert Transfer
```
var revertTransferArgs = new Tib.Api.Model.PaymentMethod.RevertTransferArgs
{
    SessionToken = _session,
    TransferId = _transfer.Value,
}; 
var result = TibInvoker.Portal.RevertTransfer(revertTransferArgs)
```
### List Recuring
```
var recuringList  = new GetRecuringTransfersArgs
{
    SessionToken = _session,
    ServiceID = _service
};
var return  = TibInvoker.Portal.GetRecuringTransfers(recuringList);
```

### Delete Recuring process
```
var deleteRecuringTransferArgs = new DeleteRecuringTransferArgs
{
    SessionToken = _session,
    RecuringTransferId = new Guid(""),
};
var result = TibInvoker.Portal.DeleteRecuringTransfer(deleteRecuringTransferArgs);
```

## Reporting of Operation

### List Executed Operations
```
var listExecutedOperationsArgs = new Tib.Api.Model.Report.ListExecutedOperationsArgs
{
    SessionToken = new Guid(""), // session token
    DateType = DateTypeEnum.CreatedDate,
    FromDate = new DateTime(2018, 01, 01),
    MerchantId = _merchant,
    ToDate = DateTime.Now,
    TransferType = TransferTypeFlag.All,
    OnlyWithErrors = false,
    TransferGroupId = "",
}
var result = TibInvoker.Portal.ListExecutedOperations(listExecutedOperationsArgs);
```


## Whitelabeling (UI Looks)

The Whitelabeling can be set on multiple levels 
* Client
* Service
* Merchant
please See [whitelabeling levels enums](./README.md#WhiteLabeling-levels-enum)

The WhiteLabeling Use 2 main Objects `WhiteLabelingModel` and `WhiteLabelingDataModel`
The first is a container of white labeling Values for a single entity (client, service, merchant) and have a list of `WhiteLabelingDataModel`.
The Second one represents the values that a single whitelabeling cssProperty going to have.

### Set WhiteLabeling
```
var localWhiteLabelingData = new List<WhiteLabelingDataModel>() // list of values you need for your whitelabeling
{	
	new WhiteLabelingDataModel {
		CssProperty = "button-color",
		CssValue = "testvalue"
	}
};
var whitelabelingArgs = new SetWhiteLabelingArgs
{
	SessionToken = _session,
	WhiteLabelingLevel = 1, // int value of WhitelabelingLevelsEnum
	WhiteLabelingData = localWhiteLabelingData
};
var result = TibInvoker.Portal.SetWhiteLabeling(whitelabelingArgs);
```
### Delete WhiteLabeling

```
var DeleteWhiteLabelingArgs = new DeleteWhitelabelinArgs
{
	SessionToken = _session,
	Id = new Guid(""), // Id of the whiteLabeling to delete.
	Level = (int)WhitelabelingLevelsEnum.Merchant // int value of WhitelabelingLevelsEnum
}
var result = TibInvoker.Portal.DeleteWhiteLabeling(DeleteWhiteLabelingArgs);
```

### Get WhiteLabeling
```
var getWhiteLabelingArgs = new GetWhiteLabelingArgs { 
	SessionToken = _session,
	WhiteLabelingLevel = type,
	Id = entityId
};
var result = TibInvoker.Portal.GetWhiteLabelingData(getWhiteLabelingArgs);
```  

### Update WhiteLabeling Values

```
var localWhiteLabelingToUpdate = new List<WhiteLabelingDataModel>() {
	new WhiteLabelingDataModel {
		WhiteLabelingDataId = new Guid(""), // WL data Id you wanna update
		CssProperty  = "", // the css Prop you wanna update
		CssValue = "Brown"
	}
};
var updateWhitelabelingArgs = new UpdateWhiteLabelingDataArgs
{
	SessionToken = _session,
	UpdatedWhiteLabelingData = localWhiteLabelingToUpdate // list of WL to update.
};
var result = TibInvoker.Portal.UpdateWhiteLabeling(updateWhitelabelingArgs);
```

### Get List of WhiteLabeling
```
var wlArgs = new GetWhiteLabelingArgs { 
	SessionToken = _session 
};
var result = TibInvoker.Portal.GetListWhiteLabeling(wlArgs);
```