
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
/// Retrieves wallet operation history for a service within a specified date range. Returns the list of daily operations, the wallet balance as of the start date, and the configured delay buffer amount.
/// </summary>
/// <param name="args">The GetWalletOperationsArgs containing the service ID and date range.</param>
/// <returns>A GetWalletOperationsResponse containing the operations, balance before operations, and delay buffer amount.</returns>
public GetWalletOperationsResponse GetWalletOperations(GetWalletOperationsArgs args)
{
    return _client.Call<GetWalletOperationsResponse>("GetWalletOperations", args);
}

/// <summary>
/// Lists recurring supplier transfers initiated by the calling merchant. Returns recurring transfer configurations where the caller is the fee-payer.
/// </summary>
/// <param name="args">The ListSupplierRecurringTransfersArgs containing the merchant ID.</param>
/// <returns>A ListSupplierRecurringTransfersResponse containing the recurring transfers.</returns>
public ListSupplierRecurringTransfersResponse ListSupplierRecurringTransfers(ListSupplierRecurringTransfersArgs args)
{
    return _client.Call<ListSupplierRecurringTransfersResponse>("ListSupplierRecurringTransfers", args);
}

/// <summary>
/// Retrieves a single supplier transfer by ID. Accessible to both the fee-payer and the supplier. Returns the transfer details along with the counterparty name and the caller's role.
/// </summary>
/// <param name="args">The GetSupplierTransferArgs containing the transfer ID.</param>
/// <returns>A GetSupplierTransferResponse containing the transfer and counterparty info.</returns>
public GetSupplierTransferResponse GetSupplierTransfer(GetSupplierTransferArgs args)
{
    return _client.Call<GetSupplierTransferResponse>("GetSupplierTransfer", args);
}

/// <summary>
/// Lists supplier transfers initiated by the calling merchant (identified via FeeMerchantId). Returns transfers where the caller is the fee-payer, with optional datestatus filters.
/// </summary>
/// <param name="args">The ListSupplierTransfersArgs containing the merchant ID and optional filters.</param>
/// <returns>A ListSupplierTransfersResponse containing the list of supplier transfers.</returns>
public ListSupplierTransfersResponse ListSupplierTransfers(ListSupplierTransfersArgs args)
{
    return _client.Call<ListSupplierTransfersResponse>("ListSupplierTransfers", args);
}

/// <summary>
/// Soft-deletes a supplier link for the specified merchant. The supplier's merchant account is not affected â€” only the payer-to-supplier association is removed.
/// </summary>
/// <param name="args">The DeleteSupplierArgs containing the merchant ID and supplier link ID.</param>
/// <returns>A DeleteSupplierResponse confirming the deletion.</returns>
public DeleteSupplierResponse DeleteSupplier(DeleteSupplierArgs args)
{
    return _client.Call<DeleteSupplierResponse>("DeleteSupplier", args);
}

/// <summary>
/// Updates the display name (alias) that the payer uses to identify a supplier. The alias is a payer-side label and does not affect the supplier's own merchant name.
/// </summary>
/// <param name="args">The UpdateSupplierAliasArgs containing the supplier link ID and new name (max 150 characters).</param>
/// <returns>An UpdateSupplierAliasResponse confirming the update.</returns>
public UpdateSupplierAliasResponse UpdateSupplierAlias(UpdateSupplierAliasArgs args)
{
    return _client.Call<UpdateSupplierAliasResponse>("UpdateSupplierAlias", args);
}

/// <summary>
/// Lists suppliers linked to the specified merchant, including detailed information such as supplier name, email address, and creation date. For a lightweight name-and-ID-only list, use GetSuppliers instead.
/// </summary>
/// <param name="args">The ListSuppliersArgs containing the merchant ID.</param>
/// <returns>A ListSuppliersResponse containing the list of supplier details.</returns>
public ListSuppliersResponse ListSuppliers(ListSuppliersArgs args)
{
    return _client.Call<ListSuppliersResponse>("ListSuppliers", args);
}

/// <summary>
/// Creates or registers a supplier for a merchant. If a supplier with the given email already exists, reuses that supplier; otherwise provisions a new client, service, merchant, and login. Links the supplier to the calling merchant and creates a reciprocal customer record in the supplier's service.
/// </summary>
/// <param name="args">The CreateSupplierArgs containing the merchant ID, supplier name, email, currency, language, and optional bank account details.</param>
/// <returns>A CreateSupplierResponse containing the supplier's merchant ID.</returns>
public CreateSupplierResponse CreateSupplier(CreateSupplierArgs args)
{
    return _client.Call<CreateSupplierResponse>("CreateSupplier", args);
}

/// <summary>
/// Retrieves the list of suppliers associated with a merchant, returning each supplier's name and identifier.
/// </summary>
/// <param name="args">The GetSuppliersArgs containing the merchant ID.</param>
/// <returns>A GetSuppliersResponse containing the list of suppliers.</returns>
public GetSuppliersResponse GetSuppliers(GetSuppliersArgs args)
{
    return _client.Call<GetSuppliersResponse>("GetSuppliers", args);
}

/// <summary>
/// Creates a payment transfer from the calling merchant to a supplier. Validates both merchants, runs business rules on the sending merchant's limits, creates the transfer as a free collection, and optionally creates a bill. Notifies the supplier unless client approval is required.
/// </summary>
/// <param name="args">The CreateSupplierTransferArgs containing both merchant IDs, amount, due date, currency, frequency, and optional bill details.</param>
/// <returns>A CreateSupplierTransferResponse containing the created transfer identifier.</returns>
public CreateSupplierTransferResponse CreateSupplierTransfer(CreateSupplierTransferArgs args)
{
    return _client.Call<CreateSupplierTransferResponse>("CreateSupplierTransfer", args);
}

