using Crm.Entities;
using Crm.Services;
using Crm.Validator;
using Crm.Entities.DTOs;
using System.ComponentModel;
using System;

ClientService clientService = new();
OrderService orderService = new();

StartProgramm();

void StartProgramm()
{
var command = GetCommand();
while(command != Command.Exit)
{
switch(command)
{
    case Command.CreateClient:
    Client client = CreateClient();
    if(client == null)
    {
        Console.WriteLine("Сlient was not created, unknown error");
        break;
    }

    Console.WriteLine("Client was successiful created");
    PrintClient(client);
    break;

    case Command.CreateOrder:

        var order = CreateOrder();

            if (order == null)
            {
                Console.WriteLine("Order was not created, unknown error");
                break;
            }

            Console.WriteLine("Order was successiful created");
            PrintOrder(order);
            break;
    
    case Command.FindClient:
    if(!clientService.IsClientListNotEmpty())
    {
        Console.WriteLine("Please, create and add client and then serch it");
        break;
    }
    
    Console.WriteLine("Please, enter client first name:");
    string clientFirstName = Console.ReadLine();
    Console.WriteLine("Please, enter client last name:");
    string clientLastName = Console.ReadLine();
    Client? clientFound =null;
     if(clientService.GetClient(clientFirstName,clientLastName,out clientFound))
     {
        PrintClient(clientFound);
        break;
     }
     else
     {
        Console.WriteLine("Client with ths Fitsname and Lastname not found");
        break;
     }

    case Command.FindOrderById:
     if(!orderService.IsOrderListNotEmpty())
    {
        Console.WriteLine("Please, create and add order and then serch it");
        break;
    }
    Console.WriteLine("Please, enter order ID:");
    int orderID;
    while(!Validator.IsValidInt(Console.ReadLine(), out orderID))
    {
        PrintMsg("Order Id", null);
    }
    
    Order? orderFound =null;
     if(orderService.GetOrder(orderID,out orderFound))
     {
        PrintOrder(orderFound);
        break;
     }
     else
     {
        Console.WriteLine("Order with ths Id not found");
        break;
     }

    case Command.FindOrderByDescription:
     if(!orderService.IsOrderListNotEmpty())
    {
        Console.WriteLine("Please, create and add order and then serch it");
        break;
    }
    Console.WriteLine("Please, enter order Description:");
    string orderDescription = Console.ReadLine();
    while(Validator.IsValidStr(orderDescription))
    {
        PrintMsg("Order Description", null);
        orderDescription = Console.ReadLine();
    }
    
    Order? orderFoundByDescription =null;
     if(orderService.GetOrder(orderDescription,out orderFoundByDescription))
     {
        PrintOrder(orderFoundByDescription);
        break;
     }
     else
     {
        Console.WriteLine("Order with ths Description not found");
        break;
     }

    case Command.ChangeClientName:
    if(!clientService.IsClientListNotEmpty())
    {
        Console.WriteLine("ClientList is empty.");
        break;
    }

    Console.WriteLine("Please, enter client firstname:");
    clientFirstName = Console.ReadLine();
    Console.WriteLine("Please, enter client lastname:");
    clientLastName = Console.ReadLine();
    if(clientService.GetClient(clientFirstName,clientLastName,out clientFound))
     {
        Console.WriteLine("Please, enter client new firstname:");
        string newClientFirstName = Console.ReadLine();
        Console.WriteLine("Please, enter client new lastname:");
        string newClientLastName = Console.ReadLine();
        clientService.EditClient(newClientFirstName,newClientLastName,clientFound);
        Console.WriteLine("Client was edited:");
        PrintClient(clientFound);
        break;
     }
     else
     {
        Console.WriteLine("Client with ths Fitsname and Lastname not found");
        break;
     }
    
    case Command.RemoveClient:
    Console.WriteLine("Please, enter client firstname:");
    clientFirstName = Console.ReadLine();
    Console.WriteLine("Please, enter client lastname:");
    clientLastName = Console.ReadLine();
    clientService.RemoveClient(clientFirstName,clientLastName);
    break;

    case Command.EditingOrderDescription:
    Console.WriteLine("Please, enter orderDescriprion:");
    orderDescription = Console.ReadLine();
    while(!Validator.IsValidStr(orderDescription))
    {
        PrintMsg("Order Description", null);
        orderDescription = Console.ReadLine();
    }
    Console.WriteLine("Please, enter new orderDescriprion:");
    string newOrderDescription = Console.ReadLine();
    while(!Validator.IsValidStr(orderDescription))
    {
        PrintMsg("Order Description", null);
        newOrderDescription = Console.ReadLine();
    }
    Order editedOrder =null;
    if(orderService.EditOrder(orderDescription, newOrderDescription, out editedOrder))
    {
        Console.WriteLine("Order was successiful edited.");
        PrintOrder(editedOrder);
    }
    else
    {
        Console.WriteLine("Order wiht this description not found.");
    }   
    break;

    case Command.RemoveOrder:
    Console.WriteLine("Please, enter orderId for removing it from list:");
    if(!Validator.IsValidInt(Console.ReadLine(),out orderID))
    {
        Console.WriteLine("Plese, enter correct order ID");
    }
    if(orderService.RemoveOrder(orderID))
        Console.WriteLine("Order was successiful removed.");
    else
        Console.WriteLine("Order wiht this Id not found.");    
    break;
    
    default:
            Console.WriteLine("Unknown error!");
            break;

}

command = GetCommand();

}
}

