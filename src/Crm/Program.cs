using Crm.Entities;
using Crm.Services;

ClientService clientService = new();
CreateClient();

OrderService orderService = new();
CreateOrder();

void CreateClient()
{
    string firstName = Console.ReadLine();
    string lastName = Console.ReadLine();
    string middleName = Console.ReadLine();
    short age = short.Parse(Console.ReadLine());
    string passportNumber = Console.ReadLine();
    string gender = Console.ReadLine();

    Client newClient = clientService.CreateClient(
        firstName,
        lastName,
        middleName,
        age,
        passportNumber,
        gender
    );

    // TODO: Output fields...
}

void CreateOrder()
        {
            int orderId = int.Parse(Console.ReadLine());
            string description = Console.ReadLine();
            int price = int.Parse(Console.ReadLine());
            DateTime orderData = DateTime.Parse( Console.ReadLine());
            string addres = Console.ReadLine();

            Order newOrder = orderService.CreateOrder(
                orderId,
                description,
                price,
                orderData,
                addres

            );
    
        }
