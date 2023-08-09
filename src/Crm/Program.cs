using Crm.Entities;
using Crm.Services;
using Crm.Validator;
using Crm.Entities.DTOs;

ClientService clientService = new();
OrderService orderService = new();

Console.WriteLine("Hello, you can input next command: \n\t1 - for creating Clint; \n\t2 - for creating Order;");
int iputedCmdNum;

while (!int.TryParse(Console.ReadLine(), out iputedCmdNum))
{
    Console.WriteLine("Please, enter correct command: \n\t1 - for creating Clint; \n\t2 - for creating Order;");
}

var command = (Command)iputedCmdNum;
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
            Console.WriteLine("Client FullName: " + client.FirstName+" " +client.LastName);
            Console.WriteLine("Client age: " + client.Age);
            Console.WriteLine("Passport Number: " + client.PassportNumber);
            Console.WriteLine("Gender: " + client.Gender);

        break;

    case Command.CreateOrder:

        var order = CreateOrder();

            if (order == null)
            {
                Console.WriteLine("Order was not created, unknown error");
                break;
            }

            Console.WriteLine("Order was successiful created");
            Console.WriteLine("Order description: " + order.Description);
            Console.WriteLine("Price: " + order.Price);
            Console.WriteLine("Delivery type: " + order.Delivery);
            Console.WriteLine("Order date: " + order.OrderDate?.ToString("yyyy-MM-dd"));
            Console.WriteLine("Address delivery: " + order.Address);

            break;
        default:
            Console.WriteLine("Unknown error!");
            break;

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

  

    Client newClient = clientService.CreateClient(
        new ClientInfo()
    {
        FirstName = firstName,
        LastName = lastName,
        MiddleName = middleName,
        Age = age,
        PassportNumber = passportNumber,
        ClientGender = gender
         
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
    string description = Console.ReadLine();
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
    string address = Console.ReadLine();
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
