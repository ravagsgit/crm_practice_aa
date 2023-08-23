using System.ComponentModel;
namespace Crm.Entities;

public enum Command
{
    [Description("Exit")]
    Exit = 0,
    [Description("Create Clinet")]
    CreateClient = 1,
    [Description("Create Order")]
    CreateOrder = 2,
    [Description("Find Client by Name and LastName")]
    FindClient = 3,
    [Description("Find Order by Id")]
    FindOrderById = 4,
    [Description("Find Order by Description")]
    FindOrderByDescription = 5,
    [Description("For editing client Firsname and Lastname")]
    ChangeClientName = 6,
    [Description("For removeing client")]
    RemoveClient = 7,
    [Description("For editing order description")]
    EditingOrderDescription = 8,
    [Description("Removing order")]
    RemoveOrder = 9,

}