/// <summary>
/// Relaunches (retries) a previously failed transfer for a merchant. Resets the failed payment in the database for reprocessing and sends an internal notification email with the transfer details.
/// </summary>
/// <param name="args">The RelaunchMerchantFailedTransferArgs containing the transfer ID.</param>
/// <returns>A RelaunchMerchantFailedTransferResponse.</returns>
public RelaunchMerchantFailedTransferResponse RelaunchMerchantFailedTransfer(RelaunchMerchantFailedTransferArgs args)
{
    return _client.Call<RelaunchMerchantFailedTransferResponse>("RelaunchMerchantFailedTransfer", args);
}

/// <summary>
/// Resends the payment notification email to the customer associated with a specific payment.
/// </summary>
/// <param name="args">The ResendPaymentEmailArgs containing the payment ID.</param>
/// <returns>A ResendPaymentEmailResponse.</returns>
public ResendPaymentEmailResponse ResendPaymentEmail(ResendPaymentEmailArgs args)
{
    return _client.Call<ResendPaymentEmailResponse>("ResendPaymentEmail", args);
}

/// <summary>
/// Creates a new sub-client (child service) under the authenticated client's account. The sub-client is represented as a service entity with its own name, language, and currency.
/// </summary>
/// <param name="args">The CreateSubClientArgs containing the sub-client name, language, and currency.</param>
/// <returns>A CreateSubClientResponse containing the newly created service ID.</returns>
public CreateSubClientResponse CreateSubClient(CreateSubClientArgs args)
{
    return _client.Call<CreateSubClientResponse>("CreateSubClient", args);
}

/// <summary>
/// Initializes the merchant onboarding (boarding) process for a service. Generates a public access token and returns a redirect URL to either the direct login page (if a service-level login exists) or the boarding sign-up wizard.
/// </summary>
/// <param name="args">The InitBoardingArgs containing the service ID.</param>
/// <returns>An InitBoardingResponse containing the redirect URL for the boarding wizard.</returns>
public InitBoardingResponse InitBoarding(InitBoardingArgs args)
{
    return _client.Call<InitBoardingResponse>("InitBoarding", args);
}

/// <summary>
/// Updates the security question and answer on an existing Interac payment method. Creates a replacement payment method with the new credentials and deletes the old one. The answer is encrypted via the external data vault, and both question and answer are obfuscated in logs.
/// </summary>
/// <param name="args">The ChangeInteracPaymentMethodQuestionAndAnswerArgs containing the payment method ID, new question, and new answer.</param>
/// <returns>A ChangeInteracPaymentMethodQuestionAndAnswerResponse containing the new payment method ID.</returns>
public ChangeInteracPaymentMethodQuestionAndAnswerResponse ChangeInteracPaymentMethodQuestionAndAnswer(ChangeInteracPaymentMethodQuestionAndAnswerArgs args)
{
    return _client.Call<ChangeInteracPaymentMethodQuestionAndAnswerResponse>("ChangeInteracPaymentMethodQuestionAndAnswer", args);
}

/// <summary>
/// Reverts (cancels or reverses) a transfer. For pending gateway payments, deletes the transfer and its public token. For processed payments, creates reversal operations for each non-fee operation. Rejects transfers over $5,000 or wallet-type transfers.
/// </summary>
/// <param name="args">The RevertTransferArgs containing the transfer ID.</param>
/// <returns>A RevertTransferResponse indicating whether the transfer was deleted or reversed.</returns>
public RevertTransferResponse RevertTransfer(RevertTransferArgs args)
{
    return _client.Call<RevertTransferResponse>("RevertTransfer", args);
}

/// <summary>
/// Creates a batch of free operations (deposits or collections) in a single call. Validates that client onboarding (KYC) is completed before allowing free deposit operations.
/// </summary>
/// <param name="args">The CreateFreeOperationBatchArgs containing the list of operations, optional group ID, and processing options.</param>
/// <returns>A CreateFreeOperationBatchResponse containing the results for each operation in the batch.</returns>
public CreateFreeOperationBatchResponse CreateFreeOperationBatch(CreateFreeOperationBatchArgs args)
{
    return _client.Call<CreateFreeOperationBatchResponse>("CreateFreeOperationBatch", args);
}

/// <summary>
/// Creates the free operation.
/// </summary>
/// <param name="args">The arguments.</param>
/// <returns>CreateFreeOperationResponse.</returns>
public CreateFreeOperationResponse CreateFreeOperation(CreateFreeOperationArgs args)
{
    return _client.Call<CreateFreeOperationResponse>("CreateFreeOperation", args);
}

/// <summary>
/// Gets the drop in public token.
/// </summary>
/// <param name="args">The arguments.</param>
/// <returns>GetDropInPublicTokenResponse.</returns>
public GetDropInPublicTokenResponse GetDropInPublicToken(GetDropInPublicTokenArgs args)
{
    return _client.Call<GetDropInPublicTokenResponse>("GetDropInPublicToken", args);
}

/// <summary>
/// Forces the payment process.
/// </summary>
/// <param name="args">The arguments.</param>
/// <returns>ForcePaymentProcessResponse.</returns>
public ForcePaymentProcessResponse ForcePaymentProcess(ForcePaymentProcessArgs args)
{
    return _client.Call<ForcePaymentProcessResponse>("ForcePaymentProcess", args);
}

