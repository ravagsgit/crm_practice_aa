using Crm.Entities;
using Crm.Entities.DTOs;
using Crm.Interfaces;

namespace Crm.Services;
public sealed class ClientService: IClientService
{
    private readonly List<Client> _clients = new List<Client>();
    /// <summary>
    /// Create client
    /// </summary>
    /// <param name="clientInfo"></param>
    /// <returns></returns>
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

        _clients.Add(newClient);
        Console.WriteLine("New client was created successiful and added to list.");
        return newClient;
    }

    /// <summary>
    /// Return Client by Firstname and LastName
    /// </summary>
    /// <param name="firstName"></param>
    /// <param name="lastName"></param>
    /// <param name="client"></param>
    /// <returns></returns>
    public bool GetClient(string firstName, string lastName, out Client? client)
    {
        foreach(var clientItem in _clients)
        {
            if(clientItem.FirstName.Equals(firstName) & clientItem.LastName.Equals(lastName))
            {
                client = clientItem;
                return true;
            }
        }

        client = null;
        return false;
    } 
    public Client GetClient(string firstName, string lastName)
    {
        //Client client = null;
        foreach(var clientItem in _clients)
        {
            if(clientItem.FirstName.Equals(firstName) & clientItem.LastName.Equals(lastName))
            {
                return clientItem;
            }
        }
        
        return null;
    } 


    public bool IsClientListNotEmpty()
    {
        return _clients.Count>0;
    }


    public bool EditClient(string firstName, string lastName, string newFirstname, string newLastname)
    {
        Client? client=null;
        if(GetClient(firstName,lastName,out client))
        {
            client.FirstName = newFirstname;
            client.LastName = newLastname;
            return true;

        }

        return false;

    }

    public void EditClient(string newFirstname, string newLastname, Client client)
    {
            client.FirstName = newFirstname;
            client.LastName = newLastname;

    }

    
     
}