# JSON e SeString nel pack

I target usano direttamente la sintassi macro di Lumina. Il vecchio formato `<hex:...>` non e' accettato.
Il controllo locale usa Lumina 7.7.0 e .NET 10, senza dipendere da dev o dal client di gioco.

Da questa radice:

```powershell
dotnet run --project tools/PackCheck -- corpus/flat/LogMessage.json
dotnet run --project tools/PackCheck -- corpus/quest/040
dotnet run --project tools/PackCheck -- corpus --english ../ffxiv-corpus-en
dotnet run --project tools/PackCheck -- --self-test
```

Il primo avvio puo' ripristinare il pacchetto NuGet Lumina. Il comando analizza i JSON, rifiuta gameKey duplicate,
controlla ogni target valorizzato con il parser reale e segnala i raw hex. Con `--english` verifica anche esistenza
della sorgente e corrispondenza degli hash per percorso/gameKey. Non modifica file. I target vuoti sono contati,
non interpretati automaticamente come omissioni: possono essere campi tecnici o asset fuori ambito.

Per vedere la rappresentazione canonica e i payload di un campo:

```powershell
dotnet run --project tools/PackCheck -- --inspect corpus/flat/LogMessage.json 'LogMessage#11549'
```

Il parser prova la sintassi, non il significato dei rami. Confronta sempre sorgente e target completi,
variabili (`lnum`, `gnum`, `lstr`, `gstr`), indici dei fogli, colori, icone e referenti prima e dopo.
Per una modifica testuale conserva le macro estranee: non rigenerare l'intera stringa dalla sola anteprima.

## Escape e condizioni

- Genere locale: `<if(gnum4,femminile,maschile)>`; verifica il referente. Non sostituire condizioni native su altri parametri.
- Corsivo: `<italic(1)>testo<italic(0)>`, senza chiusure HTML.
- Didascalia letterale: `\<scricchiolio>`, che nel JSON diventa `"\\<scricchiolio>"`.
- Dentro un argomento testuale, virgole e parentesi letterali vanno protette: `\,`, `\(`, `\)`.
- Esempio: `<if([lnum3>0],\(+<kilo(lnum3,\,)>\),)>`. Il ramo positivo mostra `(+numero)`, quello negativo e' vuoto.
- Nel JSON ogni barra inversa va raddoppiata. Non confondere l'escape JSON con quello della macro.
- Usa `-` nei composti; elimina il tag discrezionale `<-->` secondo il significato del nome.
- Conserva parametri eseguibili e indici. Traduci invece tutti gli argomenti stringa realmente visibili al giocatore.

Per neutralizzare una condizione di genere verifica i due rami originari e l'intera frase risultante;
non eliminare condizioni con controlli diversi o informazioni necessarie. Per aggiungerla ramifica un sintagma completo.
Le regole editoriali sono in [Traduzione](TRANSLATION.md#genere-e-accordi).

## Scrittura e verifica

Prima di scrivere salva i valori interessati e verifica che siano ancora quelli letti. Cambia soltanto il valore JSON
del target individuato per gameKey, preservando il resto del file e i newline. Dopo la scrittura confronta gli oggetti:
devono essere identici salvo i target dichiarati. Esegui PackCheck sui file modificati e rileggi tutti i rami nel contesto.

Le GitHub Actions del pack restano un controllo aggiuntivo del progetto. Il tool locale non riproduce tutti i controlli
della pipeline e non prova la resa nel client. Non creare eccezioni del validatore per nascondere errori di sintassi.