/// <summary>
/// Lists the executed operations.
/// </summary>
/// <param name="args">The arguments.</param>
/// <returns>ListExecutedOperationsResponse.</returns>
public ListExecutedOperationsResponse ListExecutedOperations(ListExecutedOperationsArgs args)
{
    return _client.Call<ListExecutedOperationsResponse>("ListExecutedOperations", args);
}

/// <summary>
/// Creates the transaction from raw.
/// </summary>
/// <param name="args">The arguments.</param>
/// <returns>CreateTransactionFromRawResponse.</returns>
public CreateTransactionFromRawResponse CreateTransactionFromRaw(CreateTransactionFromRawArgs args)
{
    return _client.Call<CreateTransactionFromRawResponse>("CreateTransactionFromRaw", args);
}

/// <summary>
/// Creates the direct Interac transaction
/// </summary>
/// <param name="args">The arguments.</param>
/// <returns>CreateDirectInteracTransactionResponse.</returns>
public CreateDirectInteracTransactionResponse CreateDirectInteracTransaction(CreateDirectInteracTransactionArgs args)
{
    return _client.Call<CreateDirectInteracTransactionResponse>("CreateDirectInteracTransaction", args);
}

/// <summary>
/// Deletes the payment.
/// </summary>
/// <param name="args">The arguments.</param>
/// <returns>DeletePaymentResponse.</returns>
public DeletePaymentResponse DeletePayment(DeletePaymentArgs args)
{
    return _client.Call<DeletePaymentResponse>("DeletePayment", args);
}

/// <summary>
/// Gets the payment.
/// </summary>
/// <param name="args">The arguments.</param>
/// <returns>GetPaymentResponse.</returns>
public GetPaymentResponse GetPayment(GetPaymentArgs args)
{
    return _client.Call<GetPaymentResponse>("GetPayment", args);
}

/// <summary>
/// Creates a payment associated with a specific bill.
/// </summary>
/// <value>Call this endpoint to collect money from a customer or deposit to a customer using a chosen payment method. It can inherit the customer from the bill, operate in anonymous mode, or override defaults such as immediate transfer or over‑payment safety.</value>
/// <param name="args">SessionToken: auth token; BillId: target bill GUID; SetPaymentCustomerFromBill: use bill's customer (bool); CustomerEmail: email for anonymous payments; PaymentInfo: payment method payload (type, token, etc.); MerchantId: GUID of the merchant account; ExternalReferenceId: merchant‑defined reference; SafetyToBreakIfOverRemainingBillAmount: stop if amount exceeds bill balance (bool); AutorizedPaymentMethod: pre‑authorized payment method GUID; AskForCustomerConsent: trigger consent flow (bool); DoNotSendEmail: suppress notification (bool); ImmediateTransfer: process without delay (bool); StatementDescription: text shown on bank statement.</param>
/// <returns>Success returns a JSON object containing PaymentId (Guid), Status (e.g., 'Created'), and optional fields like ProcessedAt and TransactionDetails.</returns>
public CreatePaymentResponse CreatePayment(CreatePaymentArgs args)
{
    return _client.Call<CreatePaymentResponse>("CreatePayment", args);
}

/// <summary>
/// Deletes a recurring transfer and cancels all its future scheduled executions.
/// </summary>
/// <value>Use this endpoint when a merchant must stop an existing recurring payment or collection. It removes the recurrence definition so no further transfers will be generated.</value>
/// <param name="args">SessionToken (string, auth token for the current session); RecuringTransferId (Guid, identifier of the recurring transfer to delete).</param>
/// <returns>HTTP 200 with JSON { "deleted": true, "transferId": "&lt;RecuringTransferId&gt;" } on success; error payload otherwise.</returns>
public DeleteRecuringTransferResponse DeleteRecuringTransfer(DeleteRecuringTransferArgs args)
{
    return _client.Call<DeleteRecuringTransferResponse>("DeleteRecuringTransfer", args);
}

/// <summary>
/// Retrieves all active recurring transfers for a specified service.
/// </summary>
/// <value>Call this endpoint to list a merchant's ongoing scheduled transfers, view their next execution date, and obtain related merchant metadata. Useful for monitoring, reporting, or managing recurring payment pipelines.</value>
/// <param name="args">SessionToken (string, auth token from session creation) and ServiceId (GUID identifying the contract under which the transfers were created).</param>
/// <returns>A JSON array of transfer objects, each containing TransferId (GUID), Status, NextRecurrenceDate (ISO‑8601), Amount, Currency, MerchantId (GUID), and optional metadata such as Description and LastRunResult.</returns>
public GetRecuringTransfersResponse GetRecuringTransfers(GetRecuringTransfersArgs args)
{
    return _client.Call<GetRecuringTransfersResponse>("GetRecuringTransfers", args);
}

/// <summary>
/// Retrieves all transfer records associated with a specific bill.
/// </summary>
/// <value>Call this method when you need to audit, display, or process the money movements (collections or deposits) that belong to a given bill. It provides the raw transfer data required for status tracking and error handling.</value>
/// <param name="args">SessionToken (auth token), MerchantId (GUID of the merchant account), BillId (GUID of the target bill).</param>
/// <returns>On success, a JSON array of transfer objects, each containing TransferId, OperationId, Direction, Target, Status (numeric enum), BankResult (if applicable), Description, and timestamps.</returns>
public ListTransfersFastResponse ListTransfersForBillFast(ListTransfersForBillFastArgs args)
{
    return _client.Call<ListTransfersFastResponse>("ListTransfersForBillFast", args);
}

