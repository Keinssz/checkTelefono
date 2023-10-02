# Check Telefono

- Scarichiamo  il file da classroom e rinominarlo nome.cognome.5H.CheckTelefono
-Successivamente   apriamo  la cartella su visual studio code


- Si inizia scorrendo  ogni elemento dentro all'array usando un foreach:\

foreach (var num in vettore){}
-Nel vettore richiamiamo il metotodo IsnumeroTelefonoItaliano e controlliamo che "num" sia valido:\
###
    if (IsnumeroTelefonoItaliano(num))
    {
        return num;
    }  
###

- Utilizziamo un metodo che deve  verificare  le varie caratteristiche che un numero di telefono deve avere.\

-In questo modo verifichiamo lunghezza della stringa e i prefissi se ritorna "true" significa che è valida:\
###
    if (num.Length == 13 && (num.StartsWith("+39"))
        {
            return true;
        }
###

-Gli altri due metodi verificano se sono corrette ma con caratteristiche differenti :\
###
    if (num.Length == 14 && num.StartsWith("0039"))
    {
      return true;
    }
###


###
    if (num.Length == 10 && num.StartsWith("3"))
    {
        return true;
    }
###
-Se la stringa non è conforme  alle condizioni il programma ritorna "false" significa che il numero risulta non valido.


