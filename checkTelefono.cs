using System;
using System.Linq;

public static class Telefono
{
    public static string Check(string[] vettore)
    {
        foreach (var numero in vettore)
        {
            if (IsNumeroTelefonoItaliano(numero))
            {
                return numero;
            }
        }
        return "";
    }

    private static bool IsNumeroTelefonoItaliano(string numero)
    {
        if (numero.Length == 13 && (numero.StartsWith("+39") || numero.StartsWith("0039")))
        {
            return true;
        }
        else if (numero.Length == 14 && numero.StartsWith("0039"))
        {
            return true;
        }
        else if (numero.Length == 10 && numero.StartsWith("3"))
        {
            return true;
        }
        return false;
    }
}