/// <summary>
/// Retrieves a filtered, summarized list of transfer records for a specified service.
/// </summary>
/// <value>Call this endpoint to obtain a lightweight overview of transfers that match given criteria (type, date range, merchant, group, error or resolved status). It is suited for dashboards, reporting, or error‑monitoring workflows where full transaction details are unnecessary.</value>
/// <param name="args">SessionToken (auth token), ServiceId (required Guid), FromDate/ToDate (ISO‑8601 optional range), MerchantId (Guid), TransferGroupId (Guid), TransferType (enum), MarkResolvedOnly (bool), ExternalMerchantGroupId (Guid), OnlyWithErrors (bool).</param>
/// <returns>HTTP 200 with a JSON payload containing an array of transfer summary objects (e.g., TransferId, Date, Type, Amount, Status, Resolved, ErrorCode) plus optional pagination info.</returns>
public ListTransfersFastResponse ListTransfersFast(ListTransfersFastArgs args)
{
    return _client.Call<ListTransfersFastResponse>("ListTransfersFast", args);
}

/// <summary>
/// Retrieves a paginated list of transfer records matching the supplied filters.
/// </summary>
/// <value>Call this endpoint to query transfers for reporting, reconciliation, or error handling. Use the filter options to narrow results by date range, transfer type, merchant group, or error status.</value>
/// <param name="args">SessionToken (auth), PaymentFilterLevel &amp; LevelFilterId (scope by client/service/merchant), MarkResolvedOnly (true to include only resolved transfers), FromDate/ToDate (date window), TransferGroupId (group identifier), TransferType (Collect/Deposit), ExternalMerchantGroupId (external merchant reference), OnlyWithErrors (true to return only transfers with error status).</param>
/// <returns>On success, returns a JSON object containing an array of transfer objects (each with TransferId, Status, Type, Amount, Dates, and related identifiers) and pagination metadata (TotalCount, PageSize, PageNumber).</returns>
public ListTransfersResponse ListTransfers(ListTransfersArgs args)
{
    return _client.Call<ListTransfersResponse>("ListTransfers", args);
}

/// <summary>
/// Deletes a previously created bill.
/// </summary>
/// <value>Call this endpoint to permanently remove a bill that is no longer required or was created by mistake. The bill and any associated pending payments are cancelled.</value>
/// <param name="args">SessionToken (string, authentication token), BillId (Guid, identifier of the bill to delete), MerchantId (Guid, merchant account owning the bill).</param>
/// <returns>HTTP 204 No Content on success (empty response body). Errors are returned with standard HTTP error codes and a JSON error payload.</returns>
public DeleteBillResponse DeleteBill(DeleteBillArgs args)
{
    return _client.Call<DeleteBillResponse>("DeleteBill", args);
}

/// <summary>
/// Retrieves details of a specific bill.
/// </summary>
/// <value>Call this method to obtain the full bill record, including status, amount, and linked payments, after a bill has been created or when you need to display or verify bill information.</value>
/// <param name="args">SessionToken (string) – auth token for the session; BillId (Guid) – identifier of the bill to fetch; MerchantId (Guid) – merchant (bank account) associated with the bill.</param>
/// <returns>On success, returns a Bill object containing bill metadata (id, amount, currency, status, creation date, due date) and an array of associated payment IDs.</returns>
public GetBillResponse GetBill(GetBillArgs args)
{
    return _client.Call<GetBillResponse>("GetBill", args);
}

/// <summary>
/// Creates a new bill record in TIB Finance.
/// </summary>
/// <value>Call this method when you need to generate a bill that can later have payments attached. It registers the bill under the current session and returns a unique identifier for subsequent operations such as adding payments or querying status.</value>
/// <param name="args">SessionToken (string, required): authentication token for the current session; BillData (object, required): JSON payload containing bill details (amount, currency, due date, description, etc.); BreakIfMerchantNeverBeenAuthorized (bool, optional): if true, aborts creation when the merchant has no prior authorization, preventing orphan bills.</param>
/// <returns>On success, returns a JSON object with billId (Guid) and creationTimestamp (ISO‑8601).</returns>
public CreateBillResponse CreateBill(CreateBillArgs args)
{
    return _client.Call<CreateBillResponse>("CreateBill", args);
}

/// <summary>
/// Retrieves a collection of bills created within a specified time range.
/// </summary>
/// <value>Call ListBills to enumerate all bills for a merchant when you need to display, reconcile, or process batch operations on recent billing activity. Use the date filters to limit results and reduce payload size.</value>
/// <param name="args">SessionToken (auth token), ServiceId (contract GUID), MerchantId (merchant GUID), FromDateTime (ISO‑8601 start filter), ToDateTime (ISO‑8601 end filter).</param>
/// <returns>On success, returns a JSON array of bill objects, each containing at least BillId (GUID), CreationDate, Amount, Currency, Status, and optional metadata.</returns>
public ListBillsResponse ListBills(ListBillsArgs args)
{
    return _client.Call<ListBillsResponse>("ListBills", args);
}

