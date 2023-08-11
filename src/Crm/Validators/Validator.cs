using Crm.Entities;

namespace Crm.Validator;



public static class Validator
{
    /// <summary>
    /// Checks for empty, null and whiteSpace for inputed STR
    /// </summary>
    /// <param name="str">enterd value</param>
    /// <returns>bool</returns>
    public static bool IsValidStr(string? str)
    {
        if (string.IsNullOrEmpty(str) || string.IsNullOrWhiteSpace(str))
        {
            return false;
        }

        return true;
    }

/// <summary>
/// Checks for correct inputed short val
/// </summary>
/// <param name="str">Inputed val</param>
/// <param name="returnVal">Output val</param>
/// <returns>Return bool val and short outpu val</returns>
    public static bool IsValidShort(string? str, out short returnVal)
    {
        if (!short.TryParse(str, out returnVal))
        {
            return false;
        }

        return true;

    }

    /// <summary>
    /// Checks for correct input Gender value
    /// </summary>
    /// <param name="str">The inputed value</param>
    /// <param name="genderNum">The outpute value</param>
    /// <returns>Method return bool value and have a short output value</returns>
    public static bool IsValidGender(string? str, out short genderNum)
    {
        if (!short.TryParse(str, out genderNum))
        {
            return false;
        }

        if (!str.Equals("1") & !str.Equals("2"))
        {
            return false;
        }

        return true;
    }

    /// <summary>
    /// For checking decimal values
    /// </summary>
    /// <param name="valStr"></param>
    /// <param name="outVal"></param>
    /// <returns></returns>
     public static bool IsValidDecimal(string? valStr, out decimal outVal)
    {
        if (!decimal.TryParse(valStr, out outVal))
        {
            return false;
        }

        return true;
    }

    /// <summary>
    /// For checking int values
    /// </summary>
    /// <param name="valStr"></param>
    /// <param name="outVal"></param>
    /// <returns></returns>
     public static bool IsValidInt(string? valStr, out int outVal)
    {
        if (!int.TryParse(valStr, out outVal))
        {
            return false;
        }

        return true;
    }

    /// <summary>
    /// Checking for valid inputed date value
    /// </summary>
    /// <param name="dateString"></param>
    /// <param name="date"></param>
    /// <returns></returns>
    public static bool IsValidDate(string? dateString, out DateTime date)
    {
        if (!DateTime.TryParse(dateString, out date))
        {
            return false;
        }

        return true;
    }

    /// <summary>
    /// Chdecking for valid inputed Delivery value
    /// </summary>
    /// <param name="deliverTypeString"></param>
    /// <param name="deliverTypeNumber"></param>
    /// <returns></returns>
    public static bool IsValidDeliverType(string? deliverTypeString, out short deliverTypeNumber)
    {
        if (!short.TryParse(deliverTypeString, out deliverTypeNumber))
        {
            return false;
        }

        if (!deliverTypeString.Equals("1"))
        {
            return false;
        }

        if(!deliverTypeString.Equals("2"))
        {
            return false;
        }

        if(!deliverTypeString.Equals("3"))
        {
            return false;
        }

        return true;
    }

    
}