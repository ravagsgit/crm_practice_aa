using Crm.Entities;
using Crm.Entities.DTOs;

namespace Crm.Services;
public sealed class ClientService
{
    private readonly List<Client> clients = new List<Client>();
    public Client CreateClient(ClientInfo clientInfo)
    {
        Client newClient =  new()
        {
            FirstName = clientInfo.FirstName,
            LastName = clientInfo.LastName,
            MiddleName = clientInfo.MiddleName,
            Age = clientInfo.Age,
            PassportNumber = clientInfo.PassportNumber,
            Gender = clientInfo.ClientGender,
            Phone = clientInfo.Phone,
            Email = clientInfo.Email,
            Password = clientInfo.Phone
        };

        clients.Add(newClient);
        Console.WriteLine("New client was created successiful and added to list.");
        return newClient;
    }

    public bool GetClient(string firstName, string lastName, out Client? client)
    {
        foreach(var clientItem in clients)
        {
            if(clientItem.FirstName.Equals(firstName) & clientItem.LastName.Equals(lastName))
            {
                client = clientItem;
                return true;
            }
        }

        client = null;
        return true;
    }   
}