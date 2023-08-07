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




    
}