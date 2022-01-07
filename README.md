
# Tib Dot Net Core  SDK 

This is a technical document on how to use the Tib DotNet Core SDK.

## Overview 

here you'll find CodeSample to how to use the Tib DotNet Core SDK. 

## Set Up 
` Before you using the SDK you need to set the api url up and get a session id. `

Initiat the TibInvoker Class : the Class that We are going to have the most interactions with.

``` TibInvoker.InitializePortal(_siteUrl); ```

This line Sets up the Api Url and Create a TibPortal Object that let's you call the Api Methods.

Then Create a session

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

*here you see one Example but you'll see more Examples of Using the SDK in the Program.cs File*

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
## Handling Response 

Each Api Call Return a response Object that Follow the same Object structure 

Ex : this is the base Response that the Sdk use Every Other Custom rsponse implements it's own properties depending on the Call and it's return 

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
We ca have as many ways to handle the response here be now we will focus on how to handle errors here 
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
