# Traduzione da zero

Guida operativa per nuove traduzioni, soprattutto missioni e cutscene. Per controllare una traduzione esistente usa [Revisione](REVISION.md); dopo una patch usa [Aggiornamento del client](CLIENT_UPDATE.md).

## 1. Perimetro e contesto

Controlla `git status` e `git diff` prima di scrivere. Conserva il lavoro preesistente e modifica solo file e campi assegnati, senza riformattare interi JSON. Non spostare file fra gli stati editoriali senza richiesta dell'utente.

Identifica la funzione di ogni campo: battuta, titolo, descrizione del diario, obiettivo, scelta del giocatore o identificatore tecnico. I fogli narrativi non contengono necessariamente soltanto dialoghi. Leggi la sequenza della scena e i campi collegati, identifica parlante, destinatario e referente dei pronomi. Il campo `tag` aiuta a orientarsi, ma non basta sempre a identificare il personaggio: segnala il contesto mancante senza inventarlo.

Il formato del pack e' `corpus/<categoria>/<foglio>.json`, con `entries` contenenti `gameKey`, `hash` e `target`.
La sorgente e' nel corpus inglese alla medesima gameKey; abbina anche l'hash. Il campo `en` non va aggiunto al pack.
I valori `conversation` e `gameVersion`, l'ordine delle voci e tutti i metadati restano invariati salvo aggiornamento autorizzato.
Un target vuoto non dimostra un testo mancante: verifica se la sorgente e' testo, controllo tecnico, sigla o asset.
`corpus/ui/banners.json` riguarda texture e resta fuori dal normale lavoro testuale.
Non ci sono cartelle di stato approvato/in revisione: presenza nel corpus e approvazione umana sono distinte.

## 2. Corpus, decisioni e discrepanze