/// <summary>
/// Sets the default payment method for a specified customer.
/// </summary>
/// <value>Invoke after a customer’s payment methods are created or listed to define which method will be automatically used for future payments when no explicit method is provided. Required for auto‑select or anonymous payment flows that depend on a default.</value>
/// <param name="args">SessionToken (string) – auth token from session creation; CustomerId (GUID) – target customer identifier; PaymentMethodId (GUID) – payment method to designate as default.</param>
/// <returns>HTTP 200 with JSON { "success": true, "customerId": "&lt;GUID&gt;", "defaultPaymentMethodId": "&lt;GUID&gt;" }. Errors are returned with appropriate HTTP status codes and error payloads.</returns>
public SetDefaultPaymentMethodResponse SetDefaultPaymentMethod(SetDefaultPaymentMethodArgs args)
{
    return _client.Call<SetDefaultPaymentMethodResponse>("SetDefaultPaymentMethod", args);
}

/// <summary>
/// Deletes a specific payment method from a customer profile.
/// </summary>
/// <value>Call this endpoint when a merchant needs to permanently remove a credit card, bank account, or Interac payment method that is no longer valid or authorized. The operation requires an active session and the GUID of the payment method to be deleted.</value>
/// <param name="args">SessionToken (string, required): authentication token for the current session; PaymentMethodId (GUID, required): identifier of the payment method to delete.</param>
/// <returns>HTTP 204 No Content on successful deletion; error payload with standard TIB Finance error codes on failure.</returns>
public DeletePaymentMethodResponse DeletePaymentMethod(DeletePaymentMethodArgs args)
{
    return _client.Call<DeletePaymentMethodResponse>("DeletePaymentMethod", args);
}

/// <summary>
/// Retrieves the details of a specific payment method.
/// </summary>
/// <value>Use this call when you need to read a stored payment method (credit card, bank account, or Interac) for display, validation, or to reference it in subsequent payment operations.</value>
/// <param name="args">SessionToken (string) – authentication token from a valid session; PaymentMethodId (GUID) – unique identifier of the payment method to retrieve.</param>
/// <returns>On success, returns a PaymentMethod object with fields such as id, type, masked account information, status, createdDate, and lastModifiedDate.</returns>
public GetPaymentMethodResponse GetPaymentMethod(GetPaymentMethodArgs args)
{
    return _client.Call<GetPaymentMethodResponse>("GetPaymentMethod", args);
}

/// <summary>
/// Creates an Interac payment method for a specified customer.
/// </summary>
/// <value>Use this endpoint to attach an Interac payment method to a customer so the merchant can collect or deposit funds via Interac. Required before initiating Interac‑based payments or direct Interac transfers.</value>
/// <param name="args">SessionToken (auth token), CustomerId (Guid of the customer), IsCustomerAutomaticPaymentMethod (bool, marks as default), InteracInformation (email or mobile number), Language (locale code, e.g., 'en' or 'fr'), MerchantId (Guid of the merchant account).</param>
/// <returns>On success returns a JSON object containing PaymentMethodId (Guid) and a status field indicating creation success.</returns>
public CreateInteracPaymentMethodResponse CreateInteracPaymentMethod(CreateInteracPaymentMethodArgs args)
{
    return _client.Call<CreateInteracPaymentMethodResponse>("CreateInteracPaymentMethod", args);
}

/// <summary>
/// Creates a bank‑account payment method linked directly to a customer.
/// </summary>
/// <value>Call this when you need to register a new bank account for an existing customer, optionally setting it as the default method for automatic payments.</value>
/// <param name="args">SessionToken (string) – authentication token; CustomerId (Guid) – identifier of the target customer; IsCustomerAutomaticPaymentMethod (bool) – true to make this the default payment method; Account (object) – bank account details (accountNumber, routingNumber, holderName, currency, etc.); Language (string, optional) – locale for validation messages.</param>
/// <returns>On success returns a JSON payload with paymentMethodId (Guid) and status="Created"; on failure returns standard error object with code and message.</returns>
public CreateDirectAccountPaymentMethodResponse CreateDirectAccountPaymentMethod(CreateDirectAccountPaymentMethodArgs args)
{
    return _client.Call<CreateDirectAccountPaymentMethodResponse>("CreateDirectAccountPaymentMethod", args);
}

/// <summary>
/// Creates a new credit‑card payment method for a specified customer.
/// </summary>
/// <value>Use this after obtaining a SessionToken when you need to store a customer's credit‑card details for future collections or automatic payments. The method registers the card under the given CustomerId and makes it available for payment operations.</value>
/// <param name="args">SessionToken (GUID) – auth token from session creation; Currency (ISO‑4217 code) – transaction currency; CustomerId (GUID) – target customer; IsCustomerAutomaticPaymentMethod (bool) – set as default for the customer if true; CreditCard (string) – encrypted PAN; CardOwner (string) – name on the card; ZipCode (string) – billing postal code; Language (string) – ISO language code for notifications.</param>
/// <returns>HTTP 201 with JSON containing PaymentMethodId (GUID) and masked card info (last4, expiryMonth, expiryYear).</returns>
public CreateCreditCardPaymentMethodResponse CreateCreditCardPaymentMethod(CreateCreditCardPaymentMethodArgs args)
{
    return _client.Call<CreateCreditCardPaymentMethodResponse>("CreateCreditCardPaymentMethod", args);
}

/// <summary>
/// Retrieves all payment methods associated with a specific customer under a given merchant.
/// </summary>
/// <value>Call this endpoint to enumerate a customer's stored credit card, bank account, or Interac payment methods, for selection or management before creating a payment or bill.</value>
/// <param name="args">SessionToken (string, required) – auth token for the API session; CustomerId (GUID, required) – identifier of the target customer; MerchantId (GUID, required) – identifier of the merchant account owning the customer.</param>
/// <returns>On success, returns a JSON array of payment method objects, each containing Id (GUID), Type (enum: CreditCard|BankAccount|Interac), Status, and masked account details.</returns>
public ListPaymentMethodsResponse ListPaymentMethods(ListPaymentMethodsArgs args)
{
    return _client.Call<ListPaymentMethodsResponse>("ListPaymentMethods", args);
}

