# checkTelefono
## Obiettivo
Ricevuto come parametro un vettore di string, ritornare al chiamante la prima stringa che assomiglia molto ad un numero di telefono cellulare italiano ovvero:
- che inizia con +39 (esattamente lungo  13)
- oppure con 0039 (esattamente lungo 14)
- oppure con un 3 (esattamente lungo 10)

Se il numero non viene trovato, ritornare stringa vuota ""

Ad esempio.
Se arriva "05417373", "3367726712",  "778823"
Tornare "3367726712"

Se arriva "33677267", "33677232",  "778823"
Tornare ""

Se arriva "", "05417723",  "+391231231234"
Tornare "+391231231234"

Se arriva "3", "05417723",  "00391231231230"
Tornare ""

etc

## Codice

### Il codice del programma si divide in:
```c#
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
        return numero.Replace(" ", "").Replace("-", "");
    }

    private static bool NumeroDiTelefonoItaliano(string numero)
    {
        if (numero.StartsWith("+39") && numero.Length == 13)
        {
            return true;
        }
        else if (numero.StartsWith("0039") && numero.Length == 14)
        {
            return true;
        }
        else if (numero.StartsWith("3") && numero.Length == 10)
        {
            return true;
        }

        return false;
    }
}
```
