using Crm.Services;
using Crm.Entities;

public sealed class ClientService
{
    public Client CreateClient(
        string firstName,
        string lastName,
        string middleName,
        short age,
        string passportNumber,
        string gender
    )
    {
        // TODO: Validate input parameters.
        return new()
        {
            FirstName = firstName,
            LastName = lastName,
            MiddleName = middleName,
            Age = age,
            PassportNumber = passportNumber,
            Gender = gender
        };
    }   
}