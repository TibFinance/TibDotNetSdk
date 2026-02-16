
// ***********************************************************************
// Assembly         : Tib.Api
// Author           : cboivin
// Created          : 05-15-2019
//
// Last Modified By : cboivin
// Last Modified On : 09-09-2019
//
// Last Modified By : TIB Finance
// Last Modified On : 04-14-2021
// ***********************************************************************
// <copyright file="PortalInvoker.cs" company="Tib.finance">
//     Copyright ©  2026
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using Tib.Api.Model;
using Tib.Api.Model.General;
using Tib.Api.Model.Service;
using Tib.Api.Model.Merchant;
using Tib.Api.Model.Boarding;
using Tib.Api.Model.Customer;
using Tib.Api.Model.PaymentMethod;
using Tib.Api.Model.Bill;
using Tib.Api.Model.Payment;
using Tib.Api.Model.FreeModeOperation;
using Tib.Api.Model.DropIn;
using Tib.Api.Model.FreeOperation;
using Tib.Api.Model.Client;
using Tib.Api.Model.Transfer;
using Tib.Api.Model.Supplier;



namespace Tib.Api
{
  /// <summary>
  /// Class PortalInvoker.
  /// </summary>
  public class PortalInvoker
  {
    /// <summary>
    /// The client
    /// </summary>
    private ApiClient _client = null;

    /// <summary>
    /// Initializes a new instance of the <see cref="PortalInvoker"/> class.
    /// </summary>
    public PortalInvoker()
    {
    }

    /// <summary>
    /// Sets the site URL.
    /// </summary>
    /// <param name="siteUrl">The site URL.</param>
    internal void SetSiteUrl(string siteUrl)
    {
      _client = new ApiClient(siteUrl);
    }