/// <summary>
/// Retrieves one or more TIB Finance customers matching a given external identifier.
/// </summary>
/// <value>Call this method when you need to locate existing customers that were created or referenced using your own external ID scheme, for synchronization or lookup purposes.</value>
/// <param name="args">SessionToken (string): auth token for the current session; ExternalCustomerId (string): the merchant‑provided external identifier; MerchantId (Guid): the merchant (bank account) GUID whose customers are queried.</param>
/// <returns>On success, returns a JSON array of customer objects, each containing at least the TIB CustomerId (Guid) and associated metadata. Errors are returned as standard API error objects.</returns>
public GetCustomersByExternalIdResponse GetCustomersByExternalId(GetCustomersByExternalIdArgs args)
{
    return _client.Call<GetCustomersByExternalIdResponse>("GetCustomersByExternalId", args);
}

/// <summary>
/// Deletes a customer record from the TIB Finance system.
/// </summary>
/// <value>Call this method when a merchant needs to permanently remove a customer that is no longer required, for example after account closure or data‑retention compliance. The operation also removes all payment methods linked to the customer.</value>
/// <param name="args">SessionToken (string, required): authentication token for the current session. CustomerId (Guid, required): unique identifier of the customer to delete.</param>
/// <returns>HTTP 204 No Content on success; if a body is returned, it contains a JSON object { "deletedCustomerId": "&lt;Guid&gt;", "status": "Success" }.</returns>
public DeleteCustomerResponse DeleteCustomer(DeleteCustomerArgs args)
{
    return _client.Call<DeleteCustomerResponse>("DeleteCustomer", args);
}

/// <summary>
/// Creates or updates a customer record in TIB Finance.
/// </summary>
/// <value>Use this call to register a new customer or modify an existing one for a specific merchant. The method validates the payload and associates the customer with the given merchant account.</value>
/// <param name="args">SessionToken (string) – authentication token from session creation; Customer (object) – customer details (name, email, etc.); MerchantId (Guid) – identifier of the merchant owning the customer.</param>
/// <returns>On success returns a JSON object containing CustomerId (Guid) and a success flag, e.g., { "CustomerId": "...", "Success": true }.</returns>
public SaveCustomerResponse SaveCustomer(SaveCustomerArgs args)
{
    return _client.Call<SaveCustomerResponse>("SaveCustomer", args);
}

/// <summary>
/// Retrieves details of a specific customer.
/// </summary>
/// <value>Call this method to obtain the stored information for a customer, including linked payment methods, when you need to display or process customer data. Required for operations that reference a customer by ID.</value>
/// <param name="args">SessionToken (string): auth token for the session; CustomerId (Guid): identifier of the target customer; MerchantId (Guid): identifier of the merchant account owning the customer.</param>
/// <returns>On success, returns a Customer object containing Id, Email, Status, and an array of PaymentMethod summaries. HTTP 200 with JSON payload; errors returned with appropriate HTTP status codes.</returns>
public GetCustomerResponse GetCustomer(GetCustomerArgs args)
{
    return _client.Call<GetCustomerResponse>("GetCustomer", args);
}

/// <summary>
/// Creates a new Customer object in TIB Finance.
/// </summary>
/// <value>Call this method when you need to register a person or entity that will receive or send payments. The customer acts as a container for payment methods and can be referenced in subsequent payment or bill operations.</value>
/// <param name="args">SessionToken (auth token), ServiceId (contract GUID), Customer (JSON with required fields: email, optional name, address, etc.).</param>
/// <returns>On success, returns a JSON payload containing CustomerId (GUID) and a creation timestamp.</returns>
public CreateCustomerResponse CreateCustomer(CreateCustomerArgs args)
{
    return _client.Call<CreateCustomerResponse>("CreateCustomer", args);
}

/// <summary>
/// Retrieves a list of customer objects associated with the specified merchant.
/// </summary>
/// <value>Call this method to enumerate all customers created under a merchant, including those auto‑generated by direct‑deposit or direct‑Interac operations. Useful for syncing customer data or locating a customer ID for subsequent payment actions.</value>
/// <param name="args">SessionToken (string): auth token for the current session; ServiceId (GUID): identifier of the contract under which the merchant operates; MerchantId (GUID): identifier of the merchant (bank account) whose customers are queried.</param>
/// <returns>On success, returns HTTP 200 with a JSON array of customer objects, each containing at minimum: CustomerId (GUID), Email (optional), CreatedDate (ISO‑8601), and Status (enum). Errors are returned with standard HTTP error codes and an error payload.</returns>
public ListCustomersResponse ListCustomers(ListCustomersArgs args)
{
    return _client.Call<ListCustomersResponse>("ListCustomers", args);
}

