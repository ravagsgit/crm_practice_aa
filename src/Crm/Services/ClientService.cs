using Crm.Entities;
using Crm.Entities.DTOs;

namespace Crm.Services;
public sealed class ClientService
{
    private List<Client> clients = new List<Client>();
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
}