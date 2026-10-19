
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
using Tib.Api.Model.TwoFactorAuth;



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
/// Verifies the 2FA setup after user scans QR code and enters the code. Enables 2FA for the user once verification succeeds.
/// </summary>
/// <param name="args">The arguments including the verification code.</param>
/// <returns>Verify2FASetupResponse indicating success or failure.</returns>
public Verify2FASetupResponse Verify2FASetup(Verify2FASetupArgs args)
{
    return _client.Call<Verify2FASetupResponse>("Verify2FASetup", args);
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
/// Lists recurring supplier transfers across an entire service. Returns every non-deleted recurring supplier transfer where any merchant in the given service is the fee-payer, with the supplier merchant's name on each entry. Use this to view all recurring supplier payments service-wide; use ListSupplierRecurringTransfers when scoping to a single fee-paying merchant.
/// </summary>
/// <param name="args">The ListSupplierRecurringTransfersByServiceArgs containing the service ID.</param>
/// <returns>A ListSupplierRecurringTransfersResponse containing the recurring transfers.</returns>
public ListSupplierRecurringTransfersResponse ListSupplierRecurringTransfersByService(ListSupplierRecurringTransfersByServiceArgs args)
{
    return _client.Call<ListSupplierRecurringTransfersResponse>("ListSupplierRecurringTransfersByService", args);
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
/// Lists supplier transfers initiated by the calling merchant (identified via FeeMerchantId). Returns transfers where the caller is the fee-payer, with optional date/status filters.
/// </summary>
/// <param name="args">The ListSupplierTransfersArgs containing the merchant ID and optional filters.</param>
/// <returns>A ListSupplierTransfersResponse containing the list of supplier transfers.</returns>
public ListSupplierTransfersResponse ListSupplierTransfers(ListSupplierTransfersArgs args)
{
    return _client.Call<ListSupplierTransfersResponse>("ListSupplierTransfers", args);
}

/// <summary>
/// Soft-deletes a supplier link for the specified merchant. The supplier's merchant account is not affected — only the payer-to-supplier association is removed.
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
/// Creates a payment transfer from the calling merchant to a supplier. Validates both merchants, runs business rules on the sending merchant's limits, creates the transfer as a free collection, and optionally creates a bill. Notifies the supplier unless client approval is required. This operation supports idempotency via the IdempotencyKey field.
/// </summary>
/// <param name="args">The CreateSupplierTransferArgs containing both merchant IDs, amount, due date, currency, frequency, and optional bill details.</param>
/// <returns>A CreateSupplierTransferResponse containing the created transfer identifier.</returns>
public CreateSupplierTransferResponse CreateSupplierTransfer(CreateSupplierTransferArgs args)
{
    return _client.Call<CreateSupplierTransferResponse>("CreateSupplierTransfer", args);
}

/// <summary>
/// Relaunches (retries) a previously failed transfer for a merchant. Resets the failed payment in the database for reprocessing and sends an internal notification email with the transfer details. This operation supports idempotency via the IdempotencyKey field.
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
/// Updates the security question and answer on an existing Interac payment method. Creates a replacement payment method with the new credentials and deletes the old one. The answer is encrypted via the external data vault, and both question and answer are obfuscated in logs.
/// </summary>
/// <param name="args">The ChangeInteracPaymentMethodQuestionAndAnswerArgs containing the payment method ID, new question, and new answer.</param>
/// <returns>A ChangeInteracPaymentMethodQuestionAndAnswerResponse containing the new payment method ID.</returns>
public ChangeInteracPaymentMethodQuestionAndAnswerResponse ChangeInteracPaymentMethodQuestionAndAnswer(ChangeInteracPaymentMethodQuestionAndAnswerArgs args)
{
    return _client.Call<ChangeInteracPaymentMethodQuestionAndAnswerResponse>("ChangeInteracPaymentMethodQuestionAndAnswer", args);
}

/// <summary>
/// Reverts (cancels or reverses) a transfer. For pending gateway payments, deletes the transfer and its public token. For processed payments, creates reversal operations for each non-fee operation. Rejects transfers over $5,000 or wallet-type transfers. For supplier transfers, only the paying merchant (fee-payer) can revert; the recipient supplier cannot revert a transfer they did not create. This operation supports idempotency via the IdempotencyKey field.
/// </summary>
/// <param name="args">The RevertTransferArgs containing the transfer ID.</param>
/// <returns>A RevertTransferResponse indicating whether the transfer was deleted or reversed.</returns>
public RevertTransferResponse RevertTransfer(RevertTransferArgs args)
{
    return _client.Call<RevertTransferResponse>("RevertTransfer", args);
}

/// <summary>
/// Creates a batch of free operations (deposits or collections) in a single call. Validates that client onboarding (KYC) is completed before allowing free deposit operations. This operation supports idempotency via the IdempotencyKey field.
/// </summary>
/// <param name="args">The CreateFreeOperationBatchArgs containing the list of operations, optional group ID, and processing options.</param>
/// <returns>A CreateFreeOperationBatchResponse containing the results for each operation in the batch.</returns>
public CreateFreeOperationBatchResponse CreateFreeOperationBatch(CreateFreeOperationBatchArgs args)
{
    return _client.Call<CreateFreeOperationBatchResponse>("CreateFreeOperationBatch", args);
}

/// <summary>
/// Creates the free operation. This operation supports idempotency via the IdempotencyKey field.
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
/// Forces immediate processing of a transfer that would otherwise wait for the next scheduled run. For supplier transfers, only the paying merchant (fee-payer) can force-process; the recipient supplier cannot force-execute a transfer they did not create. This operation supports idempotency via the IdempotencyKey field.
/// </summary>
/// <param name="args">The ForcePaymentProcessArgs identifying the payment to force-process.</param>
/// <returns>A ForcePaymentProcessResponse describing the outcome of the forced run.</returns>
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
/// Creates the transaction from raw. This operation supports idempotency via the IdempotencyKey field.
/// </summary>
/// <param name="args">The arguments.</param>
/// <returns>CreateTransactionFromRawResponse.</returns>
public CreateTransactionFromRawResponse CreateTransactionFromRaw(CreateTransactionFromRawArgs args)
{
    return _client.Call<CreateTransactionFromRawResponse>("CreateTransactionFromRaw", args);
}

/// <summary>
/// Creates the direct Interac transaction. This operation supports idempotency via the IdempotencyKey field.
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
/// Creates the payment. This operation supports idempotency via the IdempotencyKey field.
/// </summary>
/// <param name="args">The arguments.</param>
/// <returns>CreatePaymentResponse.</returns>
public CreatePaymentResponse CreatePayment(CreatePaymentArgs args)
{
    return _client.Call<CreatePaymentResponse>("CreatePayment", args);
}

/// <summary>
/// Deletes a recurring transfer by its identifier, stopping all future scheduled occurrences.
/// </summary>
/// <param name="args">The DeleteRecuringTransferArgs containing the recurring transfer ID.</param>
/// <returns>A DeleteRecuringTransferResponse.</returns>
public DeleteRecuringTransferResponse DeleteRecuringTransfer(DeleteRecuringTransferArgs args)
{
    return _client.Call<DeleteRecuringTransferResponse>("DeleteRecuringTransfer", args);
}

/// <summary>
/// Retrieves all active recurring transfers for a given service, including their next scheduled recurrence date and associated merchant information.
/// </summary>
/// <param name="args">The GetRecuringTransfersArgs containing the service ID.</param>
/// <returns>A GetRecuringTransfersResponse containing the list of recurring transfers.</returns>
public GetRecuringTransfersResponse GetRecuringTransfers(GetRecuringTransfersArgs args)
{
    return _client.Call<GetRecuringTransfersResponse>("GetRecuringTransfers", args);
}

/// <summary>
/// Lists the transfers of a bill.
/// </summary>
public ListTransfersFastResponse ListTransfersForBillFast(ListTransfersForBillFastArgs args)
{
    return _client.Call<ListTransfersFastResponse>("ListTransfersForBillFast", args);
}

/// <summary>
/// Retrieves a filtered, summarized list of transfers for a service using an optimized query. Supports filtering by transfer type, date range, merchant, transfer group, error status, and resolved status.
/// </summary>
/// <param name="args">The ListTransfersFastArgs containing the service ID, transfer type, date range, and optional filters.</param>
/// <returns>A ListTransfersFastResponse containing the summarized transfer list.</returns>
public ListTransfersFastResponse ListTransfersFast(ListTransfersFastArgs args)
{
    return _client.Call<ListTransfersFastResponse>("ListTransfersFast", args);
}

/// <summary>
/// Lists the transfers.
/// </summary>
/// <param name="args">The arguments.</param>
/// <returns>ListTransfersResponse.</returns>
public ListTransfersResponse ListTransfers(ListTransfersArgs args)
{
    return _client.Call<ListTransfersResponse>("ListTransfers", args);
}

/// <summary>
/// Deletes the bill.
/// </summary>
/// <param name="args">The arguments.</param>
/// <returns>DeleteBillResponse.</returns>
public DeleteBillResponse DeleteBill(DeleteBillArgs args)
{
    return _client.Call<DeleteBillResponse>("DeleteBill", args);
}

/// <summary>
/// Gets the bill.
/// </summary>
/// <param name="args">The arguments.</param>
/// <returns>GetBillResponse.</returns>
public GetBillResponse GetBill(GetBillArgs args)
{
    return _client.Call<GetBillResponse>("GetBill", args);
}

/// <summary>
/// Creates the bill.
/// </summary>
/// <param name="args">The arguments.</param>
/// <returns>CreateBillResponse.</returns>
public CreateBillResponse CreateBill(CreateBillArgs args)
{
    return _client.Call<CreateBillResponse>("CreateBill", args);
}

/// <summary>
/// Lists the bills.
/// </summary>
/// <param name="args">The arguments.</param>
/// <returns>ListBillsResponse.</returns>
public ListBillsResponse ListBills(ListBillsArgs args)
{
    return _client.Call<ListBillsResponse>("ListBills", args);
}

/// <summary>
/// Sets the default payment method.
/// </summary>
/// <param name="args">The arguments.</param>
/// <returns>SetDefaultPaymentMethodResponse.</returns>
public SetDefaultPaymentMethodResponse SetDefaultPaymentMethod(SetDefaultPaymentMethodArgs args)
{
    return _client.Call<SetDefaultPaymentMethodResponse>("SetDefaultPaymentMethod", args);
}

/// <summary>
/// Deletes the payment method.
/// </summary>
/// <param name="args">The arguments.</param>
/// <returns>DeletePaymentMethodResponse.</returns>
public DeletePaymentMethodResponse DeletePaymentMethod(DeletePaymentMethodArgs args)
{
    return _client.Call<DeletePaymentMethodResponse>("DeletePaymentMethod", args);
}

/// <summary>
/// Gets the payment method.
/// </summary>
/// <param name="args">The arguments.</param>
/// <returns>GetPaymentMethodResponse.</returns>
public GetPaymentMethodResponse GetPaymentMethod(GetPaymentMethodArgs args)
{
    return _client.Call<GetPaymentMethodResponse>("GetPaymentMethod", args);
}

/// <summary>
/// Creates the Interac payment method.
/// </summary>
/// <param name="args">The arguments.</param>
/// <returns>CreateInteracPaymentMethodResponse.</returns>
public CreateInteracPaymentMethodResponse CreateInteracPaymentMethod(CreateInteracPaymentMethodArgs args)
{
    return _client.Call<CreateInteracPaymentMethodResponse>("CreateInteracPaymentMethod", args);
}

/// <summary>
/// Creates the direct account payment method.
/// </summary>
/// <param name="args">The CreateDirectAccountPaymentMethodArgs containing the customer ID and the bank account details for the new payment method.</param>
/// <returns>A CreateDirectAccountPaymentMethodResponse containing the identifier of the newly created payment method.</returns>
public CreateDirectAccountPaymentMethodResponse CreateDirectAccountPaymentMethod(CreateDirectAccountPaymentMethodArgs args)
{
    return _client.Call<CreateDirectAccountPaymentMethodResponse>("CreateDirectAccountPaymentMethod", args);
}

/// <summary>
/// Creates the credit card payment method.
/// </summary>
/// <param name="args">The arguments.</param>
/// <returns>CreateCreditCardPaymentMethodResponse.</returns>
public CreateCreditCardPaymentMethodResponse CreateCreditCardPaymentMethod(CreateCreditCardPaymentMethodArgs args)
{
    return _client.Call<CreateCreditCardPaymentMethodResponse>("CreateCreditCardPaymentMethod", args);
}

/// <summary>
/// Lists the payment methods.
/// </summary>
/// <param name="args">The arguments.</param>
/// <returns>ListPaymentMethodsResponse.</returns>
public ListPaymentMethodsResponse ListPaymentMethods(ListPaymentMethodsArgs args)
{
    return _client.Call<ListPaymentMethodsResponse>("ListPaymentMethods", args);
}

/// <summary>
/// Gets the customers by external identifier.
/// </summary>
/// <param name="args">The arguments.</param>
/// <returns>GetCustomersByExternalIdResponse.</returns>
public GetCustomersByExternalIdResponse GetCustomersByExternalId(GetCustomersByExternalIdArgs args)
{
    return _client.Call<GetCustomersByExternalIdResponse>("GetCustomersByExternalId", args);
}

/// <summary>
/// Deletes the customer.
/// </summary>
/// <param name="args">The arguments.</param>
/// <returns>DeleteCustomerResponse.</returns>
public DeleteCustomerResponse DeleteCustomer(DeleteCustomerArgs args)
{
    return _client.Call<DeleteCustomerResponse>("DeleteCustomer", args);
}

/// <summary>
/// Updates only a customer's contact information (email, phone, address, language) without touching the rest of the customer record. Use this when editing the contact card in isolation: fields left null preserve the stored value, empty strings clear it, and non-empty values overwrite.
/// </summary>
/// <param name="args">The SaveCustomerContactInfoArgs containing the customer ID and the contact information to apply.</param>
/// <returns>A SaveCustomerContactInfoResponse containing the contact information as persisted after the save.</returns>
public SaveCustomerContactInfoResponse SaveCustomerContactInfo(SaveCustomerContactInfoArgs args)
{
    return _client.Call<SaveCustomerContactInfoResponse>("SaveCustomerContactInfo", args);
}

/// <summary>
/// Saves the customer.
/// </summary>
/// <param name="args">The arguments.</param>
/// <returns>SaveCustomerResponse.</returns>
public SaveCustomerResponse SaveCustomer(SaveCustomerArgs args)
{
    return _client.Call<SaveCustomerResponse>("SaveCustomer", args);
}

/// <summary>
/// Gets the customer.
/// </summary>
/// <param name="args">The arguments.</param>
/// <returns>GetCustomerResponse.</returns>
public GetCustomerResponse GetCustomer(GetCustomerArgs args)
{
    return _client.Call<GetCustomerResponse>("GetCustomer", args);
}

/// <summary>
/// Creates the customer.
/// </summary>
/// <param name="args">The arguments.</param>
/// <returns>CreateCustomerResponse.</returns>
public CreateCustomerResponse CreateCustomer(CreateCustomerArgs args)
{
    return _client.Call<CreateCustomerResponse>("CreateCustomer", args);
}

/// <summary>
/// Lists the customers.
/// </summary>
/// <param name="args">The arguments.</param>
/// <returns>ListCustomersResponse.</returns>
public ListCustomersResponse ListCustomers(ListCustomersArgs args)
{
    return _client.Call<ListCustomersResponse>("ListCustomers", args);
}

/// <summary>
/// Adjusts a merchant's wallet balance. IncreaseWallet collects the amount from the merchant (by EFT, or by Interac when requested) and credits the wallet; DecreaseWallet withdraws it from the wallet balance, subject to the risk-adjusted withdrawable balance. Requires the wallet feature to be enabled for the service. This operation supports idempotency via the IdempotencyKey field.
/// </summary>
/// <param name="args">The AdjustWalletArgs containing the service and merchant IDs, the amount, and the adjustment mode.</param>
/// <returns>An AdjustWalletResponse containing the identifier of the transfer created for the adjustment and WasSuccessful set to true; when a withdrawal is refused because the client's boarding is incomplete, no transfer is created and the response carries RequiresSupplierBoarding set to true with WasSuccessful false instead.</returns>
public AdjustWalletResponse AdjustWallet(AdjustWalletArgs args)
{
    return _client.Call<AdjustWalletResponse>("AdjustWallet", args);
}

/// <summary>
/// Gets the merchants by external identifier.
/// </summary>
/// <param name="args">The arguments.</param>
/// <returns>GetMerchantsByExternalIdResponse.</returns>
public GetMerchantsByExternalIdResponse GetMerchantsByExternalId(GetMerchantsByExternalIdArgs args)
{
    return _client.Call<GetMerchantsByExternalIdResponse>("GetMerchantsByExternalId", args);
}

/// <summary>
/// Deletes the merchant.
/// </summary>
/// <param name="args">The arguments.</param>
/// <returns>DeleteMerchantResponse.</returns>
public DeleteMerchantResponse DeleteMerchant(DeleteMerchantArgs args)
{
    return _client.Call<DeleteMerchantResponse>("DeleteMerchant", args);
}

/// <summary>
/// Saves the merchant account information. This operation is protected by two-factor authentication. On first use the response carries two-factor setup instructions (TwoFactorStatus and TwoFactorSetupData); see the Two-factor authentication guide.
/// </summary>
/// <param name="args">The SaveMerchantAccountInfoArgs containing the merchant ID and the replacement bank account information.</param>
/// <returns>A SaveMerchantResponse containing the two-factor authentication status of the operation.</returns>
public SaveMerchantResponse SaveMerchantAccountInfo(SaveMerchantAccountInfoArgs args)
{
    return _client.Call<SaveMerchantResponse>("SaveMerchantAccountInfo", args);
}

/// <summary>
/// Saves the merchant basic information.
/// </summary>
/// <param name="args">The arguments.</param>
/// <returns>SaveMerchantResponse.</returns>
public SaveMerchantResponse SaveMerchantBasicInfo(SaveMerchantBasicInfoArgs args)
{
    return _client.Call<SaveMerchantResponse>("SaveMerchantBasicInfo", args);
}

/// <summary>
/// Saves the merchant.
/// </summary>
/// <param name="args">The SaveMerchantArgs containing the merchant ID and the replacement merchant information.</param>
/// <returns>A SaveMerchantResponse indicating success or errors.</returns>
public SaveMerchantResponse SaveMerchant(SaveMerchantArgs args)
{
    return _client.Call<SaveMerchantResponse>("SaveMerchant", args);
}

/// <summary>
/// Gets the merchant.
/// </summary>
/// <param name="args">The arguments.</param>
/// <returns>GetMerchantResponse.</returns>
public GetMerchantResponse GetMerchant(GetMerchantArgs args)
{
    return _client.Call<GetMerchantResponse>("GetMerchant", args);
}

/// <summary>
/// Adds a new bank account (i.e., new merchant in TIB's data model) to an existing fully-boarded service. Authorizes the new merchant on insert. One-shot semantic: no pending state, no approval workflow, no confirmation email. Owner and Currency are inherited from an active sibling merchant on the same service. This is a parallel path to CreateMerchant (which serves boarding's first-merchant insert).
/// </summary>
/// <param name="args">The AddBankAccountArgs containing the service ID and the new bank account details.</param>
/// <returns>An AddBankAccountResponse containing the identifier of the newly created merchant.</returns>
public AddBankAccountResponse AddBankAccount(AddBankAccountArgs args)
{
    return _client.Call<AddBankAccountResponse>("AddBankAccount", args);
}

/// <summary>
/// Creates the merchant.
/// </summary>
/// <param name="args">The CreateMerchantArgs containing the service ID and the merchant information to create.</param>
/// <returns>A CreateMerchantResponse containing the identifier of the newly created merchant.</returns>
public CreateMerchantResponse CreateMerchant(CreateMerchantArgs args)
{
    return _client.Call<CreateMerchantResponse>("CreateMerchant", args);
}

/// <summary>
/// Retrieves the payment provider boarding (onboarding) status for all merchants within a service. Returns each merchant's boarding progress with their current status.
/// </summary>
/// <param name="args">The GetServiceBoardingStatusArgs containing the service ID to query.</param>
/// <returns>A GetServiceBoardingStatusResponse containing the boarding status of each merchant in the service.</returns>
public GetServiceBoardingStatusResponse GetServiceBoardingStatus(GetServiceBoardingStatusArgs args)
{
    return _client.Call<GetServiceBoardingStatusResponse>("GetServiceBoardingStatus", args);
}

/// <summary>
/// Lists the merchants.
/// </summary>
/// <param name="args">The arguments.</param>
/// <returns>ListMerchantsResponse.</returns>
public ListMerchantsResponse ListMerchants(ListMerchantsArgs args)
{
    return _client.Call<ListMerchantsResponse>("ListMerchants", args);
}

/// <summary>
/// Retrieves wallet information for a service, including the effective balance (wallet balance plus available delay buffer minus pending collections), the risk-adjusted withdrawable amount, processing status, and whether the new wallet feature is active.
/// </summary>
/// <param name="args">The GetWalletInformationsArgs containing the service ID.</param>
/// <returns>A GetWalletInformationsResponse containing the wallet model with balance, withdrawable amount, and status.</returns>
public GetWalletInformationsResponse GetWalletInformationsByService(GetWalletInformationsArgs args)
{
    return _client.Call<GetWalletInformationsResponse>("GetWalletInformationsByService", args);
}

/// <summary>
/// Gets the service.
/// </summary>
/// <param name="args">The arguments.</param>
/// <returns>GetServiceResponse.</returns>
public GetServiceResponse GetService(GetServiceArgs args)
{
    return _client.Call<GetServiceResponse>("GetService", args);
}

/// <summary>
/// Lists the services.
/// </summary>
/// <param name="args">The arguments.</param>
/// <returns>ListServicesResponse.</returns>
public ListServicesResponse ListServices(ListServicesArgs args)
{
    return _client.Call<ListServicesResponse>("ListServices", args);
}

/// <summary>
/// Opens a session on one access of a user, usually a client, a merchant or a service. Call GetLoginAccessList first and pass the LoginsUserRelationsId of the access to open. Send the returned SessionId as SessionToken on the following calls. On a merchant-level session, each MerchantId described as automatically set for merchant-level logins takes the session's merchant, whatever value is sent.
/// </summary>
/// <param name="args">The LoginArgs containing the client ID, username, password and the LoginsUserRelationsId of the access to open.</param>
/// <returns>A LoginResponse containing the SessionId.</returns>
public LoginResponse Login(LoginArgs args)
{
    return _client.Call<LoginResponse>("Login", args);
}

/// <summary>
/// Lists the accesses of a user. Each entry is one access that Login can open a session on (usually a client, a merchant or a service) and gives the LoginsUserRelationsId to pass to Login.
/// </summary>
/// <param name="args">The GetLoginAccessListArgs containing the client ID, username and password.</param>
/// <returns>A GetLoginAccessListResponse listing the user's accesses.</returns>
public GetLoginAccessListResponse GetLoginAccessList(GetLoginAccessListArgs args)
{
    return _client.Call<GetLoginAccessListResponse>("GetLoginAccessList", args);
}

/// <summary>
/// Opens a client-level session for a user who has client-level access to the given ClientId. Send the returned SessionId as SessionToken on the following calls. For a merchant-level or service-level access, use GetLoginAccessList, then Login.
/// </summary>
/// <param name="args">The CreateSessionArgs containing the client ID, username and password.</param>
/// <returns>A CreateSessionResponse containing the SessionId.</returns>
public CreateSessionResponse CreateSession(CreateSessionArgs args)
{
    return _client.Call<CreateSessionResponse>("CreateSession", args);
}
    
  }
}