/// <summary>
/// Adjusts the merchant's wallet balance by the specified amount.
/// </summary>
/// <value>Call this method to credit or debit a merchant wallet—for fee application, refunds, or manual corrections. The adjustment can be processed using the default mode or routed through Interac when required.</value>
/// <param name="args">SessionToken (auth token), ServiceId (contract GUID), MerchantId (wallet GUID), Amount (decimal, positive to credit, negative to debit), Mode (e.g., 'AUTO_SELECT', 'ANONYMOUS'), UseInterac (boolean, true to use Interac routing).</param>
/// <returns>On success returns an object containing AdjustWalletId (GUID), NewBalance (decimal) and Status ('Success' or error details).</returns>
public AdjustWalletResponse AdjustWallet(AdjustWalletArgs args)
{
    return _client.Call<AdjustWalletResponse>("AdjustWallet", args);
}

/// <summary>
/// Retrieves TIB merchant records that match a given external system identifier.
/// </summary>
/// <value>Call this method when you need to locate one or more merchant accounts that were created or linked via an external system, using the external IDs assigned by that system. Useful for synchronizing data or performing operations on merchants without knowing their internal GUIDs.</value>
/// <param name="args">SessionToken (string) – auth token for the current session; ExternalSystemId (string) – the identifier of the external system; ExternalSystemGroupId (string) – the external identifier assigned to the merchant within that system.</param>
/// <returns>On success, returns a JSON array of merchant objects, each containing at least the internal MerchantId (Guid) and basic merchant information. Errors are returned as standard API error objects.</returns>
public GetMerchantsByExternalIdResponse GetMerchantsByExternalId(GetMerchantsByExternalIdArgs args)
{
    return _client.Call<GetMerchantsByExternalIdResponse>("GetMerchantsByExternalId", args);
}

/// <summary>
/// Deletes a merchant (bank account) identified by its GUID.
/// </summary>
/// <value>Call this method to permanently remove a merchant record that is no longer needed, for example when a client closes a bank account or after a failed validation. The merchant must not be linked to active contracts or pending transactions.</value>
/// <param name="args">SessionToken (string) – authentication token from CreateSession; MerchantId (GUID) – identifier of the merchant to delete.</param>
/// <returns>HTTP 200 with a JSON body containing { "success": true, "merchantId": "&lt;MerchantId&gt;" }. Errors return appropriate HTTP status codes and error payload.</returns>
public DeleteMerchantResponse DeleteMerchant(DeleteMerchantArgs args)
{
    return _client.Call<DeleteMerchantResponse>("DeleteMerchant", args);
}

/// <summary>
/// Saves or updates a merchant's bank account information.
/// </summary>
/// <value>Use this endpoint when creating a merchant or when the merchant's bank account details need to be changed. The call is secured with two‑factor authentication to protect sensitive banking data.</value>
/// <param name="args">SessionToken (string) – token from session creation; MerchantId (GUID) – identifier of the merchant; Account (object) – bank account fields (number, routing, holder name, etc.); TwoFactorCode (string) – OTP from the 2FA device; TwoFactorSecurityAnswer (string) – answer to the pre‑registered security question.</param>
/// <returns>HTTP 200 with JSON confirming the operation, e.g., { "merchantId": "&lt;GUID&gt;", "accountSaved": true }.</returns>
public SaveMerchantResponse SaveMerchantAccountInfo(SaveMerchantAccountInfoArgs args)
{
    return _client.Call<SaveMerchantResponse>("SaveMerchantAccountInfo", args);
}

/// <summary>
/// Updates the basic profile data of an existing merchant.
/// </summary>
/// <value>Invoke this when a merchant's contact, address, or other basic attributes need to be changed. It overwrites the stored basic information without affecting the merchant's bank account details.</value>
/// <param name="args">SessionToken (string) – authentication token from session creation; MerchantId (GUID) – identifier of the merchant to modify; MerchantInfo (object) – JSON object with basic fields (e.g., Name, Email, Phone, Address, TaxId, etc.).</param>
/// <returns>HTTP 200 with a JSON body containing a success flag and the MerchantId; on failure returns the standard error object with error code and description.</returns>
public SaveMerchantResponse SaveMerchantBasicInfo(SaveMerchantBasicInfoArgs args)
{
    return _client.Call<SaveMerchantResponse>("SaveMerchantBasicInfo", args);
}

/// <summary>
/// Updates or creates a merchant record in TIB Finance.
/// </summary>
/// <value>Call this method when you need to modify the basic or account information of an existing merchant or to register a new merchant after obtaining a session token. It persists the supplied MerchantInfo against the specified MerchantId.</value>
/// <param name="args">SessionToken (string, required): authentication token from session creation; MerchantId (GUID, required): identifier of the merchant to save; MerchantInfo (object, required): JSON payload containing basic and/or account details to be stored.</param>
/// <returns>On success, returns HTTP 200 with a JSON body containing the saved MerchantId and a timestamp of the update, or an error object on failure.</returns>
public SaveMerchantResponse SaveMerchant(SaveMerchantArgs args)
{
    return _client.Call<SaveMerchantResponse>("SaveMerchant", args);
}

/// <summary>
/// Retrieves the details of a merchant by its GUID.
/// </summary>
/// <value>Use after creating a session to obtain the merchant's basic profile and a preview of its bank account information, needed for validation or display before processing transactions.</value>
/// <param name="args">SessionToken (string) – authentication token from SessionCreate; MerchantId (GUID) – unique identifier of the merchant to fetch.</param>
/// <returns>On success, returns a Merchant object with MerchantId, basic information (name, status, creation date) and a preview of account information (bank name, masked account number, currency, etc.).</returns>
public GetMerchantResponse GetMerchant(GetMerchantArgs args)
{
    return _client.Call<GetMerchantResponse>("GetMerchant", args);
}

