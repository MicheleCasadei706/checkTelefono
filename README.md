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
Questo programma fornisce una funzione di controllo per determinare se una serie di stringhe rappresenta numeri di telefono italiani validi.
### Il codice del programma si divide in tre parti:
<details>
<summary>Check</summary>
    
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
```
Il metodo Check accetta un array di stringhe input che rappresentano una serie di numeri di telefono.<br>
Itera attraverso ciascun numero nella matrice input.<br>
Chiama il metodo RimuoviSpaziETrattini per rimuovere eventuali spazi e trattini dalla stringa del numero.<br>
Successivamente, chiama il metodo EUnNumeroDiTelefonoItaliano per verificare se il numero pulito è un numero di telefono italiano valido.<br>
Se trova un numero di telefono italiano valido, restituisce quel numero.<br>
In caso contrario, continua a cercare nella lista. Se non trova alcun numero di telefono italiano valido, restituisce una stringa vuota.
</details>

<details>
    <summary>Rimuovi spazi e trattini</summary>
    
```c#
    private static string RimuoviSpaziETrattini(string numero)
    {
        return numero.Replace(" ", "").Replace("-", "");
    }
```
l metodo RimuoviSpaziETrattini riceve una stringa numero come input e rimuove tutti gli spazi e i trattini dalla stringa.
Restituisce la stringa "pulita" senza spazi e trattini.
</details>

<details>
    <summary>Numero di telefono italiano</summary>
    
```c#
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
Il metodo EUnNumeroDiTelefonoItaliano riceve una stringa numero come input e verifica se rappresenta un numero di telefono italiano valido.
Effettua tre controlli:
- Se la stringa inizia con "+39" ed è lunga 13 caratteri, ritorna true.
- Se la stringa inizia con "0039" ed è lunga 14 caratteri, ritorna true.
- Se la stringa inizia con "3" ed è lunga 10 caratteri, ritorna true.

Se nessuno di questi tre controlli è soddisfatto, ritorna false.
</details>
