using ConsoleTestApp.UI;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tib.Api;
using Tib.Api.Common;
using Tib.Api.Model;
using Tib.Api.Model.Bill;
using Tib.Api.Model.WhiteLabeling;
using Tib.Api.Model.WhiteLabeling.Args;
using static Tib.Api.Model.Enum;

namespace ConsoleTestApp
{
    class Program
    {
        private static Guid? _session = null;
        private static string _siteUrl = "http://sandboxportal.tib.finance";
        private static Guid _clientId = new Guid("9bfd1de3-2bb4-4a64-8b71-453699dff214");
        private static Guid _service = new Guid("038D7171-BF23-4F3C-9E78-CF6342624FC7");
        private static Guid? _provider = null;
        private static Guid _merchant = new Guid("66077224-4239-4cd1-90e4-34650bf051ad"); // default merchant 
        private static Guid _bill = new Guid("e23682cc-e2bb-4868-a1f5-9eac6e2b4109"); // default Bill to go to 
        private static Guid _customer = new Guid("7fea36a6-a62f-44c1-97af-1a0b2b285b66"); // default  Customer
        private static Guid _paymentMethodId = new Guid("ed77b689-56be-4731-9ee4-d8685eba7d50");
        private static Guid? _payment = null; // you'll have to create a payment then this variabl with get filled automaticaly.
        private static Guid? _transfer = null; // you'll have to create a transfer in order to use it . 

