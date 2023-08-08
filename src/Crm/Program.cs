using Crm.Entities;
using Crm.Services;

ClientService clientService = new();
OrderService orderService = new();

Console.WriteLine("Hello, you can input next command: \n\t1 - for creating Clint; \n\t2 - for creating Order;");
int iputedCmdNum;



void CreateClient()
{
    string firstName = Console.ReadLine();
    string lastName = Console.ReadLine();
    string middleName = Console.ReadLine();
    short age = short.Parse(Console.ReadLine());
    string passportNumber = Console.ReadLine();
    Gender gender = (Gender)short.Parse(Console.ReadLine());

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

void CheckInputValue()
{
    
}