/// <summary>
/// Creates a new merchant (bank account) for the client.
/// </summary>
/// <value>Use this when a client requires an additional merchant account beyond the primary one. The call registers the merchant and starts the required validation process.</value>
/// <param name="args">SessionToken (authentication token), ServiceId (client contract GUID), MerchantInfo (object with merchant basic data such as name, address, currency, etc.).</param>
/// <returns>MerchantId (GUID) of the newly created merchant and a validationStatus flag indicating whether the merchant is active or pending validation.</returns>
public CreateMerchantResponse CreateMerchant(CreateMerchantArgs args)
{
    return _client.Call<CreateMerchantResponse>("CreateMerchant", args);
}

/// <summary>
/// Retrieves the boarding status of all merchants associated with a specific service.
/// </summary>
/// <value>Use this endpoint after establishing a session to verify which merchants have completed, are pending, or have failed the boarding process for the given service. It helps automate monitoring and error handling of merchant onboarding.</value>
/// <param name="args">SessionToken (string) – authentication token from session creation; BoardingServiceId (Guid) – identifier of the service whose merchant boarding status is requested.</param>
/// <returns>JSON array of objects, each containing MerchantId (Guid), BoardingStatus (enum: Boarded|Pending|Failed), and StatusTimestamp (ISO‑8601). HTTP 200 on success; error codes follow standard API error handling.</returns>
public GetServiceBoardingStatusResponse GetServiceBoardingStatus(GetServiceBoardingStatusArgs args)
{
    return _client.Call<GetServiceBoardingStatusResponse>("GetServiceBoardingStatus", args);
}

/// <summary>
/// Retrieves a list of merchant accounts accessible to the authenticated session.
/// </summary>
/// <value>Call this endpoint to enumerate merchant records for a client, optionally filtering by a specific merchant ID or including all merchants associated with the client’s contracts. Useful for UI dropdowns, synchronization jobs, or validating merchant existence before creating transactions.</value>
/// <param name="args">SessionToken (string, required): auth token from session creation; ServiceId (GUID, required): identifies the client contract; MerchantId (GUID, optional): limits results to a single merchant; IncludeClientMerchants (bool, optional): when true, also returns merchants created under the client’s primary account.</param>
/// <returns>On success, returns HTTP 200 with a JSON array of merchant objects, each containing MerchantId (GUID), Name, IsPrimary (bool), and Status fields.</returns>
public ListMerchantsResponse ListMerchants(ListMerchantsArgs args)
{
    return _client.Call<ListMerchantsResponse>("ListMerchants", args);
}

/// <summary>
/// Retrieves the wallet state for a specific service.
/// </summary>
/// <value>Call this method to obtain the current effective balance, risk‑adjusted withdrawable amount, processing status, and feature flag for the new wallet associated with a service. Useful for displaying available funds or validating withdrawal limits before initiating a transaction.</value>
/// <param name="args">SessionToken (string, required) – authentication token for the current session; ServiceId (GUID, required) – identifier of the service whose wallet is queried.</param>
/// <returns>On success, returns a JSON object containing effectiveBalance (decimal), withdrawableAmount (decimal), processingStatus (enum), and isNewWalletEnabled (boolean). Errors are returned with standard API error codes.</returns>
public GetWalletInformationsResponse GetWalletInformationsByService(GetWalletInformationsArgs args)
{
    return _client.Call<GetWalletInformationsResponse>("GetWalletInformationsByService", args);
}

/// <summary>
/// Retrieves the details of a specific Service (contract) for the authenticated client.
/// </summary>
/// <value>Call this method to obtain contract metadata such as limits, fees, and status when you need to validate or display service information before performing operations that depend on the ServiceId.</value>
/// <param name="args">SessionToken (string, auth token); ServiceId (Guid, identifies the contract); MerchantId (Guid, identifies the merchant account linked to the request).</param>
/// <returns>On success, returns a Service object containing ServiceId, MerchantId, Name, Limits, Fees, Currency, EffectiveDates, and CurrentStatus.</returns>
public GetServiceResponse GetService(GetServiceArgs args)
{
    return _client.Call<GetServiceResponse>("GetService", args);
}

/// <summary>
/// Retrieves the list of service contracts associated with the authenticated merchant.
/// </summary>
/// <value>Call this method after establishing a session to enumerate all service IDs (contracts) the merchant can use for fee and limit calculations. Useful when a merchant operates multiple contracts across different companies.</value>
/// <param name="args">SessionToken (string, required) – bearer token from session creation; MerchantId (GUID, required) – identifier of the merchant account whose services are queried.</param>
/// <returns>On success, returns a JSON array of service objects, each containing ServiceId (GUID) and optional descriptive fields (e.g., Name, Status). HTTP 200.</returns>
public ListServicesResponse ListServices(ListServicesArgs args)
{
    return _client.Call<ListServicesResponse>("ListServices", args);
}

/// <summary>
/// Creates an authenticated session for a TIB Finance client.
/// </summary>
/// <value>Invoke this endpoint at the beginning of a workflow to obtain a session token required for all subsequent API calls. The session ties the request to a specific client and validates the supplied credentials.</value>
/// <param name="args">ClientId (Guid) – client identifier issued by TIB; Username – API user name; Password – API password (secure).</param>
/// <returns>On success returns a JSON payload with SessionId (Guid) and Expiration (ISO‑8601 timestamp) indicating the session token and its validity period.</returns>
public CreateSessionResponse CreateSession(CreateSessionArgs args)
{
    return _client.Call<CreateSessionResponse>("CreateSession", args);
}
    
  }
}