        static void Main(string[] args)
        {
            TibInvoker.InitializePortal(_siteUrl);
            char lastKey = ' ';

            while (lastKey != 'x' && lastKey != 'X')
            {
                Console.Clear();
                if (_session.HasValue)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("----SESSION:" + _session.Value.ToString() + "----");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                lastKey = Menu.MenuPreSelect(_session);
                switch (lastKey)
                {
                    case 'o':
                    case 'O': // opena session
                        OpenSession();
                        break;
                    case 'w':
                    case 'W': // whitelabeling Methods;
                        char wlstep = Menu.WhitelabelingMenu();
                        switch (wlstep)
                        {
                            case '1':
                                GetWhiteLabeling();
                                break;
                            case '2':
                                GetListWhiteLabelings();
                                break;
                            case '3':
                                AddWhiteLabeling();
                                break;
                            case '4':
                                DeleteWhiteLabeling();
                                break;
                            case '5':
                                UpdateWhiteLabeling();
                                break;
                        }
                        break;
                    case 'c':
                    case 'C': // Customer Methods
                        char cStep = Menu.CustomerMenu();
                        switch (cStep)
                        {
                            case '1':
                                GetCustomer();
                                break;
                            case '2':
                                CreateCustomer();
                                break;
                            case '3':
                                DeleteCustomer();
                                break;
                            case '4':
                                GetCustomerByExternalId();
                                break;
                            case '5':
                                GetListCustomers();
                                break;
                            case '6':
                                SaveCustomer();
                                break;
                        }
                        break;
                    case 'b':
                    case 'B': // Bill Methods
                        char bStep = Menu.BillMenu();
                        switch (bStep)
                        {
                            case '1':
                                CreateNewBill();
                                break;
                            case '2':
                                DeleteBill();
                                break;
                            case '3':
                                ListBills();
                                break;
                            case '4':
                                GetBill();
                                break;
                        }
                        break;
                    case 'P':
                    case 'p': // Payment Methods
                        string pStep = Menu.PaymentMenu();
                        switch (pStep)
                        {
                            case "1":
                                CreatePayement();
                                break;
                            case "2":
                                DeletePayment();
                                break;
                            case "3":
                                CreateDirecDeposit();
                                break;
                            case "4":
                                CreateDirectInteracTransaction();
                                break;
                            case "5":
                                CreateTransactionFromRaw();
                                break;
                            case "6":
                                CreateFreeOperation();
                                break;
                            case "7":
                                RevertTransfer();
                                break;
                            case "8":
                                GetRecuringTransfers();
                                break;
                            case "9":
                                DeleteRecuringTransfer();
                                break;
                            case "10":
                                CreateDirectAccountPaymentMethod();
                                break;
                            case "11":
                                CreateCreditCardPaymentMethod();
                                break;
                            case "12":
                                GetPaymentMethod();
                                break;
                            case "13":
                                ListPaymentMethod();
                                break;
                            case "14":
                                SetDefaultPaymentMethod();
                                break;
                            case "15":
                                DeletePayentMethod();
                                break;
                            case "16":
                                GetPayment();
                                break;
                            case "18":
                                MarkPaymentResolved();
                                break;
                            case "21":
                                //GetFeeCount();
                                break;
                            case "22":
                                ForcePaymentProcess();
                                break;
                            case "23":
                                Login();
                                break;
                            case "24":
                                GetLoginAccessList();
                                break;
                            case "25":
                                GetDropinPublicToken();
                                break;
                            case "26":
                                AddNewDasProvider();
                                break;
                            case "27":
                                AddNewDasPayment();
                                break;
                            case "28":
                                ListDasProviders();
                                break;
                            case "29":
                                ListDasPayments();
                                break;
                            case "30":
                                GetMerchantByExternalId();
                                break;
                            case "31":
                                ChangeInteracPaymentMethodQuestionAnswer();
                                break;
                        }
                        break;
                    case 's':
                    case 'S': // Service Methods.
                        string sStep = Menu.ServiceMenu();
                        switch (sStep)
                        {
                            case "1":
                                CreateSubClient();
                                break;
                            case "2":
                                //SetClientDefaultServiceSettings();
                                break;
                            case "3":
                                SetClientDefaultServiceFeeSettings();
                                break;
                            case "4":
                                SetClientSettigs();
                                break;
                            case "5":
                                GetClientSettings();
                                break;
                            case "6":
                                ListServices();
                                break;
                            case "7":
                                GetService();
                                break;
                            case "8":
                                CreateMerchant();
                                break;
                            case "9":
                                GetMerchant();
                                break;
                            case "10":
                                SaveMerchant();
                                break;
                            case "11":
                                SaveMerchantBasicInfo();
                                break;
                            case "12":
                                SaveMerchantAccountInfo();
                                break;
                            case "13":
                                DeleteMerchant();
                                break;
                        }
                        break;
                    case 'r':
                    case 'R': // Report Menu
                        char rStep = Menu.ReportMenu();
                        switch (rStep)
                        {
                            case '1':
                                ListExecutedOperation();
                                break;
                        }
                        break;
                }
            }
            Console.ReadLine();
        }
        #region Session 
        private static void OpenSession()
        {
            Console.Clear();
            Console.WriteLine("OPEN SESSION");
            Console.WriteLine("********************************");
            Console.WriteLine("Enter user");
            string user = Console.ReadLine();
            Console.WriteLine("Enter password");
            string pass = Console.ReadLine();


            CreateSessionResponse response = TibInvoker.Portal.CreateSession(new CreateSessionArgs()
            {
                ClientId = _clientId,
                Username = user,
                Password = pass,
            });

            ResponseHandler(response, "Press key to continue");
            if (!response.HasError)
            {
                _session = response.SessionId;
            }
        }
        #endregion
        #region Whitelabeling  (done)
        private static void GetWhiteLabeling()
        {
            Console.Clear();
            int type = GetEntityType();
            Guid entityId = new Guid(getEntityIdAsString(type));

            Console.Clear();
            var result = TibInvoker.Portal.GetWhiteLabelingData(new GetWhiteLabelingArgs
            {
                SessionToken = _session,
                WhiteLabelingLevel = type,
                Id = entityId
            });
            ResponseHandler(result, JsonConvert.SerializeObject(result.WhiteLabeling));

            Console.ReadLine();
        }
        private static void GetListWhiteLabelings()
        {
            var result = TibInvoker.Portal.GetListWhiteLabeling(new GetWhiteLabelingArgs { SessionToken = _session });
            ResponseHandler(result, JsonConvert.SerializeObject(result.whiteLabelings));
            Console.ReadKey();
        }
        private static void AddWhiteLabeling()
        {
            var localWhiteLabelingData = new List<WhiteLabelingDataModel>() {
        new WhiteLabelingDataModel { CssProperty = "test", CssValue = "testvalue" },
        new WhiteLabelingDataModel { CssProperty = "test2", CssValue = "testvalue2" }
      };
            int val = GetEntityType();

            var result = TibInvoker.Portal.SetWhiteLabeling(new SetWhiteLabelingArgs
            {
                SessionToken = _session,
                WhiteLabelingLevel = val,
                WhiteLabelingData = localWhiteLabelingData
            });

            ResponseHandler(result, "whiteLabeling added Correctly");

        }
        private static void DeleteWhiteLabeling()
        {
            int type = GetEntityType();

            Guid entityId = new Guid(getEntityIdAsString(type));
            var result = TibInvoker.Portal.DeleteWhiteLabeling(new DeleteWhitelabelinArgs
            {
                SessionToken = _session,
                Id = entityId,
                Level = type
            });

            ResponseHandler(result, "whiteLabeling Deleted Correctly");


        }
        private static void UpdateWhiteLabeling()
        {
            int type = GetEntityType();
            Guid entityId = new Guid(getEntityIdAsString(type));

            var theGetResult = TibInvoker.Portal.GetWhiteLabelingData(
              new GetWhiteLabelingArgs
              {
                  SessionToken = _session,
                  Id = entityId,
                  WhiteLabelingLevel = type
              }
            );
            if (!theGetResult.HasError)
            {
                var localWhiteLabelingToUpdate = new List<WhiteLabelingDataModel>() {
        new WhiteLabelingDataModel {
          WhiteLabelingDataId = theGetResult.WhiteLabeling.WhiteLabelingData[3].WhiteLabelingDataId,
          CssProperty  = theGetResult.WhiteLabeling.WhiteLabelingData[3].CssProperty,
          CssValue = "Brown"
        }
      };
                var result = TibInvoker.Portal.UpdateWhiteLabeling(
                  new UpdateWhiteLabelingDataArgs
                  {
                      SessionToken = _session,
                      UpdatedWhiteLabelingData = localWhiteLabelingToUpdate
                  });
                ResponseHandler(result, "whiteLabeling Updated Correctly. ");

            }
            else
            {
                Console.WriteLine("couldn't get this client's whitelabeling.");
            }
        }
        #endregion
        #region Customer (done) 
        private static void GetCustomer()
        {
            var result = TibInvoker.Portal.GetCustomer(
              new Tib.Api.Model.Customer.GetCustomerArgs
              {
                  SessionToken = _session,
                  CustomerId = _customer
              }
            );
            ResponseHandler(result, JsonConvert.SerializeObject(result.Customer));
        }
        private static void CreateCustomer()
        {
            Console.Write("Customer name: ");
            string name = Console.ReadLine();
            Console.Write("Customer DEscription: ");
            string Description = Console.ReadLine();
            Console.Write("Customer ExId: ");
            string externalId = Console.ReadLine();

            Console.WriteLine("Pick a lang \n 1- french \n 2- English");
            int lang = int.Parse(Console.ReadLine());
            var result = TibInvoker.Portal.CreateCustomer(new Tib.Api.Model.Customer.CreateCustomerArgs
            {
                SessionToken = _session,
                ServiceId = _service,
                Customer = new Tib.Api.Model.Customer.CustomerEntity
                {
                    CustomerDescription = Description,
                    CustomerName = name,
                    Language = (LanguageEnum)lang,
                    CustomerExternalId = externalId, 
                    CustomerEmail = "EMail@customer.com"
                }
            });
            ResponseHandler(result, "Customer Added Successfuly.");
            if (!result.HasError)
                _customer = result.CustomerId;
        }
        private static void DeleteCustomer()
        {
            var result = TibInvoker.Portal.DeleteCustomer(new Tib.Api.Model.Customer.DeleteCustomerArgs
            {
                SessionToken = _session,
                CustomerId = _customer
            });
            ResponseHandler(result, "Customer Delete Successfuly");
        }
        private static void GetCustomerByExternalId()
        {
            Console.Write("\n ExternalID : ");
            string exID = Console.ReadLine();
            var result = TibInvoker.Portal.GetCustomersByExternalId(
                new Tib.Api.Model.Customer.GetCustomersByExternalIdArgs
                {
                    SessionToken = _session,
                    ExternalCustomerId = exID
                }
              );
            ResponseHandler(result, JsonConvert.SerializeObject(result.Customers));
        }
        private static void GetListCustomers()
        {
            var result = TibInvoker.Portal.ListCustomers(new Tib.Api.Model.Customer.ListCustomersArgs
            {
                SessionToken = _session,
                ServiceId = _service
            });
            ResponseHandler(result, JsonConvert.SerializeObject(result.Customers));
        }
        private static void SaveCustomer()
        {
            Console.Clear();
            Console.Write("Customer name : "); string customerName = Console.ReadLine();
            Console.Write("\nCustomer External Id : "); string exId = Console.ReadLine();
            Console.Write("\nCustomer description : "); string customerDesc = Console.ReadLine();
            Console.Write("\nCustomer Language (1- fr, 2- eng) : "); int customerLang = int.Parse(Console.ReadLine());
            var result = TibInvoker.Portal.SaveCustomer(new Tib.Api.Model.Customer.SaveCustomerArgs
            {
                SessionToken = _session,
                Customer = new Tib.Api.Model.Customer.CustomerModel
                {
                    CustomerId = _customer,
                    CustomerDescription = customerDesc,
                    CustomerExternalId = exId,
                    CustomerName = customerName,
                    Language = (LanguageEnum)customerLang,
                }
            });
            ResponseHandler(result, "Customer Updated.");
        }
        #endregion
        #region Bill (done)
        private static void CreateNewBill()
        {
            Console.Write("\nAmount : ");
            int amount = Int32.Parse(Console.ReadLine());
            Console.Write("\nLanguage (1 For Frenc 2 for English ): ");
            int language = Int32.Parse(Console.ReadLine());
            Console.Write("\nCurrency (1 For Canada - 2 For Usa) : ");
            int currency = Int32.Parse(Console.ReadLine());

            Console.Write("\nTitle : ");
            string title = Console.ReadLine();
            Console.Write("\nDescription : ");
            string desc = Console.ReadLine();


            var result = TibInvoker.Portal.CreateBill(new CreateBillArgs
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
            });
            ResponseHandler(result, JsonConvert.SerializeObject(result.BillId));
            if (!result.HasError)
                _bill = result.BillId;
        }
        private static void DeleteBill()
        {
            Console.Clear();
            Console.Write("\nAre you sure? (y|Y) or (n|N)");
            char choice = Console.ReadKey().KeyChar;
            if (choice == 'y' || choice == 'Y')
            {
                var result = TibInvoker.Portal.DeleteBill(new DeleteBillArgs
                {
                    SessionToken = _session,
                    BillId = _bill
                });
                ResponseHandler(result, "Bill deleted successfuly");
            }
        }
        private static void ListBills()
        {
            var result = TibInvoker.Portal.ListBills(new ListBillsArgs
            {
                SessionToken = _session,
                ServiceId = _service,
                FromDateTime = new DateTime(2020, 12, 31),
                ToDateTime = DateTime.Now,
                MerchantId = _merchant
            });

            ResponseHandler(result, JsonConvert.SerializeObject(result.Bills));
        }
        private static void GetBill()
        {
            var result = TibInvoker.Portal.GetBill(new GetBillArgs
            {
                SessionToken = _session,
                BillId = _bill
            });
            ResponseHandler(result, JsonConvert.SerializeObject(result.Bill));
        }
        private static void SetLocalBill()
        {
            string input = Console.ReadLine();
            _bill = new Guid(input);
        }
        #endregion
        #region payment.
        private static void CreatePayement()
        {
            Console.Clear();
            Console.Write("CustomerEmail : "); string customerEmail = Console.ReadLine();
            Console.WriteLine("Choose a payment Flow \n \t 1 - annonymous \n \t 2 - know Cutomer With Email"); PaymentFlowEnum paymentFlow = (PaymentFlowEnum)int.Parse(Console.ReadLine());
            Console.WriteLine("Choose a Language \n \t 1 - french \n \t 2 - english"); LanguageEnum language = (LanguageEnum)int.Parse(Console.ReadLine());

            var result = TibInvoker.Portal.CreatePayment(new CreatePaymentArgs
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
            });
            ResponseHandler(result, JsonConvert.SerializeObject(result.PaymentId));
            if (!result.HasError)
                _payment = result.PaymentId;
        }
        private static void DeletePayment()
        {
            var result = TibInvoker.Portal.DeletePayment(new DeletePaymentArgs
            {
                SessionToken = _session,
                PaymentId = _payment.Value,
            });
            ResponseHandler(result, "Deleted Successfuly.");
        }
        private static void CreateDirecDeposit()
        {
            Console.Clear();
            Console.WriteLine("Account info");
            Console.Write("Account name : "); string accountName = Console.ReadLine();
            Console.Write("\nBank number: "); string bankNumber = Console.ReadLine();
            Console.Write("\n Check degit : "); string CheckDegit = Console.ReadLine();
            Console.Write("\n Institute number: "); string InsNumber = Console.ReadLine();
            Console.Write("\n Owner : "); string Owner = Console.ReadLine();
            Console.Write("\n Account number: "); string accountNumber = Console.ReadLine();
            //var result = TibInvoker.Portal.CreateDirectDeposit(new CreateDirectDepositArgs
            //{
            //    SessionToken = _session,
            //    Amount = 1,
            //    Currency = CurrencyEnum.USD,
            //    DepositDueDate = DateTime.Now.AddDays(1),
            //    DestinationAccount = new Tib.Api.Model.PaymentMethod.AccountModel
            //    {
            //        AccountName = accountName,
            //        BankNumber = bankNumber,
            //        CheckDigit = CheckDegit,
            //        InstitutionNumber = InsNumber,
            //        Owner = Owner,
            //        AccountNumber = accountNumber,
            //    },
            //    Language = LanguageEnum.English,
            //    OriginMerchantId = _merchant,
            //    StatementDescription = ""
            //}); 
            var res = TibInvoker.Portal.CreateFreeOperation(new CreateFreeOperationArgs
                  {
                    Amount = 1,
                    SessionToken = _session,
                    Language = LanguageEnum.English,
                    MerchantId = _merchant,
                    TransactionDueDate = DateTime.Now.AddDays(1),
                    TransferType = TransferTypeEnum.FreeDeposit,
                    PaymentMethodId = new Guid(),
                    TransferFrequency = TransferFrequencyEnum.Once,
                    StopSameIdentifications = true,
                    GroupId = "",
                    ReferenceNumber = "",
                    CustomerId = new Guid(),
                    BillId = new Guid(),

                  });
            ResponseHandler(res, "Created");
        }
        private static void CreateDirectInteracTransaction()
        {
            var result = TibInvoker.Portal.CreateDirectInteracTransaction(new CreateDirectInteracTransactionArgs
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
            });
            ResponseHandler(result, JsonConvert.SerializeObject(result.TransferId));
        }
        private static void CreateTransactionFromRaw()
        {
            var result = TibInvoker.Portal.CreateTransactionFromRaw(new CreateTransactionFromRawArgs
            {
                SessionToken = _session,
                MerchantId = _merchant,
                RawAcpFileContent = "",
            });
            ResponseHandler(result, JsonConvert.SerializeObject(result.TransactionsGroupId));
        }
        private static void CreateFreeOperation()
        {
            var result = TibInvoker.Portal.CreateFreeOperation(new CreateFreeOperationArgs
            {
                SessionToken = _session,
                BillId = _bill,
                Amount = 1,
                CustomerId = _customer,
                Language = LanguageEnum.English,
                MerchantId = _merchant,
                GroupId = "",
                PaymentMethodId = _paymentMethodId,
                ReferenceNumber = "",
                TransactionDueDate = DateTime.Now.AddDays(10),
                TransferFrequency = TransferFrequencyEnum.Monthly,
                TransferType = TransferTypeEnum.FreeCollection,
            });
            ResponseHandler(result, JsonConvert.SerializeObject(result.PaymentId));
        }
        private static void RevertTransfer()
        {
            var result = TibInvoker.Portal.RevertTransfer(new Tib.Api.Model.PaymentMethod.RevertTransferArgs
            {
                SessionToken = _session,
                TransferId = _transfer.Value,
            });
      Console.WriteLine(result.HasBeenDeleted.ToString());
            ResponseHandler(result, "Success.");
        }
        public static void getListTransfers()
        {
            var result = TibInvoker.Portal.ListTransfers(new Tib.Api.Model.Payment.ListTransfersArgs
            {
                SessionToken = _session,
                FromDate = new DateTime(2020, 01, 01),
                ExternalMerchantGroupId = "",
                LevelFilterId = new Guid(),
                MarkResolvedOnly = false,
                PaymentFilterLevel = PaymentFilterLevelEnum.Bill,
                TransferType = TransferTypeFlag.All,
                ToDate = DateTime.Now,
                TransferGroupId = "",
                OnlyWithErrors = false,
            });

            ResponseHandler(result, JsonConvert.SerializeObject(result.Payments));
        }
        public static void getListTransfersFast()
        {
            var result = TibInvoker.Portal.ListTransfersFast(new Tib.Api.Model.Payment.ListTransfersFastArgs
            {
                SessionToken = _session,
                FromDate = new DateTime(2020, 01, 01),
                ExternalMerchantGroupId = "",
                MerchantId = new Guid(), // Merchant Id
                MarkResolvedOnly = false,
                TransferType = TransferTypeEnum.PaymentAndFreeCollection, // depending on the type of payment you wanna retrieve.
                ToDate = DateTime.Now,
                TransferGroupId = "",
                OnlyWithErrors = false,
            });

            ResponseHandler(result, JsonConvert.SerializeObject(result.Transfers));

        }
        public static void getListTransfersForBillFast()
        {
            var result = TibInvoker.Portal.ListTransfersForBillFast(new Tib.Api.Model.Payment.ListTransfersForBillFastArgs
            {
                SessionToken = _session,
                BillId = new Guid(), // the bill Id 
                MerchantId = new Guid() // The Merchant Id .
            });

            ResponseHandler(result, JsonConvert.SerializeObject(result.Transfers));
        }

        private static void GetRecuringTransfers()
        {
            var result = TibInvoker.Portal.GetRecuringTransfers(new GetRecuringTransfersArgs
            {
                SessionToken = _session,
                ServiceID = _service
            });
            ResponseHandler(result, JsonConvert.SerializeObject(result.RecuringTransfers));
        }
        private static void DeleteRecuringTransfer()
        {
            var result = TibInvoker.Portal.DeleteRecuringTransfer(new DeleteRecuringTransferArgs
            {
                SessionToken = _session,
                RecuringTransferId = new Guid(""),
            });
        }
        private static void CreateDirectAccountPaymentMethod()
        {
            var result = TibInvoker.Portal.CreateDirectAccountPaymentMethod(new Tib.Api.Model.PaymentMethod.CreateDirectAccountPaymentMethodArgs
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
            });
            ResponseHandler(result, JsonConvert.SerializeObject(result.PaymentMethodId));
        }
        private static void CreateCreditCardPaymentMethod()
        {
            var result = TibInvoker.Portal.CreateCreditCardPaymentMethod(new Tib.Api.Model.PaymentMethod.CreateCreditCardPaymentMethodArgs
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
            }); ;
            ResponseHandler(result, JsonConvert.SerializeObject(result.PaymentMethodId));
            if (!result.HasError)
                _paymentMethodId = result.PaymentMethodId;
        }
        private static void GetPaymentMethod()
        {
            var result = TibInvoker.Portal.GetPaymentMethod(new Tib.Api.Model.PaymentMethod.GetPaymentMethodArgs
            {
                PaymentMethodId = _paymentMethodId,
                SessionToken = _session,
            });
            ResponseHandler(result, JsonConvert.SerializeObject(result.PaymentMethod));
        }
        private static void ListPaymentMethod()
        {
            var result = TibInvoker.Portal.ListPaymentMethods(new Tib.Api.Model.PaymentMethod.ListPaymentMethodsArgs
            {
                CustomerId = _customer,
                SessionToken = _session,
            });
            ResponseHandler(result, JsonConvert.SerializeObject(result.PaymentMethods));
        }
        private static void SetDefaultPaymentMethod()
        {
            var result = TibInvoker.Portal.SetDefaultPaymentMethod(new Tib.Api.Model.PaymentMethod.SetDefaultPaymentMethodArgs
            {
                CustomerId = _customer,
                PaymentMethodId = _paymentMethodId,
                SessionToken = _session
            });
            ResponseHandler(result, "Successfuly set.");
        }

        private static void DeletePayentMethod()
        {
            var result = TibInvoker.Portal.DeletePaymentMethod(new Tib.Api.Model.PaymentMethod.DeletePaymentMethodArgs
            {
                PaymentMethodId = _paymentMethodId,
                SessionToken = _session
            });
            ResponseHandler(result, "Deleted.");
        }

        private static void GetPayment()
        {
            var result = TibInvoker.Portal.GetPayment(new Tib.Api.Model.PaymentMethod.GetPaymentArgs
            {
                PaymentId = _payment.Value,
                SessionToken = _session
            });
            ResponseHandler(result, JsonConvert.SerializeObject(result.Payment));
        }


        private static void MarkPaymentResolved()
        {
            var result = TibInvoker.Portal.MarkPaymentResolved(new Tib.Api.Model.PaymentMethod.MarkPaymentResolvedArgs
            {
                ListOfPayment = new List<Guid> { _payment.Value },
                SessionToken = _session
            });
            ResponseHandler(result, "Success.");
        }
       
       
       
        private static void ForcePaymentProcess()
        {
            var result = TibInvoker.Portal.ForcePaymentProcess(new Tib.Api.Model.PaymentMethod.ForcePaymentProcessArgs
            {
                SessionToken = _session,
                PaymentId = _payment.Value,
            });
            ResponseHandler(result, "Success");
        }
        private static void Login()
        {
            var result = TibInvoker.Portal.Login(new Tib.Api.Model.Login.LoginArgs
            {
                ClientId = _clientId,
                SessionToken = _session,
                LoginsUserRelationsId = new Guid(),
                Password = "",
                Username = ""
            });
            ResponseHandler(result, JsonConvert.SerializeObject(result.SessionId));
        }

        private static void GetLoginAccessList()
        {
            var result = TibInvoker.Portal.GetLoginAccessList(new Tib.Api.Model.Login.GetLoginAccesListArgs
            {
                ClientId = _clientId,
                Username = "userhdce",
                Password = "userhdce",
                SessionToken = _session
            });
            ResponseHandler(result, JsonConvert.SerializeObject(result.LoginRelations));
        }

        private static void GetDropinPublicToken()
        {
            var result = TibInvoker.Portal.GetDropInPublicToken(new Tib.Api.Model.DropIn.GetDropInPublicTokenArgs
            {
                SessionToken = _session,
                Amount = 1,
                BillId = _bill,
                CustomerId = _customer,
                Description = "pay me",
                DropInAuthorizedPaymentMethod = AutorizedPaymentMethodFlags.DirectAccount,
                ExpirationDays = 10,
                ExternalReferenceNumber = "",
                Language = LanguageEnum.English,
                PaymentDueDate = DateTime.Now,
                ShowCustomerExistingPaymentMethods = true,
                Title = "pay this",
                TransferType = TransferTypeEnum.FreeDeposit,
                MerchantId = _merchant
            });
            ResponseHandler(result, JsonConvert.SerializeObject(result.PublicTokenId));
        }

        private static void AddNewDasProvider()
        {
            var result = TibInvoker.Portal.AddNewDasProvider(new Tib.Api.Model.DropIn.AddNewDasProviderArgs
            {
                SessionToken = _session,
                DasProviderCanada = new Tib.Api.Model.DropIn.DasProviderEntityCanada
                {
                    BusinessName = "canada for you",
                    BusinessOrAccountNumber = "12948939393",
                    DeclarationFrequency = DasProviderCanadaDeclarationFrequencyEnum.Monthly,
                    Description = "desc",
                    FileNumber = "98448",
                    FileType = DasProviderCanadaFileTypeEnum.FileType_RP

                },
                DasProviderQuebec = new Tib.Api.Model.DropIn.DasProviderEntityQuebec
                {
                    DeclarationFrequency = DasProviderQuebecDeclarationFrequencyEnum.Monthly,
                    Description = "desc",
                    FileNumber = "string",
                    FileType = DasProviderQuebecFileTypeEnum.FileType_RS,
                    IdentificationNumber = "333333"
                },
                DasProviderType = DasProviderTypeEnum.CanadaRevenueAgancy,
                MerchantId = new Guid("122c2650-6418-469a-a2ce-4fdc02c601ac"),
            });
            ResponseHandler(result, JsonConvert.SerializeObject(result.DasProviderId));
            if (!result.HasError)
                _provider = result.DasProviderId;
        }

        private static void AddNewDasPayment()
        {
            var result = TibInvoker.Portal.AddNewDasPayment(new Tib.Api.Model.DropIn.AddNewDasPaymentArgs
            {
                SessionToken = _session,
                DasPaymentCanada = new Tib.Api.Model.DropIn.DasPaymentCanadaEntity
                {
                    LastPayPeriodEmployeeCount = 12,
                    PaymentAmount = 12,
                    PeriodEndDate = new Tib.Api.Model.Merchant.DasMonthlyPeriod(new DateTime(2023, 02, 02)),
                    PeriodRawRemuneration = 23,
                },
                DasPaymentQuebec = new Tib.Api.Model.DropIn.DasPaymentQuebecEntity
                {
                    PeriodEndDate = new Tib.Api.Model.DropIn.DasDateField(new DateTime(2023, 02, 02)),
                    CNESST = 233,
                    HealthServiceFund = 2,
                    ParentalInsurancePlan = 2,
                    PeriodStartDate = new Tib.Api.Model.DropIn.DasDateField(new DateTime(2020, 02, 02)),
                    RetirementPensionPlan = 2,
                    WithhodingTax = 1
                },
                DasPaymentProviderType = DasProviderTypeEnum.CanadaRevenueAgancy,
                DasProviderId = _provider.Value,
                MerchantId = _merchant,

            });
            ResponseHandler(result, JsonConvert.SerializeObject(result.DasPaymentId));
        }
        private static void ListDasProviders()
        {
            var result = TibInvoker.Portal.ListDasProviders(new Tib.Api.Model.DropIn.ListDasProvidersArgs
            {
                MerchantId = _merchant,
                SessionToken = _session
            });
            ResponseHandler(result, JsonConvert.SerializeObject(result.CanadaDasProvider) + " " + JsonConvert.SerializeObject(result.QuebecDasProvider));
        }

        private static void ListDasPayments()
        {
            var result = TibInvoker.Portal.ListDasPayments(new Tib.Api.Model.DropIn.ListDasPaymentsArgs
            {
                SessionToken = _session,
                MerchantId = _merchant,
                DasProviderId = _provider.Value
            });
            ResponseHandler(result, JsonConvert.SerializeObject(result.CanadaDasPayments) + " " + JsonConvert.SerializeObject(result.QuebecDasPayments));
        }
        private static void GetMerchantByExternalId()
        {
            var result = TibInvoker.Portal.GetMerchantsByExternalId(new Tib.Api.Model.Merchant.GetMerchantsByExternalIdArgs
            {
                SessionToken = _session,
                ExternalSystemId = "111",
                ExternalSystemGroupId = "111",
            });
            ResponseHandler(result, JsonConvert.SerializeObject(result.Merchants));
        }

        private static void ChangeInteracPaymentMethodQuestionAnswer()
        {
            var result = TibInvoker.Portal.ChangeInteracPaymentMethodQuestionAndAnswer(new Tib.Api.Model.PaymentMethod.ChangeInteracPaymentMethodQuestionAndAnswerArgs
            {
                SessionToken = _session,
                InteracAnswer = "",
                InteracPaymentMethodId = _paymentMethodId,
                InteracQuestion = "",
            });
            ResponseHandler(result, JsonConvert.SerializeObject(result.PaymentMethodId));
        }
        #endregion
        #region Service  (done)
        private static void CreateSubClient()
        {
            Console.Clear();
            Console.Write("Sub client name :");
            string subClientName = Console.ReadLine();
            Console.Write("\nSub Client's LKanguage (1- fr 2- Eng) : ");
            LanguageEnum lang = (LanguageEnum)int.Parse(Console.ReadLine());
            var result = TibInvoker.Portal.CreateSubClient(new Tib.Api.Model.SubClient.CreateSubClientArgs
            {
                SessionToken = _session,
                Name = subClientName,
                Language = lang
            });

            ResponseHandler(result, result.ServiceId.ToString());
            if (!result.HasError)
                _service = result.ServiceId;
        }

        private static void SetClientDefaultServiceFeeSettings()
        {
            var result = TibInvoker.Portal.SetClientDefaultServiceFeeSettings(new Tib.Api.Model.Service.SetClientDefaultServiceFeeSettingsArgs
            {
                SessionToken = _session,
                ClientId = _clientId,
                ServiceFeeSettings = new Tib.Api.Model.Service.ServiceFeeSettingsModel
                {
                    ConvenientFeeDebitAbsoluteFee = 0,
                    ConvenientFeeCreditAbsoluteFee = 0,
                    ConvenientFeeCreditMode = ConvenientFeeModeEnum.NotSet,
                    ConvenientFeeCreditPercentageFee = 0,
                    ConvenientFeeCreditRoundUpValue = 0,
                    ConvenientFeeDebitMode = ConvenientFeeModeEnum.NotSet,
                    ConvenientFeeDebitPercentageFee = 0,
                    ConvenientFeeDebitRoundUpValue = 0,
                    CreditCardAbsoluteFee = 0,
                    CreditCardFeeMode = FeeModeEnum.NotSet,
                    CreditCardFeeRoundUpValue = 0,
                    CreditCardPercentageFee = 0,
                    DebitAbsoluteFee = 0,
                    DebitFeeMode = FeeModeEnum.NotSet,
                    DebitFeeRoundUpValue = 0,
                    DebitNFSFees = 0,
                    DebitPercentageFee = 0,
                    InteracFeeAbsolute = 0,
                    InteracFeeCollectAbsolute = 0,
                    InteracFeeCollectPercentage = 0,
                    InteracFeePercentage = 0,
                    NFSFileFees = 0,
                    RevertCreditCardAbsoluteFees = 0,
                    RevertCreditCardPercentageFees = 0,
                    RevertDebitAbsoluteFees = 0,
                    RevertDebitPercentageFees = 0
                    // service Fees settings to apply . 
                }
            });
            ResponseHandler(result, "service fee settings has been set correctly.");

        }
        private static void SetClientSettigs()
        {
            var result = TibInvoker.Portal.SetClientSettings(new Tib.Api.Model.Service.SetClientSettingsArgs
            {
                SessionToken = _session,
                CLientId = _clientId,
                ClientSettings = new Tib.Api.Model.Service.ClientSettings
                {
                    CollectionLimitDaily = 93849,
                    DepositLimitDaily = 2994949
                }
            });
            ResponseHandler(result, "Setting Set Successfuly .");

        }
        private static void GetClientSettings()
        {
            var result = TibInvoker.Portal.GetClientSettings(new Tib.Api.Model.Service.GetClientSettingsArgs
            {
                SessionToken = _session,
                CLientId = _clientId
            });
            ResponseHandler(result, JsonConvert.SerializeObject(result.ClientSettings));

        }
        private static void ListServices()
        {
            var result = TibInvoker.Portal.ListServices(new Tib.Api.Model.Service.ListServicesArgs
            {
                SessionToken = _session,
            });
            ResponseHandler(result, JsonConvert.SerializeObject(result.Services));
        }
        private static void GetService()
        {
            var result = TibInvoker.Portal.GetService(new Tib.Api.Model.Service.GetServiceArgs
            {
                SessionToken = _session,
                ServiceId = _service
            });
            ResponseHandler(result, JsonConvert.SerializeObject(result.Service));
        }
        private static void CreateMerchant()
        {

            var result = TibInvoker.Portal.CreateMerchant(new Tib.Api.Model.Service.CreateMerchantArgs
            {
                SessionToken = _session,
                MerchantInfo = new Tib.Api.Model.Service.MerchantModel
                {
                    EmailCopyTo = "EmailCopyTo@gmail.com",
                    ExternalSystemId = "M3493LDO",
                    Email = "email@email.d",
                    FavoriteProvider = ProviderEnum.CA_CreditCard_BankOfAmerica,
                    Language = LanguageEnum.English,
                    MerchantCurrency = CurrencyEnum.USD,
                    MerchantDescription = "merchant description",
                    MerchantName = "merchant name",
                    PhoneNumber = "1234567890",
                    ExternalSystemGroupId = "#PQSD23",
                    Address = new AddressModel
                    {
                        AddressCity = "CIty",
                        CountryId = CountryIdEnum.USA,
                        PostalZipCode = "VP2039",
                        ProvinceStateId = ProvinceStateIdEnum.US_Kentucky,
                        StreetAddress = "0394FKDQSF sdlqjf"
                    },
                    Account = new Tib.Api.Model.PaymentMethod.AccountModel
                    {
                        AccountName = "name",
                        AccountNumber = "1231213112312321",
                        BankNumber = "123123",
                        CheckDigit = "122",
                        InstitutionNumber = "2133112",
                        Owner = "okey",
                    }
                },
                ServiceId = _service
            });
            ResponseHandler(result, JsonConvert.SerializeObject(result.MerchantId));
            if (!result.HasError)
                _merchant = result.MerchantId;
        }
        private static void GetMerchant()
        {
            var result = TibInvoker.Portal.GetMerchant(new Tib.Api.Model.Service.GetMerchantArgs
            {
                SessionToken = _session,
                MerchantId = _merchant
            });

            ResponseHandler(result, JsonConvert.SerializeObject(result.Merchant));
        }
        private static void SaveMerchant()
        {
            var result = TibInvoker.Portal.SaveMerchant(new Tib.Api.Model.Service.SaveMerchantArgs
            {
                SessionToken = _session,
                MerchantId = _merchant,
                MerchantInfo = new Tib.Api.Model.Service.MerchantModel
                {
                    Account = new Tib.Api.Model.PaymentMethod.AccountModel { },
                }
            });

            ResponseHandler(result, "Success");
        }
        private static void SaveMerchantBasicInfo()
        {
            var result = TibInvoker.Portal.SaveMerchantBasicInfo(new Tib.Api.Model.Service.SaveMerchantBasicInfoArgs
            {
                SessionToken = _session,
                MerchantId = _merchant,
                MerchantInfo = new Tib.Api.Model.Service.MerchantModelBasicInfo
                {
                    EmailCopyTo = "EmailCopyTo@gmail.com",
                    ExternalSystemId = "M3493LDO",
                    Email = "email@email.d",
                    FavoriteProvider = ProviderEnum.CA_CreditCard_BankOfAmerica,
                    Language = LanguageEnum.English,
                    MerchantCurrency = CurrencyEnum.USD,
                    MerchantDescription = "merchant description",
                    MerchantName = "merchant nameupdate vie SDK",
                    PhoneNumber = "1234567890",
                    ExternalSystemGroupId = "#PQSD23",
                    Address = new AddressModel
                    {
                        AddressCity = "CIty",
                        CountryId = CountryIdEnum.USA,
                        PostalZipCode = "VP2039",
                        ProvinceStateId = ProvinceStateIdEnum.US_Kentucky,
                        StreetAddress = "0394FKDQSF sdlqjf"
                    },
                }
            });

            ResponseHandler(result, "Success");
        }
        private static void SaveMerchantAccountInfo()
        {
            var result = TibInvoker.Portal.SaveMerchantAccountInfo(new Tib.Api.Model.Service.SaveMerchantAccountInfoArgs
            {
                SessionToken = _session,
                MerchantId = _merchant,
                Account = new Tib.Api.Model.PaymentMethod.AccountModel
                {
                    AccountName = "name Updated via SDK",
                    AccountNumber = "1231213112312321",
                    BankNumber = "123123",
                    CheckDigit = "122",
                    InstitutionNumber = "2133112",
                    Owner = "okey",
                }
            });

            ResponseHandler(result, "Success");
        }
        private static void DeleteMerchant()
        {
            var result = TibInvoker.Portal.DeleteMerchant(new Tib.Api.Model.Merchant.DeleteMerchantArgs
            {
                SessionToken = _session,
                MerchantId = _merchant
            });
            ResponseHandler(result, "Deleted.");
        }

        #endregion
        #region Report (done) 
        private static void ListExecutedOperation()
        {
            var result = TibInvoker.Portal.ListExecutedOperations(new Tib.Api.Model.Report.ListExecutedOperationsArgs
            {
                SessionToken = _session,
                DateType = DateTypeEnum.CreatedDate,
                FromDate = new DateTime(2018, 01, 01),
                MerchantId = _merchant,
                ToDate = DateTime.Now,
                TransferType = TransferTypeFlag.All,
                OnlyWithErrors = false,
                TransferGroupId = "",
            });
            ResponseHandler(result, JsonConvert.SerializeObject(result.OperationList));
        }
        #endregion (done)

        /// <summary>
        /// displays a message depending on the result status .
        /// </summary>
        /// <param name="obj">the Result Object</param>
        /// <param name="SuccessMessageOrValue"> "Done : or Error :" + the SuccessMessage or the value that has to be shown when the call success </param>
        private static void ResponseHandler(ClientBaseResponse obj, string SuccessMessageOrValue)
        {
            Console.Clear();

            if (!obj.HasError && !string.IsNullOrEmpty(SuccessMessageOrValue))
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Done : " + SuccessMessageOrValue);
                Console.ForegroundColor = ConsoleColor.White;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Error : " + obj.Messages);
                Console.ForegroundColor = ConsoleColor.White;
            }
            Console.ReadKey();
        }

        /// <summary>
        ///  get the type of entity,  (Client, Service or a merchant . )
        /// </summary>
        /// <returns></returns>
        private static int GetEntityType()
        {
            WhiteLabelingLevelMenu();
            int value = 0;
            try
            {
                value = Int32.Parse(Console.ReadKey().KeyChar.ToString());
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return value;
        }
        private static void WhiteLabelingLevelMenu()
        {
            Console.Clear();
            Console.WriteLine("Please Select a type : ");
            Console.WriteLine((int)WhitelabelingLevelsEnum.Merchant + " - for Merchant : ");
            Console.WriteLine((int)WhitelabelingLevelsEnum.Service + " - for Service : ");
            Console.WriteLine((int)WhitelabelingLevelsEnum.Client + " - for Client: ");

        }
        private static string getEntityIdAsString(int type)
        {
            string entityId = "";
            switch (type)
            {
                case 1:
                    entityId = _merchant.ToString();
                    break;
                case 2:
                    entityId = _service.ToString();
                    break;
                case 3:
                    entityId = _clientId.ToString();
                    break;
            }
            return entityId;
        }
    }
}
