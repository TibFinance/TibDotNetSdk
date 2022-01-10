using System;

namespace ConsoleTestApp.UI
{
  public class Menu
  {
    public static char MenuPreSelect(Guid? sessionToken = null)
    {
      if (sessionToken.HasValue)
      {

        Title("Pre Select");

        Console.WriteLine("'w' Whitelabelings");
        Console.WriteLine("'c' Customers");
        Console.WriteLine("'b' Bill");
        Console.WriteLine("'p' PaymentMethods");
        Console.WriteLine("'s' Service");
        Console.WriteLine("'r' Report");

      }
      else
      {

        Console.WriteLine("\n\t \t PRESS KEY TO EXECUTE\n");
        Console.WriteLine("'o' to open session");

      }

      Console.WriteLine("'x' to quit");

      return Console.ReadKey().KeyChar;
    }
    public static char MainMenu(Guid? sessionToken = null)
    {

      if (sessionToken.HasValue)
      {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("----SESSION:" + sessionToken.ToString() + "----");
        Console.ForegroundColor = ConsoleColor.White;

        Console.WriteLine("\n\t \t PRESS KEY TO EXECUTE\n");

        Console.WriteLine("'n' to get Whitelabeling");
        Console.WriteLine("'h' to get Whitelabelings list (Client)");
        Console.WriteLine("'l' to Add Random Whitelabeling Values");
        Console.WriteLine("'d' to delete the whitelabaling.");
        Console.WriteLine("'u' to update some random prop in the whitelabaling.");
        Console.WriteLine("'p' to get a customer");
        Console.WriteLine("'o' to Create a customer");
        Console.WriteLine("'z' to Delete a customer");
        Console.WriteLine("'j' to Get a customerBy ExternalId");
        Console.WriteLine("'f' to Get a list of customers.");
        Console.WriteLine("'k' to Create a bill.");
        Console.WriteLine("'q' to Delete a bill.");
        Console.WriteLine("'s' to Create a paymnent.");
      }
      else
      {
        Console.WriteLine("\n\t \t PRESS KEY TO EXECUTE\n");
        Console.WriteLine("'c' to open session");
      }

      Console.WriteLine("'x' to quit");

      return Console.ReadKey().KeyChar;
    }
    public static char WhitelabelingMenu()
    {
      Console.Clear();

      Title("WhiteLabeling Menu");
      Console.WriteLine("'1' to get Whitelabeling");
      Console.WriteLine("'2' to get Whitelabelings list (Client)");
      Console.WriteLine("'3' to Add Random Whitelabeling Values");
      Console.WriteLine("'4' to delete the whitelabaling.");
      Console.WriteLine("'5' to update some random prop in the whitelabaling.");
      Footer();
      return Console.ReadKey().KeyChar;

    }
    public static char CustomerMenu()
    {
      Console.Clear();

      Title("Customer Menu");
      Console.WriteLine("'1' to get a customer");
      Console.WriteLine("'2' to Create a customer");
      Console.WriteLine("'3' to Delete a customer");
      Console.WriteLine("'4' to Get a customer By ExternalId");
      Console.WriteLine("'5' to Get a list of customers");
      Console.WriteLine("'6' to update a customer");
      Footer();
      return Console.ReadKey().KeyChar;
    }
    public static char BillMenu()
    {

      Console.Clear();
      Title("Bill Menu");
      Console.WriteLine("'1' to Create a Bill");
      Console.WriteLine("'2' to Delete a Bill");
      Console.WriteLine("'3' to Get a List of Bills");
      Console.WriteLine("'4' to Get a Bill");

      Footer();
      return Console.ReadKey().KeyChar;
    }
    public static string PaymentMenu()
    {
      Console.Clear();
      Title("Payment Maenu");
      Console.WriteLine("'1' to Create a payment");
      Console.WriteLine("'2' to Delete a payment");
      Console.WriteLine("'3' to Create a Direct Deposit");
      Console.WriteLine("'4' to Create a Direct Interac Transaction");
      Console.WriteLine("'5' to Create a Transation From Raw");
      Console.WriteLine("'6' to Create a Free Operation");
      Console.WriteLine("'7' to Revert a Transfer");
      Console.WriteLine("'8' to Get Recuring Transfers");
      Console.WriteLine("'9' to Delete a Recuring Transfer");
      Console.WriteLine("'10' to Create a direct Account Payment.");
      Console.WriteLine("'11' to Create a Credit Card Payment.");
      Console.WriteLine("'12' to Get A payment method");
      Console.WriteLine("'13' to get a list ofpayment methods");
      Console.WriteLine("'14' to set a default payment method");
      Console.WriteLine("'15' to delete a payment method.");
      Console.WriteLine("'16' to Get a payment.");
      Console.WriteLine("'17' Get a list of Depostit Operations");
      Console.WriteLine("'18' to makr payment as resolved.");
      Console.WriteLine("'19' to get a list of free deposit operations.");
      Console.WriteLine("'20' to get a list of free collection operaions.");
      Console.Write("'21' to get fee count. "); Console.ForegroundColor = ConsoleColor.Red; Console.Write("(Not Implemented - Temporary removed Because not used.) \n"); Console.ForegroundColor = ConsoleColor.White; 
      Console.WriteLine("'22' to Force payment process.");
      Console.WriteLine("'23' to Login");
      Console.WriteLine("'24' to get the login access list.");
      Console.WriteLine("'25' to get dropin pulic token.");
      Console.WriteLine("'26' to Add new Das provider.");
      Console.WriteLine("'27' to add new Das payment.");
      Console.WriteLine("'28' to get list of Das providers.");
      Console.WriteLine("'29' to get a list of Das payments.");
      Console.WriteLine("'30' to get merchant by external id.");
      Console.WriteLine("'31' to change the interac paymentMethod question/answer/");
      Footer();
      return Console.ReadLine();
    }
    public static void Title(string title)
    {
      Console.WriteLine(string.Format("\t \t {0} \t \t", title));
    }
    public static void Footer()
    {
      Console.WriteLine(" Press any key out of the list ot go back");
    }
    public static string ServiceMenu()
    {
      Console.Clear();

      Title("Service Menu");
      Console.WriteLine("'1' to create a subclient");
      Console.WriteLine("'2' to Set Client Default Service Settings");
      Console.WriteLine("'3' to Set Client Default Service Fee Settings");
      Console.WriteLine("'4' to Set Client Settings");
      Console.WriteLine("'5' to Get Client Settings");
      Console.WriteLine("'6' to Get a list of services ");
      Console.WriteLine("'7' to Get a service ");
      Console.WriteLine("'8' to create a merchant");
      Console.WriteLine("'9' to get a merchant");
      Console.WriteLine("'10' to save merchant");
      Console.WriteLine("'11' to save merchant basic info");
      Console.WriteLine("'12' to save a merchant account info");
      Console.WriteLine("'13' to delete a merchant ");
      Footer();
      return Console.ReadLine();
    }
    public static char ReportMenu()
    {
      Console.Clear();
      Title("Report Menu");
      Console.WriteLine("'1' to get Operation list");
      Footer();

      return Console.ReadKey().KeyChar;
    }
  }
}
