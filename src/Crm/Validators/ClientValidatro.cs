using Crm.Entities;

namespace Crm.Validator;



public static class ClientValidator
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
    
}