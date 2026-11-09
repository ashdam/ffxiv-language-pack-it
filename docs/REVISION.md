# Revisione

Questa guida copre traduzioni esistenti, feedback e riconciliazioni. Le convenzioni linguistiche, i registri e SeString sono definiti una sola volta in [Traduzione](TRANSLATION.md).

La revisione è un passaggio editoriale volto a ottenere un adattamento italiano professionale da videogioco. La traduzione iniziale deve già verificare significato e terminologia; chi revisiona ne controlla la correttezza, ma concentra il lavoro sulla resa italiana, sulla voce e sull'efficacia del testo in gioco. Anche una frase grammaticalmente corretta e conforme al glossario può richiedere una riscrittura se suona tradotta, rigida o poco adatta alla scena.

## Revisione voce per voce

Controlla `git status` e `git diff`, definisci il perimetro e preserva le modifiche presenti. Identifica funzione del foglio, campi collegati, parlante, destinatario e referente. Confronta ogni campo tradotto con la propria sorgente e leggi la sequenza narrativa: naturalezza, significato, registro e coerenza non sono verificabili con il solo elenco dei termini.

Procedi su ogni voce nel suo contesto:

1. Ricostruisci dalla sorgente che cosa comunica il testo e quale effetto deve produrre: intenzione, emozione, informazioni, rapporti fra interlocutori ed eventuali ironia o sottintesi. Non dedurli soltanto dalla traduzione esistente.
2. Leggi l'italiano come testo destinato al giocatore. Valuta sintassi, scorrevolezza, ritmo, ordine delle informazioni, idiomaticità e precisione. Individua calchi, collocazioni innaturali, pronomi ridondanti, ambiguità involontarie, ripetizioni accidentali e formulazioni burocratiche o macchinose. Distinguili dalle ripetizioni e dalle costruzioni volute del personaggio.
3. Adatta la resa alla funzione del campo e alla voce pertinente, secondo le convenzioni di [Traduzione](TRANSLATION.md#3-convenzioni-editoriali) e le schede dei parlanti. Verifica che le battute funzionino nello scambio, che le risposte si colleghino alle battute precedenti e che titoli, obiettivi e descrizioni siano efficaci nel proprio uso.
4. Riscrivi dove serve, anche cambiando costruzione e distribuzione della frase, per ottenere italiano naturale e lo stesso effetto comunicativo. Conserva significato, informazioni, intensità e caratterizzazione: non abbellire con dettagli inventati, non alzare automaticamente il registro e non appiattire le voci. Mantieni le rese già efficaci; non cambiare per semplice preferenza fra alternative equivalenti.
5. Ricontrolla la nuova resa contro la sorgente per escludere omissioni, aggiunte o slittamenti di senso, quindi rileggi in continuità la scena o il gruppo di testi collegati. Verifica anche terminologia e vincoli tecnici prima di considerare conclusa la voce.

Consulta il corpus anche come riferimento stilistico: cerca passaggi pertinenti dello stesso personaggio, della stessa fase narrativa o della stessa funzione testuale e confronta il modo di formulare le frasi, oltre ai singoli termini. I precedenti orientano la continuità editoriale, ma non rendono automaticamente buona una costruzione poco naturale e non impongono formule identiche in contesti diversi. Applica i limiti di ricerca e le regole sulle discrepanze della guida di traduzione; non estendere la revisione a una riscrittura generale dei file consultati.

Cerca precedenti mirati nel corpus corrente. Per discrepanze reali applica [la riconciliazione](TRANSLATION.md#2-corpus-decisioni-e-discrepanze): presenta i casi all'utente e, dopo la scelta, correggi tutte le occorrenze pertinenti anche negli altri file pertinenti. Non effettuare sostituzioni cieche. Una frase sorgente identica può essere riutilizzata soltanto dopo aver verificato che contesto e funzione coincidano.

Controlla il testo interno di ogni SeString, anche nei payload rimasti identici alla sorgente, seguendo [JSON e SeString](TRANSLATION.md#4-json-e-sestring). Usa [lo strumento SeString](SESTRING_TOOL.md) per leggere tutti i rami, ricodificare le modifiche e confrontare controlli e referenti prima/dopo. Controlla entrambi i risultati completi delle condizioni di genere. Verifica comandi letterali, campi nome/descrizione, varianti ammesse e le eccezioni editoriali prima di correggere un presunto residuo inglese. Elimina spazi finali superflui ereditati dalla sorgente, adatta eventuali trattini lunghi `─` residui secondo le convenzioni e accertati che i composti con trattino usino il trattino standard `-` anziché il tag SeString di sillabazione `<hex:021F0103>`.

## Controlli

Per [genere e accordi](TRANSLATION.md#genere-e-accordi), valuta sia gli accordi mancanti sia le neutralizzazioni forzate. Mantieni le varianti corrette quando danno una resa migliore; non premiare una riscrittura soltanto perché elimina una condizione. La presenza di un `If(gnum4)` di genere nella sorgente non impone di conservarlo se la frase italiana è resa neutrale in modo naturale e scorrevole.

I controlli automatici supportano la lettura editoriale e non ne determinano il perimetro: esamina tutte le voci assegnate, comprese quelle senza segnalazioni. La scansione terminologica completa serve per un audit terminologico o una riconciliazione; non è un passaggio obbligatorio di ogni revisione stilistica.

L'assenza di condizioni di genere non dimostra un errore; la loro presenza non dimostra correttezza. Distingui verifiche strutturali, segnalazioni linguistiche da contestualizzare e verifica editoriale. Non imporre automaticamente l'aggiunta o la rimozione di varianti. Per i SeString modificati usa il parser Lumina locale e il confronto prima/dopo descritto nella [guida dello strumento](SESTRING_TOOL.md); questi controlli affiancano il validatore ufficiale e la lettura nel contesto.

Esegui dalla radice del pack il parser Lumina sui file modificati:

```powershell
dotnet run --project tools/PackCheck -- corpus/flat/LogMessage.json --english ../ffxiv-corpus-en
```

Il percorso EN e' configurabile nel comando; usa una versione affidabile coerente con il lavoro.
Il tool non modifica file. Leggi tutti gli errori: un hash discordante richiede la verifica della sorgente, non un aggiornamento cieco.
Le GitHub Actions aggiungono i controlli della pipeline del pack. Una riuscita tecnica non approva la traduzione.

Per una riconciliazione cerca il termine inglese nel corpus sorgente e tutte le forme italiane precedenti nei target,
inclusi payload e flessioni. Puoi usare `rg` per localizzare i file, ma non contare le occorrenze nei JSON grezzi
come prova: abbina gameKey/hash e classifica i referenti. Conserva la lista dei soli campi interessati prima di modificarli.
Non usare il vecchio scanner dev o i suoi lock come dipendenza del pack.

## Feedback, decisioni e consegna

Applica il feedback e registra solo decisioni riutilizzabili nei [glossari locali](../glossary/README.md), con sorgente,
referente, varianti e limiti. Una scelta nuova richiede la riconciliazione pertinente; una forma gia' confermata no.
Per discrepanze realmente irrisolte chiedi con riferimenti `corpus/percorso.json#gameKey:target` e prosegui i campi indipendenti.
Le fonti storiche spiegano la provenienza, non richiedono di consultare dev o di ripristinare le vecchie traduzioni.

Consegna file e numero di campi verificati, modifiche effettive, esito dei controlli e residui motivati.
Se hai svolto soltanto una verifica terminologica, non presentarla come revisione editoriale completa.
Non dichiarare approvazione senza conferma umana. Non scrivere report per ogni comando: usa `scratch/` per prove temporanee;
in `reviews/` conserva soltanto sintesi utili, eccezioni del validatore o questioni aperte.

La revisione e' conclusa quando tutti i campi assegnati sono stati letti, i controlli pertinenti passano e i dubbi reali
sono esplicitati. Riapri solo un errore concreto, un campo cambiato o una nuova richiesta; niente cicli di passate globali.