    /// <summary>
/// Retrieves wallet operations and transaction history for a specified service within a date range.
/// </summary>
/// <param name="args">The arguments.</param>
/// <returns>GetWalletOperationsResponse.</returns>
public GetWalletOperationsResponse GetWalletOperations(GetWalletOperationsArgs args)
{
    return _client.Call<GetWalletOperationsResponse>("GetWalletOperations", args);
}

/// <summary>
/// Creates a new supplier associated with a merchant.
/// </summary>
/// <param name="args">The arguments.</param>
/// <returns>CreateSupplierResponse.</returns>
public CreateSupplierResponse CreateSupplier(CreateSupplierArgs args)
{
    return _client.Call<CreateSupplierResponse>("CreateSupplier", args);
}

/// <summary>
/// Retrieves the list of suppliers associated with a merchant.
/// </summary>
/// <param name="args">The arguments.</param>
/// <returns>GetSuppliersResponse.</returns>
public GetSuppliersResponse GetSuppliers(GetSuppliersArgs args)
{
    return _client.Call<GetSuppliersResponse>("GetSuppliers", args);
}

/// <summary>
/// Creates a transfer to a supplier.
/// </summary>
/// <param name="args">The arguments.</param>
/// <returns>CreateSupplierTransferResponse.</returns>
public CreateSupplierTransferResponse CreateSupplierTransfer(CreateSupplierTransferArgs args)
{
    return _client.Call<CreateSupplierTransferResponse>("CreateSupplierTransfer", args);
}

/// <summary>
/// Initiates a retry process for a merchant's failed transfer operation.
/// </summary>
/// <value>This function is designed to handle scenarios where a merchant's transfer has failed, allowing the system to attempt the transfer again. It ensures that any temporary issues are addressed, and the transfer process is completed successfully.</value>
/// <param name="args">The function takes a merchant ID and transfer ID as parameters to identify the specific transfer operation that needs to be retried.</param>
/// <returns>Returns a status indicating the success or failure of the retry operation.</returns>
public RelaunchMerchantFailedTransferResponse RelaunchMerchantFailedTransfer(RelaunchMerchantFailedTransferArgs args)
{
    return _client.Call<RelaunchMerchantFailedTransferResponse>("RelaunchMerchantFailedTransfer", args);
}

/// <summary>
/// Resends the payment notification email to the specified recipient.
/// </summary>
/// <value>This function is used to trigger the sending of a payment notification email again, in case the initial email was not received or needs to be re-sent for any reason.</value>
/// <param name="args">The function requires the email address of the recipient to whom the payment notification should be resent.</param>
/// <returns>Returns a status indicating whether the email was successfully resent.</returns>
public ResendPaymentEmailResponse ResendPaymentEmail(ResendPaymentEmailArgs args)
{
    return _client.Call<ResendPaymentEmailResponse>("ResendPaymentEmail", args);
}

/// <summary>
/// Creates a new sub-client within the TIB Finance system.
/// </summary>
/// <value>This function facilitates the creation of a sub-client, allowing a parent client to manage multiple entities under a single account. It is essential for clients who operate with multiple subsidiaries or departments, providing them with the ability to segregate operations and financial transactions.</value>
/// <param name="args">The function requires specific parameters such as the parent client ID and sub-client details, which include name, contact information, and financial settings.</param>
/// <returns>Returns a unique identifier for the newly created sub-client, formatted as a GUID.</returns>
public CreateSubClientResponse CreateSubClient(CreateSubClientArgs args)
{
    return _client.Call<CreateSubClientResponse>("CreateSubClient", args);
}

/// <summary>
/// Initializes the boarding process for a new client within the TIB Finance API.
/// </summary>
/// <value>This function sets up the necessary parameters and configurations to onboard a new client, ensuring that all required information is collected and validated.</value>
/// <param name="args">Takes client-specific data required for the onboarding process.</param>
/// <returns>Returns a confirmation of successful initialization or an error message if the process fails.</returns>
public InitBoardingResponse InitBoarding(InitBoardingArgs args)
{
    return _client.Call<InitBoardingResponse>("InitBoarding", args);
}

/// <summary>
/// Modifies the security question and answer for an Interac payment method associated with a customer account.
/// </summary>
/// <value>This function updates the security question and answer used for verifying Interac transactions. It is crucial for ensuring the security of transactions and preventing unauthorized access.</value>
/// <param name="args">Accepts parameters for the new security question and answer, along with the identifier of the payment method to be updated.</param>
/// <returns>Returns a confirmation of the update operation, indicating success or failure.</returns>
public ChangeInteracPaymentMethodQuestionAndAnswerResponse ChangeInteracPaymentMethodQuestionAndAnswer(ChangeInteracPaymentMethodQuestionAndAnswerArgs args)
{
    return _client.Call<ChangeInteracPaymentMethodQuestionAndAnswerResponse>("ChangeInteracPaymentMethodQuestionAndAnswer", args);
}

/// <summary>
/// Reverts a previously executed transfer operation, restoring the original state of the involved accounts.
/// </summary>
/// <value>This function is used to reverse a transfer that has already been processed. It ensures that the accounts involved in the transaction are returned to their initial states before the transfer occurred.</value>
/// <param name="args">The function requires a unique identifier for the transfer to be reverted.</param>
/// <returns>Returns a status indicating the success or failure of the revert operation.</returns>
public RevertTransferResponse RevertTransfer(RevertTransferArgs args)
{
    return _client.Call<RevertTransferResponse>("RevertTransfer", args);
}

/// <summary>
/// Initiates a batch of free operations, allowing for transactions not tied to a specific bill. This function is essential for handling payments or deposits directly linked to customer payment methods.
/// </summary>
/// <value>This function facilitates the creation of multiple free operations in a single batch, streamlining the process of handling transactions that are independent of bills.</value>
/// <param name="args">No parameters are specified for this function.</param>
/// <returns>Returns a confirmation of the batch creation, including details of each operation within the batch.</returns>
public CreateFreeOperationBatchResponse CreateFreeOperationBatch(CreateFreeOperationBatchArgs args)
{
    return _client.Call<CreateFreeOperationBatchResponse>("CreateFreeOperationBatch", args);
}

/// <summary>
/// Initiates a free operation within the TIB Finance API, allowing for transactions not directly linked to a specific bill. This function is typically used to either collect payments from a customer's payment method or deposit funds into it, with the exception of credit card deposits.
/// </summary>
/// <value>This operation facilitates transactions that are independent of predefined billing structures, providing flexibility in handling customer payments and deposits.</value>
/// <param name="args">An object containing the necessary parameters to execute the free operation, including details of the transaction and the involved accounts.</param>
/// <returns>An instance of CreateFreeOperationResponse, which contains the result of the operation and any relevant transaction details.</returns>
public CreateFreeOperationResponse CreateFreeOperation(CreateFreeOperationArgs args)
{
    return _client.Call<CreateFreeOperationResponse>("CreateFreeOperation", args);
}

/// <summary>
/// Retrieves the public token necessary for initiating a drop-in session. This token is used to authenticate and authorize the session within the API framework.
/// </summary>
/// <value>This function facilitates the acquisition of a public token, which is essential for secure API interactions.</value>
/// <param name="args">The parameters required to execute this function, which may include authentication credentials or session identifiers.</param>
/// <returns>An instance of GetDropInPublicTokenResponse, containing the public token and any associated metadata.</returns>
public GetDropInPublicTokenResponse GetDropInPublicToken(GetDropInPublicTokenArgs args)
{
    return _client.Call<GetDropInPublicTokenResponse>("GetDropInPublicToken", args);
}

/// <summary>
/// Triggers the payment processing workflow for a specific payment, overriding the default automatic selection mechanism.
/// </summary>
/// <param name="args">arguments: an object that includes required identifiers such as paymentId and merchantId, and optional flags that influence processing behavior.</param>
/// <returns>ForcePaymentProcessResponse that indicates the outcome of the forced operation and provides any error information.</returns>
public ForcePaymentProcessResponse ForcePaymentProcess(ForcePaymentProcessArgs args)
{
    return _client.Call<ForcePaymentProcessResponse>("ForcePaymentProcess", args);
}

/// <summary>
/// Retrieves a list of operations that have been executed within the system. This function provides detailed information about each operation, allowing users to track and analyze completed transactions.
/// </summary>
/// <value>This function does not require any specific input parameters, as it retrieves all executed operations by default.</value>
/// <param name="args">This function does not take any parameters.</param>
/// <returns>Returns a ListExecutedOperationsResponse object containing details of the executed operations.</returns>
public ListExecutedOperationsResponse ListExecutedOperations(ListExecutedOperationsArgs args)
{
    return _client.Call<ListExecutedOperationsResponse>("ListExecutedOperations", args);
}

/// <summary>
/// Initiates a transaction using raw data input. This function processes the raw transaction details to create a valid transaction entry within the system.
/// </summary>
/// <value>This function does not require a predefined structure for input data, allowing flexibility in transaction creation.</value>
/// <param name="args">The raw data arguments necessary for transaction creation. These should include all required transaction details.</param>
/// <returns>Returns a CreateTransactionFromRawResponse object, which contains the status and details of the transaction creation process.</returns>
public CreateTransactionFromRawResponse CreateTransactionFromRaw(CreateTransactionFromRawArgs args)
{
    return _client.Call<CreateTransactionFromRawResponse>("CreateTransactionFromRaw", args);
}

/// <summary>
/// Initiates a direct Interac transaction, enabling the transfer of funds using a recipient's email or mobile phone number. This method facilitates seamless money transfers without requiring detailed customer account information.
/// </summary>
/// <value>This function is responsible for creating a direct Interac transaction, which allows for quick and efficient money transfers using the recipient's contact information.</value>
/// <param name="args">The parameters required to execute the transaction, including recipient contact details and transaction amount.</param>
/// <returns>A CreateDirectInteracTransactionResponse object containing the status and details of the transaction.</returns>
public CreateDirectInteracTransactionResponse CreateDirectInteracTransaction(CreateDirectInteracTransactionArgs args)
{
    return _client.Call<CreateDirectInteracTransactionResponse>("CreateDirectInteracTransaction", args);
}

/// <summary>
/// Removes a specified payment from the system. This function is essential for managing and rectifying payment records, ensuring that erroneous or obsolete payments are efficiently deleted.
/// </summary>
/// <value>This function does not return a value. It performs an action to delete a payment.</value>
/// <param name="args">The parameters required to identify and delete the specific payment.</param>
/// <returns>An instance of DeletePaymentResponse, indicating the success or failure of the operation.</returns>
public DeletePaymentResponse DeletePayment(DeletePaymentArgs args)
{
    return _client.Call<DeletePaymentResponse>("DeletePayment", args);
}

/// <summary>
/// Retrieves the details of a specific payment using the provided payment identifier.
/// </summary>
/// <value>This function is used to access and retrieve payment information from the system. It requires a valid payment ID to return the corresponding payment details.</value>
/// <param name="args">The unique identifier for the payment whose details are to be retrieved.</param>
/// <returns>An instance of GetPaymentResponse containing the payment details.</returns>
public GetPaymentResponse GetPayment(GetPaymentArgs args)
{
    return _client.Call<GetPaymentResponse>("GetPayment", args);
}

/// <summary>
/// Initiates a new payment transaction within the system. This function processes the payment details provided and returns a response indicating the success or failure of the operation.
/// </summary>
/// <value>This function is responsible for handling the creation of payment transactions, ensuring all necessary parameters are correctly processed.</value>
/// <param name="args">Includes all necessary payment details such as amount, currency, and payment method.</param>
/// <returns>Returns a CreatePaymentResponse object that contains the status and details of the payment transaction.</returns>
public CreatePaymentResponse CreatePayment(CreatePaymentArgs args)
{
    return _client.Call<CreatePaymentResponse>("CreatePayment", args);
}

/// <summary>
/// Deletes a recurring transfer from the system.
/// </summary>
/// <value>This function is used to remove a scheduled recurring transfer, ensuring that no future transactions are processed under this transfer setup.</value>
/// <param name="args">The function requires the unique identifier of the recurring transfer to be deleted.</param>
/// <returns>Returns a confirmation of successful deletion or an error message if the operation fails.</returns>
public DeleteRecuringTransferResponse DeleteRecuringTransfer(DeleteRecuringTransferArgs args)
{
    return _client.Call<DeleteRecuringTransferResponse>("DeleteRecuringTransfer", args);
}

/// <summary>
/// Retrieves a list of recurring transfer operations associated with the client's account. This function is essential for clients who need to manage or review their scheduled transfers.
/// </summary>
/// <value>This function accesses the database to fetch details of all recurring transfers, including their status, amounts, and scheduled dates.</value>
/// <param name="args">None required. The function operates based on the client's authenticated session.</param>
/// <returns>Returns a list of recurring transfer objects, each containing details such as transfer ID, amount, schedule, and status.</returns>
public GetRecuringTransfersResponse GetRecuringTransfers(GetRecuringTransfersArgs args)
{
    return _client.Call<GetRecuringTransfersResponse>("GetRecuringTransfers", args);
}

/// <summary>
/// Lists the transfers for a specific bill using an optimized fast query.
/// </summary>
/// <returns>ListTransfersFastResponse.</returns>
public ListTransfersFastResponse ListTransfersForBillFast(ListTransfersForBillFastArgs args)
{
    return _client.Call<ListTransfersFastResponse>("ListTransfersForBillFast", args);
}

/// <summary>
/// Lists the transfers using an optimized fast query.
/// </summary>
/// <returns>ListTransfersFastResponse.</returns>
public ListTransfersFastResponse ListTransfersFast(ListTransfersFastArgs args)
{
    return _client.Call<ListTransfersFastResponse>("ListTransfersFast", args);
}

/// <summary>
/// Retrieves a list of all transfer operations available within the system. This function provides details about each transfer, including status and associated metadata.
/// </summary>
/// <value>This function does not require any specific input parameters and returns a comprehensive list of transfer operations.</value>
/// <param name="args">No parameters are required for this function.</param>
/// <returns>An instance of ListTransfersResponse containing the details of all transfers.</returns>
public ListTransfersResponse ListTransfers(ListTransfersArgs args)
{
    return _client.Call<ListTransfersResponse>("ListTransfers", args);
}

/// <summary>
/// Removes a specified bill from the system. This operation is typically used when a bill is no longer needed or was created in error. Ensure that the bill ID is valid and corresponds to an existing bill before attempting to delete.
/// </summary>
/// <value>This function performs the deletion of a bill identified by its unique ID. It is crucial for maintaining the accuracy and integrity of billing records.</value>
/// <param name="args">The parameters required for this operation include the unique identifier of the bill to be deleted.</param>
/// <returns>A DeleteBillResponse object indicating the success or failure of the deletion operation.</returns>
public DeleteBillResponse DeleteBill(DeleteBillArgs args)
{
    return _client.Call<DeleteBillResponse>("DeleteBill", args);
}

/// <summary>
/// Retrieves a bill based on the provided criteria. This function is essential for accessing detailed billing information within the API, facilitating further operations such as payment processing or bill management.
/// </summary>
/// <value>This function does not require additional input parameters beyond those specified in the param field.</value>
/// <param name="args">The parameters required to identify and retrieve the specific bill. These may include identifiers such as Bill ID or Customer ID.</param>
/// <returns>Returns a GetBillResponse object containing detailed information about the requested bill, including its status, amount, and associated customer details.</returns>
public GetBillResponse GetBill(GetBillArgs args)
{
    return _client.Call<GetBillResponse>("GetBill", args);
}

/// <summary>
/// Initiates the creation of a bill within the system. This function generates a unique Bill ID, which can be used for subsequent operations related to the bill.
/// </summary>
/// <value>This function does not require any specific value input.</value>
/// <param name="args">The parameters required for this function include details necessary for bill creation, such as client ID, amount, and billing information.</param>
/// <returns>Returns a CreateBillResponse object containing the newly created Bill ID and any relevant status information.</returns>
public CreateBillResponse CreateBill(CreateBillArgs args)
{
    return _client.Call<CreateBillResponse>("CreateBill", args);
}

/// <summary>
/// Retrieves a list of all bills associated with the client's account. This function is essential for managing and reviewing billing information within the system.
/// </summary>
/// <value>This function does not require any additional input parameters to execute. It operates within the context of the client's session, returning all relevant billing data.</value>
/// <param name="args">No specific arguments are required for this function.</param>
/// <returns>Returns a ListBillsResponse object containing the details of all bills.</returns>
public ListBillsResponse ListBills(ListBillsArgs args)
{
    return _client.Call<ListBillsResponse>("ListBills", args);
}

/// <summary>
/// Sets the default payment method for a customer. This function assigns a specified payment method as the primary option for transactions, ensuring that it is used by default unless another method is specified.
/// </summary>
/// <value>This function does not return any additional value beyond the standard response.</value>
/// <param name="args">The arguments required include the customer ID and the payment method ID, both of which must be in GUID format.</param>
/// <returns>Returns a SetDefaultPaymentMethodResponse object indicating the success or failure of the operation.</returns>
public SetDefaultPaymentMethodResponse SetDefaultPaymentMethod(SetDefaultPaymentMethodArgs args)
{
    return _client.Call<SetDefaultPaymentMethodResponse>("SetDefaultPaymentMethod", args);
}

/// <summary>
/// Removes a specified payment method from the system. This function is typically used to delete a customer's payment method that is no longer needed or valid.
/// </summary>
/// <value>This operation permanently deletes the payment method, ensuring it cannot be used for future transactions.</value>
/// <param name="args">The parameters required include the unique identifier of the payment method to be deleted.</param>
/// <returns>Returns a DeletePaymentMethodResponse object indicating the success or failure of the operation.</returns>
public DeletePaymentMethodResponse DeletePaymentMethod(DeletePaymentMethodArgs args)
{
    return _client.Call<DeletePaymentMethodResponse>("DeletePaymentMethod", args);
}

/// <summary>
/// Retrieves the details of a specific payment method associated with a customer. This function is essential for accessing payment method information, which can include credit cards, bank accounts, or Interac details.
/// </summary>
/// <value>This function does not require additional parameters beyond the standard call structure. It returns comprehensive details about the specified payment method.</value>
/// <param name="args">The parameters required for this function are encapsulated within the standard API call structure.</param>
/// <returns>Returns a GetPaymentMethodResponse object containing the details of the requested payment method.</returns>
public GetPaymentMethodResponse GetPaymentMethod(GetPaymentMethodArgs args)
{
    return _client.Call<GetPaymentMethodResponse>("GetPaymentMethod", args);
}

/// <summary>
/// This function initializes and creates a new Interac payment method for a customer. It allows the merchant to facilitate transactions using the Interac network, which is a popular method for electronic funds transfers in Canada.
/// </summary>
/// <value>The function does not return a value directly. Instead, it processes the creation of an Interac payment method.</value>
/// <param name="args">The function requires specific parameters related to the customer's Interac account details, such as email or phone number, to successfully create the payment method.</param>
/// <returns>The function returns a CreateInteracPaymentMethodResponse object, which contains details about the newly created Interac payment method, including its unique identifier and status.</returns>
public CreateInteracPaymentMethodResponse CreateInteracPaymentMethod(CreateInteracPaymentMethodArgs args)
{
    return _client.Call<CreateInteracPaymentMethodResponse>("CreateInteracPaymentMethod", args);
}

/// <summary>
/// Initializes a new direct account payment method for a customer. This function facilitates the creation of a payment method linked directly to a customer's bank account, allowing for seamless transactions.
/// </summary>
/// <value>This function does not return a value.</value>
/// <param name="args">Parameters required for creating the direct account payment method, including customer identification and bank account details.</param>
/// <returns>Returns a CreateDirectAccountPaymentMethodResponse object containing the status and details of the newly created payment method.</returns>
public CreateDirectAccountPaymentMethodResponse CreateDirectAccountPaymentMethod(CreateDirectAccountPaymentMethodArgs args)
{
    return _client.Call<CreateDirectAccountPaymentMethodResponse>("CreateDirectAccountPaymentMethod", args);
}

/// <summary>
/// Initializes a new credit card payment method for a customer. This function is essential for enabling transactions using a customer's credit card within the TIB Finance API. It securely stores the credit card details and associates them with the customer's account.
/// </summary>
/// <value>This function does not return a value but performs an action to create a credit card payment method.</value>
/// <param name="args">The parameters required for this function include customer identification and credit card details, which must be provided in a secure manner.</param>
/// <returns>CreateCreditCardPaymentMethodResponse, which confirms the successful creation of the credit card payment method.</returns>
public CreateCreditCardPaymentMethodResponse CreateCreditCardPaymentMethod(CreateCreditCardPaymentMethodArgs args)
{
    return _client.Call<CreateCreditCardPaymentMethodResponse>("CreateCreditCardPaymentMethod", args);
}

/// <summary>
/// Retrieves a list of available payment methods associated with a customer. This function is essential for accessing and managing the various financial accounts linked to a customer, such as credit cards, bank accounts, and Interac. It is particularly useful for applications that need to display or process customer payment options.
/// </summary>
/// <param name="args">Parameters required to execute the ListPaymentMethods function, typically including customer identification details.</param>
/// <returns>Returns a ListPaymentMethodsResponse object containing the details of each payment method associated with the customer.</returns>
public ListPaymentMethodsResponse ListPaymentMethods(ListPaymentMethodsArgs args)
{
    return _client.Call<ListPaymentMethodsResponse>("ListPaymentMethods", args);
}

/// <summary>
/// Retrieves customer information using an external identifier. This function is essential for accessing customer data linked to a specific external ID, which is useful for integration with external systems.
/// </summary>
/// <value>This function does not require additional parameters beyond the external identifier.</value>
/// <param name="args">The external identifier used to locate the customer records.</param>
/// <returns>Returns a GetCustomersByExternalIdResponse object containing the customer details associated with the provided external identifier.</returns>
public GetCustomersByExternalIdResponse GetCustomersByExternalId(GetCustomersByExternalIdArgs args)
{
    return _client.Call<GetCustomersByExternalIdResponse>("GetCustomersByExternalId", args);
}

/// <summary>
/// Removes a customer from the system based on the provided customer ID. This operation is irreversible and ensures that all associated data with the customer is permanently deleted.
/// </summary>
/// <value>This function is used to permanently delete a customer record from the database. It is crucial to ensure that the customer ID provided is accurate to prevent unintended data loss.</value>
/// <param name="args">The customer ID that identifies the customer to be deleted.</param>
/// <returns>A DeleteCustomerResponse object indicating the success or failure of the operation.</returns>
public DeleteCustomerResponse DeleteCustomer(DeleteCustomerArgs args)
{
    return _client.Call<DeleteCustomerResponse>("DeleteCustomer", args);
}

/// <summary>
/// Persists the customer data to the database, ensuring that all necessary customer information is stored for future transactions.
/// </summary>
/// <value>This function is responsible for saving customer details, which include personal and payment information, to the system's database.</value>
/// <param name="args">A structured object containing all necessary customer data, including identifiers and payment methods.</param>
/// <returns>An instance of SaveCustomerResponse, indicating the success or failure of the operation.</returns>
public SaveCustomerResponse SaveCustomer(SaveCustomerArgs args)
{
    return _client.Call<SaveCustomerResponse>("SaveCustomer", args);
}

/// <summary>
/// Retrieves detailed information about a specific customer based on the provided customer identifier. This function is essential for accessing customer data necessary for transaction processing and account management.
/// </summary>
/// <value>This method does not require any additional parameters beyond the customer identifier. It is designed to efficiently fetch customer details.</value>
/// <param name="args">The unique identifier of the customer whose information is being requested.</param>
/// <returns>An instance of GetCustomerResponse containing the customer's details.</returns>
public GetCustomerResponse GetCustomer(GetCustomerArgs args)
{
    return _client.Call<GetCustomerResponse>("GetCustomer", args);
}

/// <summary>
/// Creates a new customer entity within the system. This function initializes a customer object, which serves as a container for identifying the individual and associating payment methods.
/// </summary>
/// <param name="args">Parameters required for creating a customer, including necessary identification details.</param>
/// <returns>Returns a CreateCustomerResponse object, confirming the successful creation of the customer.</returns>
public CreateCustomerResponse CreateCustomer(CreateCustomerArgs args)
{
    return _client.Call<CreateCustomerResponse>("CreateCustomer", args);
}

/// <summary>
/// Generates a comprehensive list of all customers based on specified criteria, providing a complete overview of the customer base.
/// </summary>
/// <value>The 'ListCustomers' function retrieves a detailed list of all customers, offering a comprehensive view of the customer base. It is designed to provide targeted data retrieval, allowing for a flexible and efficient overview of customer information.</value>
/// <param name="args">The function accepts parameters that specify the criteria for generating the customer list. These parameters are designed to allow for flexible and targeted data retrieval, enabling the user to obtain a list of customers that meets specific requirements.</param>
/// <returns>The function returns a 'ListCustomersResponse' object. This object contains a detailed list of customers, each with comprehensive information, providing a complete overview of the customer base.</returns>
public ListCustomersResponse ListCustomers(ListCustomersArgs args)
{
    return _client.Call<ListCustomersResponse>("ListCustomers", args);
}

/// <summary>
/// Adjusts the balance of a wallet by adding or removing funds.
/// </summary>
/// <value>This function modifies the wallet balance for a specified merchant and service, supporting both increase and decrease operations.</value>
/// <param name="args">Parameters required for this function include the service identifier, merchant identifier, adjustment amount, and the adjustment mode (increase or decrease).</param>
/// <returns>Returns an AdjustWalletResponse object containing the transfer identifier and any error information.</returns>
public AdjustWalletResponse AdjustWallet(AdjustWalletArgs args)
{
    return _client.Call<AdjustWalletResponse>("AdjustWallet", args);
}

/// <summary>
/// Retrieves merchant information using an external identifier. This function is essential for accessing merchant details that are linked to a specific external ID, facilitating seamless integration with external systems.
/// </summary>
/// <value>This function does not require additional parameters beyond the external identifier.</value>
/// <param name="args">The external identifier used to query merchant information.</param>
/// <returns>An instance of GetMerchantsByExternalIdResponse containing the merchant details associated with the provided external identifier.</returns>
public GetMerchantsByExternalIdResponse GetMerchantsByExternalId(GetMerchantsByExternalIdArgs args)
{
    return _client.Call<GetMerchantsByExternalIdResponse>("GetMerchantsByExternalId", args);
}

/// <summary>
/// Removes a specified merchant from the system. This operation is irreversible and will permanently delete the merchant's data, including all associated accounts and transactions.
/// </summary>
/// <value>This function is used to delete a merchant identified by a unique identifier. Ensure that all necessary data is backed up before performing this operation.</value>
/// <param name="args">The unique identifier of the merchant to be deleted.</param>
/// <returns>An instance of DeleteMerchantResponse indicating the success or failure of the operation.</returns>
public DeleteMerchantResponse DeleteMerchant(DeleteMerchantArgs args)
{
    return _client.Call<DeleteMerchantResponse>("DeleteMerchant", args);
}

/// <summary>
/// Stores the merchant's account details securely in the system.
/// </summary>
/// <value>This function is responsible for saving the merchant's account information, ensuring that all necessary data is captured and stored correctly for future transactions.</value>
/// <param name="args">The parameters required for this function include the merchant's account details, which must be provided in a structured format.</param>
/// <returns>Returns a SaveMerchantResponse object indicating the success or failure of the operation.</returns>
public SaveMerchantResponse SaveMerchantAccountInfo(SaveMerchantAccountInfoArgs args)
{
    return _client.Call<SaveMerchantResponse>("SaveMerchantAccountInfo", args);
}

/// <summary>
/// This function saves the basic information of a merchant. It is used to update or create the initial details associated with a merchant account within the TIB Finance API system.
/// </summary>
/// <value>This function does not return a value.</value>
/// <param name="args">The function accepts a parameter containing the merchant's basic information, which includes essential details required for account creation or updates.</param>
/// <returns>The function returns a SaveMerchantResponse object, which contains the status and details of the save operation.</returns>
public SaveMerchantResponse SaveMerchantBasicInfo(SaveMerchantBasicInfoArgs args)
{
    return _client.Call<SaveMerchantResponse>("SaveMerchantBasicInfo", args);
}

/// <summary>
/// Persists a merchant entity to the TIB Finance system.
/// </summary>
/// <value>Executes the operation to create or update a merchant record.</value>
/// <param name="args">A SaveMerchantRequest object containing the merchant's basic and account information.</param>
/// <returns>A SaveMerchantResponse indicating the result of the operation, including the newly generated merchant identifier.</returns>
public SaveMerchantResponse SaveMerchant(SaveMerchantArgs args)
{
    return _client.Call<SaveMerchantResponse>("SaveMerchant", args);
}

/// <summary>
/// Retrieves detailed information about a specific merchant using the provided merchant ID. This function is essential for accessing the merchant's basic and account information necessary for transaction processing.
/// </summary>
/// <value>This function does not require additional input parameters beyond the merchant ID.</value>
/// <param name="args">The merchant ID, which uniquely identifies the merchant within the system.</param>
/// <returns>A GetMerchantResponse object containing the merchant's details.</returns>
public GetMerchantResponse GetMerchant(GetMerchantArgs args)
{
    return _client.Call<GetMerchantResponse>("GetMerchant", args);
}

/// <summary>
/// Initiates the creation of a new merchant account within the TIB Finance system. This function is essential for setting up a merchant's basic and account information, which is a prerequisite for conducting transactions.
/// </summary>
/// <value>This function does not require additional details in the value field.</value>
/// <param name="args">The parameters required for this function include the necessary details to establish a merchant account, such as identification and account information.</param>
/// <returns>Returns a CreateMerchantResponse object, which contains the status and details of the merchant creation process.</returns>
public CreateMerchantResponse CreateMerchant(CreateMerchantArgs args)
{
    return _client.Call<CreateMerchantResponse>("CreateMerchant", args);
}

/// <summary>
/// Gets the boarding status for a service.
/// </summary>
/// <value>This function does not require additional input parameters beyond the standard API call structure.</value>
/// <param name="args">This function accepts standard API call arguments necessary for execution.</param>
/// <returns>Returns a ListMerchantsResponse object containing details of merchants with completed boarding.</returns>
public GetServiceBoardingStatusResponse GetServiceBoardingStatus(GetServiceBoardingStatusArgs args)
{
    return _client.Call<GetServiceBoardingStatusResponse>("GetServiceBoardingStatus", args);
}

/// <summary>
/// Retrieves a list of all merchants associated with the client's account. This function is essential for managing and accessing merchant-specific data within the API.
/// </summary>
/// <value>This function does not require any input parameters and returns a comprehensive list of merchants.</value>
/// <param name="args">No parameters are required for this function.</param>
/// <returns>Returns a ListMerchantsResponse object containing details of each merchant.</returns>
public ListMerchantsResponse ListMerchants(ListMerchantsArgs args)
{
    return _client.Call<ListMerchantsResponse>("ListMerchants", args);
}

/// <summary>
/// Retrieves wallet information for a specific service.
/// </summary>
/// <param name="args">The arguments.</param>
/// <returns>GetWalletInformationsByServiceResponse.</returns>
public GetWalletInformationsResponse GetWalletInformationsByService(GetWalletInformationsArgs args)
{
    return _client.Call<GetWalletInformationsResponse>("GetWalletInformationsByService", args);
}

/// <summary>
/// Retrieves the details of a specified service within the TIB Finance API. This function is essential for accessing service-related information, which is crucial for managing contracts and determining applicable limits and fees.
/// </summary>
/// <param name="args">Parameters required to identify and retrieve the specific service details.</param>
/// <returns>An instance of GetServiceResponse containing the service details.</returns>
public GetServiceResponse GetService(GetServiceArgs args)
{
    return _client.Call<GetServiceResponse>("GetService", args);
}

/// <summary>
/// Retrieves the full list of services that are available to the authenticated client.
/// </summary>
/// <value>The operation does not require a request body; it is invoked without parameters.</value>
/// <param name="args">No arguments are required for this call.</param>
/// <returns>A ListServicesResponse object that contains an array of Service objects and associated pagination information.</returns>
public ListServicesResponse ListServices(ListServicesArgs args)
{
    return _client.Call<ListServicesResponse>("ListServices", args);
}

/// <summary>
/// The CreateSession function is purposed to establish a fresh session, thereby ensuring a secure and distinct environment for user activities.
/// </summary>
/// <value>Upon invocation, this function spawns a new session instance, thereby fabricating a unique milieu for user interactions.</value>
/// <param name="args">This function necessitates specific parameters that supply vital data for the genesis of a new session.</param>
/// <returns>On successful execution, the function yields an instance of the CreateSessionResponse, encompassing details about the freshly instantiated session.</returns>
public CreateSessionResponse CreateSession(CreateSessionArgs args)
{
    return _client.Call<CreateSessionResponse>("CreateSession", args);
}
    
  }
}