Client CreateClient()
{
    PrintMsg("Client Firstname", null);
    string firstName = Console.ReadLine();
    while(!Validator.IsValidStr(firstName))
    {
        PrintMsg("Client Firstname", null);
        firstName = Console.ReadLine();
    }

    PrintMsg("Client Lastname", null);
    string lastName = Console.ReadLine();
    while(!Validator.IsValidStr(lastName))
    {
        PrintMsg("Client Lastname", null);
        lastName = Console.ReadLine();
    }

    PrintMsg("Client Middlename", null);
    string middleName = Console.ReadLine();
    while(!Validator.IsValidStr(middleName))
    {
        PrintMsg("Client Middlename", null);
        middleName = Console.ReadLine();
    }
    
    PrintMsg("Client age", "it must be dig");
    short age;
    while(!Validator.IsValidShort(Console.ReadLine(), out age))
    {
        PrintMsg("Client age", "it must be dig");
    }

    PrintMsg("Client passportNumber", null);
    string passportNumber = Console.ReadLine();
    while(!Validator.IsValidStr(passportNumber))
    {
        PrintMsg("Client passportNumber", null);
        passportNumber = Console.ReadLine();
    }

    PrintMsg("Client gender", "1 - male; 2 - famale;");
    short genNum;
    while(!Validator.IsValidGender(Console.ReadLine(), out genNum))
    {
        PrintMsg("Client gender", "1 - male; 2 - famale;");
    }
    Gender gender = (Gender)genNum;

    PrintMsg("Client phone", null);
    string phone = Console.ReadLine();
    while(!Validator.IsValidStr(phone))
    {
        PrintMsg("Client phone", null);
        phone = Console.ReadLine();
    }

    PrintMsg("Client E-mail", null);
    string email = Console.ReadLine();
    while(!Validator.IsValidStr(email))
    {
        PrintMsg("Client E-mail", null);
        email = Console.ReadLine();
    }

    PrintMsg("Client password", null);
    string password = Console.ReadLine();
    while(!Validator.IsValidStr(password))
    {
        PrintMsg("Client password", null);
        password = Console.ReadLine();
    }

  

    Client newClient = clientService.CreateClient(
        new ClientInfo()
    {
        FirstName = firstName,
        LastName = lastName,
        MiddleName = middleName,
        Age = age,
        PassportNumber = passportNumber,
        ClientGender = gender,
        Phone = phone,
        Email = email,
        Password = password
         
    }
    );

    return newClient;

}

Order CreateOrder()
{
    PrintMsg("Order ID", "it must be dig");
    int orderId;
    while(!Validator.IsValidInt(Console.ReadLine(), out orderId))
    {
            PrintMsg("Order ID", "it must be dig");
    }

    PrintMsg("Order description", null);
    string? description = Console.ReadLine();
    while(!Validator.IsValidStr(description))
    {
        PrintMsg("Order description", null);
        description = Console.ReadLine();
    }

    PrintMsg("Price", "it must be dig");
    decimal price;
    while(!Validator.IsValidDecimal(Console.ReadLine(), out price))
    {
        PrintMsg("Price", "it must be dig");
    }

    PrintMsg("Delivery type", "1 - Express, 2 - standart, 3 - free");
    short deliveryNum;
    while(!Validator.IsValidDeliverType(Console.ReadLine(), out deliveryNum))
    {
        PrintMsg("Delivery type", "1 - Express, 2 - standart, 3 - free");
    }           
    Delivery delivery = (Delivery)deliveryNum;

    PrintMsg("Order date", "yyyy-mm-dd");
    DateTime orderData;
    while(!Validator.IsValidDate(Console.ReadLine(), out orderData))
    {
        PrintMsg("Order date", "yyyy-mm-dd");
    }
    
    PrintMsg("Address delivery", null);
    string? address = Console.ReadLine();
    while(!Validator.IsValidStr(address))
    {
        PrintMsg("Address delivery", null);
        address = Console.ReadLine();
    }
    

            Order newOrder = orderService.CreateOrder(
                new OrderInfo()
                {
                    Id = orderId,
                    Description = description,
                    Price = price,
                    OrderDate = orderData,
                    DeliveryType = delivery,
                    Address = address
                }

            );

            return newOrder;
    
        }

void PrintMsg(string msg, string? corrcetVers)
        {
            Console.WriteLine("Please, input correct "+msg+", "+corrcetVers);
        }

void PrintCommands()
{
    Console.WriteLine("Please, enter correct command:");
    Console.WriteLine(" 0 - Exit from application;");
    Console.WriteLine(" 1 - for creating Clint;");
    Console.WriteLine(" 2 - for creating Order;");
    Console.WriteLine(" 3 - find Client by Name and LastName;");
    Console.WriteLine(" 4 - find Order by Id;");
    Console.WriteLine(" 5 - find Order by Description;");
    Console.WriteLine(" 6 - edit Client by firstName and LastName;");
    Console.WriteLine(" 7 - remove Client by firstName and LastName;");
    Console.WriteLine(" 8 - edit order by Id;");
    Console.WriteLine(" 9 - remove order by Id;");
}

void PrintClient(Client client)
{
    
            Console.WriteLine("Client FullName: " + client.FirstName+" " +client.LastName);
            Console.WriteLine("Client age: " + client.Age);
            Console.WriteLine("Passport Number: " + client.PassportNumber);
            Console.WriteLine("Gender: " + client.Gender);
}

void PrintOrder(Order order)
{
            Console.WriteLine("Order description: " + order.Description);
            Console.WriteLine("Price: " + order.Price);
            Console.WriteLine("Delivery type: " + order.Delivery);
            Console.WriteLine("Order date: " + order.OrderDate?.ToString("yyyy-MM-dd"));
            Console.WriteLine("Address delivery: " + order.Address);
}

Command GetCommand()
{
    PrintCommands();
short iputedCmdNum;

while (!Validator.IsValidCommand(Console.ReadLine(), out iputedCmdNum))
{
    PrintCommands();
}

return(Command)iputedCmdNum;
}