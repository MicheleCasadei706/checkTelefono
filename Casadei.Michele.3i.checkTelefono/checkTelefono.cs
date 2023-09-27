using System;

public static class Telefono
{
    public static string Check(string[] input)
    {
        foreach (string numero in input)
        {
            string numeroPulito = RimuoviSpaziETrattini(numero);

            if (NumeroDiTelefonoItaliano(numeroPulito))
            {
                return numero;
            }
        }
        return "";
    }

    private static string RimuoviSpaziETrattini(string numero)
    {
        // Rimuove gli spazi e i trattini dal numero
        return numero.Replace(" ", "").Replace("-", "");
    }

    private static bool NumeroDiTelefonoItaliano(string numero)
    {
        // Controlla se il numero inizia con +39 ed è lungo 13 caratteri
        if (numero.StartsWith("+39") && numero.Length == 13)
        {
            return true;
        }
        // Controlla se il numero inizia con 0039 ed è lungo 14 caratteri
        else if (numero.StartsWith("0039") && numero.Length == 14)
        {
            return true;
        }
        // Controlla se il numero inizia con 3 ed è lungo 10 caratteri
        else if (numero.StartsWith("3") && numero.Length == 10)
        {
            return true;
        }

        return false;
    }
}
