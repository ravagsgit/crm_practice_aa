namespace Crm.Interfaces;

using Crm.Entities;
using Crm.Entities.DTOs;

public interface IClientService
{
    Client CreateClient(ClientInfo clientInfo);
    bool GetClient(string firstName, string lastName, out Client? client);
}