`corpus/` e' la memoria corrente: cerca precedenti per gameKey, sorgente, termine e funzione.
Consulta [Glossario](../glossary/README.md), [decisioni e note d'uso](../glossary/Glossary.md) e i JSON specializzati.
Non serve accedere al vecchio repository dev. Le istruzioni dell'utente e le decisioni specifiche successive prevalgono.
Non riaprire una scelta gia' risolta: se il testo conserva l'inglese e il canone italiano e' confermato, applicalo nel contesto.

Se due rese indicano davvero lo stesso elemento nello stesso significato e funzione, e nessuna decisione già confermata risolve il conflitto:

1. Mostra varianti, contesto e riferimenti `corpus/percorso.json#gameKey:target` e chiedi all'utente quale mantenere.
2. Continua le voci indipendenti mentre aspetti la scelta.
3. Prima di scrivere, censisci per `corpus/percorso.json#gameKey:target` le occorrenze della sorgente e delle vecchie forme italiane nel corpus corrente, inclusi singolari, plurali, composti e testo nei payload. Distingui i referenti pertinenti dagli omonimi e dalle eccezioni. Conserva il valore iniziale dei campi interessati: se cambia durante il lavoro, rileggilo e integra le modifiche senza sovrascriverle.
4. Uniforma le occorrenze pertinenti e la nuova traduzione. Questa riconciliazione comprende i file discrepanti anche fuori dal file inizialmente assegnato, salvo esclusioni esplicite dell'utente. Non usare sostituzioni per sottostringa sull'intero JSON: modifica soltanto i campi tradotti censiti e i segmenti testuali verificati, ricodificando i payload con l'helper. Per esempio, la decisione `primal` → «primale» non riguarda automaticamente `primordial`, `primeval`, l'aggettivo generico `primal` o il gruppo musicale «The Primals».
5. Rileggi ogni frase, compresi tutti i rami delle condizioni, e adatta accordi e preposizioni. Confronta prima/dopo per ID e campo: sorgenti, metadati, ID e campi estranei devono restare identici. Valida tutti i file toccati e ripeti la ricerca delle vecchie forme; per ogni residuo pertinente correggi l'omissione o documenta l'eccezione. Se emerge un danno, riparti dai valori iniziali dei soli campi interessati, non da una sostituzione inversa globale.
6. Registra la decisione riutilizzabile, distinguendo la scelta confermata dal suo stato di applicazione. Una riga nel glossario non dimostra che la riconciliazione sia completa: nella consegna riporta campi corretti, residui motivati ed eventuali casi sospesi.

Non uniformare differenze motivate da referente, significato, registro, sintassi o funzione. La conferma della forma autorizza la riconciliazione pertinente, non sostituzioni indiscriminate né cambi di stato editoriale.

Controlla anche le decisioni già presenti per singolari, ruoli e nomi composti del termine. Se una nuova forma generale contrasta con una decisione più specifica, presenta il conflitto all'utente: non presumere che la nuova scelta abroghi l'eccezione o che l'eccezione autorizzi tutte le vecchie varianti.

Nel glossario registra una sola voce per decisione e conserva soprattutto ciò che il corpus non spiega: forma sostituita in una riconciliazione, limite semantico, variante ammessa o eccezione tecnica. Non aggiungere una riga per una normale flessione, preposizione o etichetta già univoca nel corpus. «Decisione dell'utente» richiede una conferma effettiva; un precedente trovato dall'agente va citato come fonte sorgente e non risolve da solo una nuova discrepanza.

Per lore e nomi propri consulta prima il corpus. Se manca un precedente pertinente o resta un dubbio, verifica la pagina della missione, del personaggio o dell'elemento sulla wiki di FFXIV. La wiki chiarisce il significato; non sostituisce una resa italiana stabilita. Per inglese ambiguo, giochi di parole o meccaniche confronta, quando disponibili, le versioni ufficiali FR/DE/JA e annota soltanto i confronti decisivi. Segnala le ambiguità irrisolte.

## 3. Convenzioni editoriali

Traduci voce per voce, preservando senso, destinatario e registro. Usa italiano naturale, senza inserire la sorgente inglese fra parentesi nel testo di gioco. Conserva concisione nelle scelte e nei campi con poco spazio; non comprimere il dialogo a scapito della voce del personaggio. Non aggiungere tic vocali assenti nella sorgente.

- Rispetta le maiuscole della sorgente: se una parola da tradurre ha la maiuscola (iniziale maiuscola o tutto maiuscolo), la sua controparte tradotta deve mantenere la maiuscola. Se il testo visibile della stringa sorgente inizia con una maiuscola, anche la prima parola della stringa tradotta deve avere l'iniziale maiuscola, anche quando cambia l'ordine delle parole. Considera il testo visibile anche nei payload SeString, ignorando i tag e i controlli iniziali. Distingui etichette e prosa; articoli e preposizioni italiane interni restano minuscoli. Un'etichetta maiuscola non impone il maiuscolo nella prosa autonoma.
- Usa esclusivamente l'apostrofo ASCII U+0027 (`'`) nei testi italiani, nei target e nei glossari; non usare U+2019. Per le citazioni usa i caporali (« »), salvo vincoli tecnici del campo.
- Non riprodurre spazi finali accidentali presenti nella sorgente inglese al termine di voci di menu, titoli, domande o battute autoconclusive. Conserva lo spazio solo se ha un'effettiva funzione tecnica di concatenazione.
- Non mantenere il trattino lungo della sorgente (`─`, U+2500): in inglese segnala sia pause o incisi sia interruzioni brusche. In italiano adatta sempre alla punteggiatura naturale:
  - Per spiegazioni, pensieri introdotti o elenchi usa i due punti (`:`).
  - Per pause brevi, apposizioni o incisi usa la virgola (`,`) o i trattini d'inciso spaziati (` – ` o ` - `).
  - Per interruzioni brusche del parlato, battute sospese o parole mozzate usa il trattino breve ASCII (`-`) attaccato (es. *Non puoi-*) o i puntini di sospensione (`...`).
- Per i trattini nei composti (es. *città-stato*, *Tam-Tara*, *Radz-at-Han*, *Kan-E-Senna*) usa il normale trattino ASCII (`-`): non inserire né preservare il tag SeString di sillabazione discrezionale `<hex:021F0103>` dell'inglese.
- Le istruzioni rivolte al singolo giocatore usano il tu. Dialoghi e annunci conservano il destinatario attestato.
- Uniforma formule e verbi solo quando azione e registro coincidono: `Report to` può essere «Torna da» o «Fai rapporto a».
- Identifica il referente prima del lemma: `Arms` araldico è uno stemma; il `range` di livelli è una soglia, quello spaziale una portata o un raggio. Distingui tecniche, abilità, incantesimi e azioni istintive. Le sigle ATT/DIF valgono nei campi tecnici, non per ogni uso narrativo.
- `Dungeon` come attività istanziata è «Spedizione»; come ambiente fisico è «sotterraneo». Missioni, Incarichi, Mandati, Prove, Incursioni, Cripte Profonde e Operazioni di Gilda seguono le decisioni contestuali del glossario.
- Conserva comandi e parametri eseguibili (`/party`, `/waymark`, `/cwlinkshell1`); traduci la spiegazione circostante.
- Per nomi composti descrittivi verifica lore e precedenti prima di adattare cognomi, soprannomi e appellativi. I nomi dei Loporrit seguono la decisione successiva dell'utente: adattamenti in `-olo`, registrati nel glossario locale e nei nomi per gameKey. Non inventare nuovi adattamenti se manca una scelta.
- I titoli nobiliari e di rango feudale di Ishgard (*Lord*, *Lady*) si mantengono in inglese: non tradurli con «Dama» o simili adattamenti. Forme allocutive e di deferenza come *mio signore*, *mia signora*, *sua santità*, restano invece perfettamente naturali e valide nel dialogo.
- Le unità letterali di distanza sono maschili: ilm/ilmi, fulm/fulmi, yalm/yalmi, malm/malmi. I pesi sono femminili: onza/onze, ponza/ponze, tonza/tonze. «Qualche» regge il singolare. Rendi naturalmente gli idiomi e documenta le eccezioni mirate del controllo, senza convertirli meccanicamente in misure.
- Mantieni identici i crediti in `corpus/flat/CreditListText.json` e i titoli musicali nome in `corpus/flat/Orchestrion.json`; di quest'ultimo traduci soltanto le descrizioni. Le licenze generali e gli avvisi dei software di terze parti consultabili dalla lobby restano originali, compreso `corpus/flat/AddonTransient.json#AddonTransient#173:target`. Gli avvisi di licenza mostrati nelle finestre di gioco si traducono come il resto della UI: `corpus/flat/AddonTransient.json#AddonTransient#247:target` e `AddonTransient#1016:target` sono le informazioni sulle esibizioni e non sono esclusi dalla traduzione.

## 4. JSON e SeString

Conserva ID, struttura, campi sorgente e metadati. Modifica soltanto i campi `translation` e `translation_*` richiesti. Salva progressivamente blocchi coerenti della scena, fino a completare il perimetro assegnato.

**I SeString vanno sempre tradotti.** Esamina sempre tutti i SeString del campo assegnato, anche se il testo esterno è già tradotto. La presenza di un tag, di una macro o di un payload non esclude il suo contenuto dalla traduzione: decodifica e controlla anche le espressioni stringa annidate e tutti i rami delle condizioni. Parole, frasi, appellativi, alternative maschili/femminili e testi visibili al giocatore vanno obbligatoriamente tradotti secondo le stesse regole del testo esterno. Non considerare completa una voce finché il suo testo interno non è stato tradotto e controllato.

### Sintassi macro Lumina (standard di ffxiv-language-pack-it)

Nei file di `ffxiv-language-pack-it` (e nei corpus con macro testuali) si utilizza rigorosamente la **sintassi macro Lumina**, conforme al compilatore del language pack:

- **Condizionali di genere del giocatore**: `<if(gnum4,femminile,maschile)>` (o su ObjectId `<if(gnum...,...)>`).
- **Stili di testo**: corsivo con `<italic(1)>testo<italic(0)>` (MacroCode 0x1A on/off). Non usare tag in stile HTML come `</italic>`.
- **Macro dinamiche comuni**: `<ennoun(...)>`, `<head(...)>`, `<sheet(...)>`, `<string(...)>`, `<num(...)>`, `<colortype(...)>`, `<edgecolortype(...)>`.
- **Trattino unificatore non-breaking**: `-` (MacroCode 0x1F, non-breaking hyphen).
- **Divieto di tag raw `<hex:...>` nel pack**: non copiare né inserire stringhe esadecimali raw `<hex:...>` nei file di `ffxiv-language-pack-it`. Il compilatore/parser del pack non riconosce la notazione raw e fallisce la compilazione con l'errore `Unsupported MacroCode`. Usa soltanto la rappresentazione macro Lumina leggibile.
- **Escape delle parentesi uncinate letterali (`\<`)**: se il dialogo contiene direzioni di scena, versi o onomatopee scritte tra parentesi angolari (es. `\<sospiro>`, `\<gasp>`, `\<sussulto>`, `\<tira su col naso>`), la parentesi iniziale `<` **deve essere preceduta dal carattere di escape `\`** (`\<`). In caso contrario il compilatore tenterà di interpretare il testo interno come nome di un MacroCode SeString inesistente, bloccando la build.
- **Chiusura dei tag e delle macro**: verifica sempre che ogni macro aperta con `<` si chiuda correttamente con `>` e che le macro condizionali annidate chiudano sia la tonda che l'uncinata (es. `)>`).

Preserva la funzione dei controlli, variabili, icone, colori, interruzioni di riga e referenti dinamici come `<FullName>`, `<Forename>` e `<Surname>`. Per `<string(...)>` ed espressioni analoghe distingui il riferimento dinamico dagli eventuali argomenti testuali: un riferimento, indice o identificatore tecnico resta invariato; una stringa letterale destinata alla visualizzazione va esaminata e tradotta. Non sostituire i riferimenti dinamici con valori inventati. Nomi propri ed eccezioni editoriali seguono corpus e glossario anche all'interno dei payload.

Quando un payload contiene testo visibile, traduci tutti i segmenti pertinenti, anche nei rami annidati.
Nel pack le lunghezze binarie sono gestite dal compilatore Lumina: modifica le macro leggibili, non i byte.
Segui [SeString](SESTRING_TOOL.md) per escape, confronto dei controlli e parsing reale con il tool locale.
Non confondere parametri e indici con argomenti testuali; non tradurre nomi di fogli o identificatori tecnici.
Il tag discrezionale `<-->` non si conserva: nei composti usa `-`, altrimenti eliminalo secondo il nome tradotto.

### Genere e accordi

**Principio editoriale.** Scrivi anzitutto una buona frase italiana. Tra formulazioni ugualmente fedeli, naturali e appropriate alla voce, preferisci quella che non richiede varianti di genere. Non forzare una riscrittura neutra per evitare un SeString e non aggiungere una condizione dove una formulazione semplice funziona già. La scelta non dipende dall'importanza del testo: dialoghi, titoli e messaggi secondari richiedono la stessa cura.

**Identifica il referente.** Prima di intervenire, stabilisci chi parla, a chi si rivolge e con chi concordano nomi, aggettivi, pronomi e participi. Distingui giocatore, parlante, altri personaggi, gruppi, oggetti e ruoli generici. Ricostruisci i casi dubbi dalla scena e dalle fonti disponibili; non attribuire automaticamente al giocatore ogni forma vicina a «tu». Il genere grammaticale non coincide necessariamente con quello del referente: «guida» può indicare persone diverse, mentre «custode» ed «erede» possono richiedere articoli e accordi differenti. I possessivi concordano con la cosa posseduta.

**Cerca una soluzione neutra senza impoverire il testo.** Puoi usare verbi, espressioni idiomatiche, aggettivi dalla stessa forma nei due generi o costruzioni con un diverso soggetto grammaticale. Valuta ogni soluzione nel contesto: deve conservare informazioni, intensità, destinatario, registro e ritmo. Non sostituire sistematicamente gli accordi con nominalizzazioni, passivi o perifrasi burocratiche. Non cancellare informazioni di genere esplicite e pertinenti alla scena.

Esempi orientativi, non sostituzioni automatiche:

| Sorgente e contesto | Possibile resa senza varianti |
| --- | --- |
| *You are amazing!* - esclamazione ammirata | «Sei incredibile!» |
| *You're safe now.* - rassicurazione | «Ora sei al sicuro.» |
| *You've been a great help to me.* - ringraziamento del parlante | «Mi hai dato un grande aiuto.» |
| *Are you sure you want to proceed?* - conferma dell'interfaccia | «Vuoi davvero procedere?» |

«Hai fatto il tuo arrivo» non è preferibile a «Sei arrivata/arrivato» soltanto perché evita una variante. Non cambiare «Sei ferita/ferito?» in «Stai bene?» se la domanda riguarda specificamente una ferita. Le barre in questi esempi indicano le alternative editoriali, non testo da mostrare in gioco.

**Usa le varianti quando servono.** Conserva appellativi, titoli, informazioni narrative e scelte terminologiche stabilite. Se una riscrittura neutra li attenua, li altera o rende artificiale la battuta, usa il SeString appropriato. «Guerriero/Guerriera della Luce» resta il titolo concordato: non va sostituito con un appellativo diverso per eliminare la condizione.

**Ramifica un segmento grammaticalmente completo.** Includi nella variante tutti gli elementi che devono cambiare insieme: articoli, preposizioni articolate, apostrofi, nomi, aggettivi e participi. Evita ramificazioni della sola desinenza. Usa un sintagma completo quando basta; estendi la variante all'intera frase quando gli accordi sono distribuiti o le costruzioni divergono. Non duplicare necessariamente tutta la battuta e non mostrare barre come «avventuriero/a».

Per accordi riferiti al giocatore puoi aggiungere **If(gnum4)** quando necessario:
- In `ffxiv-language-pack-it` scrivi direttamente la macro Lumina `<if(gnum4,femminile,maschile)>` (es. `<if(gnum4,avventuriera,avventuriero)>`).


**Condizioni If(gnum4) nella sorgente.** Se nella sorgente è presente un SeString `If(gnum4)` di genere riferito al giocatore, non è obbligatorio mantenerlo nella traduzione italiana se la frase può essere resa neutrale in maniera naturale e rimane scorrevole. La preservazione obbligatoria dei controlli e delle condizioni native riguarda i referenti dinamici, i tag e le condizioni non legate al genere del giocatore (come `IfPcGender` su ObjectId); per `If(gnum4)`, la presenza nella sorgente non vincola l'adattamento quando una formulazione neutra è efficace e fluida.

**Controlla entrambe le rese nel contesto.** Genera e ispeziona le condizioni con lo strumento SeString, poi leggi separatamente le frasi complete. Una forma apparentemente neutra non rende neutri gli accordi circostanti. Conserva le condizioni native e i loro referenti secondo le regole tecniche seguenti.

Non applicare il genere locale a PNG, terzi, collettivi o etichette generiche. Conserva le condizioni native: **IfPcGender** (`0B`) riguarda l'ObjectId indicato e ordina i rami **maschile, femminile**. Non è intercambiabile con If(gnum4). La pseudomacro `<If(PlayerParameter(Gender)...)>` non è compilata dall'encoder.

**Applica il criterio anche alla revisione.** Una condizione esistente e corretta non costituisce un difetto da eliminare. Rimuovila soltanto quando la nuova formulazione è almeno altrettanto efficace e il confronto conferma che nessuna funzione o informazione necessaria va perduta. Questa regola non autorizza una neutralizzazione automatica del corpus. Per la rimozione intenzionale di una condizione locale segui il confronto esplicito nella [guida dello strumento](SESTRING_TOOL.md#escape-e-condizioni).

Il criterio editoriale è una decisione dell'utente. Per il contesto professionale: [strategie e limiti descritti da professioniste di Keywords Studios](https://multilingual.com/issues/may-jun-2019/gender-inclusive-language-in-games-and-its-localization-challenges/), [esempi e cambiamenti di registro nella guida ATA](https://www.atanet.org/starting-your-career/a-short-guide-to-gender-inclusiveness-in-italian-translations/), [distinzione tra genere grammaticale e referente nella consulenza della Crusca](https://accademiadellacrusca.it/it/consulenza/un-asterisco-sul-genere/4018).

## 5. Verifica e consegna

Segui i [controlli di revisione](REVISION.md#controlli). Rileggi tutte le voci nel contesto dopo la verifica tecnica. Riporta file e campi verificati, esito, ambiguità e motivazioni delle correzioni effettive. Un validatore superato non approva il file: l'approvazione editoriale spetta all'utente; non spostare file o attribuire nuovi stati.

Il lavoro diretto sui target JSON e' il flusso principale. Definisci il perimetro e non rieseguire passate globali concluse senza nuovi problemi concreti.

## Registri dei personaggi e dei popoli

### Parlato delle Società Alleate e dei popoli affini

La denominazione di progetto è **Società Alleate** (*Allied Societies*); i riferimenti storici alle tribù vanno interpretati nel loro contesto. I popoli seguenti orientano la ricerca dei precedenti:

| Espansione | Società Alleate |
| :--- | :--- |
| A Realm Reborn | Amalj'aa, Sylph, Kobold, Sahagin, Ixal |
| Heavensward | Vanu Vanu, Vath, Moguri |
| Stormblood | Ananta, Kojin, Namazu |
| Shadowbringers | Pixie, Qitari, Nani |
| Endwalker | Arkasodara, Omicron, Loporrit |
| Dawntrail | Pelupelu, Mamool Ja, Yok Huy |

Per quest e popoli non attestati nel corpus verifica il contesto sulla pagina pertinente della wiki. La tabella non sostituisce il registro effettivo del parlante.

| Popolo | Tratto da conservare nella resa italiana |
| :--- | :--- |
| **Amalj'aa** | Registro marziale e rituale quando presente; conserva richiami a fratellanza, fuoco e giuramenti se appartengono alla battuta. Niente grafia fonetica inventata. |
| **Sylph** | Mantieni la terza persona riferita a sé o al proprio gruppo (*this one / these ones*) e gli appellativi *walking one*. Usa in modo coerente **questo qui / questi qui** e **camminante / camminanti**, adattando articoli e frase alla sintassi italiana. |
| **Kobold** | Lessico concreto di miniera, fabbricazione, conteggio e scambio quando il testo lo richiama; italiano standard, senza storpiature aggiunte. |
| **Sahagin** | Conserva il soffio iniziale *psh* e le sibilanti allungate già marcate nell'originale. In italiano usa **sss** dentro parole adatte; non sostituirlo con vocali ripetute e non estenderlo a ogni parola. |
| **Ixal** | Preserva le inversioni sintattiche riconoscibili con qualche costruzione marcata ma chiara. Mantieni appellativi come *featherless one* con una resa coerente come **implume**; conserva immagini di piume, taloni e volo quando presenti. |
| **Moguri (Moogle)** | Rendi l'intercalare **kupo** con **kupò** quando compare nell'originale, nella posizione della battuta; non aggiungerlo come suffisso automatico a ogni frase. |
| **Vanu Vanu** | Mantieni tono oracolare, immagini di cielo e volo, l'autoreferenza in terza persona quando presente e l'appellativo **forestiero** per *netherling*. Evita di introdurre costruzioni anomale se la fonte non le mostra. |
| **Gnath dell'Onemind** | Quando la fonte attribuisce la battuta all'alveare, conserva il «noi» collettivo e la volontà condivisa; non trattare il parlante come un individuo isolato. |
| **Vath** | Rendi i segnali sonori espliciti come «clic» e «clac». I Vath del Nonmind hanno identità e obiettivi individuali: non confonderli con la voce collettiva dei Gnath dell'Onemind. |
| **Ananta** | Allunga le sibilanti quando l'originale le allunga; rendile con **sss** in parole italiane adatte, senza alterare parole prive di suoni sibilanti. |
| **Kojin** | Rispetta lessico e tono legati a tesori, scambi, onore e devozione se presenti; non assegnare un accento comune a tutti i Kojin. |
| **Namazu** | Conserva le ripetizioni brevi ed entusiaste dell'originale, in particolare **sì, sì** e **no, no**; non aggiungere riempitivi dove mancano. |
| **Pixie** | Mantieni malizia, giocosità e ironia proprie del singolo interlocutore; niente suffissi o deformazioni fonetiche di specie. |
| **Qitari** | Segui il tono di racconto e memoria degli antenati quando emerge dalla battuta; non inventare arcaismi o un accento uniforme. |
| **Nani** | Mantieni il saluto **Lali-ho** quando presente e traduci in italiano gli appellativi culturali per chi è senza barba. Conserva il tono schietto e bonario senza imitare un accento reale. |
| **Arkasodara** | Italiano standard; rendi il tono solidale, pratico o mercantile del singolo personaggio senza attribuire una parlata deformata all'intero popolo. |
| **Omicron** | Conserva il lessico analitico e tecnico e le formule di unità/macchina se espresse; non spezzare la grammatica italiana per farli sembrare robotici. |
| **Loporrit** | Le voci restano individuali, spesso energiche o ottimiste. I nomi seguono gli adattamenti confermati in **-olo** nel glossario locale; non dedurre il tono dal nome e non inventare nuovi adattamenti. |
| **Pelupelu** | Mantieni cortesia, lessico commerciale e retorica promozionale quando presenti; niente accento inventato. |
| **Mamool Ja** | Rispetta differenze di carattere e contesto culturale tra parlanti; non applicare una grammatica tribale uniforme. |
| **Yok Huy** | Conserva il tono solenne, misurato o cerimoniale quando attestato; evita un italiano pseudoarcaico aggiunto. |
| **Goblin** *(popolo affine)* | Ricrea in italiano le parole composte e i giochi fonici che esistono nella fonte; mantieni interiezioni esplicite come *Pshhh* e non trasferire meccanicamente ogni composto. |
| **Ondo** *(popolo affine)* | Conserva le sibilanti allungate esplicite con **sss**, come per gli Ananta e i Sahagin; mantieni appellativi come *finless one* in forma italiana coerente. |
| **Qiqirn** *(popolo affine)* | Segui la voce del singolo personaggio e le eventuali difficoltà di pronuncia mostrate nella battuta; non attribuire automaticamente a tutti una grafia deformata o un accento. |

Queste indicazioni descrivono solo segnali attestati. In ogni revisione identifica prima chi parla e controlla la battuta inglese: una parola ricorrente da sola non basta ad attribuire il registro a un'intera specie. Quando l'originale non marca una pronuncia, conserva il tono e il lessico culturale senza aggiungere tic vocali.

---

### Personaggi principali

Le schede individuali, il criterio di selezione e il modello per i nuovi profili sono in [Voci dei personaggi](CHARACTER_VOICES.md). Consulta soltanto le schede dei parlanti della scena e la fase narrativa pertinente; il profilo orienta la resa, ma non aggiunge emozioni o informazioni alla sorgente.

Per i PNG generici parti dalla battuta, dal ruolo e dalla situazione. Razza e clan non impongono un registro comune: applica i tratti di un popolo soltanto quando attestati, secondo la sezione precedente. Le schede riguardano il parlato e gli eventuali testi attribuiti al personaggio, non automaticamente titoli, obiettivi o descrizioni del diario.

---
