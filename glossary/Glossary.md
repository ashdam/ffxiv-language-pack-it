# Glossario editoriale italiano

Questo glossario e i JSON di questa cartella costituiscono il canone locale del pack.
Le istruzioni esplicite dell'utente e le decisioni specifiche successive prevalgono sulle attestazioni storiche.
Le righe marcate superate documentano la storia e non sono varianti ammesse.
Le denominazioni contestuali non autorizzano sostituzioni globali per parola.
Per le decisioni finali della migrazione consulta [Decisioni](DECISIONS.md).

I riferimenti rimasti nel formato storico `data/translations/...` o `@review/...` indicano la provenienza,
non richiedono l'accesso al vecchio repository: la regola completa e' riportata qui.
Per il lavoro ordinario cerca le attestazioni attuali in `corpus/`, abbinate al corpus EN per gameKey/hash.
Le indicazioni «controllo automatico» descrivono la vecchia diagnostica e non attestano l'esistenza di un controllo locale equivalente.


`corpus/` e' la memoria corrente della localizzazione. Cerca li' le rese pertinenti, confrontando sorgente, traduzione, campo e contesto; non duplicare qui ogni nome o etichetta. Questo registro conserva decisioni dell'utente, varianti contestuali, accordi ed eccezioni che la sola coppia sorgente/traduzione non spiega. Le istruzioni esplicite dell'utente prevalgono.

**Decisione dell'utente:** `Mogglesguard` è la **Guardia Moguri** del Buon Re Moggle Mog XII. Usa il collettivo per il corpo di guardia e «Guardia Moguri / Guardie Moguri» per i membri nei campi nome singolare/plurale; adegua articoli e accordi. Sostituisce il nome inglese e «Guardia dei Moguri» per questo referente. Riferimenti: `corpus/flat/BNpcName.json#BNpcName#11461.0:target`; `corpus/flat/NpcYell.json#NpcYell#2073:target`; `@review/quests/arr/000/GaiUse409_00077.json#71:original`.

**Decisione dell'utente:** per la classe e il ruolo `Conjurer` usa **Incantatore / Incantatrice**, secondo il referente, al plurale «Incantatori / Incantatrici». Non usare «congiuratore / congiuratrice» o «conjuratore» per questo ruolo; non riguarda «congiurare» nel senso di complottare o «scongiurare». Riferimenti: `corpus/flat/ClassJob.json#ClassJob#6.30:target`; `@review/quests/arr/000/GaiUse410_00078.json#3:original`; `#98:original`.

**Riconciliazione terminologica:** `Ala Mhigan Quarter` → **Rione di Ala Mhigo**; forme con articolo e preposizioni si accordano alla frase. Memoria ufficiale: `corpus/flat/PlaceName.json#PlaceName#2610.0:target`.

**Riconciliazione terminologica:** `Palaka's Stand` → **La Piazzola di Palaka**; articoli e preposizioni si accordano alla frase. Memoria ufficiale: `data/translations/world/placename.json#3894:translation`.

**Decisione dell'utente:** `Conjurers' Guild` si rende **Gilda degli Incantatori**. Distingui il nome dell'organizzazione dal ruolo `Conjurer` («Incantatore / Incantatrice»); adatta articoli e preposizioni al contesto. Riferimenti: `corpus/custom/000/RegFstCnjGuild_00023.json#custom/000/RegFstCnjGuild_00023#TEXT_REGFSTCNJGUILD_00023_ESUMIYAN_000_1:target/translation_description`; `world/placename.json#2203:name/translation`; `@corpus/flat/PlaceName.json#577.0:source_en/target`.

**Decisione dell'utente:** il titolo `Antecedent` di Minfilia è **Antecedente**. Sostituisce «Progenitrice», «Precedente», «Precursora» e «Precettrice» per questo titolo; comprende il ritratto intitolato «L'Antecedente». Non riguarda progenitrici, antenate o creature omonime. Riferimenti: `corpus/flat/DefaultTalk.json#DefaultTalk#590961.20:target`; `corpus/flat/Item.json#Item#8731.8:target`; `@review/quests/arr/000/GaiUse403_00054.json#52:original`.

**Decisione dell'utente:** `Elder Seedseer`, titolo di Kan-E-Senna, si rende **Anziana Veggente**. Sostituisce «Veggente Anziana», «Veggente Anziano», «Oracolo Anziano», «Anziana Chiaroveggente», «anziana profetessa» e residui inglesi riferiti a lei. Per un predecessore esplicitamente maschio, conserva l'accordo «Anziano Veggente»; non estendere il titolo completo a ogni semplice `Seedseer`. Riferimenti: `corpus/flat/DefaultTalk.json#DefaultTalk#591404.20:target`; `#591032:description` (predecessore maschio); `@review/quests/arr/000/SubFst003_00026.json#55:original`.

**Decisione dell'utente:** la creatura `anole` si chiama **anole**, invariato al plurale. Sostituisce «anolide / anolidi» per questo referente; conserva le maiuscole della sorgente e l'articolo appropriato («un anole», «gli anole»). Riferimenti: `corpus/flat/BNpcName.json#BNpcName#120.0:target`; `#120:description`; `@review/quests/arr/000/SubFst121_00060.json#49:original`.

**Decisione dell'utente:** la località `East Shroud` è il **Velo Orientale**. Sostituisce «Bosco Orientale» quando indica questa zona; non estendere la scelta a descrizioni generiche di boschi a est. Riferimenti: `world/placename.json#55:name`; `corpus/custom/000/ComDefGrandCompanyOfficer_00073.json#custom/000/ComDefGrandCompanyOfficer_00073#TEXT_COMDEFGRANDCOMPANYOFFICER_00073_SYSTEM_000_094:target`; `@review/quests/arr/000/GaiUse411_00079.json#7:original`.

**Riconciliazione terminologica:** `The Fringes` → **I Margini**; usa «Margini» con articoli e preposizioni coerenti. Distingui `East End` (**Confini Orientali**). Memoria ufficiale: `corpus/flat/PlaceName.json#PlaceName#2406.0:target`.

**Riconciliazione terminologica:** `Fringes Gate` → **Porta dei Margini**; mantieni «Porta» nel nome localizzato del pack e usa il canonico «Margini». Memoria ufficiale: `corpus/flat/PlaceName.json#PlaceName#1958.0:target`.

Per discrepanze reali dello stesso referente, significato e funzione, presenta varianti e riferimenti all'utente. Dopo la scelta uniforma tutte le occorrenze pertinenti nel corpus corrente, oltre alla nuova traduzione, con accordi e controlli specifici. Differenze motivate dal contesto restano valide. Procedura: [Traduzione](../../dev/docs/TRANSLATION.md#2-corpus-decisioni-e-discrepanze).

Nella colonna **Uso**, `Controllo automatico: residuo.` segnala il termine inglese se resta nella traduzione di una frase; `Controllo automatico: residuo plurale.` controlla anche il plurale inglese in `-s`; `Controllo automatico: suffisso equipaggiamento.` applica il controllo ai termini di materiali e provenienza in `items/item.json`; `Controllo automatico: suffisso ruolo equipaggiamento.` verifica i suffissi di ruolo solo alla fine dei nomi di equipaggiamento; `Controllo automatico: intercalare.` controlla l'intercalare parlato preservando composti come «noce kupo». Questi controlli generano candidati da verificare: il validatore non modifica i file. La forma eorzeana delle misure è verificata in base al singolare o al plurale presente nell'originale.

**Decisione dell'utente:** la città `Crystarium` mantiene il nome **Crystarium**. Non usare «Cristallium» per questo luogo; la decisione vale anche per i riferimenti pertinenti nei dialoghi e nei testi approvati. Riferimenti: `corpus/custom/005/CmnFatShop1N4Town_00584.json#custom/005/CmnFatShop1N4Town_00584#TEXT_CMNFATSHOP1N4TOWN_00584_GRAMSOL_002_001:target`; `corpus/custom/005/RegNor4FortJobb_00586.json#custom/005/RegNor4FortJobb_00586#TEXT_REGNOR4FORTJOBB_00586_FERNWREN_000_021:target`.

**Decisione dell'utente:** la fazione `Passage of the Unbound` è la **Congrega degli Indomiti**; l'emote associato `Pose of the Unbound` è **Posa degli Indomiti**. Concordare articoli e aggettivi con «Congrega»; non usare «Passaggio degli Sciolti», il nome inglese o «Posa della Libertà» per questi referenti. Riferimenti: `corpus/custom/008/JobDefRoleRralmajun_00852.json#custom/008/JobDefRoleRralmajun_00852#TEXT_JOBDEFROLERRALMAJUN_00852_RRALMAJUN_100_010:target`; `corpus/flat/Emote.json#Emote#282:target`.

**Decisione dell'utente:** l'appellativo `Mother Miounne` si traduce **Madre Miounne**, anche nei nomi visualizzati e nei riferimenti narrativi. Non mantenere «Mother Miounne» nelle traduzioni. Riferimenti: `corpus/flat/DefaultTalk.json#DefaultTalk#589870.20:target`; `corpus/flat/DefaultTalk.json#DefaultTalk#590087.20:target`.

**Decisione dell'utente:** il soprannome `Wolf Burglar` si traduce **Ladro Lupo**, anche nei nomi visualizzati, nei dialoghi e nelle firme delle citazioni. Non usare «Ladro Lupino» o «Lupo Ladro» per questo personaggio. La decisione non riguarda i lupi o i Lupin in generale. Riferimenti: `corpus/flat/DefaultTalk.json#DefaultTalk#592614.20:target`; `corpus/flat/DefaultTalk.json#DefaultTalk#594573.20:target`.

**Decisione dell'utente:** il titolo accademico sharlayano `Archon` si traduce **Arconte**, al plurale **Arconti**, anche quando indica gli Eredi. Non usare «Arcano / Arcani» o il titolo inglese per questi referenti. Mantieni gli accordi con la persona o il gruppo indicato; non applicare automaticamente la scelta a nomi di operazioni, luoghi, oggetti o ricette che contengono la stessa parola. Riferimenti: `corpus/flat/DefaultTalk.json#DefaultTalk#596564.20:target`; `corpus/flat/DefaultTalk.json#DefaultTalk#597088.20:target`.

**Decisione dell'utente:** le creature di Endwalker chiamate `blasphemy / blasphemies` si traducono **blasfemia / blasfemie**, anche nei riferimenti alle loro trasformazioni e ai loro cacciatori. Non usare «empietà» o «profanazione» per queste creature. In prosa usa la minuscola, salvo inizio frase o maiuscola della sorgente; adegua articoli e preposizioni («una blasfemia», «della blasfemia», «cacciatori di blasfemie»). La decisione non riguarda il senso religioso comune di «blasfemia / empietà», gli aggettivi come `blasphemous` o i nomi musicali. Riferimenti: `corpus/flat/DefaultTalk.json#DefaultTalk#597536.20:target`; `corpus/flat/DefaultTalk.json#DefaultTalk#598986.20:target`; `corpus/flat/BNpcName.json#BNpcName#9300.0:target`.

**Decisione dell'utente:** l'appellativo dell'Arcadion `unenhanced` si rende **non potenziato / non potenziata**, accordandolo al personaggio indicato; al plurale «non potenziati / non potenziate». Mantieni il ruolo associato («guerriera non potenziata», «campione assoluto non potenziato»). Distingui l'appellativo dai riferimenti descrittivi alla meccanica del combattere senza potenziamenti; non aggiungere condizioni a una descrizione naturalmente neutra solo per trasformarla in un appellativo. Riferimenti: `corpus/flat/DefaultTalk.json#DefaultTalk#599877.20:target`; `corpus/flat/DefaultTalk.json#DefaultTalk#601248.20:target`. Riconciliati gli appellativi nel corpus; le descrizioni neutrali della meccanica restano varianti contestuali valide.

**Decisione dell'utente:** l'appellativo moguri `landlord / landlords` per le persone che vivono a terra è **Signore di Sotto / Signora di Sotto**, al plurale **Signori di Sotto / Signore di Sotto**, secondo il referente. La forma scelta dall'utente è «Signori di Sotto»; conserva queste maiuscole e gli accordi necessari. Distingui l'appellativo culturale dal proprietario o locatore nel senso comune di `landlord`; verifica separatamente i nomi di luoghi, oggetti e brani che contengono la parola. Riferimenti: `corpus/flat/DefaultTalk.json#DefaultTalk#592519.20:target`; `corpus/flat/NpcYell.json#NpcYell#2700:target`; `corpus/flat/NpcYell.json#NpcYell#2957:target` (parola spezzata dal ritorno a capo). La «Colonia dei Signori di Sotto» e il «Signore di Sotto Perduto» derivano da questo appellativo, come spiegano `corpus/flat/Adventure.json#Adventure#2162819.15:target` e `#2162786:col_2`; usa queste forme anche per i relativi dipinti. I titoli musicali e il locatore Anaoc restano fuori da questa decisione.

**Decisione dell'utente:** `Mirror Apple` si rende **Mela Specchio**, sostituendo «mela specchiante» e «mela a specchio» per questo frutto. In prosa usa «mela specchio», al plurale «mele specchio»; per l'albero «melo specchio». La decisione comprende i semi e gli ingredienti nelle descrizioni dei cibi; conserva le maiuscole delle rispettive sorgenti. Riferimenti: `corpus/flat/Item.json#Item#6146.9:target`; `corpus/flat/Leve.json#Leve#311.1:target`.

**Decisione dell'utente:** `Amateur's Breeches` si rende **Pantaloni del Novizio**, sostituendo «Pantaloni del Dilettante» e «pantaloni da iniziato» quando indicano questo oggetto. In prosa usa «pantaloni del novizio» e adatta il numero nei campi grammaticali dell'oggetto. Non estendere la scelta agli altri equipaggiamenti `Amateur's` né ai riferimenti generici a iniziati o dilettanti. Riferimenti: `corpus/flat/Item.json#Item#3316.9:target`; `corpus/flat/Leve.json#Leve#391.1:target`.

## Licenze e avvisi nella UI

**Decisione dell'utente:** le informazioni e gli avvisi di licenza mostrati nelle finestre di gioco vanno tradotti. Questo include le informazioni sulle esibizioni in `corpus/flat/AddonTransient.json#AddonTransient#247:target` e `#1016:original`. Le licenze generali consultabili dalla lobby restano in inglese; il testo dei software di terze parti in `system/addontransient.json#173:original` mantiene l'originale. Distingui la funzione del testo, non applicare un'esclusione a tutte le voci che contengono «license» o all'intero foglio.

## Concordanza di genere del personaggio giocante

**Decisione dell'utente:** gli appellativi e gli accordi riferiti al giocatore si adattano al genere del personaggio mediante SeString. Le rese neutre naturali sono ammesse quando conservano significato e registro; non eliminare titoli o snaturare la frase per evitare la condizione. Un SeString If(gnum4) di genere nella sorgente non è obbligatorio da mantenere se lo si può rendere neutrale in maniera naturale e la frase rimane scorrevole.

- **Decisione dell'utente:** anche i titoli di missioni e mandati riferiti al giocatore si adattano mediante SeString. Verifica il referente nel contesto della missione: i titoli che descrivono PNG, oggetti o collettivi seguono il proprio referente.
- **Decisione dell'utente:** il titolo `Warrior of Light` riferito al giocatore si rende **Guerriero della Luce / Guerriera della Luce**, anche dove era stato tradotto «Eroe della Luce». Non estendere questa uniformazione a un diverso appellativo della sorgente o a un uso descrittivo di «eroe».
- Coppie d'uso: **avventuriero / avventuriera**, **Guerriero della Luce / Guerriera della Luce**, **eroe / eroina**, **amico / amica**, **forestiero / forestiera**, **signore / signora**. La barra descrive le due forme e non va mostrata nel gioco. «Gilda degli Avventurieri» resta il nome dell'organizzazione; i plurali collettivi non dipendono dal genere locale.
- Nel JSON usa **If(gnum4)** compilato: condizione `E9 05`, ramo **femminile**, ramo **maschile**. Esempio «avventuriera» / «avventuriero»: `<hex:02081FE905FF0D617676656E74757269657261FF0D617676656E7475726965726F03>`. Fonte tecnica contestuale: `dialogue/contenttalk.json#112:translation`. Le lunghezze contano i byte UTF-8.
- Accorda articoli, preposizioni, pronomi, aggettivi e participi in entrambi i rami. Preferisci il segmento completo («un'avventuriera esperta» / «un avventuriero esperto»). I possessivi concordano con ciò che è posseduto, non con il possessore.
- Non applicare il genere locale a PNG o terzi, né a etichette generiche come «Scheda dell'Avventuriero» o allo status «Nuovo Avventuriero» quando se ne parla in generale: il nome di una categoria non indica il genere di chi la consulta. Se invece un testo identifica direttamente il personaggio giocante con il titolo di «Nuovo Avventuriero», usa If(gnum4) con «Nuova Avventuriera / Nuovo Avventuriero», in accordo con la decisione dell'utente di adattare i titoli riferiti al giocatore. Preserva i referenti delle condizioni native: IfPcGender (`0B`) usa l'ObjectId indicato e ordina i rami **maschile, femminile**. Nomi di oggetti, titoli musicali, citazioni rivolte a un PNG identificato e collettivi richiedono il proprio contesto.
- Regole e verifica dei due risultati: [Traduzione](../../dev/docs/TRANSLATION.md#4-json-e-sestring). La pseudomacro `<If(PlayerParameter(Gender)...)>` non è compilata dall'encoder.

## Controllo dei Primali

**Decisione dell'utente:** il fenomeno detto `tempering` si rende **asservimento**; chi lo subisce è **asservito / asservita**, con i relativi plurali; il verbo è **asservire**. Uniformare le precedenti rese «tempra», «temperamento», «soggiogamento», «soggiogazione» e i participi equivalenti soltanto quando indicano questo fenomeno. Riferimenti: `corpus/flat/FateEvent.json#FateEvent#33.56:target`; `corpus/flat/MYCWarResultNotebook.json#MYCWarResultNotebook#29.10:target`.

La decisione non riguarda la lavorazione dei metalli, il carattere, l'allenamento, i nomi di abilità come `Tempered Will` e `Tempered Release`, né altri tipi di ammaliamento o dominio. Verificare il referente anche per armi benedette e nemici chiamati `tempered`: il nome inglese da solo non prova che si tratti di asservimento. Nel controllo mirato sono stati allineati cinque campi: `cut_scene/073/VoiceMan_07300#TEXT_VOICEMAN_07300_003370_ALPHINAUD`, `cut_scene/061/VoiceMan_06100#TEXT_VOICEMAN_06100_004100_YSHTOLA`, `InstanceContentTextData#26308`, `quest/023/HeaVny241_02394#TEXT_HEAVNY241_02394_UNUKALHAI_000_004` e `quest/040/LucKsa202_04026#TEXT_LUCKSA202_04026_MARSHAK_000_157`. I 16 campi `EObjName#2003024-2003031.0/.2` mantengono «armi dei temperati» come in legacy: sono label di equipaggiamento, non il fenomeno. L'applicazione complessiva al corpus è ancora in corso; la registrazione della decisione non certifica il completamento della riconciliazione.
La decisione non riguarda la lavorazione dei metalli, il carattere, l'allenamento, i nomi di abilità come `Tempered Will` e `Tempered Release`, né altri tipi di ammaliamento o dominio. Verificare il referente anche per armi benedette e nemici chiamati `tempered`: il nome inglese da solo non prova che si tratti di asservimento. L'applicazione al corpus è in corso; la registrazione della decisione non certifica il completamento della riconciliazione.

## Voci

### Interfaccia e comandi

| Inglese | Italiano | Fonte | Uso |
| --- | --- | --- | --- |
| Ishgardian | ishgardiano / ishgardiana / ishgardiani / ishgardiane | Decisione dell'utente | Aggettivo e sostantivo adattati a genere e numero del referente; sostituisce «ishgardese / ishgardesi» in tutti i riferimenti pertinenti. Non estendere ai nomi propri o alle etichette di interfaccia che conservano l'inglese. |
| Ishgardian Restoration | Ricostruzione di Ishgard | Decisione dell'utente | Nome del progetto e dell'attività; usare «Ricostruzione di Ishgard» nelle etichette e nei riferimenti al progetto. Per i lavori descritti genericamente usare «ricostruzione di Ishgard» in minuscolo. Riferimenti: `corpus/flat/NotebookDivision.json#NotebookDivision#2006:target`; `corpus/flat/HWDInfoBoardArticle.json#HWDInfoBoardArticle#21:target`. |
| Neo-Ishgardian | Neo-Ishgardiano / Neo-Ishgardiana / Neo-Ishgardiani / Neo-Ishgardiane | `data/translations/shops/specialshop.json#1770294-1770296:translation`; `corpus/flat/TopicSelect.json#TopicSelect#3276880:target` | Denominazione dell'equipaggiamento Neo-Ishgardian; accordare al referente anche nelle etichette di interfaccia secondo la memoria legacy. |
| Cryptlurker | Predatore delle Cripte | Decisione dell'utente | Set di equipaggiamento di Shadowbringers (patch 5.4, liv. 80). Nei nomi di armi, armature, accessori e forzieri usare «del Predatore delle Cripte» (es. «Spada del Predatore delle Cripte», «Corazza del Predatore delle Cripte della Difesa», «Spada del Predatore delle Cripte Potenziata»). Calco su FR «Rôdeur des cryptes» e DE «Krypta-Schleicher». Riferimenti: `corpus/flat/Item.json#32418.9` e segg. |
| Crypt [materiali] | [della] Cripta | Decisione dell'utente | Materiali di potenziamento per equipaggiamento Cryptlurker: Crypt Ester -> Estere della Cripta, Crypt Twine -> Spago della Cripta, Crypt Dusting -> Polvere della Cripta. Riferimenti: `corpus/flat/Item.json#32156.9`, `#32157.9`, `#32158.9`. |
| NPC | PNG | Decisione dell'utente | Controllo automatico: residuo plurale. Sigla di personaggio non giocante, maschile invariabile al singolare e al plurale; anche NPCs diventa PNG. Usare «il PNG», «i PNG», «del PNG», «dei PNG», «al PNG», «ai PNG», «dal PNG», «dai PNG», «nel PNG», «nei PNG», «sul PNG», «sui PNG», «un PNG». Conservare la sigla maiuscola anche in prosa. Non modificare comandi, identificatori tecnici o campi sorgente. Riferimenti: `corpus/flat/FittingShopCategory.json#FittingShopCategory#52:target`. |
| Party | Gruppo | `corpus/flat/Addon.json#Addon#176:target` |  Singolare «gruppo», plurale «gruppi»; evita il residuo «party» nella prosa. Conserva /party come comando e Party nei soli identificatori tecnici. |
| Delete | Elimina | `corpus/flat/Addon.json#Addon#68:target` | Varianti ammesse in prosa: «Eliminare». |
| Item Level | Livello Oggetto | Decisione dell'utente | Controllo automatico: residuo. Nome della statistica di potenza degli oggetti. Nelle etichette di menu, shop e tabelle con vincoli di spazio usare «Liv.Ogg.» (variante ammessa; Varianti ammesse in etichette: «Liv.Ogg.»). |
| IL | Liv.Ogg. | Decisione dell'utente | Abbreviazione canonica di Item Level (Livello Oggetto). Rispecchia il francese «NvObj» e il tedesco «G.-St.». Varianti ammesse in prosa: «Liv.Ogg.». |
| Rank | Grado | `corpus/flat/Addon.json#Addon#732:target` | Nel Mahjong indica la posizione in classifica; varianti ammesse in prosa: «Posizione». |
| Crafting | Fabbricazione | `corpus/flat/Addon.json#Addon#273:target` | Nome dell'attività di fabbricazione; distinto dalle altre etichette contestuali del lemma. |
| Gathering | Raccolta | `corpus/flat/Addon.json#Addon#276:target` | Varianti ammesse in prosa per l'attività in corso: «Raccogliendo». |
| Crafting & Gathering | Fabbricazione e Raccolta | `corpus/flat/AchievementKind.json#AchievementKind#5:target` | Denominazione della categoria UI; non estendere meccanicamente a ogni frase su crafting e gathering. |
| Mining (etichetta task) | Picconare | `corpus/flat/GatheringType.json#GatheringType#0:target` | Usare per l'etichetta autonoma dell'attività di retainer; conservare «estrazione mineraria» in prosa sul processo o sulla materia. |
| Quarrying (etichetta attività) | Frantumare | `corpus/flat/GatheringType.json#GatheringType#1:target` | Resa del tipo di attività nel repertorio GatheringType; non imporla a descrizioni contestuali. |
| Logging (etichetta attività) | Disboscare | `corpus/flat/GatheringType.json#GatheringType#2:target` | Resa del tipo di attività nel repertorio GatheringType; «taglio del legname» resta valido quando si descrive il processo. |
| Harvesting (etichetta attività) | Mietere | `corpus/flat/GatheringType.json#GatheringType#3:target` | Forma verbale del tipo di attività; la variante nominale «mietitura» resta ammessa nell'etichetta contestuale `Addon#4840`. |
| Battle | Battaglia | `corpus/flat/Addon.json#Addon#663:target` | Battaglia nella UI; distinta dalla categoria tutorial «Combattimento». |
| Main Scenario Quests | Missioni dello Scenario Principale | `corpus/flat/HowTo.json#HowTo#80:target` | Categoria delle missioni principali. |
| Return | Ritorna | `corpus/flat/Addon.json#Addon#1460:target` | Comando di ritorno. |
| Return | Indietro | `corpus/flat/Lobby.json#Lobby#507.3:target` | Navigazione alla schermata precedente. |
| Return | Ritorno | Decisione dell'utente; `corpus/flat/MainCommand.json#MainCommand#36.5:target` | Canone per MainCommand#36.5/HowTo#13 come nella voce Return di `overrides.json`; la legacy «Rientro» è superata in questi campi. Distinguere Ritorna (azione) e Indietro (navigazione). |
| Return | Ritorno | `corpus/flat/Status.json#Status#2452.0:target` | Nome dello status; distinto dai comandi di ritorno. |
| Exit | Esci | `corpus/flat/Addon.json#Addon#2849:target` | Azione. |
| Phrontistery / Phrontisterion | Phrontisterio | Decisione dell'utente | Nome dell'istituzione di Frondale; mantenere «Phrontisterio» anche nei nomi dei ruoli e nelle varianti inglesi Phrontistery/Phrontisterion. Riferimenti: `corpus/flat/ENpcResident.json#ENpcResident#1017813.0:target`; `corpus/flat/ENpcResident.json#ENpcResident#1033006.0:target`. |
| Exit | Uscita | `corpus/flat/PlaceName.json#PlaceName#528.0:target` | Etichetta nominale. |
| Duty | Incarichi | `corpus/flat/MainCommandCategory.json#MainCommandCategory#2:target` | Categoria del menu; plurale di Incarico. |
| Duty | Incarico | `corpus/flat/Addon.json#Addon#2225:target` | Attività singola. Distinta dalle missioni delle quest. |
| Saga of Dawn and Duty | Saga dell'Alba e del Dovere | `corpus/flat/Action.json#Action#37193:target` | Nome di un attacco; «duty» è dovere, non Incarico. |
| Duties | Incarichi | `corpus/flat/Addon.json#Addon#15793:target` | Plurale del termine di gioco. |
| Duty Finder | Ricerca Incarichi | `corpus/flat/MainCommand.json#MainCommand#33.5:target` | Nome della funzione. Varianti ammesse in prosa: «Ricerca degli Incarichi», «Incarico trovato» nei messaggi di abbinamento. |
| Duty Recorder | Registratore Incarichi | `corpus/flat/MainCommand.json#MainCommand#76.5:target` | Nome della funzione. |
| Hotbar | Barra Azioni | `corpus/flat/Addon.json#Addon#1305:target` | Nome dell'interfaccia; in prosa adattare articolo e numero. |
| Duty Support | Supporto Incarichi | `corpus/flat/MainCommand.json#MainCommand#91.5:target` | Nome della funzione. |
| Duty Roulette | Roulette Incarichi | `corpus/flat/Addon.json#Addon#8605:target` | Nome della funzione. |
| Party Finder | Ricerca Gruppo | `corpus/flat/MainCommand.json#MainCommand#57.5:target` | Nome della funzione di ricerca gruppi. |
| Hall of the Novice | Sala dei Novizi | `corpus/flat/MainCommand.json#MainCommand#70.5:target` | Nome della funzione. |
| Novice Network | Rete dei Novizi | Decisione dell'utente | Nome del canale/funzione; usare con gli articoli e le preposizioni richiesti dalla frase. Riferimenti: `corpus/flat/Addon.json#Addon#651:target`; `corpus/flat/Addon.json#Addon#4508:target`. |
| Returner | Ritornato | Decisione dell'utente | Nome dello status/categoria; al plurale «Ritornati» e, se la frase richiede l'accordo femminile, «Ritornata». Lasciare invariati i token tecnici dei comandi e della ricerca. Riferimenti: `corpus/flat/OnlineStatus.json#OnlineStatus#31:target`; `system/textcommandparam.json#424:original`. |
| G-Warrior | Guerriero-G | Decisione dell'utente | Warmachina allagana riadattata dalle Officine Garlond (Shadowbringers / Werlyt). Maschile, singolare «Guerriero-G», plurale «Guerrieri-G». Usare «il Guerriero-G», «del Guerriero-G», «al Guerriero-G». Nei composti: «Guerriero-G MG», «Guerriero-G MGSD», «carta del Guerriero-G». |
| Challenge Log | Registro Sfide | `corpus/flat/MainCommand.json#MainCommand#60.5:target` | Nome del registro; forma abbreviata senza articolo. Maiuscole fisse: «Registro Sfide».  Varianti ammesse in prosa: «Registro delle Sfide». |
| Challenge Log Rewards | Ricompense Registro Sfide | `corpus/flat/Addon.json#Addon#10116:target` | Etichetta abbreviata, senza articolo. |
| Heaven-on-High | Pilastro dei Cieli | `corpus/flat/Addon.json#Addon#4809:target` | Nome del Deep Dungeon. Decisione dell'utente: nelle occorrenze di `Heaven<hex:021F0103>on<hex:021F0103>High` in `data/da_revisionare/`, usare «Pilastro dei Cieli» eliminando esclusivamente i due tag del trattino `<hex:021F0103>` interni al nome. Conservare tutti gli altri tag; l'eccezione non si estende ad altri nomi o ai file canonici. |
| Faux Hollows | Tane Sospette | `corpus/flat/Addon.json#Addon#11013:target` | Nome della funzione. |
| Sundry Splendors | Vari Splendori | `corpus/flat/Addon.json#Addon#13512:target` | Nome del negozio. |
| Mech Ops | Operazione Mech | `corpus/flat/Addon.json#Addon#16724:target` | Modalità dell'Esplorazione Cosmica, con piloti e supporto a terra; varianti ammesse in prosa: «operazione mech», «Operazioni Mech», «operazioni mech». |
| Pilot application(s) | Candidatura pilota / candidature pilota | Decisione dell'utente | Candidatura o modulo per accedere alle operazioni mech come pilota; per la forma verbale usare «candidarsi come pilota». Riferimenti: `corpus/custom/009/CtsWksMechaEntryTicketCounter_00932`; `corpus/flat/Addon.json#16830/#16834/#16838`; `DescriptionString#1340/#1389/#1429`. |
| Crucible of the Unbroken | Crogiolo degli Infrangibili | `corpus/flat/Addon.json#Addon#17601:target` | Nome del contenuto. |
| Company Chest | Forziere della Compagnia | `corpus/flat/Addon.json#Addon#2880:target` | Nome della funzione della Compagnia Libera. Variante ammessa solo per vincoli di spazio della UI: «Forziere» in `corpus/flat/Addon.json#Addon#2963:target`. |
| Rowena's House of Splendors | Casa degli Splendori di Rowena | `corpus/flat/Addon.json#Addon#6170:target` | Nome del negozio. |
| Hunting Log | Registro di Caccia | `corpus/flat/MainCommand.json#MainCommand#8.5:target` | Nome del registro; varianti ammesse in prosa: «registro di caccia», «voce del registro di caccia», «rango di difficoltà del registro di caccia». |
| Field Record | Rapporti sul Campo | `corpus/flat/McGuffinUIData.json#McGuffinUIData#3:target` | Nome della raccolta delle schede di Save the Queen; usare la forma canonica anche se l'originale è singolare. |
| Gathering Log | Registro di Raccolta | `corpus/flat/MainCommand.json#MainCommand#7.5:target` | Nome del registro; varianti ammesse in prosa: «taccuino di raccolta». |
| Crafting Log | Registro di Fabbricazione | `corpus/flat/MainCommand.json#MainCommand#9.5:target` | Nome del registro. |
| Fishing Log | Registro di Pesca | `corpus/flat/MainCommand.json#MainCommand#29.5:target` | Nome del registro; varianti ammesse in prosa: «taccuino di pesca», «registro di pesca». |
| weak bite | abboccata debole | `corpus/flat/DescriptionString.json#DescriptionString#412:target`; `corpus/flat/ActionTransient.json#ActionTransient#4103:target`; `corpus/flat/IKDPlayerMissionCondition.json#IKDPlayerMissionCondition#4/#10/#16/#22/#27/#32/#37:target` | Intensità dell'abboccata durante la pesca; distinguere da `hooking` = ferrata. Decisione dell'utente del 14 novembre 2026. |
| Fellowships | Confraternite | `corpus/flat/MainCommand.json#MainCommand#85.5:target` | Nome della funzione; singolare: Confraternita. |
| Fellowship Finder | Ricerca Confraternite | `corpus/flat/MainCommand.json#MainCommand#86.5:target` | Nome della funzione. Varianti ammesse in prosa: «Ricerca dei Sodalizi». |
| Strategy Board | Lavagna Strategica | `corpus/flat/MainCommand.json#MainCommand#98.5:target` | Nome della funzione; varianti ammesse in prosa: «lavagna strategica», «lavagne strategiche», «Lavagne Strategiche», «Lavagna Tattica». |
| Unending Codex | Codex Infinito | `corpus/flat/McGuffinUIData.json#McGuffinUIData#5:target` | Nome della raccolta; mantenere la forma invariabile e adattare articoli e preposizioni alla sintassi italiana («nel Codex Infinito»). |
| The Source | La Sorgente | `corpus/flat/TripleTriadCard.json#TripleTriadCard#387.8:target` | Variante del nome del mondo usata sistematicamente nei testi revisionati. |
| Amajina & Sons Mineral Concern | Impresa Mineraria Amajina e Figli | `corpus/flat/ContentFinderConditionTransient.json#ContentFinderConditionTransient#3:target` | Varianti ammesse in prosa: «Compagnia Mineraria Amajina e Figli». |
| Far East | Estremo Oriente | `corpus/flat/MKDLore.json#MKDLore#1.6:target` | Varianti ammesse in prosa: «Lontano Oriente». |
| Grand Company | Grande Compagnia | `corpus/flat/ContentTalk.json#ContentTalk#42:target` | Varianti ammesse in prosa: «Compagnia Maggiore». |
| The Churning Mists | Nebbie Vorticose | `corpus/flat/ContentFinderConditionTransient.json#ContentFinderConditionTransient#37:target` | Nome dell'area; forma preferita dall'utente. |
| Sightseeing Log | Diario Esplorazione | `corpus/flat/MainCommand.json#MainCommand#64.5:target` | Nome del registro; maiuscole fisse: Diario Esplorazione. In prosa: «diario di esplorazione». |
| Vault Oneiron | Volta Oneiron | `corpus/flat/HowTo.json#HowTo#289:target` | Nome del luogo. |
| Armoury Chest | Armeria | `corpus/flat/MainCommand.json#MainCommand#25.5:target` | Nome della funzione. |
| Armoury system | sistema dell'Armeria | Decisione dell'utente | Sistema per cambiare classe o job mediante l'arma o lo strumento equipaggiato. Sostituisce «sistema dell'Arsenale» e «sistema Armeria»; non riguarda gli arsenali in altri significati. Riferimenti: `corpus/flat/HowToPage.json#HowToPage#115.4:target`; `@review/quests/arr/000/ClsLnc002_00035.json#84:original`. |
| Chocobo Saddlebag | Bisaccia del Chocobo | `corpus/flat/MainCommand.json#MainCommand#77.5:target` | Nome della funzione. |
| Blue Magic Spellbook | Grimorio di Magia Blu | `corpus/flat/MainCommand.json#MainCommand#81.5:target` | Nome della funzione. |
| Accursed Hoard | Tesoro Maledetto | Decisione dell'utente | Nome del tesoro recuperabile nelle Cripte Profonde; usa «pezzo/frammento del Tesoro Maledetto» per *piece*, secondo il contesto. |
| Aetherial Beacon | Faro Eterico | Decisione dell'utente | Riferimento ai beacon eterici; in prosa minuscolo secondo il contesto («faro eterico»). Distingui da Aetheryte. Riferimenti: `LogMessage#845`; `RegFstAetheryteGuid_00032#NICIA_000_30/32`; `RegSeaAetheGuid_00051#SUNDHIMAL_000_30/32`; `RegWilAetheGuid_00060#NENEBARU_034`. |
| Aetherial Aegis | Egida Eterea | `corpus/flat/InstanceContentTextData.json#InstanceContentTextData#25306:target` | Azione difensiva del G-Warrior; conserva le maiuscole quando indica il nome dell'azione. |
| Aether Currents | Correnti Eteriche | `corpus/flat/MainCommand.json#MainCommand#67.5:target` | Nome della funzione; varianti ammesse in prosa: «correnti eteriche», «corrente eterica». |
| Adventurer Plate | Scheda dell'Avventuriero | `corpus/flat/MainCommand.json#MainCommand#93.5:target` | Nome della funzione; varianti ammesse in prosa: «scheda dell'avventuriero», «schede degli avventurieri». |
| Shared FATE | FATE Condivisi | `corpus/flat/MainCommand.json#MainCommand#84.5:target` | Nome della funzione. |
| New Game+ | Nuova Partita+ | `corpus/flat/MainCommand.json#MainCommand#88.5:target` | Nome della modalità. |
| Waymarks | Marcatori Tattici | `corpus/flat/MainCommand.json#MainCommand#58.5:target` | Nome della funzione. Singolare in prosa: «marcatore tattico»; evita il residuo «waymark». Conserva /waymark, /wmark e i sottocomandi letterali nella sintassi dei comandi. Attestazione: `system/textcommand.json#178:translation_col_2`. |
| Ready Check | Appello | `corpus/flat/MainCommand.json#MainCommand#59.5:target` | Nome della funzione. |
| Record Ready Check | Registra Appello | `corpus/flat/MainCommand.json#MainCommand#79.5:target` | Funzione per registrare un appello prima di registrare un incarico. Varianti ammesse in prosa: «appello di registrazione», «appello per la registrazione», «verifica di prontezza alla registrazione». L'etichetta del comando mantiene le maiuscole fisse: «Registra Appello». |
| PvP Profile | Profilo PvP | `corpus/flat/MainCommand.json#MainCommand#56.5:target` | Nome della funzione. |
| PvP Team | Squadra PvP | `corpus/flat/MainCommand.json#MainCommand#78.5:target` | Nome della funzione; varianti ammesse in prosa: «una squadra PvP», «le squadre PvP», «delle squadre PvP», «squadre PvP». |
| Silence Echo | Silenzia Eco | `corpus/flat/Addon.json#Addon#12691:target` | Etichetta contestuale; distinta dal termine generico «Silence». |
| Starward Standings | Classifica Stellare | `corpus/flat/Addon.json#Addon#16716:target` | Etichetta della classifica; distinta dal nome dell'area «Spalti delle Stelle». |
| Mount Guide | Guida Cavalcature | `corpus/flat/MainCommand.json#MainCommand#61.5:target` | Nome della funzione. |
| Minion Guide | Guida Minion | `corpus/flat/MainCommand.json#MainCommand#62.5:target` | Nome della funzione.  Varianti ammesse in prosa: «Guida ai Minion». |
| Raid Finder | Ricerca Incursioni | `corpus/flat/MainCommand.json#MainCommand#72.5:target` | Nome della funzione. |
| V&C Dungeon Finder | Ricerca Spedizioni V&C | `corpus/flat/MainCommand.json#MainCommand#94.5:target` | Nome della funzione; comprende varianti e criterio. Varianti ammesse in prosa: «finestra di ricerca delle spedizioni V&C». |
| Levequests | Mandati | `corpus/flat/Addon.json#Addon#8602:target` | Singolare: Mandato; tipo specifico di attività. |
| Leves | Mandati | `corpus/flat/Addon.json#Addon#8337:target` | Sinonimo di Levequests; varianti ammesse in prosa: «Incarico di [dispositivo]». |
| Guildleves | Mandati di Gilda | `corpus/flat/HowTo.json#HowTo#33:target` | Singolare «mandato di gilda»; in prosa minuscolo. «Trial guildleve»: «mandato di gilda di prova». Variante UI: «Incarichi di Gilda» in `corpus/flat/Addon.json#Addon#574:target`. |
| Wingleves | Mandati Alari | Decisione dell'utente | Decisione editoriale del lotto main-only; in prosa usare «mandato alare» al singolare e minuscolo. Riferimento: `quest/050/KinGyr101_05003#TEXT_KINGYR101_05003_SYSTEM_000_009:source_en`. |
| Supply & Provisioning Missions | Missioni di Rifornimento e Approvvigionamento | Decisione dell'utente | Denominazione congiunta delle due attività delle Grandi Compagnie. Non usare «Provviste» per Provisioning. Variante ammessa in prosa: «missioni di rifornimento e approvvigionamento». |
| Supply and Provisioning Missions | Missioni di Rifornimento e Approvvigionamento | Decisione dell'utente | Stessa denominazione con la congiunzione estesa. Variante ammessa in prosa: «missioni di rifornimento e approvvigionamento». |
| Trials | Prove | `corpus/flat/Addon.json#Addon#8608:target` | Singolare: Prova; attività istanziata. |
| Raids | Incursioni | `corpus/flat/Addon.json#Addon#8609:target` | Singolare: Incursione; attività istanziata. |
| Tratti Phantom job | Guardia Spettrale Potenziata; Preghiera Potenziata; Rabbia Potenziata; Calcio Spettrale Potenziato; Mira Spettrale Potenziata; Colpo di Iai Potenziato; Canto Potenziato; Fuoco Fantasma Potenziato; Salto Occulto Potenziato; Adattabile | Decisione dell'utente: `MKDTrait#1-#9/#11/#14/#19` | Applicare alle sole label dei tratti; non estendere alle descrizioni o ai nomi di azioni. Fonte legacy `data/translations/combat/mkdtrait.json`. |
| EventTutorial | Trasporto; Trasparente; Scorta; Seguire; Protezione; Esegui una Combo Istintiva/Intenzionale/Infinita | Decisione dell'utente: `EventTutorial#3.0/#4.1/#5.0-.1/#6.0-.1/#10.0/#11-#13.0` | Forme legacy limitate ai campi indicati; per le tre descrizioni brevi combo si conserva invece il casing main. |
| Categorie Orchestrion | Luoghi I/II; Spedizioni I/II; Incursioni I/II; Stagionali | Decisione dell'utente: `OrchestrionCategory#2/#3/#5/#7/#9/#10/#12` | «Luoghi I/II» mantiene il canone main; «Spedizioni» e «Incursioni» sono plurali legacy specifici delle categorie I/II; «Stagionali» mantiene la label legacy. Non estendere queste forme ad altri contesti. |
| Dungeons | Spedizioni | `corpus/flat/Addon.json#Addon#8335:target` | Attività istanziata; al singolare: Spedizione. Per il luogo fisico usare Sotterraneo, secondo il contesto. |
| Dungeon | Spedizione | Decisione dell'utente | Etichetta dell'attività istanziata. |
| Dungeon (physical place) | Sotterraneo | Decisione dell'utente | Luogo fisico: usare «sotterraneo» in riferimenti espliciti all'ambiente, come «this dungeon», l'ingresso o l'interno. Le funzioni che concludono un Incarico, per esempio la votazione per terminare e lasciare il dungeon, si riferiscono all'attività e usano «spedizione». Il validatore confronta i riferimenti con la frase tradotta, senza segnalare «spedizione» usato correttamente altrove nello stesso testo. |
| Deep Dungeon | Cripta Profonda | `corpus/flat/Addon.json#Addon#2304:target` | Tipo distinto di attività. Varianti ammesse in prosa: «cripta profonda», «cripte profonde», rispettando le maiuscole della frase. |
| Effetti di piano Deep Dungeon | Riduzione PV; Amnesia; Celerità; Penalità Oggetti/Scatto/Respingimento/Autoguarigione/Magicite/Demicloni/Incenso | Decisione dell'utente: `DeepDungeonFloorEffectUI#2/#4/#5/#7-#10/#13-#15` | Resa legacy specifica delle label; «Haste» resta per azione/status; BaseParam#47.1 usa «Rapidità» per decisione dell'utente dell'11 novembre 2026. «Celerità» resta limitata all'effetto #5. «Tenebra» per Gloom resta la decisione Glossary.md#961. |
| Guildhests | Operazioni di Gilda | `corpus/flat/Addon.json#Addon#3165:target` | Singolare: Operazione di Gilda. |
| FATE | FATE | `corpus/flat/Addon.json#Addon#5768:target` | Sigla invariabile. |
| FATEs | FATE | `corpus/flat/Addon.json#Addon#8336:target` | Plurale senza punti. |
| Need | Necessità | `corpus/flat/Addon.json#Addon#390:target` | Scelta per l'assegnazione del bottino. |
| Greed | Avidità | `corpus/flat/Addon.json#Addon#391:target` | Decisione dell'utente; scelta per l'assegnazione del bottino. |
| Pass | Rinuncia | `corpus/flat/Addon.json#Addon#392:target` | Scelta per rifiutare il bottino; nella schermata del Mahjong, variante ammessa in prosa: «Passa». |
| Need, Greed, Pass | Necessità, Avidità, Rinuncia | `corpus/flat/Addon.json#Addon#12693:target` | Decisione dell'utente per Greed; nomi delle tre scelte nel sistema di distribuzione del bottino. Varianti ammesse in prosa: «Necessità, Avidità e Rinuncia», «Solo Avidità». |
| Aetheryte Tickets | Buoni Eterite | `corpus/flat/Addon.json#Addon#8501:target` | Oggetti per il teletrasporto; tradurre «Aetheryte» come «Eterite». |
| Aetheryte Ticket Usage | Uso dei Buoni Eterite | `corpus/flat/Addon.json#Addon#8522:target` | Etichetta della funzione. |
| Chocobo Porter | Noleggio Chocobo | `corpus/flat/Addon.json#Addon#2730:target` | Servizio di noleggio del Chocobo. Varianti ammesse in prosa: «chocobo da trasporto». |
| Levemete | Ufficiale degli Incarichi | `corpus/flat/Addon.json#Addon#678:target` | PNG che assegna Mandati; resa contestuale. |
| Advanced Materia Melding | Innesto Avanzato di Materia | `corpus/flat/HowTo.json#HowTo#99:target` | Nome della funzione di innesto avanzato. |
| Familiar | Famiglio | Decisione dell'utente | Forma singolare nel testo dinamico di `system/addon.json#17657`: usare quando il conteggio è 1. |
| Familiars | Famigli | Decisione dell'utente | Forma plurale nel testo dinamico di `system/addon.json#17657`: usare quando il conteggio è diverso da 1. |
| Pet Glamours | Illusione dei Famigli | `corpus/flat/HowTo.json#HowTo#233:target` | Resa del sistema di glamour applicato ai famigli. |
| Moogle Treasure Trove | Forziere del Moguri | `corpus/flat/Addon.json#Addon#2778:target` | Nome dell'evento; varianti ammesse in prosa: «Tesoro dei Moogle». |
| Happy Bunny | Coniglio Felice | `corpus/flat/Addon.json#Addon#9791:target` | Nome dell'attività; in etichetta usare «Coniglio Felice». Varianti ammesse in prosa: «coniglio felice», «Coniglietto Felice», «coniglietto felice». In `corpus/flat/ENpcResident.json#ENpcResident#1042437.0:target`, l'originale tutto minuscolo richiede «coniglio felice»; al plurale: «conigli felici». |
| Forked Towers | Torri Biforcute | Decisione dell'utente | Nome del contenuto. Varianti ammesse in prosa: «Torre Biforcuta». Singolare «Torre Biforcuta», plurale «Torri Biforcute»; sostituire le precedenti forme Biforcata/Biforcate per questo nome. Riferimento: `corpus/flat/Addon.json#Addon#16699:target`. |
| Resident Caretaker | Custode Residenziale | `corpus/flat/Addon.json#Addon#3691:target` | Ruolo nella zona residenziale; varianti ammesse in prosa: «custode residente», «custode locale», «custode», «custode del quartiere». |
| Crystalline Conflict | Conflitto Cristallino | `corpus/flat/Addon.json#Addon#5557:target` | Modalità PvP. |
| Final / Endless / Rising Conflict (ranghi stagionali) | Re del Conflitto / Principe del Conflitto / Asso del Conflitto | `corpus/flat/BannerDecoration.json#BannerDecoration#33–35`; `corpus/flat/BannerBg.json#BannerBg#32–34` | Rispettivamente, nelle stagioni 1–21; usare le forme flesse richieste da titoli e ricompense. |
| The Feast | Il Banchetto | `corpus/flat/Addon.json#Addon#5510:target` | Modalità PvP; in prosa adattare l'articolo («nel Banchetto», «del Banchetto»). Varianti ammesse in prosa per il senso comune: «banchetto». |
| Frontline | Prima Linea | `corpus/flat/Addon.json#Addon#5558:target` | Modalità PvP; verificare le maiuscole nel contesto. |
| Elite Enemy | Nemico d'élite | `corpus/flat/Addon.json#Addon#17542:target` | Etichetta con numero dinamico; abbreviare il numero come «n.»; varianti ammesse in prosa: «nemici d'élite», «nemici élite». |
| Rival Wings | Ali Rivali | `corpus/flat/Addon.json#Addon#5559:target` | Modalità PvP. |
| Soaring | Ascesa | Decisione dell'utente | Nome dell'effetto di Ali Rivali; non usarlo per il senso generico di «volteggiare». Riferimenti: `corpus/flat/Status.json#Status#1465.0:target`; `corpus/flat/DescriptionString.json#DescriptionString#144:target`. |
| Cruise Chaser | Inseguitore | Decisione dell'utente | Nome del machina di Ali Rivali; adattare articolo e numero. |
| Oppressor | Oppressore | Decisione dell'utente | Nome del machina di Ali Rivali; adattare articolo e numero. |
| Brute Justice | Giustizia Brutale | Decisione dell'utente | Nome del machina di Ali Rivali; adattare articolo e numero. |
| Triple Triad | Triple Triad | `corpus/flat/Addon.json#Addon#9529:target` | Nome ufficiale del minigioco; varianti ammesse in prosa: «Tris». |
| Lord of Verminion | Lord of Verminion | `corpus/flat/Addon.json#Addon#9550:target` | Nome invariato del minigioco. |
| Gold Saucer | Gold Saucer | `corpus/flat/Addon.json#Addon#8612:target` | Nome invariato della destinazione. |
| Manderville Gold Saucer | Gold Saucer Manderville | Decisione dell'utente | Nome completo del luogo; usare anche nei composti che ne indicano attrazioni, arredi, punti e crediti. Sostituisce «Gold Saucer di Manderville». Non altera la forma breve «Gold Saucer» né le sigle MGP, MGF e MGC. |
| The Gold Saucer | Gold Saucer | `corpus/flat/PlaceName.json#PlaceName#1484.0:target` | Nome della destinazione; variante ammessa in prosa: «Gold Saucer». |
| The Gold Saucer | Il Gold Saucer | `corpus/flat/PlaceName.json#PlaceName#1484.0:target` | Forma autonoma del toponimo. |
| Leap of Faith | Salto della Fede | `corpus/flat/Addon.json#Addon#8475:target` | GATE del Gold Saucer. |
| The Hunt | La Caccia | `corpus/flat/Addon.json#Addon#838:target` | Nome della funzione di gioco; prefisso di un titolo composto da ignorare; distinguere dall'uso comune di hunt; varianti ammesse in prosa: «la caccia». |
| Treasure Hunt | Caccia al Tesoro | `corpus/flat/Addon.json#Addon#2276:target` | Modalità di gioco; distinguere dall'uso comune; varianti ammesse in prosa: «Caccia al tesoro», «caccia al tesoro». |
| Journal | Diario di Viaggio | `corpus/flat/Addon.json#Addon#450:target` | Nome del menu. |
| Journal | Diario | `corpus/flat/Addon.json#Addon#593:target` | Etichetta breve. |
| All | Tutti | `corpus/flat/Addon.json#Addon#970:target` | Insieme di elementi; variante ammessa in prosa: «Tutte». |
| All | Tutto | `corpus/flat/HowToCategory.json#HowToCategory#1:target` | Categoria tutorial. |
| Battle | Combattimento | `corpus/flat/HowToCategory.json#HowToCategory#4:target` | Categoria tutorial. |
| Crafting | Artigianato | `corpus/flat/HowToCategory.json#HowToCategory#12:target` | Categoria tutorial. |
| Crafting | Creazione | `corpus/flat/Addon.json#Addon#13233:target` | Etichetta contestuale in addon. |
| Overview | Panoramica | `corpus/flat/DescriptionString.json#DescriptionString#122:target` | Titolo di una sezione informativa. |
| Qty. | Qtà | `corpus/flat/Addon.json#Addon#618:target` | Abbreviazione dell'etichetta «Quantity». |
| Collectability | Collezionabilità | `corpus/flat/Addon.json#Addon#1056:target` | Statistica usata nel sistema di raccolta. |
| Default | Predefinito | `corpus/flat/Addon.json#Addon#1217:target` | Valore predefinito nelle opzioni. |
| Category | Categoria | `corpus/flat/Addon.json#Addon#612:target` | Etichetta di categoria nell'interfaccia. |
| Requirements | Requisiti | `corpus/flat/Addon.json#Addon#992:target` | Titolo di una sezione informativa. |
| Rewards | Ricompense | `corpus/flat/DescriptionString.json#DescriptionString#582:target` | Titolo di una sezione informativa. |
| Leave | Abbandona | `corpus/flat/Addon.json#Addon#2508:target` | Comando per lasciare un gruppo o un'attività. |
| Proceed | Procedi | `corpus/flat/Addon.json#Addon#924:target` | Comando o pulsante di conferma.  Varianti ammesse in prosa: «Procedere». |
| Remove | Rimuovi | `corpus/flat/Addon.json#Addon#85:target` | Comando per rimuovere un elemento. |
| Edit | Modifica | `corpus/flat/Addon.json#Addon#442:target` | Comando per modificare un elemento. |
| Class/Job | Classe/Job | `corpus/flat/Addon.json#Addon#315:target` | Etichetta d'interfaccia; mantenere «Job» secondo la voce canonica. |
| Combo Weaponskills / Combo Spells | Combo Tecniche / Combo Incantesimi | Decisione dell'utente | Etichette delle categorie di combo: usare le forme compatte senza «di» per rispettare lo spazio disponibile nella UI. Riferimenti: `corpus/flat/ClassJobActionUICategory.json#ClassJobActionUICategory#4.0:target`, `#ClassJobActionUICategory#5.0:target`, `corpus/flat/Addon.json#Addon#14483:target`, `#Addon#14493:target`. Non estendere automaticamente la forma alla prosa. |
| Healer | Curatore | `corpus/flat/Addon.json#Addon#1083:target` | Ruolo di classe; in prosa usare «curatore» e «curatori». |
| Normal | Normale | `corpus/flat/Status.json#Status#2204.0:target` | Stato o opzione; accordare in base al sostantivo in contesto. |

### Sistemi e funzioni ricorrenti

| Inglese | Italiano | Fonte | Uso |
| --- | --- | --- | --- |
| Cryptlurker | Predatore delle Cripte | Decisione dell'utente | Set di equipaggiamento di Shadowbringers (patch 5.4, liv. 80). Nei nomi di armi, armature, accessori e forzieri usare «del Predatore delle Cripte» (es. «Spada del Predatore delle Cripte», «Corazza del Predatore delle Cripte della Difesa», «Spada del Predatore delle Cripte Potenziata»). Calco su FR «Rôdeur des cryptes» e DE «Krypta-Schleicher». Riferimenti: `corpus/flat/Item.json#32418.9` e segg. |
| Crypt [materiali] | [della] Cripta | Decisione dell'utente | Materiali di potenziamento per equipaggiamento Cryptlurker: Crypt Ester -> Estere della Cripta, Crypt Twine -> Spago della Cripta, Crypt Dusting -> Polvere della Cripta. Riferimenti: `corpus/flat/Item.json#32156.9`, `#32157.9`, `#32158.9`. |
| Sanction (Grandi Compagnie) | Benedizione | Decisione dell'utente | Potenziamento degli equipaggiamenti delle Grandi Compagnie; sostituisce «Sanzione di Compagnia», «Sanzione» e «Patrocinio» in questo contesto. Non estendere agli attacchi omonimi di `combat/action.json` né a sanction nel senso comune di permesso. Riferimenti: `corpus/flat/Status.json#Status#245.0:target`; `corpus/flat/Item.json#Item#4636.8:target`. |
| Linkshells | Fonoreti | Decisione dell'utente | Plurale; singolare «fonorete». Mantieni /linkshell e /cwlinkshell1 nei nomi dei comandi, ma traduci linkshell quando indica la funzione di comunicazione. |
| Linkpearl(s) | fonoperla / fonoperle | Decisione dell'utente | Perla di comunicazione; distinguere da linkshell («fonorete»). Conservare `/linkpearl` soltanto come alias eseguibile. |
| Linkshell [1] | Fonorete [1] | Decisione dell'utente | Etichetta numerata; conservare il numero. |
| Cross-world Linkshells | Fonoreti Intermondo | Decisione dell'utente | Plurale; singolare «Fonorete Intermondo». Tradurre linkshell come «fonorete», non «fonoperla». |
| Cross-world Linkshell [1] | Fonorete Intermondo [1] | Decisione dell'utente | Etichetta numerata; conservare il numero. |
| Cross-world Linkshell Invites | Inviti alle Fonoreti Intermondo | Decisione dell'utente | Inviti alla funzione intermondo; al singolare «invito alla Fonorete Intermondo». |
| Cross-world Party | Gruppo Intramondo | `corpus/flat/Addon.json#Addon#10902:target` | Gruppo formato tra mondi diversi; maiuscole fisse: Gruppo Intramondo. |
| Linkshell Distributor | Distributore di Fonoreti | Decisione dell'utente | Nome del funzionario che gestisce le fonoreti. |
| Home World | Mondo d'Origine | `corpus/flat/ContentFinderConditionTransient.json#ContentFinderConditionTransient#195:target` | Mondo di appartenenza del personaggio. Varianti ammesse in prosa: «Mondo di Origine», «Mondo di Residenza». |
| World Visit | Visita Mondo | `corpus/flat/Addon.json#Addon#12510:target` | Funzione di viaggio tra mondi.  Varianti ammesse in prosa: «Visita Mondi», «Guida alla Visita Mondi». |
| Data Center | Data Center | `corpus/flat/HowToPage.json#HowToPage#2506.4:target` | Nome invariato della struttura server; variante ammessa in prosa per il termine minuscolo nell'originale: «data center».  Varianti ammesse in prosa: «centro dati», «centri dati». Varianti ammesse in prosa: «Centro Dati». |
| Housing | Alloggi | `corpus/flat/Addon.json#Addon#1999:target` | Sistema degli alloggi. Varianti ammesse in prosa: «Abitazioni», «Abitazione». |
| Glamours | Illusioni | `corpus/flat/Addon.json#Addon#16030:target` | Nome della funzione. Varianti ammesse in prosa: «illusioni», «Illusioni» nei titoli, «Completi Pronti per l'Illusione» per gli Outfit Glamour. Singolare editoriale: «illusione». |
| Glamour Dresser | Comò delle Illusioni | `corpus/flat/Addon.json#Addon#3735:target` | Arredo delle illusioni. Varianti ammesse in prosa: «comò delle illusioni», «i comò delle illusioni». |
| Glamour Plate | Piastra d'Illusione | `corpus/flat/Addon.json#Addon#3185:target` | Piastra che memorizza un insieme di illusioni. Varianti ammesse in prosa: «piastra d'illusione», «piastre d'illusione», «Piastre d'Illusione» (etichetta del pulsante), rispettando le maiuscole richieste dalla frase. |
| Glamour Prism | Prisma delle Illusioni | `corpus/flat/Addon.json#Addon#5733:target` | Catalizzatore per applicare illusioni. Varianti ammesse in prosa: «prisma delle illusioni», «prismi delle illusioni», rispettando le maiuscole della frase. |
| Cast Glamour | Applica Illusione | `corpus/flat/Addon.json#Addon#3700:target` | Comando per applicare un'illusione. Varianti ammesse in prosa: «applicare un'illusione», «applicare l'illusione», «applicata un'illusione». Il nome del comando mantiene le maiuscole fisse: «Applica Illusione».  Varianti ammesse in prosa: «applica l'illusione». |
| Apply Glamours | Applica Illusioni | `corpus/flat/Addon.json#Addon#10583:target` | Comando al plurale con maiuscole fisse: «Applica Illusioni». Varianti ammesse in prosa: «applicare illusioni», «applicare le illusioni». |
| Glamour-ready | Pronto per l'illusione | `corpus/flat/Addon.json#Addon#5728:target` | Idoneità dell'oggetto; adattare genere e numero in prosa. |
| Outfit Glamour | Completo Illusione | `corpus/flat/Addon.json#Addon#15644:target` | Insieme di oggetti registrato come illusione. Varianti ammesse in prosa: «completi pronti per l'illusione», «completo pronto per l'illusione», «Completi Pronti per l'Illusione», «Completo Pronto per l'Illusione». |
| Furnishing Glamours | Illusioni d'Arredo | `corpus/flat/Addon.json#Addon#15533:target` | Aspetti alternativi degli arredi. Varianti ammesse in prosa: «illusioni d'arredo», «Glamour degli Arredi»; mantenere le minuscole nel testo corrente.  Varianti ammesse in prosa: «illusione d'arredo». |
| Registered Glamours | Illusioni Registrate | `corpus/flat/Addon.json#Addon#15528:target` | Nome dell'elenco delle illusioni d'arredo registrate. Varianti ammesse in prosa: «Illusioni Registrate» per l'etichetta, «illusioni registrate» in prosa. |
| Placed Glamours | Illusioni Posizionate | `corpus/flat/Addon.json#Addon#15539:target` | Illusioni d'arredo già posizionate.  Varianti ammesse in prosa: «illusione d'arredo è attualmente posizionata sulla tua isola». |
| Register Glamour | Registra Illusione | `corpus/flat/Addon.json#Addon#15525:target` | Registra l'aspetto alternativo di un arredo. |
| Place Glamour | Posiziona Illusione | `corpus/flat/Addon.json#Addon#15564:target` | Posiziona un'illusione d'arredo. |
| Store as Glamour | Conserva come Illusione | `corpus/flat/Addon.json#Addon#15622:target` | Salva un oggetto come illusione. |
| Armoire | Armadio | `corpus/flat/Addon.json#Addon#3734:target` | Arredo di deposito. |
| Retainer | Servitore | `corpus/flat/Addon.json#Addon#532:target` | Aiutante del personaggio; in prosa minuscolo. |
| Venture (valuta dei servitori) | Gettone/i di spedizione | Decisione dell'utente | Valuta con cui si pagano le spedizioni dei servitori; al plurale «gettoni di spedizione». Distinguere dall'incarico del servitore, che in contesto è una «spedizione». Riferimenti main: `custom/000/CmnDefRetainerCall_00010#CURRENCY_CHANGE1`; `HowToPage#1601.4`. |
| Venture promissory note(s) | pagherò per spedizioni | Decisione dell'utente | Pagherò riscattabile in cambio di gettoni di spedizione; usare «pagherò per spedizioni» al singolare e al plurale. Riferimenti main: `Item#7796.0/.8/.9`; `custom/000/CmnDefRetainerCall_00010#CURRENCY_CHANGE1`. |
| Materia Melding | Innesto Materia | `corpus/flat/Addon.json#Addon#993:target` | Funzione per innestare materia. Variante ammessa in prosa: «Innesto della Materia». |
| Desynthesis | Desintesi | `corpus/flat/Addon.json#Addon#1815:target` | Funzione di smontaggio degli oggetti. |
| Aetherial Reduction | Riduzione Eterea | `corpus/flat/Addon.json#Addon#2160:target` | Funzione di riduzione; varianti ammesse in prosa: «riduzione eterea», «Riduzione Eterica», «la riduzione eterea», «riduzioni eteree». |
| Item Dyeing | Tintura Oggetti | `corpus/flat/Addon.json#Addon#4690:target` | Funzione di tintura dell'equipaggiamento; varianti ammesse in prosa: «tintura degli oggetti», «finestra di tintura degli oggetti». |
| Custom Deliveries | Consegne Personalizzate | `corpus/flat/NotebookDivisionCategory.json#NotebookDivisionCategory#6:target` | Attività ricorrente; varianti ammesse in prosa: «Consegne su Misura». |
| Custom Deliveries | Consegne su Misura | `corpus/flat/PlaceName.json#PlaceName#1298.0:target` | Forma approvata per l'etichetta nel catalogo dei luoghi; variante della funzione «Consegne Personalizzate». |
| Wondrous Tails | Code Meravigliose | `corpus/flat/Addon.json#Addon#5600:target` | Registro di attività. |
| Portraits | Ritratti | `corpus/flat/Addon.json#Addon#14650:target` | Funzione del personaggio. |
| Actions & Traits | Azioni e Tratti | `corpus/flat/MainCommand.json#MainCommand#3.5:target` | Menu del personaggio. |
| Blacklist | Lista Nera | `corpus/flat/MainCommand.json#MainCommand#14.5:target` | Elenco di giocatori bloccati. |
| Character Configuration | Configurazione Personaggio | `corpus/flat/MainCommand.json#MainCommand#34.5:target` | Menu delle impostazioni; varianti ammesse in prosa: «configurazione del personaggio», «Configurazione del Personaggio», «impostazioni del personaggio».  Varianti ammesse in prosa: «configurazione attuale del tuo personaggio». Varianti ammesse in prosa: «impostazioni del Client e del personaggio». |
| Collection | Collezione | `corpus/flat/MainCommand.json#MainCommand#87.5:target` | Menu della collezione. |
| Companion | Compagno | `corpus/flat/MainCommand.json#MainCommand#42.5:target` | Funzione del compagno e nome del compagno da battaglia; decisione dell'utente. Distinguere dai minion, che restano in inglese. |
| Contacts | Giocatori Recenti | `corpus/flat/MainCommand.json#MainCommand#74.5:target` | Elenco dei contatti recenti. |
| Countdown | Conto alla Rovescia | `corpus/flat/MainCommand.json#MainCommand#73.5:target` | Funzione del gruppo. |
| Emotes | Emote | `corpus/flat/MainCommand.json#MainCommand#17.5:target` | Categoria di azioni sociali. |
| Fashion Accessories | Accessori di Moda | `corpus/flat/MainCommand.json#MainCommand#89.5:target` | Collezione di accessori. Varianti ammesse in prosa: «accessorio di moda», «accessori di moda», rispettando le maiuscole della frase. |
| Friend List | Lista Amici | `corpus/flat/MainCommand.json#MainCommand#13.5:target` | Elenco sociale. |
| HUD Layout | Disposizione HUD | `corpus/flat/MainCommand.json#MainCommand#22.5:target` | Funzione di disposizione dell'interfaccia. Varianti ammesse in prosa: «disposizione dell'HUD», «disposizione HUD», «disposizione speciale dell'HUD», «disposizione delle barre azioni nell'HUD», «disposizione e dimensione dell'HUD», «layout HUD», «editor del layout HUD».  Varianti ammesse in prosa: «layout dell'HUD corrente». Varianti ammesse in prosa: «disposizione predefinita dell'HUD». |
| Key Items | Oggetti Chiave | `corpus/flat/MainCommand.json#MainCommand#11.5:target` | Categoria di inventario; varianti ammesse in prosa: «oggetti chiave», «scheda Oggetti chiave». |
| Keybind | Assegnazione Tasti | `corpus/flat/MainCommand.json#MainCommand#20.5:target` | Configurazione dei comandi. |
| Mount Speed | Velocità Cavalcatura | `corpus/flat/MainCommand.json#MainCommand#75.5:target` | Funzione delle cavalcature; varianti ammesse in prosa: «velocità della cavalcatura», «velocità delle cavalcature», «quella della cavalcatura», «Velocità Cavalcature Terrestri», «velocità delle cavalcature terrestri». |
| Mute List | Lista Silenziati | `corpus/flat/MainCommand.json#MainCommand#96.5:target` | Nome del menu. Maiuscole fisse: «Lista Silenziati». Varianti ammesse in prosa: «lista dei personaggi silenziati».  Varianti ammesse in prosa: «elenco dei personaggi silenziati». |
| Player Search | Ricerca Giocatori | `corpus/flat/MainCommand.json#MainCommand#15.5:target` | Ricerca di altri giocatori. |
| System Configuration | Configurazione di Sistema | `corpus/flat/HowToPage.json#HowToPage#21.4:target` | Menu delle impostazioni.  Varianti ammesse in prosa: «configurazione del sistema». |
| User Macros | Macro Utente | `corpus/flat/HowToPage.json#HowToPage#82.4:target` | Funzione delle macro.  Varianti ammesse in prosa: «macro personali». |
| Accessibility Settings | Impostazioni Accessibilità | `corpus/flat/MainCommand.json#MainCommand#63.5:target` | Impostazioni di accessibilità. |
| Graphics Settings | Impostazioni Grafiche | `corpus/flat/MainCommand.json#MainCommand#47.5:target` | Impostazioni video.  Varianti ammesse in prosa: «parametri di rendering grafico». |
| Sound Settings | Impostazioni Audio | `corpus/flat/MainCommand.json#MainCommand#46.5:target` | Impostazioni audio.  Varianti ammesse in prosa: «impostazioni sonore», «volumi sonori». |
| UI Settings | Impostazioni Interfaccia | `corpus/flat/MainCommand.json#MainCommand#52.5:target` | Impostazioni dell'interfaccia. Varianti ammesse in prosa: «Impostazioni UI», «interfaccia di gioco», «parametri dell'interfaccia grafica», «impostazioni dell'interfaccia utente». |
| Item Settings | Impostazioni Oggetti | `corpus/flat/MainCommand.json#MainCommand#71.5:target` | Impostazioni degli oggetti. |
| Mouse Settings | Impostazioni Mouse | `corpus/flat/MainCommand.json#MainCommand#48.5:target` | Impostazioni del mouse. Varianti ammesse in prosa: «impostazioni di [dispositivo] e del mouse», «impostazioni Tastiera/Mouse», «parametri del puntatore del mouse» quando il dispositivo è indicato dal tag dinamico. |
| Theme Settings | Impostazioni Tema | `corpus/flat/MainCommand.json#MainCommand#83.5:target` | Impostazioni grafiche. |
| Configuration Sharing | Condivisione Configurazione | `corpus/flat/MainCommand.json#MainCommand#99.5:target` | Condivisione delle impostazioni; varianti ammesse in prosa: «condivisione della configurazione». |
| Party Members | Membri del Gruppo | `corpus/flat/MainCommand.json#MainCommand#12.5:target` | Nome dell'elenco. Varianti ammesse in prosa: «membro del gruppo», «membri del gruppo», «membri vicini del gruppo», «membri del suo gruppo», «membri», «altri membri», «tutti i membri», «compagni di squadra», «tutto il gruppo», «il gruppo», «gruppo prefissato», «gruppo abbinato», «gruppo di massimo quattro giocatori», «gruppi da uno a quattro giocatori», «gruppo in anticipo», «con il gruppo», «in gruppo», «menu del gruppo», «nessun membro nel gruppo», «membri nel gruppo», «altri membri nel gruppo», «membri per il gruppo» (quando il riferimento al gruppo è chiaro).  Varianti ammesse in prosa: «Membri del party». |
| Sanctuary Crafting Log | Registro di Fabbricazione del Rifugio Insulare | `corpus/flat/Addon.json#Addon#14259:target` | Nome del registro di fabbricazione del Rifugio Insulare; variante in prosa: «registro di fabbricazione del Rifugio Insulare». |
| Sanctuary Gathering Log | Registro di Raccolta del Rifugio Insulare | `corpus/flat/Addon.json#Addon#14260:target` | Nome del registro di raccolta del Rifugio Insulare; varianti ammesse in prosa: «registro di raccolta del Rifugio Insulare». |
| Currency | Valute | `corpus/flat/MainCommand.json#MainCommand#66.5:target` | Nome del menu; altre etichette usano il singolare «Valuta». |
| Currency | Valuta | `corpus/flat/ItemUICategory.json#ItemUICategory#100:target` | Forma singolare usata nelle etichette. |


| Lost Finds Cache | Deposito dei Reperti Perduti | `corpus/flat/AddonTransient.json#AddonTransient#350:target` | Deposito delle azioni perdute del Fronte Meridionale di Bozja. |
### Termini di gioco

| Inglese | Italiano | Fonte | Uso |
| --- | --- | --- | --- |
| Cryptlurker | Predatore delle Cripte | Decisione dell'utente | Set di equipaggiamento di Shadowbringers (patch 5.4, liv. 80). Nei nomi di armi, armature, accessori e forzieri usare «del Predatore delle Cripte» (es. «Spada del Predatore delle Cripte», «Corazza del Predatore delle Cripte della Difesa», «Spada del Predatore delle Cripte Potenziata»). Calco su FR «Rôdeur des cryptes» e DE «Krypta-Schleicher». Riferimenti: `corpus/flat/Item.json#32418.9` e segg. |
| Crypt [materiali] | [della] Cripta | Decisione dell'utente | Materiali di potenziamento per equipaggiamento Cryptlurker: Crypt Ester -> Estere della Cripta, Crypt Twine -> Spago della Cripta, Crypt Dusting -> Polvere della Cripta. Riferimenti: `corpus/flat/Item.json#32156.9`, `#32157.9`, `#32158.9`. |
| Free Company | Compagnia Libera | `corpus/flat/HowToPage.json#HowToPage#1760.4:target` | Varianti ammesse in prosa: «Compagnia Libera», «compagnia libera», «compagnie libere» quando il riferimento indica la stessa organizzazione.  Varianti ammesse in prosa: «Compagnie Libere». |
| Company Actions | Azioni della Compagnia | Decisione dell'utente | Funzione delle Compagnie Libere; nel menu associato, Actions → «Azioni». In `HowToPage#490.4`, statuses è reso «parametri». Riferimento: `corpus/flat/HowToPage.json#490.4`. |
| Ward (residential) | Quartiere | Decisione dell'utente | Settore di un distretto residenziale; in prosa e nelle etichette usare «quartiere». Non estendere a ward come barriera o protezione. Riferimento: `corpus/flat/HowToPage.json#1351.4`. |
| Grand Company | Grande Compagnia | `corpus/flat/Addon.json#Addon#337:target` | Varianti ammesse in prosa: «Grandi Compagnie». |
| Subleader | Vice | `corpus/flat/Addon.json#Addon#11771:target` | Ruolo nella squadra PvP; in prosa minuscolo «vice». |
| Subleaders | Vice | `corpus/flat/Addon.json#Addon#11819:target` | Plurale invariabile; in prosa «i vice». |
| Aetheryte | Eterite | `corpus/flat/Addon.json#Addon#8511:target` | Nome comune della struttura; distinto dai toponimi omonimi. |
| Aetherial node(s) | Nodo Eterico / Nodi Eterici | Decisione dell'utente | Nome comune dei nodi eterici; in prosa usare la minuscola e accordare singolare/plurale. Riferimenti: `corpus/flat/PublicContentTextData.json#PublicContentTextData#2134:target`; `corpus/flat/EObjName.json#EObjName#2009727.0:target`. |
| Keystone (rite of succession) | Pietrachiave | Decisione dell'utente | Nome delle sette pietre ottenute dagli elettori nel rito di successione; scrivere una parola: «pietrachiave» al singolare e «pietrachiavi» al plurale. Non estendere a chiavi di volta architettoniche, alle pietre del Palazzo del Viandante o agli usi figurati. Riferimenti: `corpus/flat/KTGTypeWordTextData.json#KTGTypeWordTextData#1685:target`; `corpus/flat/EObjName.json#EObjName#2005518.0:target`. |
| proto-aetheryte | protoeterite | Decisione dell'utente | Nome comune dell'apparato antico di Eureka; in prosa minuscolo. Sostituisce «proto-eterite» ed «etereporto prototipo». Riferimento: `corpus/flat/ContentFinderConditionTransient.json#ContentFinderConditionTransient#598:target`. |
| Crystal Forge | Forgia di Cristallo | Decisione dell'utente | Nome dell'apparato usato nelle spedizioni Eureka; al plurale «Forge di Cristallo». Versione migliorata: «Forgia di Cristallo Mark II». Riferimenti: `corpus/flat/CustomTalk.json#CustomTalk#721389.65:target`; `corpus/flat/EObjName.json#EObjName#2009555.0:target`. |
| Logos Manipulator | Sintetizzatore Logos | Decisione dell'utente | Nome del dispositivo che estrae e trasmuta i mnemi dai logogrammi; nei richiami abbreviati allo stesso dispositivo usare «Sintetizzatore». Riferimenti: `corpus/flat/CustomTalk.json#CustomTalk#721411.65:target`; `corpus/flat/Addon.json#Addon#11640:target`. |
| Aetherpool | Eterico | Decisione dell'utente | Controllo automatico: residuo. Aggettivo da accordare al sostantivo: «arma/armatura/impugnatura eterica», «armi/armature/impugnature eteriche», «equipaggiamento/vetro/frammento eterico», «frammenti/scudi eterici». Eliminare «di aetherpool» quando diventa un aggettivo; adeguare articoli e altri aggettivi. Maiuscole secondo il campo sorgente e la funzione, minuscolo in prosa. Sostituisce anche le precedenti rese «etereo/eterea» e «della riserva eterea» riferite ad aetherpool; non modificare gli altri usi di etereo né sorgenti, identificatori o tag. Varianti ammesse in prosa: «eterica», «eterici», «eteriche». |
| Vitiated Aether | Etere corrotto | Decisione dell'utente | Flusso energetico delle spedizioni Eureka; in prosa usare la minuscola. Riferimenti: `corpus/flat/PublicContentTextData.json#PublicContentTextData#2001:target`; `corpus/flat/LogMessage.json#LogMessage#3741:target`. |
| Scrip | Gettone | Decisione dell'utente | Valuta degli Artigiani e dei Raccoglitori; al plurale usare «Gettoni degli Artigiani/dei Raccoglitori». |
| Society (Triple Triad) | Società | `corpus/flat/TripleTriadCardType.json#TripleTriadCardType#3:target` | Tipo di carta Triple Triad; non applicare al nome comune «società» o a «tribù» come gruppo di persone. |
| Variant Dungeons | Spedizioni Varianti | Decisione dell'utente | Nome della categoria di contenuti; in prosa usare «spedizione variante» e «spedizioni varianti». Riferimenti: `corpus/flat/AddonTransient.json#AddonTransient#1052:target`; `corpus/flat/ContentsTutorial.json#ContentsTutorial#3.9:target`. |
| Tankbuster | Colpo Devastante | Decisione dell'utente | Nome della meccanica di attacco ad alto danno rivolta al difensore; usare questa resa nelle etichette, adattando articoli e accordi in prosa. |
| Enmity | ostilità | Decisione dell'utente | Resa della meccanica di aggro e delle occorrenze narrative. In prosa usare la minuscola e accordare articoli e preposizioni («l'ostilità», «dell'ostilità»); la maiuscola si usa a inizio frase e nelle etichette o nei titoli. Sostituisce «inimicizia», «astio» e «minaccia» quando traducono questo termine. Riferimenti: `corpus/flat/ActionTransient.json#ActionTransient#11:target`; `corpus/flat/DescriptionString.json#DescriptionString#1106:target`. |
| Instinctual Skill | Azione Istintiva | Decisione dell'utente | Termine di gioco del Domatore e dei famigli. Plurale: «Azioni Istintive». In prosa usare «azione istintiva / azioni istintive», rispettando le maiuscole dell'originale; sostituisce «abilità istintiva/istintuale» e «tecnica istintiva». Riferimento: `corpus/flat/XBMItem.json#XBMItem#19.12:target`. Non estendere questa resa a ogni occorrenza di skill: identifica prima la categoria di azione nel contesto. |
| Simular | Simulacro | Decisione dell'utente | Categoria di mangime; nei nomi composti usare «Simulacro di [ingrediente]» e al plurale «Simulacri di [ingrediente]». |
| EXP | ESP | Decisione dell'utente | Controllo automatico: residuo. Sigla italiana dei punti esperienza; usare «ESP» nelle etichette e descrizioni (es. «Bonus ESP»). Riferimento: `corpus/flat/Item.json#Item#2632.8:target`. |
| Rolanberry | Rolanbacca | Decisione dell'utente | Controllo automatico: residuo. Nome del frutto e ingrediente, femminile: «la Rolanbacca», «della Rolanbacca». Nei nomi di ricette usare la forma idiomatica «alle Rolanbacche»; accordare articoli e aggettivi al femminile plurale (es. «le Rolanbacche essiccate e aspre»). Eccezione: «Rolanberry Field» è il nome proprio «Campo di Rolanbacche»; «Rolanberry children» indica i bambini del campo, non i frutti. Riferimento: `corpus/flat/Item.json#Item#4815.0:target`. |
| Rolanberries | Rolanbacche | Decisione dell'utente | Controllo automatico: residuo plurale. Plurale femminile: «le/delle/alle Rolanbacche»; concordare gli aggettivi (es. «Rolanbacche essiccate e aspre»). Riferimento: `corpus/flat/Item.json#Item#4815.2:target`. |
| Rolanberry Red | Rosso Rolan | `data/translations/items/stain.json#9:translation_name/#9:translation_description` | Nome della tonalità; nel nome dell'oggetto usare «Tintura Rosso Rolan», senza interpretare Rolanberry come frutto. |
| Minotaur Malm | Il Malm del Minotauro / Malm del Minotauro | `world/placename.json#322:name` | Nome proprio della località; mantenere «Malm» anche nei composti (es. `world/placename.json#470:name`). |
| Claret Dragon | Drago Cremisi | Decisione dell'utente | Nome della creatura; nel composto «Claret Dragon's Power» usare «Potere del Drago Cremisi». |
| Scion of the Seventh Dawn | Erede della Settima Alba | `corpus/flat/CompanionTransient.json#CompanionTransient#91.1:target` | Nome invariabile per genere: al singolare «Erede della Settima Alba», al plurale «Eredi della Settima Alba». |
| Scion | Erede | Decisione dell'utente | Forma singolare; «Erede» non varia per genere. |
| Scions | Eredi | Decisione dell'utente | Forma plurale; per il gruppo usare «Eredi della Settima Alba». |
| Delineation | Compendio | `corpus/flat/CraftAction.json#CraftAction#100179.1:target` | Risorsa consumata dalle Azioni da Specialista; usare «Compendio di [disciplina]» e, per «Crafter's Delineation», «Compendio dell'Artigiano». |
| Light-heavyweight | Pesi Leggeri | Decisione dell'utente | Categoria di peso AAC M1–M4. |
| Cruiserweight | Pesi Medi | Decisione dell'utente | Categoria di peso AAC M1–M4. |
| Heavyweight | Pesi Massimi | Decisione dell'utente | Categoria di peso AAC M1–M4. |
| Ultimate raid | Incursione Suprema | Decisione dell'utente | «Suprema» è la resa della modalità Ultimate. |
| Savage | Selvaggio | Decisione dell'utente | Resa della modalità di difficoltà Savage (es. «(Selvaggio)» nelle istanze raid e trial). |
| Doman | Domano / Domana | Decisione dell'utente | Aggettivo riferito a Doma, da accordare per genere (es. «Mahjong Domano», «Ricostruzione dell'Enclave Domana»). Per gli abitanti, plurale «i Domani» (attestazione: `dialogue/balloon.json#16576:translation`). |
| Doman Adventurers' Guild | Gilda degli Avventurieri di Doma | Decisione dell'utente | Nome dell'organizzazione; non usare «Gilda degli Avventurieri Domani». Riferimenti: `da_tradurre/quests/arr/001/SubLak003_00100.json#1:translation`; `da_tradurre/quests/arr/001/SubLak003_00100.json#126:translation`; `corpus/flat/DefaultTalk.json#DefaultTalk#594797.20:target`; `corpus/custom/005/CtsDomReconstructIhase_00527.json#custom/005/CtsDomReconstructIhase_00527#TEXT_CTSDOMRECONSTRUCTIHASE_00527_YOUZAN_000_069:target`. |
| Blunderful | Blunderful | Decisione dell'utente | Nome ufficiale della cornice Fall Guys; lasciare in inglese. |
| Blunderous | Blunderous | Decisione dell'utente | Nome ufficiale della cornice Fall Guys; lasciare in inglese. |
| Blunder-villed | Blunder-villed | Decisione dell'utente | Nome ufficiale della cornice Fall Guys; lasciare in inglese. |
| The Black Shroud | Velo Nero | `corpus/flat/Addon.json#Addon#1578:target` | Nome dell'area. Genere grammaticale maschile: usare «il Velo Nero», «del Velo Nero», «nel Velo Nero». Vietato categoricamente l'uso di articoli o preposizioni femminili («la Velo Nero», «della Velo Nero», «nella Velo Nero»). Eccezione: in `TextCommand#153.7` il nome resta in inglese perché è un valore letterale di ricerca accettato dal comando e la memoria legacy lo conserva. |
| Airship | Aeronave | Decisione dell'utente | Controllo automatico: residuo plurale. Plurale inglese: «Airships» → «Aeronavi». |
| Mount | Cavalcatura | `corpus/flat/Addon.json#Addon#774:target` | Nome della cavalcatura; distinto dalle azioni «Monta» e «Pilota». |
| Achievement | Obiettivo | `corpus/flat/Addon.json#Addon#1484:target` | Per la categoria di gioco usare «Obiettivo» al singolare e «Obiettivi» al plurale; accordare gli articoli («gli obiettivi», «degli obiettivi»). In prosa, il termine resta minuscolo. |
| Quest | Missione | `corpus/flat/Addon.json#Addon#12723:target` | Categoria generale, singolare. |
| Job Gauge | Barra Job | `corpus/flat/GuideTitle.json#GuideTitle#1.0:target` | Nome dell'indicatore per il Job; varianti ammesse in prosa: «Indicatore Job».  Varianti ammesse in prosa: «indicatore Job». |
| Addersgall Gauge | Barra dell'Umore | Decisione dell'utente | Barra Job del Saggio; mantenere «Addersgall» quando si parla della risorsa accumulata. |
| Retainer | Retainer | `corpus/flat/Addon.json#Addon#12580:target` | Termine conservato in una specifica etichetta. |
| Mount | Monta | `corpus/flat/Addon.json#Addon#4964:target` | Azione contestuale. |
| Mount | Pilota | `corpus/flat/Addon.json#Addon#11382:target` | Azione contestuale. |
| Weaponskills | Tecniche | `corpus/flat/Addon.json#Addon#14484:target` | Categoria di azione; singolare: «tecnica». Nelle descrizioni tecniche è attestato anche «tecniche d'arma» (`corpus/flat/Status.json#Status#1346.1:target`). Non confondere con abilità, incantesimi o azioni istintive. |
| Byregot's Strike | Colpo di Byregot | `corpus/flat/Action.json#Action#29029:target` | Nome di un'azione; «strike» qui significa colpo, non sciopero. |
| Byregot's Strike | Il Colpo di Byregot | `data/translations/world/placename.json#324:translation` | Forma autonoma del toponimo. |
| Air Raid | Incursione Aerea | `corpus/flat/Action.json#Action#6602:target` | Nome di un'azione; «raid» qui è reso come «incursione». |
| Formation: Air Raid | Formazione: Incursione Aerea | `corpus/flat/Action.json#Action#20400:target` | Nome di un'azione. |
| Call Strategic Raid | Chiama Incursione Strategica | `corpus/flat/Action.json#Action#24578:target` | Nome di un'azione. |
| Hair Raid | Incursione dei Capelli | `corpus/flat/Action.json#Action#30076:target` | Nome di un'azione; stessa resa per le varianti dello stesso nome. |
| Morrowmotes | Soffio d'Aurora | `corpus/flat/Action.json#Action#4026:target` | Nome di un'azione. |
| Morrowmotes | Soffio d'Aurora | `world/placename.json#2156:name` | Nome di luogo; stessa resa del nome dell'azione. |
| Dungeon Siege | Assedio Sotterraneo | `corpus/flat/Achievement.json#Achievement#742.1:target` | Nome della serie di obiettivi; mantiene il numero romano. |
| Dungeon Master | Signore del Sotterraneo | `corpus/flat/Achievement.json#Achievement#746.1:target` | Nome di un obiettivo. |
| Dungeon Master | Signora del Sotterraneo | `world/title.json#109:description` | Forma femminile del titolo; accordo di genere. |
| HP | PV | `corpus/flat/Addon.json#Addon#232:target` | Sigla conservata in un'etichetta. |
| MP | PM | `corpus/flat/Addon.json#Addon#233:target` | Sigla conservata in un'etichetta. |


| Maelstrom Command | Comando della Tempesta | `corpus/flat/ContentFinderConditionTransient.json#ContentFinderConditionTransient#40:target` | Nome del luogo o della struttura. |
| Dosis | Dosis | Decisione dell'utente | Nome dell'incantesimo del saggio (greco antico intatto); mantenere invariato anche nelle varianti Dosis II, Dosis III e Dosis Eukrasica (II/III), comprese le azioni dei PNG e i riferimenti nei payload SeString. Non alterare il sostantivo italiano comune «dosi». Riferimenti: `corpus/flat/Action.json#Action#24283:target`; `corpus/flat/ActionTransient.json#ActionTransient#24290:target`. |
| Cure | Energia | Decisione dell'utente | Magia bianca di recupero, canone ufficiale Square Enix Italia; anche nelle forme Energia II ed Energia III. Riferimenti: `corpus/flat/Action.json#Action#120:target`. |
| Haste | Haste | Decisione dell'utente | Nome proprio dell'incantesimo e dello status di velocità, canone ufficiale Square Enix Italia. Distinto dall'attributo BaseParam#47.1 («Rapidità»), confermato dall'utente l'11 novembre 2026. Riferimenti: `corpus/flat/Action.json#Action#309:target`; `corpus/flat/Status.json#Status#8.0:target`. |
| Berserk | Berserk | Decisione dell'utente | Nome dell'abilità e dello status, canone ufficiale Square Enix Italia; non usare la parafrasi «Furia Berserker». Riferimenti: `corpus/flat/Action.json#Action#38:target`; `corpus/flat/Status.json#Status#86.0:target`. |
| Flare | Flare | Decisione dell'utente | Nome della magia nera, canone ufficiale moderno Square Enix Italia; anche nei composti Flare Doloroso, Flare Mortale, Flare Solare, Flare Astrale. Eccezione RDM confermata: «Verfusione». Riferimenti: `corpus/flat/Action.json#Action#162:target`. |
| Requiescat | Requiescat | Decisione dell'utente | Nome liturgico dell'azione del Paladino, da mantenere in latino (coerente con Confiteor e Imperator). Riferimenti: `corpus/flat/Action.json#Action#7383:target`. |
| Unmend | Squarcio Oscuro | Decisione dell'utente | Azione magica a distanza del Cavaliere Oscuro; sostituisce il calco «Disfare». Riferimenti: `corpus/flat/Action.json#Action#3624:target`. |
| Scathe | Collasso | Decisione dell'utente | Magia nera istantanea di distruzione caotica (JP: コラプス / Collapse); sostituisce «Graffio». Riferimenti: `corpus/flat/Action.json#Action#156:target`. |
| Broil | Fulgore | Decisione dell'utente | Incantesimo offensivo dello Studioso, anche nelle forme Fulgore II, III, IV e nei relativi tratti «Maestria del Fulgore I-IV»; sostituisce «Scottatura». Riferimenti: `corpus/flat/Action.json#Action#3584:target`. |
| Malefic | Maleficio | Decisione dell'utente | Incantesimo astrologico tolemaico dell'Astrologo, contrapposto a Beneficio; anche nelle forme Maleficio II, III, IV, Maleficio Calante e nei tratti «Maestria del Maleficio I-IV». Riferimenti: `corpus/flat/Action.json#Action#3596:target`. |
| Bad Breath | Alito Cattivo | Decisione dell'utente | Attacco iconico del Malboro, canone storico Square Enix Italia; sostituisce l'inversione «Cattivo Alito». Riferimenti: `corpus/flat/Action.json#Action#604:target`. |
| Megaflare | Megaflare | Decisione dell'utente | Attacco supremo di Bahamut e dei draghi, canone storico Square Enix Italia; anche per Gigaflare, Teraflare ed Exaflare. Riferimenti: `corpus/flat/Action.json#Action#2023:target`. |
| Zantetsuken | Zantetsuken | Decisione dell'utente | Fendente millenario di Odino, da mantenere in romaji (giapponese intatto, coerente con Shin-Zantetsuken); sostituisce «Lama Che Fende il Ferro». Riferimenti: `corpus/flat/Action.json#Action#780:target`. |
| Mighty Guard | Difesa Totale | Decisione dell'utente | Barriera/Magia Blu canonica dei mostri di Final Fantasy; sostituisce «Guardia Possente». Riferimenti: `corpus/flat/Action.json#Action#11417:target`; `corpus/flat/Status.json#Status#1719.0:target`. |
| Blaster | Scarica Paralizzante | Decisione dell'utente | Attacco elettrico paralizzante degli iaguari; sostituisce «Spara-Proiettili». Riferimenti: `corpus/flat/Action.json#Action#353:target`. |
| Big Bang | Esplosione Primordiale | Decisione dell'utente | Attacco cosmico di Proto-Ultima e Neo Exdeath; sostituisce «Grande Scoppio». Riferimenti: `corpus/flat/Action.json#Action#12633:target`; `corpus/flat/Status.json#Status#3760.0:target`. |
| Tank Purge | Spurgo Energetico | Decisione dell'utente | Attacco ad area devastante dell'Ultima Weapon; sostituisce «Spurgo del Serbatoio». Riferimenti: `corpus/flat/Action.json#Action#1190:target`. |
| Hyperdrive | Ipercarica | Decisione dell'utente | Attacco tankbuster devastante di Kefka e dei boss magitek; sostituisce «Iperguida». Riferimenti: `corpus/flat/Action.json#Action#10472:target`. |
| Worse Breath | Alito Pestilenziale | Decisione dell'utente | Variante potenziata di Alito Cattivo del Grande Malboro; sostituisce «Peggiore Respiro». Riferimenti: `corpus/flat/Action.json#Action#16951:target`. |
| Summon Alexander | Evoca Alexander | Decisione dell'utente | Evocazione primordiale di Alexander; sostituisce «Convoca Alessandro». Riferimenti: `corpus/flat/Action.json#Action#6666:target`. |
| Summon Icicle | Evoca Stalattite | Decisione dell'utente | Evocazione delle stalattiti di ghiaccio di Shiva; sostituisce «Evoca Ghiacciolo». Riferimenti: `corpus/flat/Action.json#Action#8095:target`. |
| Aqua Breath | Idrorespiro | Decisione dell'utente | Magia Blu/attacco acquatico iconico; sostituisce «Respiro Acquatico». Riferimenti: `corpus/flat/Action.json#Action#21751:target`. |
| Diamondback | Guscio di Diamante | Decisione dell'utente | Magia Blu difensiva corazzata; sostituisce «Dorso di Diamante». Riferimenti: `corpus/flat/Action.json#Action#32431:target`; `corpus/flat/Status.json#Status#1722.0:target`. |
| Hydro Pull | Vortice Idrico | Decisione dell'utente | Magia Blu di attrazione dei nemici; sostituisce il calco «Tiro Idrico». Riferimenti: `corpus/flat/Action.json#Action#23282:target`. |
| Peat Pelt | Getto di Torba | Decisione dell'utente | Magia Blu di lancio della torba; sostituisce il calco errato «Mantello di Torba». Riferimenti: `corpus/flat/Action.json#Action#34569:target`. |
| Revenge Blast | Ritorsione | Decisione dell'utente | Magia Blu di contrattacco; sostituisce «Esplosione di Vendetta». Riferimenti: `corpus/flat/Action.json#Action#18316:target`. |
| Kaltstrahl | Kaltstrahl | Decisione dell'utente | Termine proprio tedesco dell'attacco tecnologico dei goblin; mantenere intatto, coerente con Zantetsuken. Riferimenti: `corpus/flat/Action.json#Action#18299:target`. |
| Salted Earth | Terra Maledetta | Decisione dell'utente | Abilità del Cavaliere Oscuro (maledizione sterile della terra); sostituisce l'inversione semantica «Terra Consacrata». Riferimenti: `corpus/flat/Action.json#Action#3632:target`; `corpus/flat/Status.json#Status#749.0:target`. |
| Second Wind | Secondo Respiro | Decisione dell'utente | Azione di ruolo di recupero rapido del fiato; sostituisce il calco «Secondo Vento». Riferimenti: `corpus/flat/Action.json#Action#57:target`; `corpus/flat/Trait.json#Trait#642:target`. |
| True North | Bussola Interiore | Decisione dell'utente | Azione di ruolo marziale che annulla i requisiti posizionali; sostituisce il calco «Nord Vero». Riferimenti: `corpus/flat/Action.json#Action#7546:target`; `corpus/flat/Status.json#Status#1250.0:target`. |
| Pyretic Booster | Potenziatore Piretico | `corpus/flat/InstanceContentTextData.json#InstanceContentTextData#25211:target` | Potenziamento offensivo del G-Warrior; conserva le maiuscole quando indica il nome dell'azione. |
| Rough Divide | Squarcio Brusco | Decisione dell'utente | Assalto rapido con fendente del Gunbreaker; sostituisce il calco «Divisione Brusca». Riferimenti: `corpus/flat/Action.json#Action#16152:target`. |
| Druochole | Druochole | Decisione dell'utente | Azione medica del Saggio, greco intatto coerente con le altre azioni anatomiche (Kerachole, Ixochole, Taurochole); sostituisce l'ibrido «Druocura». Riferimenti: `corpus/flat/Action.json#Action#24300:target`. |
| Aerial Blast | Raffica Aerea | Decisione dell'utente | Attacco supremo di Garuda e dei suoi Egi, canone italiano; sostituisce «Esplosione Aerea». Riferimenti: `corpus/flat/Action.json#Action#11281:target`; `corpus/flat/PetAction.json#PetAction#21.0:target`. |
| Heartless Angel | Angelo Spietato | Decisione dell'utente | Attacco supremo di Kefka e Sephiroth che riduce a 1 PV, canone storico Square Enix Italia; sostituisce «Angelo Senza Cuore». Riferimenti: `corpus/flat/Action.json#Action#10490:target`. |
| Big Crunch | Collasso Cosmico | Decisione dell'utente | Attacco supremo di Zeromus (collasso cosmico della materia); sostituisce il calco economico «Grande Crisi». Riferimenti: `corpus/flat/Action.json#Action#35588:target`. |
| Curtain Call | Cala il Sipario | Decisione dell'utente | Attacco teatrale di Amon (chiusura del sipario); sostituisce il calco telefonico «Chiamata Finale». Riferimenti: `corpus/flat/InstanceContentTextData.json#InstanceContentTextData#32516:target`; `combat/action.json#2441/#11063/#25702:original` (omonimi da disambiguare per referente). |
| Raise (incantesimo) | Reiz | Decisione dell'utente | Nome dell'incantesimo e delle varianti composte, come «Reiz L» e «Reiz Variante»; sostituisce «Rianimazione» e «Resurrezione» quando designano questa azione. Non riguarda la rianimazione come processo o stato generico, né azioni diverse come Reanimate, Revive e Lost Arise. Riferimenti: `corpus/flat/Action.json#Action#125:target`; `@review/quests/arr/000/ClsCnj002_00091.json#84:original`. |
| Culling Time | Frenesia di Sangue | Decisione dell'utente | Fase di danno aumentato nel PvP The Feast (texture `ui/icon/120000/en/120127.tex`). |
| Trick (azione famiglio Domatore) | Trucco | Decisione dell'utente | Azione istintiva del famiglio del Domatore; sostituisce «Scherzo». Non estendere ad altre azioni con «Trick» (es. Trick Attack → Colpo Basso, Trickshot → Trucco, Treater's Trick → Scherzo del Benefattore). Riferimenti: `corpus/flat/Action.json#Action#47093:target`; `corpus/flat/Addon.json#Addon#17715:target`. |
| Tempered Release | Rilascio Temprato | Decisione dell'utente | Azione del Domatore (e relativo tratto «Maestria in Rilascio Temprato»); sostituisce «Liberazione Temperata». Riferimenti: `corpus/flat/Action.json#Action#44890:target`; `corpus/flat/Addon.json#Addon#17714:target`; `corpus/flat/Trait.json#Trait#749:target`. |
| Borrow | Potere Condiviso | Decisione dell'utente | Azione del Domatore (e relativo tratto «Potere Condiviso Potenziato»); sostituisce «Prestito». Non estendere al verbo comune «borrow» né ad altre voci non del Domatore (es. Borrowed Time, Crest of Time Borrowed). Riferimenti: `corpus/flat/Action.json#Action#44895:target`; `corpus/flat/Addon.json#Addon#17749:target`; `corpus/flat/Trait.json#Trait#750:target`. |




### Etichette degli attributi (BaseParam)

Decisione dell'utente dell'11 novembre 2026: le 25 etichette di BaseParam valutate singolarmente sono registrate in `overrides.json`, ciascuna con la propria gameKey e con fonte nel corpus attuale. La stessa resa si applica alle etichette UI dello stesso parametro e ai bonus pertinenti; le formulazioni descrittive in prosa non devono riprodurre per forza le abbreviazioni della UI.

In particolare: Attack Magic Potency -> «Potenza Magica»; Healing Magic Potency -> «Potenza Curativa»; Skill Speed -> «Velocità Tecniche»; Spell Speed -> «Velocità Incantesimi». In prosa restano valide «velocità delle tecniche» e «velocità degli incantesimi». Danno Fisico/Danno Magico sono le etichette del parametro: non impongono il singolare a ogni riferimento ai danni inflitti.

Haste -> «Rapidità» solo per BaseParam#47.1; l'incantesimo e lo status restano «Haste», mentre l'effetto di piano DeepDungeonFloorEffectUI#5.1 resta «Celerità». Per il tratto da corsa ChocoboRaceAbility#31.0 e i suoi manuali resta la scelta specifica «Resistenza a Pesantezza», distinta dall'etichetta BaseParam#66.1 «Resistenza alla Pesantezza».

### Misure e pesi

Decisione dell'utente: adattamento morfologico delle unità di misura eorzeane:
- **Distanza / Lunghezza (maschili)**: singolare in *-m*, plurale in *-mi* (*ilm / ilmi, fulm / fulmi, yalm / yalmi, malm / malmi*).
- **Peso (femminili)**: singolare in *-a*, plurale in *-e* (*onza / onze, ponza / ponze, tonza / tonze*).

| Inglese | Italiano | Fonte | Uso |
| --- | --- | --- | --- |
| Cryptlurker | Predatore delle Cripte | Decisione dell'utente | Set di equipaggiamento di Shadowbringers (patch 5.4, liv. 80). Nei nomi di armi, armature, accessori e forzieri usare «del Predatore delle Cripte» (es. «Spada del Predatore delle Cripte», «Corazza del Predatore delle Cripte della Difesa», «Spada del Predatore delle Cripte Potenziata»). Calco su FR «Rôdeur des cryptes» e DE «Krypta-Schleicher». Riferimenti: `corpus/flat/Item.json#32418.9` e segg. |
| Crypt [materiali] | [della] Cripta | Decisione dell'utente | Materiali di potenziamento per equipaggiamento Cryptlurker: Crypt Ester -> Estere della Cripta, Crypt Twine -> Spago della Cripta, Crypt Dusting -> Polvere della Cripta. Riferimenti: `corpus/flat/Item.json#32156.9`, `#32157.9`, `#32158.9`. |
| yalm | yalm | Decisione dell'utente | Unità di misura eorzeana di lunghezza (maschile, circa 1 iarda / 0,9 m). Riferimento: `corpus/flat/DefaultTalk.json#DefaultTalk#589846.20:target`. |
| yalms | yalmi | Decisione dell'utente | Plurale maschile (es. «dieci maledetti yalmi»). |
| malm | malm | Decisione dell'utente | Unità di misura eorzeana di distanza (maschile, circa 1 miglio / 1,6 km). |
| malms | malmi | Decisione dell'utente | Plurale maschile. |
| ilm | ilm | Decisione dell'utente | Unità di misura eorzeana di lunghezza (maschile, circa 1 pollice / 2,5 cm). |
| ilms | ilmi | Decisione dell'utente | Plurale maschile. |
| fulm | fulm | Decisione dell'utente | Unità di misura eorzeana di lunghezza (maschile, circa 1 piede / 30 cm). |
| fulms | fulmi | Decisione dell'utente | Plurale maschile. |
| onze | onza | Decisione dell'utente | Unità di peso eorzeana (femminile, circa 1 oncia / 28 g). |
| onzes | onze | Decisione dell'utente | Plurale femminile. |
| ponze | ponza | Decisione dell'utente | Unità di peso eorzeana (femminile, circa 1 libbra / 453 g). |
| ponzes | ponze | Decisione dell'utente | Plurale femminile. |
| tonze | tonza | Decisione dell'utente | Unità di peso eorzeana (femminile, circa 1 tonnellata). |
| tonzes | tonze | Decisione dell'utente | Plurale femminile. |

Nel controllo delle unità, non declinare le forme che appartengono a nomi propri attestati: «Hell of Malms» / «Inferno dei Malm» (`world/placename.json#1773:name`), «Baldewyn Four Yalms» (`corpus/flat/BNpcName.json#BNpcName#1381.0:target`) e il titolo musicale «Six Fulms Under» (`corpus/flat/Orchestrion.json#Orchestrion#855.0:target`). Queste eccezioni valgono solo per i nomi indicati.

### Classi e mestieri

Per le etichette delle armi, *One<hex:021F0103>handed* e *Two<hex:021F0103>handed* diventano **a una mano** e **a due mani**, senza il tag del trattino `<hex:021F0103>`. Il trattino appartiene al composto inglese e non va reinserito nella locuzione italiana. Questa eccezione non autorizza la rimozione di altri tag né dei trattini necessari in italiano (es. «città-stato»). Fonte: Decisione dell'utente; `items/itemuicategory.json#6:translation`, `#7:translation`, `#8:translation`, `#9:translation`.

| Inglese | Italiano | Fonte | Uso |
| --- | --- | --- | --- |
| Cryptlurker | Predatore delle Cripte | Decisione dell'utente | Set di equipaggiamento di Shadowbringers (patch 5.4, liv. 80). Nei nomi di armi, armature, accessori e forzieri usare «del Predatore delle Cripte» (es. «Spada del Predatore delle Cripte», «Corazza del Predatore delle Cripte della Difesa», «Spada del Predatore delle Cripte Potenziata»). Calco su FR «Rôdeur des cryptes» e DE «Krypta-Schleicher». Riferimenti: `corpus/flat/Item.json#32418.9` e segg. |
| Crypt [materiali] | [della] Cripta | Decisione dell'utente | Materiali di potenziamento per equipaggiamento Cryptlurker: Crypt Ester -> Estere della Cripta, Crypt Twine -> Spago della Cripta, Crypt Dusting -> Polvere della Cripta. Riferimenti: `corpus/flat/Item.json#32156.9`, `#32157.9`, `#32158.9`. |
| DoW/DoM | Combattenti/Maghi | `corpus/flat/Addon.json#Addon#1080:target` | Etichetta breve per le categorie Discepoli della Guerra e Discepoli della Magia. |
| DoH/DoL | Artigiani/Raccoglitori | `corpus/flat/Addon.json#Addon#1081:target` | Etichetta breve per le categorie Discepoli della Mano e Discepoli della Terra. |
| Lancer | Lanciere | `corpus/flat/ClassJob.json#ClassJob#4.30:target` |  Forma femminile per PNG identificati nei campi di supporto: «Lanciera». Varianti ammesse in prosa: «Lanciera». Non applicare il genere del giocatore a questi ruoli. |
| Archer | Arciere | `corpus/flat/ClassJob.json#ClassJob#5.30:target` |  Forma femminile per PNG identificati nei campi di supporto: «Arciera». Varianti ammesse in prosa: «Arciera». Non applicare il genere del giocatore a questi ruoli. |
| Thaumaturge | Taumaturgo | `corpus/flat/ClassJob.json#ClassJob#7.30:target` |  Forma femminile per PNG identificati nei campi di supporto: «Taumaturga». Varianti ammesse in prosa: «Taumaturga». Non applicare il genere del giocatore a questi ruoli. |
| Armorer | Corazziere | `corpus/flat/ClassJob.json#ClassJob#10.30:target` | Nome della classe artigiana; usare «corazziere» anche nei composti e nelle descrizioni. |
| Armorcraft (disciplina) | Corazzeria | `corpus/flat/CraftType.json#CraftType#2:target` | Nome della disciplina/categoria di fabbricazione delle armature; distinguere dal mestiere `Armorer` («Corazziere»). «Fabbricazione di armature» resta valido per il processo o le ricette in prosa. |
| White Mage | Mago Bianco | `corpus/flat/ClassJob.json#ClassJob#24.30:target` | Varianti ammesse in prosa: «mago bianco», «Maga Bianca», «Maga Bianca Makai». |
| Black Mage | Mago Nero | `corpus/flat/ClassJob.json#ClassJob#25.30:target` | Varianti ammesse in prosa: «mago nero», «maghi neri», «Maga Nera», «maghe nere», «Maga Nera Makai». |
| Dark Knight | Cavaliere Oscuro | `corpus/flat/MountTransient.json#MountTransient#56.1:target` | Variante ammessa in prosa: «cavaliere oscuro».  Varianti ammesse in prosa: «Cavalieri Oscuri», «cavalieri oscuri». |
| Red Mage | Mago Rosso | `corpus/flat/ClassJob.json#ClassJob#35.30:target` | Varianti ammesse in prosa: «mago rosso», «Maga Rossa», «maga rossa», «Maga Rossa Makai». |
| Blue Mage | Mago Blu | `corpus/flat/ClassJob.json#ClassJob#36.30:target` | Varianti ammesse in prosa: «mago blu», «maghi blu». |
| Beastmaster | Domatore | `corpus/flat/ClassJob.json#ClassJob#43.30:target` |  Nei riferimenti al Job usa «Domatore», in prosa «domatore» secondo le maiuscole sorgente; evita il residuo «beastmaster». Le azioni dei famigli sono «azioni istintive», non tecniche d'arma. |

### Sigle delle classi e dei mestieri

| Inglese | Italiano | Fonte | Uso |
| --- | --- | --- | --- |
| Cryptlurker | Predatore delle Cripte | Decisione dell'utente | Set di equipaggiamento di Shadowbringers (patch 5.4, liv. 80). Nei nomi di armi, armature, accessori e forzieri usare «del Predatore delle Cripte» (es. «Spada del Predatore delle Cripte», «Corazza del Predatore delle Cripte della Difesa», «Spada del Predatore delle Cripte Potenziata»). Calco su FR «Rôdeur des cryptes» e DE «Krypta-Schleicher». Riferimenti: `corpus/flat/Item.json#32418.9` e segg. |
| Crypt [materiali] | [della] Cripta | Decisione dell'utente | Materiali di potenziamento per equipaggiamento Cryptlurker: Crypt Ester -> Estere della Cripta, Crypt Twine -> Spago della Cripta, Crypt Dusting -> Polvere della Cripta. Riferimenti: `corpus/flat/Item.json#32156.9`, `#32157.9`, `#32158.9`. |
| GLA | GLA | `corpus/flat/ClassJobCategory.json#ClassJobCategory#2:target` | Sigla del Gladiatore. |
| PGL | PGL | `corpus/flat/ClassJobCategory.json#ClassJobCategory#3:target` | Sigla del Pugile. |
| MRD | ICR | `corpus/flat/ClassJobCategory.json#ClassJobCategory#4:target` | Sigla dell'Incursore. |
| LNC | LNC | `corpus/flat/ClassJobCategory.json#ClassJobCategory#5:target` | Sigla del Lanciere. |
| ARC | ARC | `corpus/flat/ClassJobCategory.json#ClassJobCategory#6:target` | Sigla dell'Arciere. |
| CNJ | INC | `corpus/flat/ClassJobCategory.json#ClassJobCategory#7:target` | Sigla dell'Incantatore. |
| THM | TAU | `corpus/flat/ClassJobCategory.json#ClassJobCategory#8:target` | Sigla del Taumaturgo. |
| CRP | FAL | `corpus/flat/ClassJobCategory.json#ClassJobCategory#9:target` | Sigla del Falegname. |
| BSM | FBR | `corpus/flat/ClassJobCategory.json#ClassJobCategory#10:target` | Sigla del Fabbro. |
| ARM | COR | `corpus/flat/ClassJobCategory.json#ClassJobCategory#11:target` | Sigla del Corazziere. |
| GSM | ORE | `corpus/flat/ClassJobCategory.json#ClassJobCategory#12:target` | Sigla dell'Orefice. |
| LTW | CON | `corpus/flat/ClassJobCategory.json#ClassJobCategory#13:target` | Sigla del Conciatore. |
| WVR | TES | `corpus/flat/ClassJobCategory.json#ClassJobCategory#14:target` | Sigla del Tessitore. |
| ALC | ALC | `corpus/flat/ClassJobCategory.json#ClassJobCategory#15:target` | Sigla dell'Alchimista. |
| CUL | CUO | `corpus/flat/ClassJobCategory.json#ClassJobCategory#16:target` | Sigla del Cuoco. |
| MIN | MIN | `corpus/flat/ClassJobCategory.json#ClassJobCategory#17:target` | Sigla del Minatore. |
| BTN | BOT | `corpus/flat/ClassJobCategory.json#ClassJobCategory#18:target` | Sigla del Botanico. |
| FSH | PES | `corpus/flat/ClassJobCategory.json#ClassJobCategory#19:target` | Sigla del Pescatore. |
| PLD | PLD | `corpus/flat/ClassJobCategory.json#ClassJobCategory#20:target` | Sigla del Paladino. |
| MNK | MNC | `corpus/flat/ClassJobCategory.json#ClassJobCategory#21:target` | Sigla del Monaco. |
| WAR | GUE | `corpus/flat/ClassJobCategory.json#ClassJobCategory#22:target` | Sigla del Guerriero, applicata solo nelle categorie di classi e mestieri. |
| DRG | DRG | `corpus/flat/ClassJobCategory.json#ClassJobCategory#23:target` | Sigla del Dragone. |
| BRD | BRD | `corpus/flat/ClassJobCategory.json#ClassJobCategory#24:target` | Sigla del Bardo. |
| WHM | MBI | `corpus/flat/ClassJobCategory.json#ClassJobCategory#25:target` | Sigla del Mago Bianco. |
| BLM | MNE | `corpus/flat/ClassJobCategory.json#ClassJobCategory#26:target` | Sigla del Mago Nero. |
| ACN | ACN | `corpus/flat/ClassJobCategory.json#ClassJobCategory#27:target` | Sigla dell'Arcanista. |
| SMN | EVO | `corpus/flat/ClassJobCategory.json#ClassJobCategory#28:target` | Sigla dell'Evocatore. |
| SCH | STU | `corpus/flat/ClassJobCategory.json#ClassJobCategory#29:target` | Sigla dello Studioso. |
| ROG | FUR | `corpus/flat/ClassJobCategory.json#ClassJobCategory#91:target` | Sigla del Furfante. |
| NIN | NIN | `corpus/flat/ClassJobCategory.json#ClassJobCategory#92:target` | Sigla del Ninja. |
| MCH | ART | `corpus/flat/ClassJobCategory.json#ClassJobCategory#96:target` | Sigla dell'Artificiere. |
| DRK | CAO | `corpus/flat/ClassJobCategory.json#ClassJobCategory#98:target` | Sigla del Cavaliere Oscuro. |
| AST | AST | `corpus/flat/ClassJobCategory.json#ClassJobCategory#99:target` | Sigla dell'Astrologo. |
| SAM | SAM | `corpus/flat/ClassJobCategory.json#ClassJobCategory#111:target` | Sigla del Samurai. |
| RDM | MRO | `corpus/flat/ClassJobCategory.json#ClassJobCategory#112:target` | Sigla del Mago Rosso. |
| BLU | MBL | `corpus/flat/ClassJobCategory.json#ClassJobCategory#129:target` | Sigla del Mago Blu. |
| GNB | ETE | `corpus/flat/ClassJobCategory.json#ClassJobCategory#149:target` | Sigla dell'Eterlama. |
| DNC | DNZ | `corpus/flat/ClassJobCategory.json#ClassJobCategory#150:target` | Sigla del Danzatore. |
| RPR | MTR | `corpus/flat/ClassJobCategory.json#ClassJobCategory#180:target` | Sigla del Mietitore. |
| SGE | SGO | `corpus/flat/ClassJobCategory.json#ClassJobCategory#181:target` | Sigla del Saggio. |
| VPR | VPR | `corpus/flat/ClassJobCategory.json#ClassJobCategory#196:target` | Sigla della Vipera. |
| PCT | PTM | `corpus/flat/ClassJobCategory.json#ClassJobCategory#197:target` | Sigla del Pittomante. |
| BST | DMT | `corpus/flat/ClassJobCategory.json#ClassJobCategory#203:target` | Sigla del Domatore. |

### Suffissi di equipaggiamento (Ruoli e Discipline)

| Inglese | Italiano | Fonte | Uso |
| --- | --- | --- | --- |
| Cryptlurker | Predatore delle Cripte | Decisione dell'utente | Set di equipaggiamento di Shadowbringers (patch 5.4, liv. 80). Nei nomi di armi, armature, accessori e forzieri usare «del Predatore delle Cripte» (es. «Spada del Predatore delle Cripte», «Corazza del Predatore delle Cripte della Difesa», «Spada del Predatore delle Cripte Potenziata»). Calco su FR «Rôdeur des cryptes» e DE «Krypta-Schleicher». Riferimenti: `corpus/flat/Item.json#32418.9` e segg. |
| Crypt [materiali] | [della] Cripta | Decisione dell'utente | Materiali di potenziamento per equipaggiamento Cryptlurker: Crypt Ester -> Estere della Cripta, Crypt Twine -> Spago della Cripta, Crypt Dusting -> Polvere della Cripta. Riferimenti: `corpus/flat/Item.json#32156.9`, `#32157.9`, `#32158.9`. |
| of Fending | della Difesa | Decisione dell'utente | Controllo automatico: suffisso ruolo equipaggiamento. Suffisso per l'equipaggiamento da difensore (Tank). Sostituisce «da difensore» e «di difesa». |
| of Maiming | della Lacerazione | Decisione dell'utente | Controllo automatico: suffisso ruolo equipaggiamento. Suffisso per l'equipaggiamento da assaltatore pesante (Dragoon / Reaper). |
| of Slaying | della Furia | Decisione dell'utente | Controllo automatico: suffisso ruolo equipaggiamento. Suffisso per l'equipaggiamento/accessori da mischia (Strength DPS). Sostituisce «da attacco». |
| of Striking | dell'Impeto | Decisione dell'utente | Controllo automatico: suffisso ruolo equipaggiamento. Suffisso per l'equipaggiamento da mischia corpo a corpo (Monk / Samurai). Sostituisce «da combattimento». |
| of Scouting | dell'Incursione | Decisione dell'utente | Controllo automatico: suffisso ruolo equipaggiamento. Suffisso per l'equipaggiamento da ricognizione/incursione (Ninja / Viper). Sostituisce «da esploratore». |
| of Aiming | della Mira | Decisione dell'utente | Controllo automatico: suffisso ruolo equipaggiamento. Suffisso per l'equipaggiamento da attaccante fisico a distanza (Physical Ranged DPS). Sostituisce «da mira». |
| of Casting | dell'Arcano | Decisione dell'utente | Controllo automatico: suffisso ruolo equipaggiamento. Suffisso per l'equipaggiamento da incantatore (Magic Ranged DPS). Sostituisce «da incantatore» e «per il lancio di incantesimi». |
| of Healing | della Cura | Decisione dell'utente | Controllo automatico: suffisso ruolo equipaggiamento. Suffisso per l'equipaggiamento da curatore (Healer). Sostituisce «di guarigione» e «da guaritore». |
| of War | della Guerra | Decisione dell'utente | Controllo automatico: suffisso ruolo equipaggiamento. Suffisso per l'equipaggiamento generico dei Discepoli della Guerra (Disciples of War). |
| of Magic | della Magia | Decisione dell'utente | Controllo automatico: suffisso ruolo equipaggiamento. Suffisso per l'equipaggiamento generico dei Discepoli della Magia (Disciples of Magic). |
| of Crafting | della Creazione | Decisione dell'utente | Controllo automatico: suffisso ruolo equipaggiamento. Suffisso per l'equipaggiamento dei Discepoli della Mano (Disciples of the Hand). Sostituisce «da sintesi». |
| of Gathering | della Raccolta | Decisione dell'utente | Controllo automatico: suffisso ruolo equipaggiamento. Suffisso per l'equipaggiamento dei Discepoli della Terra (Disciples of the Land). Sostituisce «da raccolta». |

### Oggetti ed equipaggiamento

| Inglese | Italiano | Fonte | Uso |
| --- | --- | --- | --- |
| Cryptlurker | Predatore delle Cripte | Decisione dell'utente | Set di equipaggiamento di Shadowbringers (patch 5.4, liv. 80). Nei nomi di armi, armature, accessori e forzieri usare «del Predatore delle Cripte» (es. «Spada del Predatore delle Cripte», «Corazza del Predatore delle Cripte della Difesa», «Spada del Predatore delle Cripte Potenziata»). Calco semantico su FR «Rôdeur des cryptes» e DE «Krypta-Schleicher». Riferimenti: `corpus/flat/Item.json#32418.9` e segg. |
| Crypt [materiali] | [della] Cripta | Decisione dell'utente | Materiali di potenziamento per equipaggiamento Cryptlurker: Crypt Ester -> Estere della Cripta, Crypt Twine -> Spago della Cripta, Crypt Dusting -> Polvere della Cripta. Riferimenti: `corpus/flat/Item.json#32156.9`, `#32157.9`, `#32158.9`. |
| Cryptlurker | Predatore delle Cripte | Decisione dell'utente | Set di equipaggiamento di Shadowbringers (patch 5.4, liv. 80). Nei nomi di armi, armature, accessori e forzieri usare «del Predatore delle Cripte» (es. «Spada del Predatore delle Cripte», «Corazza del Predatore delle Cripte della Difesa», «Spada del Predatore delle Cripte Potenziata»). Calco su FR «Rôdeur des cryptes» e DE «Krypta-Schleicher». Riferimenti: `corpus/flat/Item.json#32418.9` e segg. |
| Crypt [materiali] | [della] Cripta | Decisione dell'utente | Materiali di potenziamento per equipaggiamento Cryptlurker: Crypt Ester -> Estere della Cripta, Crypt Twine -> Spago della Cripta, Crypt Dusting -> Polvere della Cripta. Riferimenti: `corpus/flat/Item.json#32156.9`, `#32157.9`, `#32158.9`. |
| toadskin jacket | giacca in pelle di rospo | Decisione dell'utente | Sostituisce «giubbetto in pelle di rospo» per questo oggetto; plurale «giacche in pelle di rospo», etichetta «Giacca in Pelle di Rospo». Non riguarda il diverso oggetto toadskin jerkin, che conserva «giubbetto in pelle di rospo». Riferimenti: `corpus/flat/Item.json#Item#3100.0:target`; `#3100:description`; `#3100:col_3`; `@review/quests/arr/000/ClsTan006_00061.json#26:original`. |
| Artemis Bow | arco di Artemide | Decisione dell'utente | Controllo automatico: residuo. Arma relic per Bardo e relativi stadi evolutivi. |
| Stardust Rod | verga della Polvere Stellare | Decisione dell'utente | Controllo automatico: residuo. Arma relic per Mago Nero e relativi stadi evolutivi. |
| Chicken Knife | Coltello da Pollo | Decisione dell'utente | Controllo automatico: residuo. Arma iconica per Mago Rosso. |
| break blade | lama spezzante | Decisione dell'utente | Spada da gladiatore. |
| thousand needle | ago dei mille aghi | Decisione dell'utente | Strumento da tessitore. |
| dual haken | doppio haken | Decisione dell'utente | Ascia da marauder. |
| the Destroyer's Stead | Sostegno del Distruttore | Decisione dell'utente | Lancia sacra di Ser Vellguine. |
| Worm of the Dell | Drago della Conca | Decisione dell'utente | Bastone sacro di Ser Haumeric (worm nel senso araldico di drago/lindworm). |
| cluster | aggregato | Decisione dell'utente | Categoria di cristalli elementali di alto rango (es. aggregato di fulmine, aggregato planare). |
| Gear Set | set di equipaggiamento | Decisione dell'utente | Nome della funzione e dell'insieme d'equipaggiamento salvato; invariabile al plurale («set di equipaggiamento»). Sostituisce «completo» solo nel senso di gear set, non nell'uso aggettivale. Riferimenti: `system/logmessage.json#697-701`, `#717-719`, `#765-770`; riconciliazione globale del corpus. |
| Blade's (Bozja gear) | della Lama | Decisione dell'utente | Set di equipaggiamento delle Lame di Bozja (es. diadema della Lama della Difesa). |
| Gunblade | Eterlama | Decisione dell'utente | Controllo automatico: residuo. Arma del job Gunbreaker (femminile: l'eterlama, armi da eterlama). |
| Titanbronze | Bronzo Titanico | Decisione dell'utente | Controllo automatico: suffisso equipaggiamento. Lega e set di equipaggiamento (es. spada di bronzo titanico, lingotto di bronzo titanico). |
| Deepgold | Oro Cupo | Decisione dell'utente | Controllo automatico: suffisso equipaggiamento. Lega aurifera e set di equipaggiamento (es. spada d'oro cupo, lingotto d'oro cupo). |
| Stonegold | Litoro | Decisione dell'utente | Controllo automatico: suffisso equipaggiamento. Lega aurifera-litica e set di equipaggiamento (es. stocco di litoro, lingotto di litoro). |
| Bluespirit | Azzurrite | Decisione dell'utente | Controllo automatico: suffisso equipaggiamento. Minerale etereo azzurro e set di equipaggiamento (es. spada d'azzurrite, minerale d'azzurrite). |
| Truegold | Aurovero | Decisione dell'utente | Controllo automatico: suffisso equipaggiamento. Minerale/metallo aurifero puro (es. sabbia d'aurovero, minerale d'aurovero). |
| Equipaggiamento in materiali composti | in [materiale] di [creatura/origine] | Decisione dell'utente | Per evitare ripetizioni di «di» (es. «grimorio in pelle di lobo pregiato» anziché «di pelle di...»; «targa in pelle di raptor»). Non si applica a contenitori/unità di misura come «tazza di tisana» o «pezza di cuoio di». |
| Mistic Memory | della Memoria Mistica | Decisione dell'utente | Controllo automatico: suffisso equipaggiamento. Set di equipaggiamento (es. celata della Memoria Mistica della Difesa). |
| Queensknight | del Cavaliere della Regina | Decisione dell'utente | Controllo automatico: suffisso equipaggiamento. Set di armi ed equipaggiamento (es. falcione del Cavaliere della Regina). |
| Sky Rat | del Ratto del Cielo | Decisione dell'utente | Controllo automatico: suffisso equipaggiamento. Set di equipaggiamento (es. maschera del Ratto del Cielo della Difesa). |
| Radiant's (gear) | della Schiera Radiosa | Decisione dell'utente | Controllo automatico: suffisso equipaggiamento. Set di equipaggiamento della Schiera Radiosa di Thavnair (es. spada bastarda della Schiera Radiosa). |
| Law's Order | dell'Ordine Giusto | Decisione dell'utente | Controllo automatico: suffisso equipaggiamento. Set di armi di Bozja (es. spada bastarda dell'Ordine Giusto). |
| Courtly Lover | dell'Amante Cortese | Decisione dell'utente | Controllo automatico: suffisso equipaggiamento. Set di armi ed equipaggiamento (es. spada dell'Amante Cortese). |
| Tomestone | Tavoletta | Decisione dell'utente | Controllo automatico: residuo plurale. Nome femminile: «tavoletta/e»; se la sorgente specifica Allagan: «tavoletta/e allagana/e». Eccezioni: «tavoletta/e di Orthos»; per il Forziere del Moguri, «tavoletta/e irregolare/i». Adattare articoli e accordi frase per frase. |
| Tomelith | tomolite / tomoliti | Decisione dell'utente del 14 novembre 2026 | Nome maschile del dispositivo/struttura di dati allagana («il tomolite», «i tomoliti»); sostituisce il precedente mantenimento dell'inglese. Distinto da Tomestone = Tavoletta. Riferimenti EN/hash verificati: `corpus/flat/Completion.json#Completion#1453.3`, `corpus/flat/EObjName.json#EObjName#2005338.0/.2`, `corpus/flat/DescriptionString.json#DescriptionString#289/#294`. |
| Wolf Mark | Marchio del Lupo | Decisione dell'utente | Valuta PvP; plurale: Marchi del Lupo (es. 500 Marchi del Lupo). Sostituisce «Contrassegno del Lupo». |
| Dated (gear) | obsoleto / obsoleta | Decisione dell'utente | Controllo automatico: suffisso equipaggiamento. Equipaggiamento della versione 1.0 (es. gladio di bronzo obsoleto, spatha di bronzo obsoleta). Sostituisce la dicitura «d'epoca». |
| Cesti | Tirapugni | Decisione dell'utente | Categoria d'arma per pugile/monaco (es. paio di tirapugni in pelle di dodo). Sostituisce «cesti». |
| Gridanian (gear/items) | gridaniano / gridaniana | Decisione dell'utente | Controllo automatico: suffisso equipaggiamento. Aggettivo relativo a Gridania (es. macuahuitl gridaniano, spatha gridaniana). |
| Lominsan | lominsano / lominsana | Decisione dell'utente | Controllo automatico: suffisso equipaggiamento. Aggettivo relativo a Limsa Lominsa (es. spada corta lominsana, arco lominsano). Sostituisce la formula perifrastica «di Limsa Lominsa». |
| Ul'dahn (gear/items) | ul'dahno / ul'dahna | Decisione dell'utente | Controllo automatico: suffisso equipaggiamento. Aggettivo relativo a Ul'dah (es. falchione ul'dahno, scimitarra ul'dahna). Sostituisce la formula perifrastica «di Ul'dahn». |
| GC Factions (short form) | della Fiamma / della Vipera / della Tempesta | Decisione dell'utente | Forma abbreviata per equipaggiamenti e gradi delle Grandi Compagnie (es. «libro del sergente della Fiamma», «pugnale del soldato semplice della Vipera», «spadone dell'ufficiale della Tempesta»). Evita ripetizioni prolungate come «delle Fiamme Immortali» o «dell'Ordine della Vipera Gemella». Nei gradi di Gridania il nome breve è «della Vipera», non «del Serpente» (`corpus/flat/GCRankGridaniaFemaleText.json#GCRankGridaniaFemaleText#1.0:target`). |
| Elm (material) | d'olmo | Decisione dell'utente | Controllo automatico: suffisso equipaggiamento. Forma elisa obbligatoria (es. «tronco d'olmo», «tavola d'olmo», «macuahuitl d'olmo»). Evitare la forma non elisa «di olmo». |
| Snakestongue (gear) | Linguaserpe | Decisione dell'utente | Controllo automatico: suffisso equipaggiamento. Adattamento composto a parola singola per la serie di equipaggiamento PvP (es. «elmo Linguaserpe», «lancia Linguaserpe»). Riferimento: `corpus/flat/Item.json#Item#7378.0:target`. |
| Bearsmaw (gear) | Fauciorso | Decisione dell'utente | Controllo automatico: suffisso equipaggiamento. Adattamento composto a parola singola per la serie di equipaggiamento PvP (es. «armetto Fauciorso», «ascia Fauciorso»). Riferimento: `corpus/flat/Item.json#Item#7372.0:target`. |
| Hawkwing (gear) | Alafalco | Decisione dell'utente | Controllo automatico: suffisso equipaggiamento. Adattamento composto a parola singola per la serie di equipaggiamento PvP (es. «armetto Alafalco», «artigli Alafalco»). Riferimento: `corpus/flat/Item.json#Item#7366.0:target`. |
| Lionsmane (gear) | Chiomaleone | Decisione dell'utente | Controllo automatico: suffisso equipaggiamento. Adattamento composto a parola singola per la serie di equipaggiamento PvP (es. «armetto Chiomaleone», «scudo Chiomaleone»). Riferimento: `corpus/flat/Item.json#Item#7360.0:target`. |
| Birdsong (gear) | Cantaugello | Decisione dell'utente | Controllo automatico: suffisso equipaggiamento. Adattamento composto a parola singola per la serie di equipaggiamento PvP (es. «maschera Cantaugello», «arco Cantaugello»). Riferimento: `corpus/flat/Item.json#Item#7384.0:target`. Non applicare ai titoli dei rulli orchestrion. |
| Swansgrace (gear) | Graziacigno | Decisione dell'utente | Controllo automatico: suffisso equipaggiamento. Adattamento composto a parola singola per la serie di equipaggiamento PvP (es. «cappuccio Graziacigno», «bastone Graziacigno»). Riferimento: `corpus/flat/Item.json#Item#7390.0:target`. |
| Wolfseye (gear) | Occhiolupo | Decisione dell'utente | Controllo automatico: suffisso equipaggiamento. Adattamento composto a parola singola per la serie di equipaggiamento PvP (es. «cappello Occhiolupo», «bastone Occhiolupo»). Riferimento: `corpus/flat/Item.json#Item#7396.0:target`. |
| Elkhorn (gear) | Cornoalce | Decisione dell'utente | Controllo automatico: suffisso equipaggiamento. Adattamento composto a parola singola per la serie di equipaggiamento PvP (es. «cappello Cornoalce», «grimorio Cornoalce»). Riferimento: `corpus/flat/Item.json#Item#7402.0:target`. |
| Elktail (gear) | Codalce | Decisione dell'utente | Controllo automatico: suffisso equipaggiamento. Adattamento composto a parola singola per la serie di equipaggiamento PvP (es. «cappello Codalce», «grimorio Codalce»). Riferimento: `corpus/flat/Item.json#Item#7408.0:target`. |
| Hellwolf (gear) | Infernalupo | Decisione dell'utente | Controllo automatico: suffisso equipaggiamento. Adattamento composto a parola singola per la serie di accessori PvP (es. «bracciale Infernalupo della Difesa»). Riferimento: `corpus/flat/Item.json#Item#7414.0:target`. |
| Roseblood (gear) | Rosasangue | Decisione dell'utente | Controllo automatico: suffisso equipaggiamento. Adattamento composto a parola singola per la serie di equipaggiamento PvP (es. «cappello Rosasangue», «abito Rosasangue»). Riferimento: `corpus/flat/Item.json#Item#42661.0:target`. |
| Evenstar (gear) | Stellavespro | Decisione dell'utente | Controllo automatico: suffisso equipaggiamento. Adattamento composto a parola singola per la serie di equipaggiamento (es. «cappello Stellavespro», «giubba Stellavespro»). Riferimento: `corpus/flat/Item.json#Item#7340.0:target`. |
| Daystar (gear) | Stelladiurna | Decisione dell'utente | Controllo automatico: suffisso equipaggiamento. Adattamento composto a parola singola per la serie di equipaggiamento (es. «diadema Stelladiurna», «veste Stelladiurna»). Riferimento: `corpus/flat/Item.json#Item#7330.0:target`. |
| Gloam (gear) | Crepuscolo | Decisione dell'utente | Controllo automatico: suffisso equipaggiamento. Adattamento per la serie di equipaggiamento (es. «cuffia Crepuscolo», «sopravveste Crepuscolo»). Riferimento: `corpus/flat/Item.json#Item#7310.0:target`. |
| Auroral (gear) | Aurorale | Decisione dell'utente | Controllo automatico: suffisso equipaggiamento. Adattamento aggettivale per la serie di equipaggiamento (es. «cuffia Aurorale», «bracciali Aurorali»). Riferimento: `corpus/flat/Item.json#Item#7320.0:target`. |
| Hoplon (shield) | Oplone | Decisione dell'utente | Controllo automatico: suffisso equipaggiamento. Termine canonico italiano per lo scudo rotondo (plur. «oploni», es. «oplone di bronzo», «oplone Noct»). Riferimento: `corpus/flat/Item.json#Item#7350.0:target`. |
| Conquerer (weapon) | Conquistatore | Decisione dell'utente | Controllo automatico: suffisso equipaggiamento. Ascia da guerra da Marauder/Warrior (es. «Conquistatore», «Conquistatore logoro»). Riferimento: `items/item.json#7353:name`. |
| Liberator (weapon) | Liberatore | Decisione dell'utente | Controllo automatico: suffisso equipaggiamento. Lancia da Dragoon (es. «Liberatore», «Liberatore logoro»). Riferimento: `items/item.json#7354:name`. |
| Burtgang | Burtgang | Decisione dell'utente | Nome proprio mitologico di spada leggendaria di origine antico-nordica/germanica (*Þiðreks saga*), conservato invariato. Riferimento: `items/item.json#7351:name`. |
| Lockbox (Eureka) | Forziere | Decisione dell'utente | Nome degli scrigni chiusi che si trovano nelle spedizioni Eureka; accordare al plurale «forzieri» e nei composti descrittivi. Riferimenti: `corpus/flat/Item.json#Item#17341.0:target`; `corpus/flat/Item.json#Item#17341.9:target`. |



### Razze e clan

| Inglese | Italiano | Fonte | Uso |
| --- | --- | --- | --- |
| Cryptlurker | Predatore delle Cripte | Decisione dell'utente | Set di equipaggiamento di Shadowbringers (patch 5.4, liv. 80). Nei nomi di armi, armature, accessori e forzieri usare «del Predatore delle Cripte» (es. «Spada del Predatore delle Cripte», «Corazza del Predatore delle Cripte della Difesa», «Spada del Predatore delle Cripte Potenziata»). Calco su FR «Rôdeur des cryptes» e DE «Krypta-Schleicher». Riferimenti: `corpus/flat/Item.json#32418.9` e segg. |
| Crypt [materiali] | [della] Cripta | Decisione dell'utente | Materiali di potenziamento per equipaggiamento Cryptlurker: Crypt Ester -> Estere della Cripta, Crypt Twine -> Spago della Cripta, Crypt Dusting -> Polvere della Cripta. Riferimenti: `corpus/flat/Item.json#32156.9`, `#32157.9`, `#32158.9`. |
| Hyur | Hyur | `world/race.json#1:name_masculine` | Forma del nome; controllare gli accordi nel contesto. |
| Elezen | Elezen | `world/race.json#2:name_masculine` | Forma del nome; controllare gli accordi nel contesto. |
| Lalafell | Lalafell | `world/race.json#3:name_masculine` | Forma del nome; controllare gli accordi nel contesto. |
| Miqo'te | Miqo'te | `world/race.json#4:name_masculine` | Forma del nome; controllare gli accordi nel contesto. |
| Roegadyn | Roegadyn | `world/race.json#5:name_masculine` | Forma del nome; controllare gli accordi nel contesto. |
| Au Ra | Au Ra | `world/race.json#6:name_masculine` | Forma del nome; controllare gli accordi nel contesto. |
| Hrothgar | Hrothgar | `world/race.json#7:name_masculine` | Forma del nome; controllare gli accordi nel contesto. |
| Viera | Viera | `world/race.json#8:name_masculine` | Forma del nome; controllare gli accordi nel contesto. |
| Midlander | Mezzocolle | `data/translations/world/tribe.json#1:translation_name_masculine/translation_name_feminine` | Decisione dell'utente; resa legacy attuale, mantenere il plurale e gli accordi della frase. |
| Highlander | Altomonte | `data/translations/world/tribe.json#2:translation_name_masculine/translation_name_feminine` | Decisione dell'utente; resa legacy attuale, mantenere il plurale e gli accordi della frase. |
| Wildwood | Silvano | `world/tribe.json#3:name_masculine` | Forma del nome; controllare gli accordi nel contesto. |
| Duskwight | Crepuscolare | `world/tribe.json#4:name_masculine` | Forma del nome; controllare gli accordi nel contesto. |
| Plainsfolk | Pratoverde | `world/tribe.json#5:name_masculine` | Forma del nome; controllare gli accordi nel contesto. |
| Dunesfolk | Dunagialla | `world/tribe.json#6:name_masculine` | Forma del nome; controllare gli accordi nel contesto. |
| Seeker of the Sun | Cercasole | `world/tribe.json#7:name_masculine` | Forma del nome; controllare gli accordi nel contesto. |
| Keeper of the Moon | Guardialuna | `world/tribe.json#8:name_masculine` | Forma del nome; controllare gli accordi nel contesto. |
| Sea Wolf | Lupo di Mare | `world/tribe.json#9:name_masculine` | Forma del nome; controllare gli accordi nel contesto. |
| Hellsguard | Guardinferno | `world/tribe.json#10:name_masculine` | I nomi composti da parole comuni si traducono come descrizioni italiane; non applicare questa regola ai nomi dei Lupi di Mare in lingua Roegadyn antica. Decisione dell'utente. |
| Raen | Raen | `world/tribe.json#11:name_masculine` | Forma del nome; controllare gli accordi nel contesto. |
| Xaela | Xaela | `world/tribe.json#12:name_masculine` | Forma del nome; controllare gli accordi nel contesto. |
| Helions | Eliano | `world/tribe.json#13:name_masculine` | Forma del nome; controllare gli accordi nel contesto. |
| The Lost | Ramingo | `world/tribe.json#14:name_masculine` | Forma del nome; controllare gli accordi nel contesto. |
| Rava | Rava | `world/tribe.json#15:name_masculine` | Forma del nome; controllare gli accordi nel contesto. |
| Veena | Veena | `world/tribe.json#16:name_masculine` | Forma del nome; controllare gli accordi nel contesto. |

### Parlato delle Società Alleate

| Inglese | Italiano | Fonte | Uso |
| --- | --- | --- | --- |
| Cryptlurker | Predatore delle Cripte | Decisione dell'utente | Set di equipaggiamento di Shadowbringers (patch 5.4, liv. 80). Nei nomi di armi, armature, accessori e forzieri usare «del Predatore delle Cripte» (es. «Spada del Predatore delle Cripte», «Corazza del Predatore delle Cripte della Difesa», «Spada del Predatore delle Cripte Potenziata»). Calco su FR «Rôdeur des cryptes» e DE «Krypta-Schleicher». Riferimenti: `corpus/flat/Item.json#32418.9` e segg. |
| Crypt [materiali] | [della] Cripta | Decisione dell'utente | Materiali di potenziamento per equipaggiamento Cryptlurker: Crypt Ester -> Estere della Cripta, Crypt Twine -> Spago della Cripta, Crypt Dusting -> Polvere della Cripta. Riferimenti: `corpus/flat/Item.json#32156.9`, `#32157.9`, `#32158.9`. |
| Sylph: this one / these ones | questo qui / questi qui | `corpus/flat/DefaultTalk.json#DefaultTalk#590258.20:target` | Autoreferenza in terza persona; conservare il tratto e accordare al numero. |
| Sylph: walking one(s) | camminante / camminanti | `corpus/flat/DefaultTalk.json#DefaultTalk#590270.20:target` | Appellativo per chi non è Sylph; evitare «camminatore», che suggerisce un mestiere o un ruolo. |
| Sahagin: sibilanti allungate | sss | `corpus/flat/CompanionTransient.json#CompanionTransient#61.2:target` | Decisione dell'utente: rendere con sibilanti allungate solo le parole marcate dalla fonte, senza allungare vocali a caso. |
| Ananta: sibilanti allungate | sss | `corpus/flat/CompanionTransient.json#CompanionTransient#262.2:target` | Decisione dell'utente, verificata sulle battute originali di Sarisha ed Eshana: seguire la stessa convenzione degli Sahagin. |
| Ondo: sibilanti allungate | sss | `corpus/flat/NpcYell.json#NpcYell#8552:target` | Resa attestata nelle battute degli Ondo del Tempest; conservare il segnale quando è presente nella fonte. |
| Ixal: featherless one(s) | implume / implumi | `corpus/flat/InstanceContentTextData.json#InstanceContentTextData#13005:target` | Appellativo rivolto a chi non ha piume; mantenere la voce inversa degli Ixal quando è marcata, senza rendere il testo oscuro. |
| kupo | kupò | `corpus/flat/DefaultTalk.json#DefaultTalk#592316.20:target` | Controllo automatico: intercalare. Per l'intercalare pronunciato usare la grafia «kupò»; parole citate, composti e nomi propri come «noce kupo» e «Uccell-kupo» restano invariati. |
| Vath: click / clack | clic / clac | `dialogue/balloon.json#5293:original` | Tradurre come segnali sonori quando sono testo visibile; non trattarli come tag SeString. |
| Namazu: yes, yes / no, no | sì, sì / no, no | `corpus/flat/FishParameter.json#FishParameter#1246.0:target` | Conservare la ripetizione entusiasta se presente nella battuta; non aggiungere particelle a frasi che non la contengono. |
| Vanu Vanu: netherling | forestiero | `corpus/flat/FateEvent.json#FateEvent#249.56:target` | Appellativo per chi viene da fuori; mantenere la forma coerente con genere e numero della frase, senza renderlo «creatura infernale». |

### Luoghi

Catalogo integrale: `data/translations/world/placename.json`. Cercare il nome inglese nel campo `name` per ottenere la forma italiana `translation` e l'ID della fonte. Per un nome corto usare `scan --term "NOME"`.

| Inglese | Italiano | Fonte | Uso |
| --- | --- | --- | --- |
| Steps of the Speaker | I Gradini dell'Oratore | Decisione dell'utente dell'11 novembre 2026 | Toponimo, titolo del Diario Esplorazione e dipinti; sostituisce Gradini della Portavoce. Adattare articoli e preposizioni. Riferimenti: `corpus/flat/Adventure.json#Adventure#2163027.13:target`; `corpus/flat/PlaceName.json#PlaceName#4723.0:target`, `#PlaceName#4723.2:target`; `Item#44409`; `quest/049/KinGmf110_04955`. |
| Camp Dragonhead | Campo Testadrago | Decisione dell'utente dell'11 novembre 2026 | Nome dell'accampamento in tutto il corpus, incluse etichette, prosa e dipinti; sostituisce Campo Capodrago. Dragonhead senza Camp resta distinto. Riferimenti: `corpus/flat/PlaceName.json#PlaceName#388.0:target`, `#PlaceName#388.2:target`; `corpus/flat/Adventure.json#Adventure#2162762.13:target`; `corpus/flat/Item.json#Item#17110.0:target`. |
| The Drowning Wench | La Fanciulla Annegata | corpus/flat/PlaceName.json#PlaceName#715.0:target | Nome della locanda; applicare anche a PlaceName#716 con «Gilda degli Avventurieri» e ai riferimenti nel testo, adattando articoli e preposizioni («alla Fanciulla», «della Fanciulla»). |
| Josselin's Spire | Guglia di Josselin | Decisione dell'utente | Sostituisce «Torre di Josselin» in tutti i riferimenti allo stesso luogo. Memoria ufficiale: `data/translations/world/placename.json#158:translation`. |
| Hedgetree | Albero di Confine | Decisione dell'utente | Mantenere la forma main anche nei riferimenti al luogo; accordare articoli e plurali al contesto. Sostituisce la forma legacy «Albero Siepe». |
| Cryptlurker | Predatore delle Cripte | Decisione dell'utente | Set di equipaggiamento di Shadowbringers (patch 5.4, liv. 80). Nei nomi di armi, armature, accessori e forzieri usare «del Predatore delle Cripte» (es. «Spada del Predatore delle Cripte», «Corazza del Predatore delle Cripte della Difesa», «Spada del Predatore delle Cripte Potenziata»). Calco su FR «Rôdeur des cryptes» e DE «Krypta-Schleicher». Riferimenti: `corpus/flat/Item.json#32418.9` e segg. |
| Crypt [materiali] | [della] Cripta | Decisione dell'utente | Materiali di potenziamento per equipaggiamento Cryptlurker: Crypt Ester -> Estere della Cripta, Crypt Twine -> Spago della Cripta, Crypt Dusting -> Polvere della Cripta. Riferimenti: `corpus/flat/Item.json#32156.9`, `#32157.9`, `#32158.9`. |
| Doma Castle | Castello di Doma | Decisione dell'utente | Toponimo; adattare articoli e preposizioni al contesto. Riferimenti: `data/translations/world/placename.json#1037/#2810`; `corpus/flat/PlaceName.json#1037.0/.2`. |
| Lotus Stand | La Tribuna del Loto | Decisione dell'utente | Toponimo; adattare articolo e preposizione al contesto («alla/dalla/nella Tribuna del Loto»). Riferimenti: `data/translations/world/placename.json#347:translation`; `corpus/flat/PlaceName.json#347.0/.2`. |
| Rising Stones | Pietre Risorte | Decisione dell'utente | Sede degli Eredi della Settima Alba; mantenere il plurale femminile e adattare articoli e preposizioni. Riferimenti: `data/translations/world/warp.json#131144/#131145:translation_description`; `corpus/cut_scene/060/VoiceMan_06006.json#TEXT_VOICEMAN_06006_001110_URIANGER:target`. |
| Seat of the First Bow | Seggio del Primo Arciere | Decisione dell'utente | Nome del luogo; forma canonica, sostituisce «Sede del Primo Arco» e «Seggio del Primo Arco». Riferimenti: `world/placename.json#346:name`; `corpus/flat/Warp.json#Warp#131075.11:target`. |
| Treespeak Stables | Scuderie di Frusciodeglialberi | Decisione dell'utente | Sostituisce «Scuderie di Parlalberi» nei riferimenti alle stesse scuderie; coerente con Treespeak → «Frusciodeglialberi». Riferimenti: `world/placename.json#136:name`; `@review/quests/arr/000/ClsCnj001_00048.json#2:original`. |
| Blessed Bud | Gemma Benedetta | Decisione dell'utente | Riferimento: ``world/placename.json#160:translation``. Toponimo; accordare articoli e preposizioni al femminile. |
| Sweetbloom Pier | Molo Dolcefiore | Decisione dell'utente | Riferimento: ``world/placename.json#155:translation``. Toponimo. |
| Sunsilk Tapestries / Sunsilk (brand) | Arazzi Setasole | Decisione dell'utente del 14 novembre 2026 | Nome della bottega/azienda di Ul'dah e del marchio; usare «Arazzi Setasole» anche nei riferimenti a capi, commissioni e tessitori del marchio. Adattare articoli e preposizioni al contesto. Fonti EN/hash: `PlaceName#642.0/.2`, `#644.0/.2`, `Balloon#631`, `DefaultTalk#590336.20`, `#590338.20`. Riconciliazione di 30 target in 17 file, inclusa DefaultTalk#590339.20 (riferimento confermato dal francese «Soieries du Soleil»). |
| Fullflower Comb | Favo Pienofiore | Decisione dell'utente | Riferimento: ``world/placename.json#159:translation``. Toponimo; usare l'articolo e le preposizioni maschili (al/del Favo). |
| Lord of the Bramble Patch | Signore del Rovo | Decisione dell'utente | Soprannome del cinghiale Kamapuaa; sostituisce «Lord del Rovo» e il nome inglese non tradotto. Non è un titolo nobiliare di Ishgard. Riferimenti: `corpus/flat/LogMessage.json#LogMessage#3201:target`; `#3202:original`; `@review/quests/arr/000/ClsLnc004_00056.json#106:original`. |
| Lakeland | Terralago | Decisione dell'utente | Toponimo; in prosa usare «Terralago» con preposizioni appropriate, per esempio «a Terralago» e «di Terralago». Riferimento: `world/placename.json#2953:name`. |
| Baldesion Arsenal | Arsenale di Baldesion | Decisione dell'utente | Nome della spedizione; in prosa accordare articolo e preposizioni alla forma maschile («nell'Arsenale di Baldesion»). Riferimenti: `corpus/flat/Achievement.json#Achievement#2227.2:target`; `corpus/flat/PublicContentTextData.json#PublicContentTextData#2132:target`. |
| Void Ark | Arca del Vuoto | Decisione dell'utente | Nome dell'aeronave e dell'incursione; in prosa accordare articolo e preposizioni alla forma femminile («l'Arca del Vuoto», «nell'Arca del Vuoto», «sull'Arca del Vuoto», «dell'Arca del Vuoto»). Riferimenti: `world/placename.json#2181:name`; `corpus/flat/ContentFinderCondition.json#ContentFinderCondition#120.43:target`. |
| The Thunderyards | I Cantieri del Tuono | Decisione dell'utente | Toponimo; usare questa forma nei titoli e nei riferimenti al luogo, adattando articolo e preposizioni. Riferimento: `corpus/flat/PlaceName.json#PlaceName#4680.0:target`.
| The Tempest | Fossantica | Decisione dell'utente | Toponimo; in prosa usare «Fossantica» con preposizioni appropriate, distinguendolo dalle tempeste meteorologiche e dalla Porta Tempesta. Riferimento: `corpus/flat/PlaceName.json#PlaceName#2958.0:target`. |
| Temenos Rookery | La Colombaia di Temenos | Decisione dell'utente | Nome della struttura di allevamento degli amaro nel Crystarium; usare la forma completa per questo luogo, mantenendo «Garzaia» per gli altri rookery. Riferimenti: `corpus/flat/Adventure.json#Adventure#2162896.13:target`; `world/placename.json#3246:name`. |
| Slitherbough | Fendiscoglio | Decisione dell'utente | Toponimo; usare questa forma per il villaggio e per i riferimenti alla sua provenienza, adattando la frase. Riferimenti: `world/chocobotaxistand.json#1179718:original`; `world/placename.json#3170:name`. |
| Estersands | Sabbie Orientali | Decisione dell'utente | Regione del deserto di Dalmasca; sostituisce «Dune Orientali». La decisione non riguarda Westersands. Riferimento: `corpus/custom/004/RegHinAllaganStorageSystem_00491.json#custom/004/RegHinAllaganStorageSystem_00491#TEXT_REGHINALLAGANSTORAGESYSTEM_00491_00491_ALLAGAN_000_180:target`. |
| Fields of Gold | Campi Dorati | Decisione dell'utente | Toponimo di Ok'hanu; sostituisce «Campi d'Oro». Riferimenti: `world/placename.json#4591:name`; `corpus/flat/EventItemHelp.json#EventItemHelp#2003513:target`. Varianti ammesse nelle etichette: «I Campi Dorati». |
| Cracked Cistern | Cisterna Crepata | Decisione dell'utente | Toponimo; sostituisce «Cisterna Incrinata». Conservare l'articolo richiesto dalla frase o dall'etichetta. Riferimento: `world/placename.json#4605:name`. Varianti ammesse nelle etichette: «La Cisterna Crepata». |
| Zephyr Gate | Porta Zefiro | Decisione dell'utente | Toponimo; usare questa forma, con articoli e preposizioni richiesti dalla frase. Riferimenti: `world/placename.json#179:name`; `world/placename.json#735:name`. |
| The Salt Strand | La Riva Salata | Decisione dell'utente | Toponimo; usare questa forma, con articoli e preposizioni richiesti dalla frase. Riferimenti: `corpus/flat/Adventure.json#Adventure#2162693.13:target`; `corpus/flat/PlaceName.json#PlaceName#338.0:target`. |
| The Hard Place | L'Incudine | Decisione dell'utente | Nome del locale di Adkiragh; usare «all'Incudine» nei riferimenti al luogo e «dell'Incudine» quando la frase richiede la preposizione articolata. Riferimenti: `corpus/flat/PlaceName.json#PlaceName#2096.0:target`; `corpus/flat/DefaultTalk.json#DefaultTalk#595139.20:target`. |
| Keeper of the Lake | Custode del Lago | Decisione dell'utente | Nome del relitto formato dai resti del `Agrius` e di Midgardsormr; usare la forma maschile con articoli e preposizioni appropriati («il Custode», «al Custode», «del Custode»). Riferimenti: `corpus/flat/PlaceName.json#418.0/.2`; `corpus/flat/Adventure.json#2162767.13`; `corpus/cut_scene/025/VoiceMan_02500.json#TEXT_VOICEMAN_02500_000200_LUCIA`. |
| Archeo Alexandria | Archeo Alexandria | `world/placename.json#4676:name` | Conservare il toponimo ufficiale «Alexandria», senza adattarlo in «Alessandria». |
| The Source | La Sorgente | `corpus/flat/AkatsukiNoteString.json#AkatsukiNoteString#33:target` | Nome del mondo; forma attestata anche in `TripleTriadCard#387:col_2`. |
| The Source | La Fonte (legacy, superata) | `data/translations/world/placename.json#3039/#3294/#3700:translation` | Forma legacy diretta superata dalla decisione dell'utente «La Sorgente» per il nome del mondo; non ammetterla come variante. Non estendere la decisione alle fonti comuni o ad altri toponimi, come «Fonte di Maya». |
| The Missing Gem | La Gemma Mancante | `corpus/flat/PlaceName.json#PlaceName#2267.0:target` | Nome dell'isola / settore esplorativo nel Diadema. |
| The One River | Fiumescelto | `corpus/flat/SpearfishingItem.json#SpearfishingItem#20034:target` | Nome del fiume in Yanxia; forma preferita dall'utente. |
| The Ruby Sea | Il Mar Rubino | `corpus/flat/ContentFinderConditionTransient.json#ContentFinderConditionTransient#235:target` | Nome del mare; varianti ammesse in prosa: «Mare di Rubino». |
| The Wolves' Den | L'Antro dei Lupi | Decisione dell'utente | Canone scelto per tutti i riferimenti alla destinazione, comprese le occorrenze nelle quest e nella prosa main; adattare articoli e preposizioni. Sostituisce «La Tana dei Lupi» come variante di corpus. Riferimenti legacy: `corpus/custom/001/RegSeaPvpColosseum_00102.json#custom/001/RegSeaPvpColosseum_00102#TEXT_REGSEAPVPCOLOSSEUM_00102_BERKOEYA_000_010:target`; `world/achievementcategory.json#9:name`. |
| The Wolves' Den | L'Antro dei Lupi / La Tana dei Lupi | Decisione dell'utente | Varianti della memoria legacy: «Antro» nella descrizione dell'arena PvP e «Tana» nelle categorie e nella prosa dei luoghi. Usare la forma del campo legacy corrispondente; nelle quest main-only questa revisione usa «Tana dei Lupi», coerente con «Molo della Tana dei Lupi». Riferimenti: `corpus/custom/001/RegSeaPvpColosseum_00102.json#custom/001/RegSeaPvpColosseum_00102#TEXT_REGSEAPVPCOLOSSEUM_00102_BERKOEYA_000_010:target`; `world/achievementcategory.json#9:name`. |
| Minion Square | Piazza dei Minion | `world/placename.json#1578:name` | Area del Gold Saucer dedicata a Lord of Verminion; mantenere «Minion» invariato. |
| Beankeep | Assistente di Blunderville | Decisione dell'utente | Ruolo dell'incaricato di Blunderville; sostituisce «Custode dei Fagioli». Riferimento: `corpus/flat/ENpcResident.json#ENpcResident#1046439.0:target`. |
| The Sea of Clouds | Mare di Nuvole | `world/contentfinderconditiontransient.json#11:original` | Nome del mare; varianti ammesse in prosa: «Mare di Nuvole». |
| Mt. Gulg | Monte Gulg | `corpus/flat/ContentFinderConditionTransient.json#ContentFinderConditionTransient#659:target` | Forma usata in prosa; varianti ammesse per il nome autonomo: «Mt. Gulg». |
| Mt. Gulg | Mt. Gulg | `world/placename.json#2997:name` | Variante ammessa per il toponimo autonomo; in prosa usare «Monte Gulg». |
| The First | Il Primo Mondo | `corpus/flat/MountTransient.json#MountTransient#170.1:target` | Nome del Primo Riflesso; varianti ammesse in prosa: «Prima Riflessione», «della Prima», «del Primo», «la Prima», «il Primo», «nel Primo». |
| The Interdimensional Rift | La Faglia Interdimensionale | `corpus/flat/CompanionTransient.json#CompanionTransient#345.1:target` | Nome del luogo; varianti ammesse in prosa: «Fenditura Interdimensionale». |
| The Tower of Zot | La Torre di Zot | `corpus/flat/TripleTriadCard.json#TripleTriadCard#336.8:target` | Nome del luogo; varianti ammesse in prosa: «Torre di Babil». |
| Victors' Spoils | Le Spoglie dei Vincitori | Decisione dell'utente | Nome del luogo; femminile plurale, con articoli e accordi al plurale («alle/delle Spoglie»). Distinguere il toponimo dall'espressione comune «to the victor go the spoils». Riferimento: `world/placename.json#3906:name`. |
| The Warring Triad | Triade della Discordia | `corpus/flat/TripleTriadCard.json#TripleTriadCard#168.8:target` | Nome del gruppo di tre eikon. |
| Dragonsong War | Guerra del Canto dei Draghi | Decisione dell'utente | Nome del conflitto ishgardiano; uniformare nei titoli e nella prosa riferiti allo stesso evento. Riferimenti: `corpus/flat/InstanceContentTextData.json#InstanceContentTextData#32621:target`; `corpus/flat/OpenContentCandidateName.json#OpenContentCandidateName#33:target`. |
| The World of Darkness | Il Mondo dell'Oscurità | `corpus/flat/GimmickBill.json#GimmickBill#60:target` | Nome del Tredicesimo; varianti ammesse in prosa: «Mondo delle Tenebre». |
| The Battlehall | La Sala d'Armi | `corpus/flat/CustomTalk.json#CustomTalk#721265.64:target` | Nome del luogo; varianti ammesse in prosa: «Sala dei Duelli». |
| The Scholar | Erudito | `corpus/flat/OmikujiGuidance.json#OmikujiGuidance#2501.2:target` | In questi testi indica l'archetipo del saggio; non il Job. Varianti ammesse in prosa: «studioso». |
| The Scholar | Lo Studioso | `corpus/flat/PlaceName.json#PlaceName#3826.0:target` | Nome del landmark di Thaliak nello Scholar's Harbor; variante approvata per il nome del luogo. |
| Hair Raid | Incursione dei Capelli | `corpus/flat/Action.json#Action#30076:target` | Nome di un'azione; variante ammessa in prosa: «Assalto di Capelli». |
| Wanderlust | Sete di Viaggio | `data/translations/world/placename.json#2960:translation` | Nome proprio; variante ammessa per il compagno: «Spirito Vagabondo». Fonte corretta; PlaceName#2150 è «Singularity Reactor». |
| Tessellation | Tassellazione | `corpus/flat/Addon.json#Addon#8678:target` | Opzione grafica; variante ammessa: «La Tassellatura». |
| Tessellation | La Tassellatura | `data/translations/world/placename.json#3240:translation` | Nome del ponte che collega l'Exarch Gate al Crystarium; variante approvata per l'opzione grafica. |
| Gatekeeper | Guardiano dei Cancelli | `corpus/flat/Title.json#Title#207.1:target` | Decisione dell'utente dell'11 novembre 2026: «Guardiano dei Cancelli» per il titolo Title#207.1 (Gatekeeper); sostituisce «Custode delle Porte» in questa etichetta. La variante «Custode delle Porte» resta ammessa in prosa. Non estendere a fazioni, mestieri o altri omonimi. |
| The Rothlyt Sound | Stretto di Rothlyt | `corpus/flat/TripleTriadCard.json#TripleTriadCard#10.8:target` | Nome dello stretto; varianti ammesse in prosa: «Stretto di Rothlyt». |
| The Aetherfont | La Fonte Eterica | `corpus/flat/TripleTriadCard.json#TripleTriadCard#381.8:target` | Nome del luogo. |
| Pilgrim's Traverse | Traversata del Pellegrino | `data/translations/world/placename.json#5277:translation` | Nome proprio; variante ammessa in prosa: «Cammino del Pellegrino». Fonte corretta; PlaceName#2150 è «Singularity Reactor». |
| Kydonia Knolls | I Poggi di Kydonia | `corpus/flat/CompanionTransient.json#CompanionTransient#495.1:target` | Nome di una formazione rocciosa. |
| Moongate Hub | Lo Snodo della Porta Lunare | `corpus/flat/WKSPlanetSelect.json#WKSPlanetSelect#0:target` | Nome della base lunare. |
| Maelstrom | La Tempesta | `data/translations/world/placename.json#1775:translation` | Nome della compagnia; come sostantivo comune, «maelstrom» si traduce «vortice». |
| Maelstrom | Vortice | `corpus/flat/Action.json#Action#7127:target` | Uso comune in un nome d'azione; la Compagnia usa «La Tempesta». |
| Camp Skull Valley | Campo Valleteschio | Decisione dell'utente del 14 novembre 2026 | Forma canonica dell'accampamento in tutto il corpus; distinguere da «Skull Valley» senza «Camp». Riferimenti EN/hash: `corpus/flat/PlaceName.json#PlaceName#224.0/.2`; `corpus/flat/Adventure.json#Adventure#2162715.13`. |
| Loading Station | Stazione di Carico | `corpus/flat/PlaceName.json#PlaceName#2599.0:target` | Varianti ammesse in prosa: «stazione», «stazioni», «stazioni di carico». |
| Camp Iron Lake | Campo Lago di Ferro | `corpus/flat/Achievement.json#Achievement#355.1:target/translation_description` | Nome completo della località; distinto dal luogo «Iron Lake». Fonte legacy diretta verificata per ID, EN e hash. |
| Camp Nine Ivies | Campo Nove Edere | `corpus/flat/Achievement.json#Achievement#359.1:target/translation_description` | Nome completo della località; distinto dal luogo «Nine Ivies». Fonte legacy diretta verificata per ID, EN e hash. |
| Black Brush | Sterpenero | Decisione dell'utente | Toponimo base; «Black Brush Station» resta «Stazione Sterpenero» e «Camp Black Brush» resta «Campo Sterpenero». Fonte: `world/placename.json#248:translation`. |
| Camp Black Brush | Campo Sterpenero | `corpus/flat/Achievement.json#Achievement#365.1:target/translation_description` | Nome completo della località; distinto dal luogo «Black Brush». Fonte legacy diretta verificata per ID, EN e hash. |
| Camp Broken Water | Campo Acqua Spezzata | `world/placename.json#254:name` | Nome completo della località; distinto dal luogo «Broken Water». |

| The Tam-Tara Deepcroft | La Cripta di Tam-Tara | `corpus/flat/PlaceName.json#PlaceName#58.0:target` | Forma canonica applicata alle tre occorrenze. |
| Dzemael Darkhold | Fortezza Oscura di Dzemael | `data/translations/world/placename.json#64:translation` | Forma canonica applicata alle tre occorrenze. |
| Blue Badger Gate | Porta del Tasso Blu | `data/translations/world/placename.json#87:translation` | Forma canonica applicata a entrambe le occorrenze. |
| Naked Rock | Roccianuda | `world/placename.json#92:name` | Forma canonica applicata a entrambe le occorrenze. |
| The Fold | La Piega | `corpus/flat/PlaceName.json#PlaceName#5125.0:target` | Forma canonica applicata alle tre occorrenze. |
| Abalathia's Spine | Spina di Abalathia | `corpus/flat/Addon.json#Addon#1590:target` | Forma in questa frase; la voce PlaceName autonoma è «La Spina di Abalathia». |
| Crystal Tower Striker | Il Martello della Torre di Cristallo | `corpus/flat/Addon.json#Addon#9989:target` | Nome completo; non applicare separatamente il termine «Crystal Tower». |
| Island Sanctuary | Rifugio Insulare | `corpus/flat/Addon.json#Addon#1799:target` | Nome dell'area; in prosa usare le minuscole e adattare l'articolo. |
| Hideaway | Base dell'Isola | `corpus/flat/DescriptionString.json#DescriptionString#684:target` | Nel Rifugio Insulare indica la base operativa sud-occidentale dell'isola; variante ammessa in prosa: «base». |
| The Occult Crescent | Falce Occulta | `corpus/flat/PlaceName.json#PlaceName#4931.0:target` | Nome dell'area; variante ammessa in prosa: «Falce Occulta» quando l'articolo è retto da una preposizione. |
| The Occult Crescent | La Falce Occulta | `system/description.json#3604507:name` | Forma autonoma del nome dell'area. |
| Treasure Coffer | Forziere | `corpus/flat/Addon.json#Addon#17622:target` | In questi messaggi indica il forziere che contiene il tesoro. Varianti ammesse in prosa: «Scrigno del Tesoro». |
| Treasure Coffer | Scrigno del Tesoro | `corpus/flat/Addon.json#Addon#10113:target` | Variante usata come etichetta autonoma. |
| Residential Area | Zona Residenziale | `corpus/flat/Addon.json#Addon#8463:target` | Nome della zona; in prosa usare le minuscole. |
| Market Wards | quartiere mercantile | `corpus/flat/Addon.json#Addon#948:target` | Forma singolare contestuale dopo «alcun». |
| Market Wards | Rioni del Mercato | `world/placename.json#753:name` | Nome proprio della località; distinto dall'uso comune singolare. |
| Starward Standings | Spalti delle Stelle | `world/placename.json#2567:name` | Nome della località; la funzione usa «Classifica Stellare». |
| Abalathia's Spine | La Spina di Abalathia | `data/translations/world/placename.json#497:translation` | Forma autonoma del toponimo; nelle frasi può cadere l'articolo. |
| Skull Valley | Valleteschio | `corpus/flat/Adventure.json#Adventure#2162716.15:target` | Forma canonica applicata a entrambe le occorrenze. |
| Via Praetoria | Via Praetoria | `data/translations/world/placename.json#429:translation` | Forma canonica applicata a entrambe le occorrenze. |
| Central Hall | Salone Centrale | `corpus/flat/PlaceName.json#PlaceName#5484.0:target` | Forma canonica applicata a entrambe le occorrenze. |
| Chocobokeep | Chocobiere | `world/placename.json#2315:name` | Forma canonica applicata a tutte le occorrenze. |
| Fang Cage | Gabbia della Zanna | `world/placename.json#1700:name` | Forma canonica applicata a tutte le occorrenze. |
| Claw Cage | Gabbia dell'Artiglio | `world/placename.json#1699:name` | Forma canonica applicata a tutte le occorrenze. |
| Inner Sanctum | Sancta Sanctorum | `world/placename.json#1560:name` | Forma canonica applicata a entrambe le occorrenze. |
| The Presence Chamber | Sala delle Udienze | `corpus/flat/PlaceName.json#PlaceName#872.0:target` | Decisione dell'utente dell'11 novembre 2026: Sala delle Udienze per il toponimo e i riferimenti pertinenti; sostituisce Camera d'Udienza. Riferimenti: PlaceName#872.0/.2 e PlaceName#3389.0/.2. |
| Third Floor | Terzo Piano | `corpus/flat/PlaceName.json#PlaceName#1529.0:target` | Forma canonica applicata a tutte le occorrenze. |
| Sohm Al Summit | Vetta Sohm Al | `corpus/flat/PlaceName.json#PlaceName#1010.0:target` | Forma canonica applicata a entrambe le occorrenze. |
| Dimwold | Selvacupa | `world/placename.json#1015:name` | Forma canonica applicata a entrambe le occorrenze. |
| Mirage Creek | Torrente Miraggio | `world/placename.json#1018:name` | Forma canonica applicata a entrambe le occorrenze. |
| The Slow Wash | La Lenta Corrente | `corpus/flat/PlaceName.json#PlaceName#1020.0:target` | Forma canonica applicata a entrambe le occorrenze. |
| The Sultana's Breath Subdivision | Quartieri del Respiro della Sultana | `corpus/flat/PlaceName.json#PlaceName#1191.0:target` | Forma canonica applicata a entrambe le occorrenze. |
| The Sultana's Breath | Il Respiro della Sultana | `corpus/flat/PlaceName.json#PlaceName#1211.0:target` | Forma canonica applicata a entrambe le occorrenze. |


| Old Sharlayan | Vecchia Sharlayan | `data/translations/world/placename.json#3706:translation` | Nome del luogo. In prosa usare la preposizione semplice: «di Vecchia Sharlayan» o «della Vecchia Sharlayan» (vietato l'uso di «del Vecchia Sharlayan»). |
| Netroot Radius | Raggio di Radicirete | `corpus/flat/WKSDevGrade.json#WKSDevGrade#205.3:target` | Nome del luogo o della struttura. |
| Piercingway Tunnel | Galleria di Trivéllalo | `data/translations/world/placename.json#5238:translation` | Nome del luogo o della struttura, senza articolo nel campo nome. Adattamento del nome Loporrit secondo la decisione dell'utente (Piercingway > Trivéllalo). |
| The Cosmoor | L'Ormeggio Cosmico | `corpus/flat/WKSMissionText.json#WKSMissionText#89:target` | Nome del luogo o della struttura. |
| Zorgor the Boundless | Zorgor lo Sconfinato | `corpus/flat/GimmickBill.json#GimmickBill#90:target` | Nome del luogo o della struttura. |
| Rhotano Sea | Mare di Rhotano | `world/adventure.json#2162693:col_2` | Nome del luogo o della struttura. |
| Castrum Abania | Castrum Abania | `corpus/flat/Adventure.json#Adventure#2162850.15:target` | Nome del luogo o della struttura. |
| The Aurum Vale | Valdorata | `corpus/flat/ContentFinderConditionTransient.json#ContentFinderConditionTransient#5:target` | Nome del luogo o della struttura. |
| The Matron's Lethe | Il Lete della Matrona | `corpus/flat/ContentFinderConditionTransient.json#ContentFinderConditionTransient#49:target` | Nome del luogo o della struttura. |
| Bowl of Embers | Cratere delle Braci | `data/translations/world/placename.json#357:translation` | Nome del luogo. Maschile: «il Cratere delle Braci», «al Cratere delle Braci», «del Cratere delle Braci» (vietato l'uso dell'articolo femminile «alla Cratere»). |
| Windspath Gardens | Giardini del Cammino del Vento | `corpus/flat/FateEvent.json#FateEvent#690.62:target` | Nome del luogo o della struttura. |
| The Unmaking | La Disfazione | `corpus/flat/MountTransient.json#MountTransient#444.1:target` | Nome del luogo o della struttura. |
| Bestways Burrow | Tana dei Modi Migliori | `data/translations/world/placename.json#3966:translation` | Nome del luogo o della struttura. |

| The Resonatorium | Il Risonatorio | `corpus/flat/MYCWarResultNotebook.json#MYCWarResultNotebook#38.10:target` | Nome del luogo o della struttura. Varianti ammesse in prosa: «Risonatorio». |
| Shin-Zantetsuken Containment Unit | Unità di Contenimento Shin-Zantetsuken | `corpus/flat/PublicContentTextData.json#PublicContentTextData#2126:target` | Nome del luogo o della struttura. Varianti ammesse in prosa: «Unità di Contenimento della Zantetsuken Autentica». |
| Lance of Virtue Containment Unit | Unità di Contenimento Lancia della Virtù | `corpus/flat/PublicContentTextData.json#PublicContentTextData#2128:target` | Nome del luogo o della struttura. Varianti ammesse in prosa: «Unità di Contenimento della Lancia della Virtù». |
| Proto Ozma Containment Unit | Unità di Contenimento Proto Ozma | `corpus/flat/PublicContentTextData.json#PublicContentTextData#2130:target` | Nome del luogo o della struttura. Varianti ammesse in prosa: «Unità di Contenimento di Proto Ozma». |
| Smoldering Bedchamber | Camera da Letto delle Braci | `corpus/flat/VVDVoteRouteLabel.json#VVDVoteRouteLabel#6:target` | Decisione dell'utente per la label del percorso: preferire la resa main «La Camera da Letto delle Braci» alla legacy «La Camera da Letto Fumante». L'epiteto «The Pari of Plenty» resta in inglese in questa label. |
| Sea-maid's Mirror | Specchio della Sirena | `corpus/flat/VVDVoteRouteLabel.json#VVDVoteRouteLabel#7:target` | Nome del luogo o della struttura. Varianti ammesse in prosa: «Specchio della Fanciulla del Mare». |
| Goldsmiths' Guild | Gilda degli Orafi | `corpus/flat/CompanionTransient.json#CompanionTransient#4.1:target` | Nome del luogo o della struttura. Varianti ammesse in prosa: «capogilda degli Orafi». |
| Memeroon's Trading Post | La Locanda di Memeroon | `corpus/flat/CompanionTransient.json#CompanionTransient#26.1:target` | Nome del luogo o della struttura. Varianti ammesse in prosa: «Bottega di Memeroon», «Bazar di Memeroon». |
| Saint Mocianne's Arboretum | Arboreto di Santa Mocianne | `corpus/flat/CompanionTransient.json#CompanionTransient#166.1:target` | Nome del luogo o della struttura. Varianti ammesse in prosa: «Arboreto di Saint Mocianne». |
| The Antitower | L'Antitorre | `corpus/flat/CompanionTransient.json#CompanionTransient#178.1:target` | Nome del luogo o della struttura. Varianti ammesse in prosa: «Torre dell'Antitour». |
| Leatherworkers' Guild | Gilda dei Conciatori | `corpus/flat/CompanionTransient.json#CompanionTransient#196.1:target` | Nome del luogo o della struttura. Varianti ammesse in prosa: «Gilda dei Lavoratori di Cuoio». |
| The Sirensong Sea | Il Mar Canto | `corpus/flat/CompanionTransient.json#CompanionTransient#258.1:target` | Nome del luogo o della struttura. Varianti ammesse in prosa: «Mare del Canto delle Sirene». |
| Hells' Lid | Tappinferno | `corpus/flat/CompanionTransient.json#CompanionTransient#279.1:target` | Nome del luogo o della struttura. Varianti ammesse in prosa: «Bocca dell'Inferno». |
| The Sil'dihn Subterrane | I Sotterranei di Sil'dih | `corpus/flat/CompanionTransient.json#CompanionTransient#463.1:target` | Nome del luogo o della struttura. Varianti ammesse in prosa: «Sotterranei di Sil'dih». |
| The Underworld | Il Regno Sotterraneo | `corpus/flat/CompanionTransient.json#CompanionTransient#477.1:target` | Varianti ammesse in prosa: «Inferi» per il luogo personificato, «inferi» in senso comune o idiomatico. |
| The Skydeep Cenote | Il Cenote Abissale | `corpus/flat/CompanionTransient.json#CompanionTransient#519.1:target` | Nome del luogo o della struttura. Varianti ammesse in prosa: «Cenote delle Profondità Celesti». |
| Marsh Ligaka | Palude Ligaka | `corpus/flat/SpearfishingItem.json#SpearfishingItem#20262:target` | Nome del luogo o della struttura. Varianti ammesse in prosa: «palude di Ligaka». |
| The Ut'ohmu Horizon | Orizzonte Ut'ohmu | `corpus/flat/SpearfishingItem.json#SpearfishingItem#20267:target` | Nome del luogo o della struttura. Varianti ammesse in prosa: «Orizzonte di Ut'ohmu». |
| Rooting Towerling | La Torretta Radicante | `corpus/flat/WKSDevGrade.json#WKSDevGrade#232.2:target` | Nome del luogo o della struttura. Varianti ammesse in prosa: «Torretta Radicante». |
| Capsule Chasm | Voragine delle Capsule | `corpus/flat/WKSText.json#WKSText#15:target` | Nome del luogo o della struttura. Varianti ammesse in prosa: «Abisso Capsule». |
| Fusingway Vent | Condotto di Fóndilo | `corpus/flat/WKSText.json#WKSText#16:target` | Nome del luogo o della struttura. Variante ammessa in prosa: «Fenditura di Fóndilo». Il nome Fusingway è adattato come Fóndilo secondo la decisione dell'utente. |
| Grandma Laurel | Nonna Alloro | `corpus/flat/WKSText.json#WKSText#29:target` | Nome del luogo o della struttura. Varianti ammesse in prosa: «nonna Laurel». |
| The Capitol | Il Campidoglio | `corpus/flat/ContentTalk.json#ContentTalk#208:target` | Nome del luogo o della struttura. Varianti ammesse in prosa: «Capitale». |
| Mistwake | Scia delle Nebbie | `data/translations/world/placename.json#5350:translation` | Adattamento richiesto dall'utente. Nome della spedizione e del luogo; femminile: «nella Scia delle Nebbie», «della Scia delle Nebbie». Per equipaggiamento e creature usare «della Scia delle Nebbie». «Wake» interpretato come scia; la wiki attesta il contesto del Continente della Nebbia, non un'etimologia esplicita. Altra attestazione: `corpus/flat/CabinetSubCategory.json#CabinetSubCategory#198:target`. |
| The Meso Terminal | Il Terminale Meso | `corpus/flat/PlaceName.json#PlaceName#5266.0:target` | Nome del luogo o della struttura. In prosa si può usare «Terminale Meso» senza articolo quando la sintassi lo consente. |
| Meso Terminal | Terminale Meso | Decisione dell'utente | Nome della struttura; usare «il Terminale Meso» quando la sintassi richiede l'articolo. Riferimento: `world/placename.json#4701:name`. |
| Everkeep | Roccaeterna | `data/translations/world/placename.json#4684:translation` | Nome della città e della torre. |
| The Derelicts | I Relitti | `corpus/flat/PlaceName.json#PlaceName#3258.0:target` | Nome del luogo; adattare articolo e preposizione alla frase. |
| The Ondo Cups | Coppe degli Ondo | `corpus/flat/PlaceName.json#PlaceName#3195.0:target` | Nome del luogo; adattare articolo e preposizione alla frase. |
| Full Bloom Gardens | Giardini della Piena Fioritura | `corpus/flat/PointMenu.json#PointMenu#18:target` | Nome del luogo o della struttura. Varianti ammesse in prosa: «Giardini Fioriti». |
| Tomb of the Nullstone | Tomba della Pietra Nullificante | `corpus/flat/TripleTriadCard.json#TripleTriadCard#152.8:target` | Nome del luogo o della struttura. Varianti ammesse in prosa: «Tomba della Pietranulla». |
| Watts's Anvil | L'Incudine di Watts | `corpus/flat/TripleTriadCard.json#TripleTriadCard#296.8:target` | Nome del luogo o della struttura. Varianti ammesse in prosa: «Fucina di Watts», «Incudine di Watts». |
| Matoya's Relict | L'Eremo di Matoya | `corpus/flat/TripleTriadCard.json#TripleTriadCard#306.8:target` | Nome del luogo o della struttura. Varianti ammesse in prosa: «Relitto di Matoya». |
| The Promenade | Il Lungomare | `data/translations/world/adventure.json#2162701:translation_col_2` | Nome del luogo o della struttura. Varianti ammesse in prosa: «Passeggiata». |
| The Fragrant Chamber | La Camera Profumata | `data/translations/world/adventure.json#2162701:translation_col_2` | Nome del luogo o della struttura. La forma «Sala Profumata» e' superata per questo referente dalla decisione specifica in DECISIONS.md. |
| Wailing Barracks | Caserma delle Sentinelle | Decisione dell'utente | Nome della struttura; usare «Caserma delle Sentinelle» nei riferimenti al luogo. Riferimenti: `PlaceName#570.0/.2`; `PlaceName#572.0/.2`; `custom/LucKbb102_03262` (tre occorrenze). |
| The Great Gubal Library | La Grande Biblioteca di Gubal | `corpus/flat/PlaceName.json#PlaceName#2038.0:target` | Nome della biblioteca; adattare articolo e preposizione alla frase («dalla Grande Biblioteca di Gubal»). Altre attestazioni: `corpus/flat/PlaceName.json#PlaceName#2038.0:target`; `corpus/custom/008/CmnDefSdsAddNpc01_00806.json#custom/008/CmnDefSdsAddNpc01_00806#TEXT_CMNDEFSDSADDNPC01_00806_ALPHINAUD_000_031:target`. |
| The Trivium | Il Trivio | `corpus/flat/Adventure.json#Adventure#2162894.15:target` | Nome del luogo o della struttura. Varianti ammesse in prosa: «Trivio». |
| The Buttress | Il Contrafforte | `corpus/flat/Adventure.json#Adventure#2162897.15:target` | Nome del luogo o della struttura. Varianti ammesse in prosa: «Volta». |
| Dwarven Hollows | Gli Antri dei Nani | `corpus/flat/Adventure.json#Adventure#2162913.15:target` | Nome del luogo o della struttura. Varianti ammesse in prosa: «Cunicoli Nanici». |
| House of Winds High | L'Alta Casa dei Venti | `corpus/flat/Adventure.json#Adventure#2162994.15:target` | Nome del luogo o della struttura. Varianti ammesse in prosa: «Casa Alta dei Venti». |
| Tuliyollal Trailhead | L'Imbocco del Sentiero di Tuliyollal | `corpus/flat/Adventure.json#Adventure#2163006.15:target` | Nome del luogo o della struttura. Varianti ammesse in prosa: «punto di partenza del sentiero di Tuliyollal». |
| Akh Afah Amphitheatre | L'Anfiteatro Akh Afah | `corpus/flat/ContentFinderCondition.json#ContentFinderCondition#79.43:target` | Nome del luogo o della struttura. Varianti ammesse in prosa: «Anfiteatro di Akh Afah». |
| Steps of Faith | Gradini della Fede | `corpus/flat/ContentFinderCondition.json#ContentFinderCondition#169.43:target` | Nome del luogo o della struttura. Varianti ammesse in prosa: «Ultimi Passi della Fede». |
| South Horn | Corno Sud | `corpus/flat/ContentFinderCondition.json#ContentFinderCondition#1018.43:target` | Nome del luogo o della struttura. Varianti ammesse in prosa: «Corno Meridionale». |
| North Horn | Corno Nord | `corpus/flat/ContentFinderCondition.json#ContentFinderCondition#1093.43:target` | Nome del luogo o della struttura. Varianti ammesse in prosa: «Corno Settentrionale». |
| The Haar | La Foschia | `corpus/flat/ContentFinderConditionTransient.json#ContentFinderConditionTransient#23:target` | Nome del luogo o della struttura. Varianti ammesse in prosa: «Foschia». |
| Naldiq & Vymelli's | Naldiq e Vymelli | `corpus/flat/ContentFinderConditionTransient.json#ContentFinderConditionTransient#40:target` | Nome del luogo o della struttura. Varianti ammesse in prosa: «Naldiq & Vymelli». |
| The Duergar Mountains | Montagne dei Duergar | `corpus/flat/ContentFinderConditionTransient.json#ContentFinderConditionTransient#779:target` | Nome del luogo o della struttura. Varianti ammesse in prosa: «Monti dei Duergar». |
| Royal Allagan Sunway | La Via Solare Reale Allagana | `corpus/flat/FateEvent.json#FateEvent#81.57:target` | Nome del luogo o della struttura. Varianti ammesse in prosa: «Strada Solare Allagana Reale». |
| The Wanderer's Haven | Il Rifugio del Vagabondo | `corpus/flat/MKDLore.json#MKDLore#46.6:target` | Nome del luogo o della struttura. Varianti ammesse in prosa: «Rifugio del Viandante». |
| Secluded Stacks / The Secluded Stacks | Biblioteca Appartata | `corpus/flat/PlaceName.json#PlaceName#5196.0:target` | Sala bibliotecaria in cima alla Torre del Sangue, contenente tomi, tavolette e manoscritti. «Stacks» ha valore bibliotecario; non usare «cataste». In prosa: «biblioteca appartata», rispettando le maiuscole dell'originale. Altra attestazione: `corpus/flat/MKDLore.json#MKDLore#30.5:target`. |
| The Diadem | Il Diadema | `corpus/flat/Addon.json#Addon#8462:target` | Nome del luogo o della struttura. Varianti ammesse in prosa: «Diadema». |
| Grounding Gale | Raffica Ancorante | Decisione dell'utente | Barriera di etere instabile del Diadema. Uniformare anche la precedente variante «Raffica di Ancoraggio». |
| Critical Engagement | Ingaggio Critico | Decisione dell'utente | Attività di Bozja e Zadnor. Varianti ammesse in prosa: «ingaggio critico», «ingaggi critici», «Ingaggi Critici». Sostituire le precedenti rese «scontro critico» e «scontro decisivo» riferite a questa attività, con articoli e preposizioni appropriati. |
| Iron Bellows | Il Mantice di Ferro | Decisione dell'utente | Bottega di Iola al Crystarium e titolo della missione omonima. Varianti ammesse in prosa: «Mantice di Ferro». In prosa accordare al singolare: «del Mantice di Ferro», «al Mantice di Ferro». Non mantenere il nome inglese né le precedenti preposizioni al plurale. |
| Fanciest Fish Finder | La più raffinata cercatrice di pesci / Il più raffinato cercatore di pesci | Decisione dell'utente | Titolo di reputazione assegnato da Donuhanu al giocatore. Usare SeString per i due generi; nella frase corrente mantenere minuscolo l'articolo. Non alternare «scopritrice/scopritore» o «più elegante» per questo stesso titolo. |
| Star Contributor | Contributore Stellare | Decisione dell'utente | Varianti ammesse in prosa: «Contributrice Stellare», «Contributori Stellari», «Contributrici Stellari». Controllo automatico: residuo plurale. Titolo dell'Esplorazione Cosmica: concordare gli appellativi rivolti al giocatore; mantenere il nome generico nelle etichette di stato e del riconoscimento. Il messaggio che nomina un premiato tramite lstr1 può riferirsi a una persona diversa dal lettore. |
| Skybuilders' Board | Bacheca dei Costruttori Celesti | Decisione dell'utente | Nome proprio della bacheca dei lavori del Firmamento; al plurale «bacheche dei Costruttori Celesti». Riferimenti: `corpus/flat/Addon.json#Addon#13200:target`; `corpus/flat/EObjName.json#EObjName#2010775.0:target`. |
| Sagolii Desert | Deserto di Sagolii | `corpus/flat/Lobby.json#Lobby#132.5:target` | Nome del luogo o della struttura. Varianti ammesse in prosa: «Deserto di Sagolii». |
| Irmin Hedge | Siepe di Irmin | `corpus/flat/Action.json#Action#26756:target` | Nome della barriera o evocazione protettiva vegetale. |
| The Forbidden Land, Eureka | Terra Proibita, Eureka | Decisione dell'utente | Nome del luogo; aggiungere il nome della regione quando la fonte specifica Anemos, Pagos, Pyros o Hydatos. Riferimenti: `corpus/flat/Addon.json#Addon#2305:target`; `corpus/flat/ContentFinderCondition.json#ContentFinderCondition#581.43:target`. |
| Lily Hills / Lily Hills Apartment | Colline dei Gigli / Appartamento delle Colline dei Gigli | Decisione dell'utente del 14 novembre 2026 | Usare «Colline dei Gigli» anche nei riferimenti dinamici agli appartamenti; non «Colli dei Gigli». Riferimenti: `corpus/flat/PlaceName.json#PlaceName#1807.0/.2`, `#1808.0/.2`, `#1813.0/.2`, `#1814.0/.2`; `corpus/custom/003/HouFixMansionOfficer_00363.json`; `corpus/custom/001/ComDefHousingOfficer_00136.json`. |
| Sultana's Breath Apartment / Lobby | Appartamento del Respiro della Sultana / Atrio del Respiro della Sultana | Decisione dell'utente del 14 novembre 2026 | Accordare la preposizione: «del Respiro». Riferimenti: `corpus/flat/PlaceName.json#PlaceName#1815.0/.2`, `#1816.0/.2`. |
| Nightsoil Pots | Vasi di Concime | Decisione dell'utente del 14 novembre 2026 | Forma specifica per questo luogo; non confondere *nightsoil* con un vaso da notte. Riferimenti: `corpus/flat/PlaceName.json#PlaceName#3264.0/.2`, `#3339.0/.2`. |
| Bhaflau / Arrapago / Zhayolm Remnants | Rovine di Bhaflau / Rovine di Arrapago / Rovine di Zhayolm | Decisione dell'utente del 14 novembre 2026 | Limitare la resa alle aree indicate; non sostituire globalmente «Remnants». Riferimenti: `corpus/flat/PlaceName.json#PlaceName#4155–#4157`, `#4161–#4163`; menzioni delle rovine di Bhaflau in `corpus/quest/046/AktKmj107_04676.json` e `AktKmj108_04677.json`. |
| Tower of White | Torre della Magia Bianca | Decisione dell'utente del 14 novembre 2026 | Toponimo e nome dell'obiettivo. Riferimenti: `corpus/flat/PlaceName.json#PlaceName#1345.0/.2`; `InstanceContentTextData#5401`. |
| Sphere of the Ravenous | Sfera dei Voraci | Decisione dell'utente del 14 novembre 2026 | Mantenere il plurale parallelo a «Sfera dei Ciechi» e «Sfera dei Muti». Riferimento: `corpus/flat/PlaceName.json#PlaceName#1435.0/.2`. |
| Unsevered Despair | Disperazione Inscindibile | Decisione dell'utente del 14 novembre 2026 | Nome del luogo e obiettivo dell'attività. Riferimenti: `corpus/flat/PlaceName.json#PlaceName#1767.0/.2`; `InstanceContentTextData#12400`. |
| School of Nihility | Sala di Lettura del Nulla | Decisione dell'utente del 14 novembre 2026 | Usare la forma riferita alla sala di lettura. Riferimento: `corpus/flat/PlaceName.json#PlaceName#1796.0/.2`. |
| Cold Arms' Quietus | Deposito delle Armi Fredde | Decisione dell'utente del 14 novembre 2026 | «Fredde» segue la sorgente EN e DE; «deposito» descrive la funzione indicata anche da FR e JA. Riferimento: `corpus/flat/PlaceName.json#PlaceName#4214.0/.2`. |
### Meteo

I nomi delle condizioni sono distinti dalle forme grammaticali usate nelle descrizioni.

| Inglese | Italiano | Fonte | Uso |
| --- | --- | --- | --- |
| Cryptlurker | Predatore delle Cripte | Decisione dell'utente | Set di equipaggiamento di Shadowbringers (patch 5.4, liv. 80). Nei nomi di armi, armature, accessori e forzieri usare «del Predatore delle Cripte» (es. «Spada del Predatore delle Cripte», «Corazza del Predatore delle Cripte della Difesa», «Spada del Predatore delle Cripte Potenziata»). Calco su FR «Rôdeur des cryptes» e DE «Krypta-Schleicher». Riferimenti: `corpus/flat/Item.json#32418.9` e segg. |
| Crypt [materiali] | [della] Cripta | Decisione dell'utente | Materiali di potenziamento per equipaggiamento Cryptlurker: Crypt Ester -> Estere della Cripta, Crypt Twine -> Spago della Cripta, Crypt Dusting -> Polvere della Cripta. Riferimenti: `corpus/flat/Item.json#32156.9`, `#32157.9`, `#32158.9`. |
| Showers | Rovesci | `corpus/flat/Weather.json#Weather#8.1:target` | Condizione meteorologica; distinta dalla variante «Rovesci passeggeri» attestata in un'altra voce meteo. |
| Thunder | Tuoni | `corpus/flat/Weather.json#Weather#9.1:target` | Condizione meteorologica al plurale; distinta dal nome dell'elemento «Tuono» nelle azioni. |
| Thunder | Tuono | `corpus/flat/Action.json#Action#144:target` | Nome dell'elemento nelle azioni; la condizione meteo usa il plurale «Tuoni». |
| Sandstorms | Tempesta di sabbia / Tempeste di sabbia | `corpus/flat/Weather.json#Weather#12.1:target` | Usare il singolare o il plurale secondo la frase. |
| Showers | Rovesci passeggeri | `corpus/flat/Weather.json#Weather#210.1:target` | Variante attestata in un'altra voce meteo. |

### Rifugio Insulare

Le voci identificano strutture, aree, visioni, missioni e mammets del Rifugio Insulare. I nomi degli NPC sono ruoli/nominativi di mammets specifici, non descrizioni generiche.

| Inglese | Italiano | Fonte | Uso |
| --- | --- | --- | --- |
| Cryptlurker | Predatore delle Cripte | Decisione dell'utente | Set di equipaggiamento di Shadowbringers (patch 5.4, liv. 80). Nei nomi di armi, armature, accessori e forzieri usare «del Predatore delle Cripte» (es. «Spada del Predatore delle Cripte», «Corazza del Predatore delle Cripte della Difesa», «Spada del Predatore delle Cripte Potenziata»). Calco su FR «Rôdeur des cryptes» e DE «Krypta-Schleicher». Riferimenti: `corpus/flat/Item.json#32418.9` e segg. |
| Crypt [materiali] | [della] Cripta | Decisione dell'utente | Materiali di potenziamento per equipaggiamento Cryptlurker: Crypt Ester -> Estere della Cripta, Crypt Twine -> Spago della Cripta, Crypt Dusting -> Polvere della Cripta. Riferimenti: `corpus/flat/Item.json#32156.9`, `#32157.9`, `#32158.9`. |
| Island Sanctuary Guide | Guida del Rifugio Insulare | `corpus/flat/LogMessage.json#LogMessage#10136:target` | Nome della guida di aiuto del Rifugio Insulare. |
| Landmarks | Punti di riferimento | Decisione dell'utente | Nel Rifugio Insulare indica le strutture costruibili dedicate; usare la stessa forma nelle etichette e in prosa. Riferimenti: `corpus/flat/Addon.json#Addon#14269:target`; `corpus/flat/Addon.json#Addon#15253:target`. |
| Sanctuary Rank [1] | Rango [1] del Rifugio Insulare | `corpus/flat/Achievement.json#Achievement#3089.2:target` | Progressione dell'isola; con il numero usare «rango 10 del rifugio insulare». |
| Islekeep | Custode dell'Isola | `corpus/flat/MJIText.json#MJIText#66:target` | Titolo del proprietario dell'isola; in prosa usare «custode dell'isola». |
| Cozy Cabin | Casetta Accogliente | `corpus/flat/MJIText.json#MJIText#2:target` | Struttura principale dell'isola. |
| Cropland | Campo Coltivato | `corpus/flat/MJIText.json#MJIText#62:target` | Area di coltivazione dell'isola. |
| Pasture | Pascolo | `corpus/flat/MJIText.json#MJIText#63:target` | Area per gli animali catturati. |
| Mossy Mountains | Montagne Muschiose | `corpus/flat/MJIText.json#MJIText#43:target` | Area di spedizione dei mammets del granaio. |
| Mountain Hollow | Cavità della Montagna | `corpus/flat/MJIProgress.json#MJIProgress#39.1:target` | Area interna alla grotta dell'isola, raggiunta durante la progressione. |
| The Coziest of Cabins | La Casetta più Accogliente | `corpus/flat/MJIProgress.json#MJIProgress#1.0:target` | Visione del Rifugio Insulare. |
| Top Crops | Coltivazioni Eccellenti | `corpus/flat/MJIProgress.json#MJIProgress#7.0:target` | Visione legata alla costruzione del Campo Coltivato. |
| Adorable Animals | Animali Adorabili | `corpus/flat/MJIProgress.json#MJIProgress#13.0:target` | Visione legata alla costruzione del Pascolo. |
| A Workshop of Wonders | Una Bottega delle Meraviglie | `corpus/flat/MJIProgress.json#MJIProgress#20.0:target` | Visione legata alla costruzione dell'officina. |
| The Perfect Paradise | Il Paradiso Perfetto | `corpus/flat/MJIProgress.json#MJIProgress#26.0:target` | Visione di sviluppo dell'isola. |
| Passionate Pioneering | Pionierismo Appassionato | `corpus/flat/MJIProgress.json#MJIProgress#28.0:target` | Visione di sviluppo dell'isola. |
| Delightful Discovery | Una Scoperta Entusiasmante | `corpus/flat/MJIProgress.json#MJIProgress#30.0:target` | Visione che sblocca la Cavità della Montagna. |
| The Land of Luxury | La Terra del Lusso | `corpus/flat/MJIProgress.json#MJIProgress#35.0:target` | Visione di sviluppo dell'isola. |
| A Subterranean Investigation | Un'Indagine Sotterranea | `corpus/flat/MJIProgress.json#MJIProgress#37.0:target` | Missione che porta alla Cavità della Montagna; distinta dalla visione «A Subterranean Expansion». |
| An Idyllic Island | Un'Isola Idilliaca | `corpus/flat/MJIProgress.json#MJIProgress#42.0:target` | Visione conclusiva dello sviluppo dell'isola. |
| Felicitous Furball | Batuffolo Felice | `corpus/flat/MJIProgress.json#MJIProgress#1.1:target` | Mammet che guida la squadra di aiutanti dell'isola. |
| Produce Producer | Curatore dei prodotti | `corpus/flat/Addon.json#Addon#14326:target` | Mammet che gestisce la coltivazione automatizzata; varianti ammesse in prosa: «coltivatore», «responsabile dei raccolti», «addetto alle colture». In `corpus/flat/ENpcResident.json#ENpcResident#1043465.0:target`, rispettare il minuscolo dell'originale: «curatore dei prodotti»; al plurale: «curatori dei prodotti». |
| Creature Comforter | Custode delle creature | `corpus/flat/Addon.json#Addon#15223:target` | Mammet che gestisce la cura degli animali del Pascolo; varianti ammesse in prosa: «responsabile degli animali», «addetto agli animali». In `corpus/flat/ENpcResident.json#ENpcResident#1043466.0:target`, rispettare il minuscolo dell'originale: «custode delle creature»; al plurale: «custodi delle creature». |
| Pathological Pathfinder | Esploratore Ossessivo | `corpus/flat/MJIProgress.json#MJIProgress#21.1:target` | Mammet che libera ed espande il terreno; rende il tono comico del nome. |
| Determined Digger | Scavatore Determinato | `corpus/flat/MJIProgress.json#MJIProgress#33.1:target` | Mammet addetto agli scavi nella Cavità della Montagna. |

### Titoli narrativi

| Inglese | Italiano | Fonte | Uso |
| --- | --- | --- | --- |
| Cryptlurker | Predatore delle Cripte | Decisione dell'utente | Set di equipaggiamento di Shadowbringers (patch 5.4, liv. 80). Nei nomi di armi, armature, accessori e forzieri usare «del Predatore delle Cripte» (es. «Spada del Predatore delle Cripte», «Corazza del Predatore delle Cripte della Difesa», «Spada del Predatore delle Cripte Potenziata»). Calco su FR «Rôdeur des cryptes» e DE «Krypta-Schleicher». Riferimenti: `corpus/flat/Item.json#32418.9` e segg. |
| Crypt [materiali] | [della] Cripta | Decisione dell'utente | Materiali di potenziamento per equipaggiamento Cryptlurker: Crypt Ester -> Estere della Cripta, Crypt Twine -> Spago della Cripta, Crypt Dusting -> Polvere della Cripta. Riferimenti: `corpus/flat/Item.json#32156.9`, `#32157.9`, `#32158.9`. |
| Once More, to the Ruby Sea | Ancora una volta, al Mar Rubino | `corpus/flat/Achievement.json#Achievement#1788.2:target` | Titolo della missione principale che conduce al Mar Rubino. |
| Futures Rewritten | Futuri Riscritti | Decisione dell'utente | Titolo della missione e denominazione condivisa di elementi per schede e banner; usare questa forma per tutte le occorrenze con sorgente esatta. Riferimenti: `da_revisionare/quests/master/completejournal.json#1088:original`; `corpus/flat/BannerBg.json#BannerBg#306:target`; `corpus/flat/CharaCardDecoration.json#CharaCardDecoration#575:target`. |
| Challenge Accepted | Sfida Accettata | Decisione dell'utente | Titolo; usare la forma nelle occorrenze con sorgente esatta. Riferimenti: `corpus/flat/Achievement.json#Achievement#1380.1:target`; `corpus/flat/Fate.json#Fate#1725.0:target`; `da_revisionare/quests/master/legacyquest.json#287:name`. |
| Newfound Adventure | Nuova Avventura Ritrovata | Decisione dell'utente | Titolo della missione; usare la forma anche nei riferimenti alla categoria «Tales of Newfound Adventure». Riferimenti: `corpus/flat/Achievement.json#Achievement#3075.1:target`; `da_revisionare/quests/master/completejournal.json#1206:original`. |
| Battle on the Big Bridge | Battaglia sul Grande Ponte | Decisione dell'utente | Nome del contenuto; usare la forma anche per la traccia orchestrion e nei riferimenti alla battaglia. Riferimenti: `corpus/flat/ContentFinderCondition.json#ContentFinderCondition#76.43:target`; `corpus/flat/Orchestrion.json#Orchestrion#72.0:target`; `da_revisionare/quests/master/completejournal.json#7399:original`. |
| On the Lamb | Gregge in fuga | Decisione dell'utente | Titolo riferito alla FATE e alle missioni che coinvolgono pecore; preservare il gioco di parole. Riferimenti: `corpus/flat/Fate.json#Fate#227.0:target`; `corpus/flat/Achievement.json#Achievement#1057.1:target`; `da_revisionare/quests/master/leve.json#511:name`. |
| Recollection | Rievocazione | Decisione dell'utente | Titolo del contenuto e della traccia orchestrion; non applicare meccanicamente al nome dell'azione «Recollection», che nel contesto resta «Ricordo». Riferimenti: `corpus/flat/ContentFinderCondition.json#ContentFinderCondition#1030.43:target`; `corpus/flat/Orchestrion.json#Orchestrion#852.0:target`; `da_revisionare/quests/master/completejournal.json#7773:original`. |
| Vanguard | L'Avanguardia | Decisione dell'utente | Nome del dungeon e della zona; usare la forma con articolo quando il titolo indica il contenuto o il luogo («L'Avanguardia»), senza articolo solo nei composti che lo richiedono. Riferimenti: `corpus/flat/ContentFinderCondition.json#ContentFinderCondition#831.43:target`; `world/placename.json#4677:name`; `da_revisionare/quests/master/completejournal.json#7729:original`. |
| It's Probably Pirates | Probabilmente sono pirati | Decisione dell'utente | Titolo della missione; mantenere questa forma nei requisiti di sblocco. Riferimenti: `corpus/flat/DefaultTalk.json#DefaultTalk#594798.22:target`; `corpus/flat/DefaultTalk.json#DefaultTalk#596333.21:target`. |

### Nomi propri

| Inglese | Italiano | Fonte | Uso |
| --- | --- | --- | --- |
| Cryptlurker | Predatore delle Cripte | Decisione dell'utente | Set di equipaggiamento di Shadowbringers (patch 5.4, liv. 80). Nei nomi di armi, armature, accessori e forzieri usare «del Predatore delle Cripte» (es. «Spada del Predatore delle Cripte», «Corazza del Predatore delle Cripte della Difesa», «Spada del Predatore delle Cripte Potenziata»). Calco su FR «Rôdeur des cryptes» e DE «Krypta-Schleicher». Riferimenti: `corpus/flat/Item.json#32418.9` e segg. |
| Crypt [materiali] | [della] Cripta | Decisione dell'utente | Materiali di potenziamento per equipaggiamento Cryptlurker: Crypt Ester -> Estere della Cripta, Crypt Twine -> Spago della Cripta, Crypt Dusting -> Polvere della Cripta. Riferimenti: `corpus/flat/Item.json#32156.9`, `#32157.9`, `#32158.9`. |
| Red Rooster Stead | Fattoria del Gallo Rosso | Decisione dell'utente | Nome della fattoria in Bassa La Noscea; usare questa forma nei nomi di luogo e nei riferimenti narrativi. Riferimenti: `PlaceName#200.0/.2:target`; `Leve#144.1:target`. Decisione dell'utente dell'11 novembre 2026: la stessa forma vale anche per il titolo del Diario Esplorazione `corpus/flat/Adventure.json#Adventure#2162694.13:target`; la vecchia variante «Il Gallo Rosso» e' superata in quel campo. |
| Geva patterns | modelli di Geva | Decisione dell'utente | Modelli e metodi per la lavorazione e il taglio delle pelli con il minimo spreco; sostituisce «stampe Geva» e le riprese anaforiche «stampe» nello stesso contesto. Non sono stampe decorative. Riferimenti: `corpus/flat/Adventure.json#Adventure#2162696.15:target`; `@review/quests/arr/000/ClsTan008_00064.json#4:original`; `#49:original`; `#72:original`; `#81:original`. |
| Yellowjackets | Giubbe Gialle | Decisione dell'utente | Nome della milizia di Limsa Lominsa; un membro è una «Giubba Gialla» al singolare e le «Giubbe Gialle» al plurale. Accordare articoli e aggettivi al contesto. Riferimenti: `corpus/flat/BNpcName.json#BNpcName#981.2:target`; `corpus/flat/ENpcResident.json#ENpcResident#1003285.2:target`. |
| Warrior of Darkness | Guerriero dell'Oscurità | Decisione dell'utente | Titolo riferito al personaggio giocante; accordare con il genere mediante If(gnum4), usando «Guerriera dell'Oscurità» al femminile. Riferimenti: `corpus/flat/BNpcName.json#BNpcName#5240.0:target`; `corpus/flat/ENpcResident.json#ENpcResident#1013810.0:target`. Varianti ammesse: «Guerriera dell'Oscurità», «<hex:020837E905FF194775657272696572612064656C6C274F736375726974C3A0FF1947756572726965726F2064656C6C274F736375726974C3A003>». |
| Shadowkeeper | Custode delle Ombre | Decisione dell'utente | Personaggio femminile; usare l'articolo e gli accordi al femminile («la Custode»). Riferimenti: `corpus/flat/Action.json#Action#22304:target`; `corpus/flat/BNpcName.json#BNpcName#9769.0:target`. |
| the watcher (Watcher lunare) | Custode | Decisione dell'utente | Per questa figura lunare usare «il custode» in prosa e nei nomi NPC; il toponimo The Watcher's Palace diventa «Palazzo del Custode». Non estendere a watcher generici o al distinto toponimo The Watcher (`PlaceName#2228`). Riferimenti: `ENpcResident#1038082:translation_description`; `VoiceMan_06003#TEXT_VOICEMAN_06003_000360`; `PlaceName#3950.0/.2`; `VoiceMan_06002#TEXT_VOICEMAN_06002_001710`. |
| Faux Commander | Comandante Volpe | Decisione dell'utente | Nome proprio del personaggio e delle ricompense associate; usare «Comandante Volpe» al singolare e «Comandanti Volpe» al plurale. Riferimenti: `corpus/flat/CharaCardDecoration.json#CharaCardDecoration#405:target`; `corpus/flat/ENpcResident.json#ENpcResident#1028179.0:target`. |
| Berube skipper | Amaro Berube | Decisione dell'utente | Nome della razza di Skip; usare per l'animale, non per chi lo alleva. Riferimenti: `corpus/flat/Item.json#Item#27251.8:target`; `corpus/custom/005/CtsDkbCharacter3_00569.json#custom/005/CtsDkbCharacter3_00569#TEXT_CTSDKBCHARACTER3_00569_BETHRIC_000_156:target`. |
| Brute Bomber | Brute Bomber | Decisione dell'utente | Ring name del combattente dell'Arcadion; usare la forma originale inglese in dialoghi, messaggi, etichette e riferimenti al personaggio (decisione dell'utente del 14 novembre 2026 per tutti i boss Arcadion M1–M12). Riferimenti: `corpus/flat/BannerBg.json#BannerBg#380:target`; `corpus/flat/BannerDesignPreset.json#BannerDesignPreset#361:target`. |

| Gods' Quiver | Faretra degli Dei | Decisione dell'utente | Nome della fazione; usare questa forma in tutto il corpus. Riferimenti: `corpus/flat/BNpcName.json#BNpcName#621.0:target`; `corpus/flat/BNpcName.json#BNpcName#1861.0:target`. |
| Convictors | Redento / Redenti | Decisione dell'utente | Nome della fazione e dei suoi membri: singolare «Redento», plurale «Redenti». Per la sede, usare «Rifugio dei Redenti». Riferimenti: `corpus/flat/ENpcResident.json#ENpcResident#1015169.2:target`; `corpus/flat/ENpcResident.json#ENpcResident#1015170.2:target`. |
| せーりーふー | せーりーふー | Decisione dell'utente | Lasciare la stringa in giapponese nei cinque campi `description` dei file custom: non ha una resa lessicale chiara e probabilmente non è usata nei file inglesi. |
| Nepto Dragon | Neptodrago | Decisione dell'utente | Nome della creatura; al plurale «Neptodraghi». Riferimenti: `items/item.json#8754:name`; `items/item.json#8754:col_3`. |
| Eastern alliance | Alleanza Orientale | Decisione dell'utente | Nome della coalizione; usare questa forma anche quando la frase richiede l'articolo o un'altra preposizione. Riferimenti: `corpus/flat/BNpcName.json#BNpcName#10180.0:target`; `corpus/flat/BNpcName.json#BNpcName#10180.2:target`. |
| Sultansworn | Giurati della Sultana | Decisione dell'utente | Nome della fazione; declinare «Giurato» e «Giurati» in base al referente, mantenendo il nome approvato. Riferimenti: `corpus/flat/BNpcName.json#BNpcName#970.0:target`; `corpus/flat/BNpcName.json#BNpcName#1911.0:target`. |
| Crystal Braves | Bravi di Cristallo | Decisione dell'utente | Nome della fazione; usare questa forma in prosa e nei nomi. Riferimenti: `corpus/flat/ENpcResident.json#ENpcResident#1001881.2:target`; `corpus/flat/ENpcResident.json#ENpcResident#1006967.2:target`. |
| Landsguard | Guardia Territoriale | Decisione dell'utente | Nome della forza di Tuliyollal; usare questa forma in dialoghi, nomi dei membri e testi di lore. Riferimenti: `corpus/flat/ENpcResident.json#ENpcResident#1046791.0:target`; `corpus/flat/ENpcResident.json#ENpcResident#1051928.0:target`. |
| Songstress of Ul'dah | Cantautrice di Ul'dah | Decisione dell'utente | Titolo dell'artista; mantenere «Cantautrice» nelle occorrenze pertinenti. Riferimenti: `corpus/flat/Balloon.json#Balloon#2882:target`; `corpus/flat/DefaultTalk.json#DefaultTalk#600699.20:target`. |
| Allagan Empire | Impero Allagano | Decisione dell'utente | Nome dell'impero; accordare l'aggettivo al nome «Impero». Riferimenti: `corpus/flat/NpcYell.json#NpcYell#18017:target`; `corpus/flat/EventItemHelp.json#EventItemHelp#2000936:target`. |
| Wood Wailers | Sentinelle del Bosco | Decisione dell'utente | Nome della fazione di Gridania; distinguere i riferimenti alla fazione dai guardaboschi generici. Riferimenti: `corpus/flat/ENpcResident.json#ENpcResident#1002841.2:target`; `corpus/flat/ENpcResident.json#ENpcResident#1002842.2:target`. Per un membro usare «Sentinella del Bosco»; accordare al femminile grammaticale anche quando il referente è un uomo. Per il ruolo sentry: «Guardia delle Sentinelle del Bosco» (plurale «Guardie delle Sentinelle del Bosco»). Sostituisce «Guardaboschi», «Guardiaselva» e Wood Wailer quando indicano la fazione o i suoi membri. |
| Twelveswood | Bosco dei Dodici | Decisione dell'utente | Nome della foresta; usare «Bosco» nelle occorrenze pertinenti. Riferimenti: `corpus/flat/RacingChocoboName.json#RacingChocoboName#1254:target`; `corpus/flat/DefaultTalk.json#DefaultTalk#589867.20:target`. |
| Final Days | Ultimi Giorni | Decisione dell'utente | Nome dell'evento; uniformare «Ultimi Giorni» nelle occorrenze pertinenti. Riferimenti: `corpus/flat/AkatsukiNoteString.json#AkatsukiNoteString#8:target`; `corpus/flat/AkatsukiNoteString.json#AkatsukiNoteString#9:target`. |
| The Unending Journey | Il Viaggio Senza Fine | Decisione dell'utente | Nome della funzione e dei relativi oggetti; allineare il menu alla forma già presente in `corpus/flat/Item.json#Item#13069.0:target`. Riferimenti: `corpus/flat/Item.json#Item#13069.9:target`; `corpus/flat/Addon.json#Addon#4800:target`. |
| Alexandrite | Alexandrite | Decisione dell'utente | Decisione dell'utente riconfermata l'11 novembre 2026: nome del catalizzatore delle armi dello Zodiaco, delle varianti perfette e dei riusi dello stesso materiale (incluso SubFst980_01670); il minerale comune resta alessandrite. Per il catalizzatore mantenere la grafia scelta anche nei nomi degli oggetti (es. «frammento di Alexandrite»). Riferimenti: `corpus/flat/PointMenuString.json#PointMenuString#63:target`; `corpus/flat/Item.json#Item#7883.9:target`. |
| Clutchfather Novv | Padre della Covata Novv | Decisione dell'utente | Titolo di Novv; usare «Covata» per il gruppo familiare, non «Branco». Riferimenti: `corpus/flat/DefaultTalk.json#DefaultTalk#591280.20:target`; `corpus/flat/CompanionTransient.json#CompanionTransient#61.2:target`. |
| Heavensturn | Capodanno Celeste | Decisione dell'utente | Nome della ricorrenza; usare la forma canonica in prosa e nei nomi degli oggetti collegati. Riferimenti: `corpus/flat/Orchestrion.json#Orchestrion#83.0:target`; `corpus/flat/FittingShopCategory.json#FittingShopCategory#102:target`. |
| Advent cake(s) (Capodanno Celeste) | Mochi di Capodanno | Decisione dell'utente | Nome dei dolci di riso tradizionali del Capodanno Celeste; in prosa usare «mochi di Capodanno», senza estendere la forma a mochi generici. Riferimenti: `corpus/flat/EventItem.json#EventItem#2001940.0:target`; `corpus/flat/EventItem.json#EventItem#2001940.9:target`. |
| Kobold(s) | koboldo / koboldi | Decisione dell'utente | Nome del popolo: «koboldo» al singolare, «koboldi» al plurale; accordare anche le forme aggettivali. Riferimenti: `corpus/flat/TripleTriadCard.json#TripleTriadCard#17.0:target`; `corpus/flat/ENpcResident.json#ENpcResident#1003859.0:target`. |
| Primal(s) | primale / primali | Decisione dell'utente | Nome delle entità evocate: «primale» al singolare e «primali» al plurale. Accordare l'articolo al genere della singola entità («il/la primale»; «i/le primali»). L'aggettivo generico *primal* può richiedere «primordiale» (es. «furia primordiale»), senza indicare un'entità evocata. «Primordiale» resta l'aggettivo comune quando la fonte dice *primordial/primeval* e non indica un Primale. Conservare «The Primals» nei nomi di gruppo, nei titoli musicali e nei crediti. Riferimenti: `corpus/flat/RacingChocoboName.json#RacingChocoboName#1419:target`; `corpus/flat/TripleTriadCardType.json#TripleTriadCardType#1:target`. |
| The Navel | L'Ombelico / Ombelico | Decisione dell'utente | Nome della località; usare «L'Ombelico» con articolo nel toponimo e «Ombelico» nella variante senza articolo. Riferimento lessicale legacy: `corpus/flat/PlaceName.json#PlaceName#359.0:target`; main: `PlaceName#359.0/.2`. |
| Stillglade Fane | Tempio della Radura Silente | Decisione dell'utente | Nome del Tempio dei Maghi Bianchi; usare «Radura Silente» in tutte le occorrenze del toponimo. Riferimento: `PlaceName#578.0/.2:target`. |
| Storm Landing | Approdo della Tempesta | Decisione dell'utente | Nome della località; mantenere «Approdo» e la specificazione «della Tempesta». Riferimenti: `PlaceName#1284.0/.2`; `PlaceName#1366.0/.2`. |
| South Shroud | Velo Meridionale | Decisione dell'utente | Nome della regione; usare «Velo Meridionale» e «Approdo del Velo Meridionale» per South Shroud Landing. Riferimenti: `PlaceName#56.0/.2`; `PlaceName#127.0/.2`. |
| Till Sea Swallows All | Finché il mare non ci inghiottirà tutti | Decisione dell'utente | Titolo della missione; mantenere la stessa forma nei titoli e nelle citazioni del titolo. Riferimenti: `Quest#66220:target`; `CompleteJournal#440`; `LegacyQuest#233`. |
| Limit Break | Trascendenza | Decisione dell'utente | Termine del sistema di combattimento; usare «Trascendenza» nei nomi di categoria e nelle istruzioni d'uso. Riferimenti: `ActionCategory#9/#15`; `HowToPage#240/#241/#243`; `KinGmc106_04902#SYSTEM_000_501`. |
| Haunted Manor | Maniero Infestato | Decisione dell'utente | Nome dell'istanza; mantenere «Maniero Infestato» nei menu e nei riferimenti all'istanza. Riferimenti: `HalloweenEntrance#MAINMENU_1/#CHALLENGEMENU_CONFIRM`; `ContentFinderCondition#181.43`. |
| Area Effect: Gloom | Tenebra | Decisione dell'utente | Nome dell'effetto di piano; usare «Tenebra» per il titolo dell'effetto. Riferimento: `DeepDungeonFloorEffectUI#11.1`. |
| Pomander / Protomander | Ambra / Protoambra | Decisione dell'utente | Nomi degli oggetti dei Dungeon del Profondo; mantenere la distinzione e non confonderli con il Vaso magico (Magic Pot). Riferimenti: `DeepDungeonItem#1.1/.3/.9`; `DeepDungeonItem#20.1/.3/.9`. |
| Battlewarden | Sovrintendente | Decisione dell'utente | Titolo del responsabile militare; usare «Sovrintendente» nei dialoghi e nelle quest pertinenti. Riferimenti: `ContentTalk#40/#60`; quest della Lepre Smarrita. |
| The Howling Eye | Il Cuore del Ciclone | Decisione dell'utente | Nome della Prova; mantenere questa forma nei nomi di luogo e nei riferimenti narrativi. Riferimenti: `PlaceName#361.0`; `PlaceName#459.0`; `GaiUsd012_01195#TEXT_GAIUSD012_01195_SEQ_01`. |
| Eikon(s) | eone / eoni | Decisione dell'utente | Usare «eone» al singolare e «eoni» al plurale quando la fonte impiega *eikon(s)* per queste entità evocate, distinguendo il termine da *primal(s)* («primale/primali»). La decisione non si estende all'aggettivo *eikonic*. Riferimenti: `minigames/tripletriadcard.json#137.8:target`; `#168.8:target`; `#182.8:target`. |
| Eidolon(s) | eone / eoni | Decisione dell'utente | Estensione esplicita della forma «eone/eoni» anche a *eidolon(s)*; applicare solo alle entità denominate *eidolon*, senza estendere agli usi generici. Riferimento della scelta: `VoiceMan_06200#TEXT_VOICEMAN_06200_004000–004040:target`. |
| Somanoutics | Somanautica | Decisione dell'utente | Nome dell'arte del Saggio; usare «Somanautica» anche nei riferimenti alla disciplina, come «fondamenti della Somanautica». Riferimenti: `corpus/flat/InstanceContentTextData.json#InstanceContentTextData#32034:target`; `corpus/flat/DefaultTalk.json#DefaultTalk#598424.20:target`. |
| Zodiac Weapon(s) | Arma dello Zodiaco / Armi dello Zodiaco | Decisione dell'utente | Nome della categoria; accordare «Arma/Armi» al numero e mantenere «dello Zodiaco». Riferimenti: `corpus/flat/Addon.json#Addon#2491:target`; `corpus/flat/AchievementCategory.json#AchievementCategory#63:target`. |
| Blackbosom | Cuorenero | Decisione dell'utente | Soprannome/cognome composto di Edda; mantenere la forma invariabile come nome proprio in tutti i testi, compresi NPC e personaggi secondari. Usare «Edda Cuorenero» e «di Cuorenero» secondo la sintassi. |
| Baderon Tenfingers | Baderon Diecidita | Decisione dell'utente | Soprannome composto: conserva il nome proprio Baderon e traduce «Tenfingers». Riferimento: `corpus/flat/ENpcResident.json#ENpcResident#1011882.0:target`. |
| Bert the Beloved | Bert il Benamato | Decisione dell'utente | Soprannome di Bert; usare questa forma nelle battute e nei riferimenti al personaggio. Riferimenti: `corpus/flat/DefaultTalk.json#DefaultTalk#599452.20:target`; `corpus/flat/DefaultTalk.json#DefaultTalk#598920.20:target`. |
| Chirpy Chocobo | Chocobo Cinguettante | Decisione dell'utente | Mascotte dei festeggiamenti (fête) della Ricostruzione di Ishgard («Tosatura dello Yak»). Riferimento: `corpus/flat/Balloon.json#Balloon#6318:target`. |
| Mighty Moogle | Moguri Possente | Decisione dell'utente | Mascotte dei festeggiamenti (fête) della Ricostruzione di Ishgard («Fatti di Stoffa Morbida»). Riferimento: `corpus/flat/Balloon.json#Balloon#6317:target`. |
| Perky Piggy | Porcellino Vispo | Decisione dell'utente | Mascotte dei festeggiamenti (fête) della Ricostruzione di Ishgard («Caccia al Balocco»). Riferimento: `corpus/flat/Balloon.json#Balloon#6304:target`. |
| Iceheart | Cuordighiaccio | Decisione dell'utente | Nome tradotto; plurale «Cuordighiaccio». Nome proprio composto; con titolo nobiliare «Lady Cuordighiaccio» (i titoli nobiliari di Ishgard restano in inglese). Riferimenti: `corpus/flat/Quest.json#Quest#67140:target`; `corpus/flat/AkatsukiNoteString.json#AkatsukiNoteString#196:target`. |
| Coeurlfist | Pugnoiaguaro | Decisione dell'utente | Soprannome (Ivon Pugnoiaguaro); sostituisce la precedente eccezione «Pugno di Coeurl» (10 novembre 2026). |
| magitek avenger | vendicatore magitec | Decisione dell'utente | Nome comune di macchina; plurale «vendicatori magitec» e minuscolo nei campi che hanno la fonte minuscola. |
| white whittret | donnola bianca | Decisione dell'utente | Nome comune della creatura; concordare l'aggettivo al plurale («donnole bianche»). |
| bridesmoogle | moguri nuziale | Decisione dell'utente | Nome comune della creatura; «moguri» resta invariabile e l'aggettivo concorda («moguri nuziali» al plurale). |
| Redback | Dorsorosso | Decisione dell'utente | Nome proprio del minion; plurale «Dorsorossi» quando la fonte indica più esemplari. |
| Minitek | minitec | Decisione dell'utente | Adattamento di «magitek» usato come nome comune; rispettare il minuscolo salvo inizio frase. |
| bitty duckbill | ornitorinco minuscolo | Decisione dell'utente | Nome comune della creatura; concordare al plurale («ornitorinchi minuscoli»). |
| gimme kitten | gattino scroccone | Decisione dell'utente | Nome comune del minion; concordare al plurale («gattini scrocconi»). |
| Dreambringer | Portatore di Sogni | ../ffxiv-corpus-en/corpus/flat/Item.json#Item#46786.9:en (hash verificato) | Nome del minion; al minuscolo usare «portatore di sogni» al singolare e «portatori di sogni» al plurale. Riferimenti riconciliati: corpus/flat/Companion.json#Companion#560.0/.2; corpus/flat/BNpcName.json#BNpcName#14257.0/.2; corpus/flat/ENpcResident.json#ENpcResident#1054242.0/.2, #1054681.0/.2, #1054683.0/.2, #1054688.0/.2, #1054691.0/.2, #1054694.0/.2; corpus/flat/CompanionTransient.json#CompanionTransient#560.0; corpus/flat/Item.json#Item#46786.0/.2/.8/.9; corpus/flat/DefaultTalk.json#DefaultTalk#600877.21. Non estendere automaticamente al titolo distinto «Bringer of Dreams» in Achievement#3790.2. |
| puny mage | maghetto minuscolo | Decisione dell'utente | Nome comune; concordare al plurale («maghetti minuscoli»). |
| flame recruit | recluta della fiamma | Decisione dell'utente | Ruolo militare; mantenere «fiamma» minuscolo e concordare al plurale. |
| magic pot | vaso magico | Decisione dell'utente | Nome comune della creatura; usare «vasi magici» al plurale. |
| Ascian | Ascian / Asciani | Decisione dell'utente | Nome del popolo; singolare «Ascian», plurale «Asciani». |
| flame private | soldato semplice della fiamma | Decisione dell'utente | Grado militare; forme femminili «soldatessa semplice» e «soldatesse semplici»; «fiamma» minuscolo. |
| Silent Moss the Solemn | Muschio Silente il Solenne | Decisione dell'utente | Nome proprio e titolo; conservare maiuscole e ordine della resa. |
| glaring goodwife | massaia furiosa | Decisione dell'utente | Nome comune dell'NPC; concordare al plurale («massaie furiose»). |
| House Fortemps guard | Guardia della Casata Fortemps | Decisione dell'utente | Ruolo; usare la maiuscola nella denominazione autonoma, la minuscola nella prosa; «Casata Fortemps» è un nome proprio. |
| House Fortemps knight | Cavaliere della Casata Fortemps / Cavaliera della Casata Fortemps / Cavalieri della Casata Fortemps | Decisione dell'utente | Ruolo; concordare genere e numero («Cavaliere/Cavalieri», «Cavaliera/Cavalieri» secondo il referente). |
| adventurous frontier hand | lavoratore di frontiera avventuroso | Decisione dell'utente | Ruolo; concordare genere e numero con il referente. |
| Tailfeather hunter | Cacciatore di Codapiuma | Decisione dell'utente | Ruolo nei nomi autonomi; nella prosa usare la minuscola e concordare il numero («cacciatori»). Codapiuma resta un nome proprio. |
| moogle | moguri | Decisione dell'utente | Nome comune della specie, invariabile al plurale; minuscolo salvo inizio frase o nome proprio. Per «one-minded moogle», conservare l'aggettivo già presente: «moguri risoluto». |
| Imperial pilus prior | Primipilo imperiale | Decisione dell'utente | Grado militare; plurale «Primipili imperiali». |
| Serpent Commander Heuloix | Comandante della Vipera Heuloix | Decisione dell'utente | Titolo e nome proprio; conservare le maiuscole della forma del nome. |
| graverobber | tombarolo | Decisione dell'utente | Nome comune di ruolo; concordare al plurale («tombaroli»). |
| Skysteel engineer | Ingegnere di Ferrocielo | Decisione dell'utente | Ruolo nei nomi autonomi; plurale «Ingegneri di Ferrocielo». Nella prosa usare la minuscola. |
| Bombardier researcher | ricercatore dei Bombardieri | Decisione dell'utente | Ruolo; concordare genere e numero, mantenendo «Bombardieri» come nome proprio della compagnia. |
| Wood Wailer sentry | Guardia delle Sentinelle del Bosco | Decisione dell'utente | Ruolo; plurale «Guardie delle Sentinelle del Bosco». Sostituisce «Sentinella Guardabosco» e la proposta «Sentinella del Bosco di guardia». Riferimenti: `corpus/flat/BNpcName.json#BNpcName#453.0:target`; `corpus/flat/ENpcResident.json#ENpcResident#1041741.0:target`. |
| Bloody Executioner deckhand | Mozzo degli Esecutori Sanguinari | Decisione dell'utente | Ruolo; concordare «Mozzo/Mozzi» e conservare il nome della nave. |
| Lightning (personaggio di Final Fantasy XIII) | Lightning | Fonte ufficiale Square Enix | Nome proprio della protagonista; mantenerlo invariato in `BNpcName#2216.0/.2` ed `ENpcResident#1008256.0/.2`. Distinguere dal nome comune `lightning` («fulmine») e dal titolo FATE `Lightning Strikes`, adattato «Il Fulmine Colpisce». |
| lightning sprite | elementale del fulmine | Decisione dell'utente | Nome comune della creatura; plurale «elementali del fulmine». |
| tainted earth/wind/water sprite | elementale della terra / del vento / dell'acqua corrotto | Decisione dell'utente | Plurali «elementali della terra / del vento / dell'acqua corrotti». Sostituisce «sprite» e «spiritello» con «contaminato» o «corrotto» per queste tre creature; non estende la decisione ad altri sprite. Riferimenti: `corpus/flat/BNpcName.json#BNpcName#134.0:target`; `#135:name`; `#136:name`; `#594:name`; `#1420:name`; `#1424:name`. Resta valida la decisione specifica su lightning sprite. |
| magitek | magitec | Decisione dell'utente | Adattamento italiano; mantenere invariabile e rispettare il maiuscolo/minuscolo della fonte. Anche il composto «Praemagitek» diventa «Praemagitec». |
| magitek bit | drone magitec | Revisione editoriale | Nome dell'unità magitec; plurale «droni magitec». Per «model magitek bit», usare «modellino/i di drone/i magitec»; non applicare a bit informatico. EN/hash verificati: `corpus/flat/BNpcName.json#BNpcName#2142.0/.2`, #5563.0/.2, #6206.0/.2, #9425.0/.2, #11620.0/.2, #12275.0/.2; FR/DE convergono su drone. |
| Dronebit | frammento di drone / frammenti di drone | Decisione dell'utente del 14 novembre 2026 | Valuta/materiale dell'Esplorazione Cosmica, ottenuto nelle missioni stellari e scambiato per moduli di drone. Distinto da `magitek bit` = drone magitec. Riferimenti EN/hash verificati: `corpus/custom/009/CtsWksTreasure_00966.json#TEXT_CTSWKSTREASURE_00966_TALK_ACTOR_003_002`, `corpus/flat/Item.json#Item#49170.0/.2`, `corpus/flat/DescriptionString.json#DescriptionString#1591`. |
| Alexandrian | Alexandriano | Decisione dell'utente | Aggettivo/etnonimo; declinare in genere e numero («Alexandrina», «Alexandrini», «Alexandrine»); lasciare «Alexandria» invariato come toponimo. |

| Ironheart | Cuordiferro | Decisione dell'utente | Cognome della famiglia; usare questa forma per Millith, Nedrick, Kester, Ulger e gli altri membri. Riferimenti: `corpus/flat/ENpcResident.json#ENpcResident#1019464.0:target`; `corpus/flat/ENpcResident.json#ENpcResident#1019464.2:target`. |
| Sphere scroll(s) | pergamena sferica / pergamene sferiche | Decisione dell'utente | Nome dell'oggetto; mantenere questa forma al singolare e al plurale. Riferimenti: `corpus/flat/CustomTalk.json#CustomTalk#721067.64:target`; `corpus/flat/HowTo.json#HowTo#175:target`. |
| Zodiac glass | Lente dello Zodiaco | Decisione dell'utente | Nome dell'oggetto; al plurale «Lenti dello Zodiaco». Riferimenti: `corpus/flat/Item.json#Item#8659.0:target`; `corpus/flat/Item.json#Item#8659.9:target`. |
| Continental Circus | Circo Continentale | Decisione dell'utente | Nome della compagnia; usare la forma italiana nelle menzioni e nei nomi. Riferimenti: `corpus/flat/ENpcResident.json#ENpcResident#1010179.8:target`; `corpus/flat/ENpcResident.json#ENpcResident#1010180.8:target`. |
| Hippo Riders | Cavalcatori di Ippopotami | Decisione dell'utente | Nome del gruppo di corrieri thavnairiani; nelle menzioni usare «i Cavalcatori di Ippopotami». Riferimenti: `corpus/flat/BannerBg.json#BannerBg#156:target`; `corpus/flat/BannerDesignPreset.json#BannerDesignPreset#125:target`. |
| Scarlet Snout | Muso Scarlatto | Decisione dell'utente | Soprannome di Papà Gruff; sostituisce la forma inglese nei riferimenti allo stesso personaggio. Riferimento: `corpus/flat/DefaultTalk.json#DefaultTalk#597222.20:target`. |
| Doomsday Clown | Pagliaccio del Giorno del Giudizio | `corpus/custom/007/FesHlw2021ActionGuide_00737.json#custom/007/FesHlw2021ActionGuide_00737#TEXT_FESHLW2021ACTIONGUIDE_00737_MARK_012:target` | Titolo alternativo di Papà Gruff; usare questa forma quando la fonte presenta il soprannome. |
| Yes We Cant | Sì, Non Possiamo | Decisione dell'utente | Titolo della missione; conservare il gioco di parole scelto dall'utente. Riferimenti: `corpus/flat/Achievement.json#Achievement#1027.2:target`; `corpus/flat/Lobby.json#Lobby#642.3:target`. |
| Ceremony Planner (Claribel) | Organizzatrice della Cerimonia | Decisione dell'utente | Ruolo di Claribel, accordato al personaggio femminile; usare «organizzatrice» nei riferimenti al suo incarico. Riferimenti: `corpus/flat/ENpcResident.json#ENpcResident#1009761.8:target`; `corpus/flat/ENpcResident.json#ENpcResident#1010508.8:target`. |
| Bloody Executioners | Boia Sanguinari | Decisione dell'utente | Nome della fazione; usare questa forma nelle menzioni del gruppo. Riferimenti: `corpus/flat/ENpcResident.json#ENpcResident#1010265.2:target`; `corpus/flat/ENpcResident.json#ENpcResident#1010266.2:target`. |
| Durai Papers | Documenti dei Durai | Decisione dell'utente | Nome della testata/raccolta; usare questa forma nelle menzioni. Riferimenti: `corpus/flat/NpcYell.json#NpcYell#7122:target`; `corpus/flat/ContentFinderConditionTransient.json#ContentFinderConditionTransient#636:target`. |
| Majestic Theater Company | Compagnia Teatrale Majestica | Decisione dell'utente | Nome della compagnia; mantenere «Imperiale» quando la fonte include «Imperial». Riferimenti: `corpus/flat/DefaultTalk.json#DefaultTalk#596749.20:target`; `corpus/flat/DefaultTalk.json#DefaultTalk#596781.20:target`. |
| Mythril Eye | L'Occhio di Mithril | Decisione dell'utente | Nome del giornale; in prosa usare le forme contratte «dell'Occhio», «dall'Occhio». Riferimenti: `corpus/flat/ENpcResident.json#ENpcResident#1016354.0:target`; `corpus/flat/ENpcResident.json#ENpcResident#1018403.0:target`. |
| Velodyna Gatekeepers | Guardiani di Velodyna | Decisione dell'utente | Nome della fazione; per il ruolo individuale usare «Guardiano/Guardiana di Velodyna» secondo il personaggio. Riferimenti: `corpus/flat/BannerBg.json#BannerBg#185:target`; `corpus/flat/BannerDesignPreset.json#BannerDesignPreset#154:target`. |

### Eventi e termini di lore

| Inglese | Italiano | Fonte | Uso |
| --- | --- | --- | --- |
| Cryptlurker | Predatore delle Cripte | Decisione dell'utente | Set di equipaggiamento di Shadowbringers (patch 5.4, liv. 80). Nei nomi di armi, armature, accessori e forzieri usare «del Predatore delle Cripte» (es. «Spada del Predatore delle Cripte», «Corazza del Predatore delle Cripte della Difesa», «Spada del Predatore delle Cripte Potenziata»). Calco su FR «Rôdeur des cryptes» e DE «Krypta-Schleicher». Riferimenti: `corpus/flat/Item.json#32418.9` e segg. |
| Crypt [materiali] | [della] Cripta | Decisione dell'utente | Materiali di potenziamento per equipaggiamento Cryptlurker: Crypt Ester -> Estere della Cripta, Crypt Twine -> Spago della Cripta, Crypt Dusting -> Polvere della Cripta. Riferimenti: `corpus/flat/Item.json#32156.9`, `#32157.9`, `#32158.9`. |
| Rejoining(s) | Congiunzione / Congiunzioni | Decisione dell'utente | Nome dell'evento cosmologico; usare singolare e plurale con la maiuscola. Great Rejoining: «Grande Congiunzione». Non applicare ai verbi ordinari «rejoin/rejoining». Riferimenti: `corpus/cut_scene/050/VoiceMan_05001.json#TEXT_VOICEMAN_05001_002570_URIANGER:target`; `corpus/cut_scene/050/VoiceMan_05002.json#TEXT_VOICEMAN_05002_003940_EMETSELCH:target`. |
| The Twelve Archons | i Dodici Arconti | `corpus/flat/SnipeTalk.json#SnipeTalk#48.3:target` | Eroi della leggenda legata a Hatching-tide; la resa riguarda il gruppo storico. |
| Dragon Gay | drago allegro | Decisione dell'utente | Nel titolo della fiaba «The Boy and the Dragon Gay», gay significa «allegro»; usare «Il Ragazzo e il Drago Allegro», anche nei titoli derivati. Sostituisce «Drago Gay» e «Drago Gioioso». Riferimento: `corpus/flat/EObjName.json#EObjName#2007490.0:target`. |
| Sixth Umbral Calamity | Sesta Calamità Umbrale | Decisione dell'utente | Nome dell'evento storico; usare questa forma nelle menzioni della calamità. Riferimenti: `corpus/flat/FishParameter.json#FishParameter#528.0:target`; `corpus/flat/DefaultTalk.json#DefaultTalk#598467.20:target`. |
| The Echo | L'Eco | `corpus/flat/Status.json#Status#42.0:target` | Nome del potere dei Discendenti. |
| Fishback(s) | dorsopesce (sing.), dorsopesci (pl.) | Decisione dell'utente | Soprannome dispregiativo riferito ai Sahagin; usare «dorsopesce» al singolare e «dorsopesci» al plurale. Riferimenti: `corpus/flat/Balloon.json#Balloon#2083:target`; `corpus/flat/NpcYell.json#NpcYell#1210:target`; `da_revisionare/quests/master/legacyquest.json#72:name`. |
| Endsinger | Cantamorte | Decisione dell'utente | Nome e titolo dell'entità femminile; usare «la Cantamorte» e «della Cantamorte». |
| Cloud of Darkness | Nube Oscura | Decisione dell'utente | Nome della regina delle creature del vuoto; usare «Nube Oscura» al singolare e «Nubi Oscure» per le manifestazioni plurali. Riferimenti: `corpus/flat/TripleTriadCard.json#TripleTriadCard#140.0:target`; `corpus/flat/BNpcName.json#BNpcName#3240.0:target`. |
| The Scions of the Seventh Dawn | Eredi della Settima Alba | `corpus/flat/ContentFinderConditionTransient.json#ContentFinderConditionTransient#284:target` | Nome dell'organizzazione; usare la forma estesa al primo riferimento. Variante ammessa con articolo: «Gli Eredi della Settima Alba». |
| Little Ladies' Day | Giornata delle Piccole Dame | Decisione dell'utente | Controllo automatico: residuo. Nome della festa stagionale; accordare articoli e preposizioni alla forma femminile «Giornata» (es. «durante la Giornata delle Piccole Dame»). |
| Hatching-tide | Festa delle Uova | Decisione dell'utente | Nome della festa stagionale; riferimento contestuale: `corpus/flat/ENpcResident.json#ENpcResident#1011803.0:target`. Eccezione tecnica confermata dall'utente: in `world/fate.json#1594:translation_description`, `#1595:translation_description`, `#1856:translation_description`; `data/da_revisionare/dialogue/custom/006/fesest2020transform_00668.json#0,#2,#9,#11,#18:translation_description`; `data/da_revisionare/dialogue/custom/007/fesest2021guide_00712.json#0,#1,#4:translation_description`; `data/da_revisionare/dialogue/custom/007/fesest2021addpubenpc_00713.json#0,#11:translation_description`; e `data/da_revisionare/dialogue/custom/007/fesest2021recollection_00714.json#4,#39:translation_description`; `data/da_revisionare/dialogue/custom/008/fespdyest2024guid_00843.json#0,#4,#19-23,#26:translation_description`; `data/da_revisionare/dialogue/custom/009/fesest2025guide_00914.json#0-4:translation_description`; `data/da_revisionare/dialogue/custom/009/fesest2026guide_00959.json#0-4:translation_description`, rendere `Hatching<hex:021F0103>tide` come «Festa delle Uova», eliminando esclusivamente il tag del trattino `<hex:021F0103>`. L'eccezione vale soltanto per queste voci; conservare tutti gli altri tag. |
| Scholasticate | Il Seminario | Decisione dell'utente | Istituzione di Sant'Endalim; nei ruoli rispettare il minuscolo dell'originale: «docente del seminario», «diacono del seminario». Riferimento: `corpus/flat/ENpcResident.json#ENpcResident#1011215.0:target`. |
| Starlight Celebration | Celebrazione delle Stelle | Decisione dell'utente | Nome della festa stagionale; riferimento contestuale: `corpus/flat/ENpcResident.json#ENpcResident#1010742.0:target`. |
| The Masked Carnivale | Il Carnevale Mascherato | Decisione dell'utente | Nome dell'attività; mantenere «Carnevale Mascherato» nelle menzioni e accordare articoli/preposizioni. Riferimenti: `corpus/flat/ContentType.json#ContentType#27:target`; `corpus/flat/Addon.json#Addon#8832:target`. |
| Starlight sentinel | sentinella delle Stelle | Decisione dell'utente | Nome dell'albero decorato per la Celebrazione delle Stelle; accordare genere e numero. Riferimenti: `corpus/flat/Item.json#Item#13066.0:target`; `corpus/flat/Item.json#Item#13066.9:target`. Varianti ammesse per gli arredi specifici: «abete sentinella della Celebrazione delle Stelle», «sentinella argentata della Celebrazione delle Stelle», «sentinella argentata autentica della Celebrazione delle Stelle». Gli aggettivi distinguono gli oggetti; non eliminarli per uniformare il nome. |
| Zodiac Braves | Eroi dello Zodiaco | Decisione dell'utente | Nome collettivo degli eroi di Ivalice; al singolare usare «Eroe dello Zodiaco». Riferimenti: `corpus/flat/Item.json#Item#9500.8:target`; `corpus/flat/Item.json#Item#9491.8:target`. |
| Soul attunement | sintonia spirituale | Decisione dell'utente | Termine per la progressione spirituale delle armi reliquia; usare questa forma nelle istruzioni e nei messaggi di stato. Riferimenti: `corpus/flat/LogMessage.json#LogMessage#4655:target`; `corpus/flat/Addon.json#Addon#3010:target`. |
| Festal Cant | Canto Festivo | Decisione dell'utente | Nome dell'incanto usato durante la parata. Riferimenti: `corpus/flat/Action.json#Action#2360:target`; `corpus/flat/NpcYell.json#NpcYell#2305:target`. |
| Moonfire Faire | Festa del Fuoco Lunare | Decisione dell'utente | Nome della festa stagionale estiva; riferimento contestuale: `corpus/flat/ENpcResident.json#ENpcResident#1009242.8:target`. |
| Grand Chaperone | Gran Supervisore | Decisione dell'utente | Titolo di Haermaga alla Festa del Fuoco Lunare; usare «Gran Supervisore» anche nei dialoghi. Riferimenti: `corpus/flat/ENpcResident.json#ENpcResident#1017199.8:target`; `corpus/flat/DefaultTalk.json#DefaultTalk#601190.20:target`. |
| Eorzean Nimble Warrior course | percorso del Guerriero Agile Eorzeano | Decisione dell'utente | Nome del percorso acrobatico della Festa del Fuoco Lunare; usare «percorso del Guerriero Agile Eorzeano» nelle menzioni. Riferimenti: `corpus/flat/Balloon.json#Balloon#6893:target`; `corpus/flat/Balloon.json#Balloon#4021:target`. |
| Great White Tsuchinoko | Grande Tsuchinoko Bianco | Decisione dell'utente | Nome proprio della creatura leggendaria; accordare articoli e numero al contesto. Riferimenti: `corpus/flat/Item.json#Item#41472.2:target`; `corpus/flat/BNpcName.json#BNpcName#12612.2:target`. |
| The Rising | La Rinascita | Decisione dell'utente | Nome dell'evento annuale; nei ruoli usare «della Rinascita». Riferimento: `corpus/flat/ENpcResident.json#ENpcResident#1009290.0:target`. |
| All Saints' Wake | Veglia di Tutti i Santi | Decisione dell'utente | Nome della festa stagionale; riferimento contestuale: `corpus/flat/ENpcResident.json#ENpcResident#1043978.0:target`. |
| voidsent | vuotofago (sing. masc.), vuotofagi (pl.); vuotofaga/e per referenti femminili | Decisione dell'utente | Nome comune della specie: usare il maschile per i riferimenti generici e accordare al femminile quando il referente è una creatura identificabile di genere noto. Scrivere in minuscolo in prosa; mantenere le maiuscole di etichette o titoli della sorgente. |
| Dawnservant | Custode dell'Alba | Decisione dell'utente | Titolo del sovrano di Tural; accordare articoli e preposizioni con «Custode» e mantenere minuscola la preposizione interna «dell'». Riferimenti: `corpus/flat/ActionTransient.json#ActionTransient#37129:target`. |
| Beastkin | Bestiomorfi | Decisione dell'utente | Categoria tassonomica dei famigli; singolare «Bestiomorfo». In prosa usare il minuscolo quando il nome non è un'etichetta di categoria. Riferimenti: `corpus/flat/ActionTransient.json#ActionTransient#44895:target`. |
| Vilekin | Vilomorfi | Decisione dell'utente | Categoria tassonomica dei famigli; singolare «Vilomorfo». In prosa usare il minuscolo quando il nome non è un'etichetta di categoria. Riferimenti: `corpus/flat/ActionTransient.json#ActionTransient#44895:target`. |
| Cloudkin | Aeromorfi | Decisione dell'utente | Categoria tassonomica dei famigli; singolare «Aeromorfo». In prosa usare il minuscolo quando il nome non è un'etichetta di categoria. Riferimenti: `corpus/flat/ActionTransient.json#ActionTransient#44895:target`. |
| Seedkin | Fitomorfi | Decisione dell'utente | Categoria tassonomica dei famigli; singolare «Fitomorfo». In prosa usare il minuscolo quando il nome non è un'etichetta di categoria. Riferimenti: `corpus/flat/ActionTransient.json#ActionTransient#44895:target`. |
| Sunbeard | Barbasole | Decisione dell'utente | Nome della creatura, maschile invariabile: «il barbasole», «i barbasole», «del barbasole», «dei barbasole». Usare «barbasole» in prosa e nei nomi sorgente minuscoli; «Barbasole» quando la fonte ha l'iniziale maiuscola. Per bushy sunbeard: «barbasole folto», plurale «barbasole folti». Riferimenti: `corpus/flat/FateEvent.json#FateEvent#743.56:target`; `corpus/flat/Fate.json#Fate#1865.1:target`. |
| Wavekin | Idromorfi | Decisione dell'utente | Categoria tassonomica dei famigli; singolare «Idromorfo». In prosa usare il minuscolo quando il nome non è un'etichetta di categoria. Riferimenti: `corpus/flat/ActionTransient.json#ActionTransient#44895:target`. |
| Scalekin | Squamorfi | Decisione dell'utente | Categoria tassonomica dei famigli; singolare «Squamorfo». In prosa usare il minuscolo quando il nome non è un'etichetta di categoria. Riferimenti: `corpus/flat/ActionTransient.json#ActionTransient#44895:target`. |
| Soulkin | Animamorfi | Decisione dell'utente | Categoria tassonomica dei famigli; singolare «Animamorfo». In prosa usare il minuscolo quando il nome non è un'etichetta di categoria. Riferimenti: `corpus/flat/ActionTransient.json#ActionTransient#44895:target`. |
| Ashkin | Necromorfi | Decisione dell'utente | Categoria tassonomica dei famigli; singolare «Necromorfo». In prosa usare il minuscolo quando il nome non è un'etichetta di categoria. Riferimenti: `corpus/flat/ActionTransient.json#ActionTransient#44895:target`. |
| Spoken | Parlanti | `corpus/custom/009/CtsEtcXbmLoosefroxTalk_00992.json#custom/009/CtsEtcXbmLoosefroxTalk_00992#TEXT_CTSETCXBMLOOSEFROXTALK_00992_A2_000_007:target` | Categoria tassonomica per le creature capaci di parlare e farsi capire; usare «Parlanti» come etichetta e «parlante» in prosa. |
| Forgekin | Meccanomorfi | `corpus/custom/009/CtsEtcXbmLoosefroxTalk_00992.json#custom/009/CtsEtcXbmLoosefroxTalk_00992#TEXT_CTSETCXBMLOOSEFROXTALK_00992_A2_000_008:target` | Categoria tassonomica delle creature meccaniche; usare «meccanomorfo» al singolare e «meccanomorfi» al plurale. |

| Sundrop Dance | Danza della Goccia Solare | Decisione dell'utente | Nome della danza rituale dei Vanu Vanu; mantenere il nome scelto nelle battute. Riferimenti: `corpus/flat/CompanionTransient.json#CompanionTransient#172.3:target`; `corpus/flat/Emote.json#Emote#120:target`. |
| The Hounds of Ishgard | i Mastini di Ishgard | Decisione dell'utente | Nome della fazione; usare «i Mastini» in prosa. Riferimenti: `corpus/flat/DefaultTalk.json#DefaultTalk#594136.20:target`. |
| Bombard(s) | Bombardo / Bombardi | Decisione dell'utente del 13 novembre 2026 (decisione successiva) | Nome della creatura: usare Bombardo al singolare e Bombardi al plurale nei nomi dei nemici e nei titoli che li nominano. Sostituisce Piro/Piros per Bombard; Bomb resta Piro/Piros, Ice Bombard resta Bombarda/Bombarde di ghiaccio e Bombardier resta Bombardiere. Riferimenti: `corpus/flat/BNpcName.json#BNpcName#1641.0/.2`, `#1642.0/.2`, `#2911.0/.2`, `#4927.0/.2`, `#4964.0/.2`, `#9613.0/.2`; `corpus/flat/Fate.json#Fate#1710.0`. |
| Thunder Picket(s) | Picchetto fulminante / picchetti fulminanti | Decisione dell'utente del 13 novembre 2026 | Nome dei nemici: `corpus/flat/BNpcName.json#BNpcName#4492.0/.2`; non usare «sentinella». EN/hash verificati. |
| Hawk(s) (insetti nemici) | vespa scavatrice; vespa sentinella; vespa operaia; vespa regina; vespa guardiana reale | Decisione dell'utente del 13 novembre 2026 | Applicare solo alla famiglia di BNpcName#4541, #4642, #4652, #4656, #4657 e alle Queen Hawk correlate (`#13361`, `#14605`, `AozActionTransient#61.3`, `InstanceContentTextData#9703`, `custom/008/CtsHnt70RiskyMobUrqopacha_00898`), con plurali concordati. Per Tarantula Hawk usare «vespa delle tarantole» (`BNpcName#3593`, #4279, #4281, #4297, #4443, #9717; `Fate#759`; quest/019); nome comune italiano attestato da [GBIF](https://www.gbif.org/taxon/63L9B). Non applicare agli uccelli o alle metafore con hawk. EN/hash verificati. |
| the Pagan's Knot/Shrub/Vine(s) | Nodo/Nodi, Arbusto/Arbusti, Vite/Viti di Irminsul | Decisione dell'utente del 13 novembre 2026 | Escrescenze di Irminsul nel Void Ark: `corpus/flat/BNpcName.json#BNpcName#4614–#4616`, `.0/.2`. EN/hash verificati. |
| Shriveled Talon(s) | Arpia avvizzita / arpie avvizzite | Decisione dell'utente del 13 novembre 2026 | Aggiunte di Forgall in Weeping City: `corpus/flat/BNpcName.json#BNpcName#4879–#4882`, `.0/.2`. EN/hash verificati. |
| Bombard(s) | Piro / Piros (forma superata per il Bombard) | Decisione dell'utente superata il 13 novembre 2026 | La scelta precedente per Bombard è sostituita da Bombardo/Bombardi per i nomi dei nemici e i titoli sopra; Piro/Piros resta il nome della creatura distinta Bomb. Non confondere con Bombardier/Bombardieri. |
| Bombard(s) | Bombarda / Bombarde (forma storica per Bombard senza Ice) | Decisione storica superata | La forma fu sostituita prima da Piro/Piros e poi da Bombardo/Bombardi per Bombard; resta valida l'eccezione specifica Ice Bombard, decisa come Bombarda/Bombarde di ghiaccio l'11 novembre 2026. Riferimenti: `BNpcName#10193.0/.2` e `Fate#1710.1`. |
| Cascadiers | Cascadiers | Decisione dell'utente | Nome della fazione legata alla Festa del Fuoco Lunare; lasciarlo invariato. Riferimenti: `corpus/flat/Fate.json#Fate#532.3:target`; `corpus/flat/Fate.json#Fate#533.3:target`. |
| Saint of Nymeia | Santo di Nymeia | Decisione dell'utente | Titolo del personaggio della Celebrazione delle Stelle; tradurre anche nei riferimenti al Santo nel dialogo. Riferimenti: `corpus/flat/ENpcResident.json#ENpcResident#1016274.0:target`; `corpus/flat/ENpcResident.json#ENpcResident#1017823.0:target`. |
| the Spinner (Nymeia) | la Tessitrice | Decisione dell'utente | Epiteto della dea Nymeia; non applicare a spinner come esca da pesca o a usi comuni del verbo. Riferimenti: `corpus/flat/Item.json#Item#43558.9:target`; `corpus/flat/Lobby.json#Lobby#161.3:target`. |
| Valentione's Day | Giornata di Valentione | Decisione dell'utente | Nome della ricorrenza; usare questa forma nei riferimenti all'evento e nei nomi collegati. Riferimenti: `corpus/flat/FittingShopCategory.json#FittingShopCategory#103:target`; `corpus/flat/EObjName.json#EObjName#2009385.0:target`. |
| Emissary of ardor | emissario dell'ardore / emissaria dell'ardore | `corpus/flat/Achievement.json#Achievement#2484.2:target` | Ruolo della Casata Valentione; accordare «emissario/emissaria» al genere. Per “head emissary” usare «emissaria capo». Nuova traduzione: `data/da_revisionare/dialogue/custom/008/fesvlt2024guide_00844.json#17,#20,#23:description`. |
| Lifestream | Flusso Vitale | Decisione dell'utente | Termine di lore; accordare articoli e preposizioni alla forma maschile («nel Flusso Vitale», «del Flusso Vitale»). Riferimenti: `corpus/flat/KTGTypeWordTextData.json#KTGTypeWordTextData#609:target`; `corpus/flat/KTGTypeWordTextData.json#KTGTypeWordTextData#956:target`. |

### Distinzioni ricorrenti dal censimento

Rese attestate nelle correzioni del corpus: il qualificatore inglese delimita il contesto, non è testo da mostrare nel client. Il metodo di censimento è documentato in [Revisione](../../dev/docs/REVISION.md#controlli).

| Inglese | Italiano | Fonte | Uso |
| --- | --- | --- | --- |
| Cryptlurker | Predatore delle Cripte | Decisione dell'utente | Set di equipaggiamento di Shadowbringers (patch 5.4, liv. 80). Nei nomi di armi, armature, accessori e forzieri usare «del Predatore delle Cripte» (es. «Spada del Predatore delle Cripte», «Corazza del Predatore delle Cripte della Difesa», «Spada del Predatore delle Cripte Potenziata»). Calco su FR «Rôdeur des cryptes» e DE «Krypta-Schleicher». Riferimenti: `corpus/flat/Item.json#32418.9` e segg. |
| Crypt [materiali] | [della] Cripta | Decisione dell'utente | Materiali di potenziamento per equipaggiamento Cryptlurker: Crypt Ester -> Estere della Cripta, Crypt Twine -> Spago della Cripta, Crypt Dusting -> Polvere della Cripta. Riferimenti: `corpus/flat/Item.json#32156.9`, `#32157.9`, `#32158.9`. |
| Arms (heraldry) | Stemma | `corpus/flat/BannerDecoration.json#BannerDecoration#36:target` | In decorazioni e insegne Arms ha valore araldico: «Stemma del Conflitto di Bronzo 1», non «Armi». Non applicare ai nomi di armi o alle categorie di equipaggiamento. |
| Stack (effect) | Accumulo | `corpus/flat/CraftAction.json#CraftAction#100161.1:target` | Plurale «accumuli» per il numero di applicazioni di un effetto; evita «cumuli». Per pile di oggetti, accumuli fisici o il verbo to stack valuta il referente. |
| ATK | ATT | `corpus/flat/CompanionTransient.json#CompanionTransient#8.4:target` | Sigla della statistica Attacco nelle descrizioni dei minion; maschile: «l'ATT», «dell'ATT». Non abbreviare ogni uso narrativo di attack. |
| DEF | DIF | `corpus/flat/CompanionTransient.json#CompanionTransient#6.4:target` | Sigla della statistica Difesa nelle descrizioni dei minion; femminile: «la DIF», «della DIF». Non abbreviare ogni uso narrativo di defense. |
| Weaponskill | Tecnica | `corpus/flat/Status.json#Status#1346.1:target` | Singolare della categoria; nelle etichette brevi è ammesso «Tecnica». Non usare «abilità con armi». Varianti ammesse in prosa: «tecnica», «tecniche», «tecniche d'arma». |
| Potency scales with item level | La potenza varia in base al livello oggetto | `corpus/flat/ActionTransient.json#ActionTransient#41592:target` | Formula per la dipendenza della potenza dal livello oggetto; evita il calco «scala con». Non presumere una crescita lineare né trasferire la frase intera a descrizioni con condizioni diverse. |
| Range (level threshold) | Soglia | `corpus/flat/TraitTransient.json#TraitTransient#35:target` | In Stealth/Furtività indica il livello massimo dei nemici evitabili: «Estende al livello 30 la soglia…». Per una distanza spaziale usa invece portata o raggio secondo il campo. |
| Sons of Saint Coinach | Figli di San Coinach | Decisione dell'utente | Nome dell'organizzazione di studiosi; per un membro «Figlio di San Coinach». Sostituisce «Figli/Figlio di Saint Coinach»; la scelta riguarda l'organizzazione e i suoi membri, non automaticamente ogni toponimo contenente Saint Coinach. Riferimento: `corpus/flat/ENpcResident.json#ENpcResident#1011641.2:target`. |
| Anima Weapon | Arma Anima / Armi Anima | Decisione dell'utente | «Anima» è il nome proprio della reliquia; accordare «arma» al numero e agli aggettivi. Riferimenti: `corpus/flat/Item.json#Item#13223.8:target`; `corpus/flat/Item.json#Item#13225.8:target`. |
| Ultima Weapon | Arma Ultima (forma superata) | Decisione utente aggiornata | La fonte legacy usa «Arma Ultima»; decisione utente successiva: nel canone main usare «Ultima Arma» e in prosa «l'Ultima Arma». Riferimenti: `corpus/flat/TripleTriadCard.json#TripleTriadCard#51.0:target`; `corpus/flat/BNpcName.json#BNpcName#2137.0:target`; `OpenContentCandidateName#17`; `BNpcName#2137`. |
| Ultima Weapon | Ultima Arma | Decisione dell'utente aggiornata | Nome della macchina da guerra allagana: usare «Ultima Arma» e, in prosa, l'articolo femminile «l'Ultima Arma». «Arma Ultima» è la forma legacy superata. Riferimenti: `corpus/flat/TripleTriadCard.json#TripleTriadCard#51.0:target`; `corpus/flat/BNpcName.json#BNpcName#2137.0:target`; Decisione dell'utente. |
| Crystal Caravan | Carovana di Cristallo | Decisione dell'utente | Nome della compagnia teatrale; usare «Carovana di Cristallo» anche nei ruoli dei suoi membri. Riferimenti: `corpus/flat/ENpcResident.json#ENpcResident#1017489.0:target`; `corpus/flat/ENpcResident.json#ENpcResident#1017493.0:target`. |
| Ruby Tithe | Decima di Rubino | Decisione dell'utente | Tributo riscosso dalla Confederazione nel Mar Rubino. Riferimenti: `corpus/flat/DefaultTalk.json#DefaultTalk#594010.20:target`; `corpus/flat/TripleTriadCard.json#TripleTriadCard#214.8:target`. |
| Ruby Princess | Principessa di Rubino | Decisione dell'utente | Titolo della sovrana di Shisui; plurale «Principesse di Rubino»; «Principessa del Rubino» resta variante ammessa. Riferimenti: `corpus/flat/BNpcName.json#BNpcName#6241.0:target`; `corpus/flat/InstanceContentTextData.json#InstanceContentTextData#14903:target`. |
| Ruby Princess | Principessa di Rubino | Decisione dell'utente | Titolo della sovrana di Shisui; accordare il titolo nelle forme plurali. Riferimenti: `corpus/flat/BNpcName.json#BNpcName#6241.0:target`; `corpus/flat/InstanceContentTextData.json#InstanceContentTextData#14903:target`. |
| Banestool(s) | fungo malefico / funghi malefici | `corpus/flat/BNpcName.json#BNpcName#2314.0/.2:target` | Nome di un nemico fungino; usare «fungo malefico» con «maggiore» o «gigante» secondo la fonte. Applicare anche ai nomi degli oggetti e alle menzioni delle quest pertinenti. EN/hash verificati; FR «vesse-de-fléau», DE «Fluchhut» e JA «ドクキリタケ» confermano il referente fungino. Riferimenti: `corpus/flat/EObjName.json#EObjName#2003242–#2003248`; `corpus/quest/012/BanSyl110_01266.json`, `BanSyl210_01276.json`, `BanSyl203_01269.json`, `BanSyl310_01286.json`. |
| Mimic (creatura) | mimico / mimici | `corpus/flat/BNpcName.json#BNpcName#2566.0/.2`, `#14264.0/.2`, `#14265.0/.2`, `#14266.0/.2`, `#2976.0/.2` | Per la creatura che imita uno scrigno usare «mimico / mimici»; non applicare a `Mimic` come abilità da corsa chocobo (`ChocoboRaceAbility#52.0`, «Mimesi»). EN/hash verificati. |
| Miacid(s) | miacide / miacidi | `corpus/flat/BNpcName.json#BNpcName#3577.0/.2`, `#4195.0/.2`, `#4457.0/.2`, `#5097.0/.2`, `#5536.0/.2` | Nome del mammifero; singolare «miacide», plurale «miacidi». Estendere la forma alle menzioni della creatura in FATE, quest, yell e aiuto dell'oggetto. Riferimento lessicale: [Treccani, miacidi](https://www.treccani.it/vocabolario/miacidi/). EN/hash verificati nelle occorrenze riconciliate. |
| wisent / wisents | bisonte europeo / bisonti europei | `corpus/flat/BNpcName.json#BNpcName#3504.0/.2`; `corpus/flat/EventItem.json#EventItem#2001655.0/.2/.9` | Nome della specie; applicare anche alle descrizioni e alle menzioni della stessa specie. Il toponimo `Wisent Herd` resta «Mandria di Bisonti» (`PlaceName#2153.0/.2`). |
| Drakespur(s) | sperone draconico / speroni draconici | `corpus/flat/BNpcName.json#BNpcName#3803.0/.2`; `corpus/flat/NpcYell.json#NpcYell#15065–#15066` | Nome della pianta nemica; rendere il composto in italiano anche nei richiami. FR «éperon draconique»; EN/hash verificati. |
| Scarlet/Sable Price (nemici) | gemma scarlatta / gemme scarlatte; gemma d'ebano / gemme d'ebano | `corpus/flat/BNpcName.json#BNpcName#3459.0/.2`, `#3460.0/.2`, `#10338.0/.2` | Nomi delle creature; non applicare alle azioni omonime `Action#3904`, `#3905`, `#3908`, `#15001`, `#30203`, `#30205`, che restano «Prezzo Scarlatto/Oscuro». Decisione dell'utente; EN/hash verificati. |
| Melia(e) | melia / melie | `corpus/flat/BNpcName.json#BNpcName#3568.0/.2`, `#3668.0/.2`, `#4284.0/.2`; menzioni in Fate e quest | Plurale italiano «melie» per la specie; applicato anche a «melie arboree», ai richiami nelle quest e a «melie nodose/irate». EN/hash verificati. |
| Moundrinx Eightclinks | Moundrinx Ottoanelli | `corpus/flat/BNpcName.json#BNpcName#3942.0/.2`; `corpus/flat/Fate.json#Fate#767.1`; `corpus/flat/MountTransient.json#MountTransient#141.2` | Nome proprio del goblin; usare «Ottoanelli» anche nel FATE, in sostituzione della precedente forma «Ottoferri». Decisione dell'utente; EN/hash verificati. |
| Roundsman(s) | fattorino / fattorini | `corpus/flat/BNpcName.json#BNpcName#377.0/.2`, `#1832.0/.2`, `#2516.0/.2`, `#2518.0/.2`, `#2684.0/.2`, `#4556.0/.2`, `#9874.0/.2`, `#10049.0/.2` | Ruolo di garzone/corriere dei koboldi; applicare anche ai riferimenti a Ge Ga in FATE e quest. Conservare in «Il fattorino non fa più il suo giro?» il gioco di parole inglese *The roundsman makes his rounds no more*. FR «livreur» e DE «Laufbursche» confermano il ruolo. Non applicare a `groundsman` (`BNpcName#1271.0/.2`, «custode»). |
| witchweed | erba strega | `corpus/flat/BNpcName.json#BNpcName#8588.0/.2, #8706.0/.2`; `corpus/flat/EventItem.json#EventItem#2002660.9, #2002928.9` | Nome della pianta; usare «erba strega» al singolare e «erbe streghe» al plurale. Per oggetti e descrizioni: «spina/e di erba strega» e «petali di erba strega». EN/hash verificati; menzioni pertinenti riconciliate in EventItem, EventItemHelp, BNpcName e quest. |
| cliffmole | talpa rupestre | `corpus/flat/BNpcName.json#BNpcName#8528.0/.2, #10156.0/.2`; `corpus/flat/ENpcResident.json#ENpcResident#1030805.0/.2`; `corpus/flat/EventItemHelp.json#EventItemHelp#2002704–2002706` | Specie femminile: «talpa rupestre», «talpe rupestri»; per i giovani, «giovane/i talpa/e rupestre/i». EN/hash verificati; le ricorrenze pertinenti sono state riconciliate. |

### Decisioni terminologiche: Ishgard e Firmamento

| Inglese | Italiano | Fonte | Uso |
| --- | --- | --- | --- |
| Cryptlurker | Predatore delle Cripte | Decisione dell'utente | Set di equipaggiamento di Shadowbringers (patch 5.4, liv. 80). Nei nomi di armi, armature, accessori e forzieri usare «del Predatore delle Cripte» (es. «Spada del Predatore delle Cripte», «Corazza del Predatore delle Cripte della Difesa», «Spada del Predatore delle Cripte Potenziata»). Calco su FR «Rôdeur des cryptes» e DE «Krypta-Schleicher». Riferimenti: `corpus/flat/Item.json#32418.9` e segg. |
| Crypt [materiali] | [della] Cripta | Decisione dell'utente | Materiali di potenziamento per equipaggiamento Cryptlurker: Crypt Ester -> Estere della Cripta, Crypt Twine -> Spago della Cripta, Crypt Dusting -> Polvere della Cripta. Riferimenti: `corpus/flat/Item.json#32156.9`, `#32157.9`, `#32158.9`. |
| Skybuilders | Costruttori Celesti | Decisione dell'utente | Nome del gruppo di artigiani e raccoglitori del Firmamento; usare «Costruttori Celesti» anche nei composti e nei riferimenti al gruppo. Riferimenti: `corpus/flat/Item.json#Item#28731.9:target`; `corpus/flat/Item.json#Item#28745.0:target`. |
| Skybuilders' Scrip(s) | Gettone dei Costruttori Celesti / Gettoni dei Costruttori Celesti | Decisione dell'utente | Valuta ottenuta contribuendo ai lavori del Firmamento; al plurale usare «Gettoni dei Costruttori Celesti». Riferimenti: `corpus/flat/Item.json#Item#28063.0:target`; `corpus/flat/Item.json#Item#28063.9:target`. |
| Heavens' Ward | Guardia Celeste | Decisione dell'utente | Nome dell'ordine cavalleresco di Ishgard; per i membri usare «cavalieri della Guardia Celeste». Riferimenti: `corpus/flat/Orchestrion.json#Orchestrion#398.0:target`; `corpus/flat/CabinetSubCategory.json#CabinetSubCategory#107:target`. |
| Ishgard Restoration | Ricostruzione di Ishgard | Decisione dell'utente | Nome del progetto e dell'attività, anche quando la sorgente dice «Ishgardian Restoration»; usare «Ricostruzione di Ishgard» nelle etichette e nei riferimenti al progetto. La decisione utente estende la forma scelta in `HWDInfoBoardArticle#21` a `Completion#4017.3`. Per lavori descritti genericamente usare «ricostruzione di Ishgard» in minuscolo. |
| Skyrise Celebration | Celebrazione del Firmamento | Decisione dell'utente | Nome dell'evento che comprende le Fêtes; accordare articoli e preposizioni al femminile singolare. Riferimenti: `corpus/flat/HWDDevLevelWebText.json#HWDDevLevelWebText#114.0:target`; `corpus/flat/HWDDevLevelWebText.json#HWDDevLevelWebText#115.0:target`. |

### Nomi di oggetti e bevande

| Inglese | Italiano | Fonte | Uso |
| --- | --- | --- | --- |
| Cryptlurker | Predatore delle Cripte | Decisione dell'utente | Set di equipaggiamento di Shadowbringers (patch 5.4, liv. 80). Nei nomi di armi, armature, accessori e forzieri usare «del Predatore delle Cripte» (es. «Spada del Predatore delle Cripte», «Corazza del Predatore delle Cripte della Difesa», «Spada del Predatore delle Cripte Potenziata»). Calco su FR «Rôdeur des cryptes» e DE «Krypta-Schleicher». Riferimenti: `corpus/flat/Item.json#32418.9` e segg. |
| Crypt [materiali] | [della] Cripta | Decisione dell'utente | Materiali di potenziamento per equipaggiamento Cryptlurker: Crypt Ester -> Estere della Cripta, Crypt Twine -> Spago della Cripta, Crypt Dusting -> Polvere della Cripta. Riferimenti: `corpus/flat/Item.json#32156.9`, `#32157.9`, `#32158.9`. |
| Bozjan Clusters | Aggregati di Bozja | Decisione dell'utente | Valuta degli scontri critici; usare la forma scelta anche nel nome del menu e nei dialoghi. Riferimenti: `corpus/flat/Item.json#Item#31135.2:target`; `corpus/flat/Addon.json#Addon#13822:target`. |
| Diamond Weapon | Arma di Diamante | Decisione dell'utente | Nome proprio della macchina da guerra; accordare al femminile. Riferimenti: `corpus/flat/TripleTriadCard.json#TripleTriadCard#324.0:target`; `corpus/flat/BNpcName.json#BNpcName#9953.0:target`. |
| Wicked White | Maledetto Bianco | Decisione dell'utente | Nome del cocktail; mantenere coerente il riferimento nelle battute dei clienti. Nuova traduzione `data/da_revisionare/dialogue/custom/006/regnor4girutt_00688.json#16,#43,#70,#73,#98:description`. |
| Alcoholic Beaverage | Bevanda al Castoro | Decisione dell'utente | Nome del cocktail; conservare la battuta sui castori. Nuova traduzione `data/da_revisionare/dialogue/custom/006/regnor4girutt_00688.json#17,#47,#74,#103:description`. |
| Gysahl Greens | Erba Gysahl | Decisione dell'utente del 14 novembre 2026 | Nome ufficiale SE della pianta/alimento; in prosa «erba Gysahl» al singolare massivo, adattando articoli e accordi; per i mazzi usare «mazzo d'erba Gysahl». Distinguere le verdure di Chysahl. Riferimenti EN/hash: `Item#4868.9`, `EventItem#2000085.9`, `DefaultTalk#590305.20`. |
| Kupo Nut / Kupo Nuts | noce kupo / noci kupo | `corpus/flat/EventItem.json#EventItem#2001635.0/.2/.9` | Nome del frutto anche nelle etichette oggetto e nei riferimenti alla stessa noce; composti con il nome «kupo» restano senza accento (intercalare «kupò»). Conservare in inglese le stringhe esatte da digitare. |
| Kupo Tree(s) | albero kupo / alberi kupo | `corpus/flat/EventItemHelp.json#EventItemHelp#2001635`; `corpus/quest/019/HeaVnz913_01978#TEXT_HEAVNZ913_01978_MOGLIN_000_013` | Nome della pianta che produce le noci kupo; mantenere senza accento il composto e distinguere l'intercalare «kupò». |

### Terminologia aggiuntiva: Bozja ed Eulmore

| Inglese | Italiano | Fonte | Uso |
| --- | --- | --- | --- |
| Cryptlurker | Predatore delle Cripte | Decisione dell'utente | Set di equipaggiamento di Shadowbringers (patch 5.4, liv. 80). Nei nomi di armi, armature, accessori e forzieri usare «del Predatore delle Cripte» (es. «Spada del Predatore delle Cripte», «Corazza del Predatore delle Cripte della Difesa», «Spada del Predatore delle Cripte Potenziata»). Calco su FR «Rôdeur des cryptes» e DE «Krypta-Schleicher». Riferimenti: `corpus/flat/Item.json#32418.9` e segg. |
| Crypt [materiali] | [della] Cripta | Decisione dell'utente | Materiali di potenziamento per equipaggiamento Cryptlurker: Crypt Ester -> Estere della Cripta, Crypt Twine -> Spago della Cripta, Crypt Dusting -> Polvere della Cripta. Riferimenti: `corpus/flat/Item.json#32156.9`, `#32157.9`, `#32158.9`. |
| Boutique of Splendors | Boutique degli Splendori | Decisione dell'utente | Nome della boutique di Rowena; usare questa forma nei dialoghi e nelle descrizioni dei suoi incaricati e materiali. Riferimenti: `corpus/flat/Item.json#Item#39766.8:target`; `corpus/flat/Item.json#Item#38749.8:target`. |
| Resplendent Tool(s) | attrezzo splendente / attrezzi splendenti | Decisione dell'utente | Nome degli attrezzi da artigiano e dei relativi componenti; usare «Scambio degli Attrezzi Splendenti» per Resplendent Tool Exchange. Riferimenti: `corpus/flat/SpecialShop.json#SpecialShop#1770333:target`; `corpus/flat/ENpcResident.json#ENpcResident#1027566.8:target`. |
| Blade (grado della Resistenza Bozjana) | Lama | Decisione dell'utente | Titolo rivolto all'avventuriero nel contesto della Resistenza Bozjana; non applicare al nome «Lame di Gunnhildr» né agli usi comuni di blade. Riferimenti: `corpus/flat/Action.json#Action#36347:target`; `corpus/flat/Action.json#Action#36356:target`. |
| Field Notes (collezionabili della Resistenza Bozjana) | Note sul Campo | Decisione dell'utente del 14 novembre 2026 | Per le etichette di scambio usare «Scambio Note sul Campo» (`DisposalShop#3473420–#3473422`); nei titoli dei 50 collezionabili usare «Note sul Campo: [referente]» (`Item#30342.9–#30361.9`, `#32191.9–#32200.9`, `#33798.9–#33817.9`). Nei fasci descrittivi (`sheaf(s) of field notes`) mantenere «appunti di campo». |
| Hannish Certificates of Grade 1–3 Import | Certificati Hannish d'Importazione di Grado 1–3 | Decisione dell'utente del 14 novembre 2026 | Etichette per le categorie di armi, equipaggiamento e accessori: `DisposalShop#3473444–#3473452`. Coerente con i nomi delle valute `Item#36794.9`, `#39088.9` e `#40896.9`; usare l'aggettivo «Hannish», non «di Radz-at-Han». |
| Eulmoran Certificate of Grandeur | Certificato di Grandiosità di Eulmore | Decisione dell'utente del 14 novembre 2026 | Nome della valuta e delle relative categorie: `Item#33440.0/.2/.9` e `DisposalShop#3473441–#3473443`; sostituisce «Certificato Eulmoran di Grandezza» per questo referente. |

### Terminologia Dawntrail confermata

| Inglese | Italiano | Fonte | Uso |
| --- | --- | --- | --- |
| Cryptlurker | Predatore delle Cripte | Decisione dell'utente | Set di equipaggiamento di Shadowbringers (patch 5.4, liv. 80). Nei nomi di armi, armature, accessori e forzieri usare «del Predatore delle Cripte» (es. «Spada del Predatore delle Cripte», «Corazza del Predatore delle Cripte della Difesa», «Spada del Predatore delle Cripte Potenziata»). Calco su FR «Rôdeur des cryptes» e DE «Krypta-Schleicher». Riferimenti: `corpus/flat/Item.json#32418.9` e segg. |
| Crypt [materiali] | [della] Cripta | Decisione dell'utente | Materiali di potenziamento per equipaggiamento Cryptlurker: Crypt Ester -> Estere della Cripta, Crypt Twine -> Spago della Cripta, Crypt Dusting -> Polvere della Cripta. Riferimenti: `corpus/flat/Item.json#32156.9`, `#32157.9`, `#32158.9`. |
| Earthenshire | Borgoargilla | Decisione dell'utente | Toponimo da scrivere unito e senza articolo; accordare le preposizioni al contesto. Riferimenti: `corpus/flat/Adventure.json#Adventure#2162998.13:target`; `world/chocobotaxistand.json#1179740:original`. |
| Skyruin | Flagello Celeste | Decisione dell'utente | Epiteto di Valigarmanda; usare «il Flagello Celeste» nei riferimenti diretti, accordando articoli e preposizioni. Lasciare invariati i titoli musicali in `housing/orchestrion.json`, secondo la guida di traduzione. Riferimenti: `corpus/flat/Action.json#Action#36161:target`; `corpus/flat/Action.json#Action#36162:target`. |
| Ceruleum | ceruleo | Decisione dell'utente | Usare «ceruleo» quando indica il combustibile o il minerale, con maiuscola solo a inizio frase o nei titoli dei campi. Lasciare invariati i titoli musicali e il nome della tinta «Ceruleum Blue». Riferimenti: `corpus/flat/Addon.json#Addon#11358:target`; `corpus/flat/AkatsukiNoteString.json#AkatsukiNoteString#92:target`. |
| Xak Tural Railing | Ferrovia di Xak Tural | Decisione dell'utente | Nome dell'azienda ferroviaria; usare la forma completa alla prima menzione e «Ferrovia» quando il contesto è chiaro. Riferimenti: `corpus/flat/Item.json#Item#44858.8:target`; `corpus/flat/CompanionTransient.json#CompanionTransient#539.1:target`. |
### Esplorazione Cosmica

| Inglese | Italiano | Fonte | Uso |
| --- | --- | --- | --- |
| Cosmic Exploration | Esplorazione Cosmica | Decisione dell'utente del 14 novembre 2026 | Nome canonico della funzione nelle etichette di sistema, del profilo giocatore, dei banner, delle decorazioni e delle categorie; in prosa adattare articoli e preposizioni alla frase. Riferimenti EN/hash verificati: `corpus/flat/Addon.json#Addon#3849`, `corpus/flat/CharaCardBase.json#CharaCardBase#137`, `corpus/flat/BannerFrame.json#BannerFrame#232`, `corpus/flat/BannerDesignPreset.json#BannerDesignPreset#294`, `corpus/flat/BannerDecoration.json#BannerDecoration#268`, `corpus/flat/BannerBg.json#BannerBg#313`, `corpus/flat/Completion.json#Completion#4048.3`, `corpus/flat/DescriptionString.json#DescriptionString#1276`, `corpus/flat/ContentsTutorial.json#ContentsTutorial#8.9`, `corpus/flat/DescriptionStandAloneTransient.json#DescriptionStandAloneTransient#24.1`, `corpus/flat/Description.json#Description#3604506.3`, `corpus/flat/CharaCardPlayStyle.json#CharaCardPlayStyle#34`, `corpus/flat/CharaCardHeader.json#CharaCardHeader#74`, `corpus/flat/CharaCardDesignPreset.json#CharaCardDesignPreset#98`, `corpus/flat/CharaCardDecoration.json#CharaCardDecoration#587/#588/#589`, `corpus/flat/GroupPoseStampCategory.json#GroupPoseStampCategory#30`, `corpus/flat/MassivePcContent.json#MassivePcContent#1/#2/#5/#6`. |
| Cryptlurker | Predatore delle Cripte | Decisione dell'utente | Set di equipaggiamento di Shadowbringers (patch 5.4, liv. 80). Nei nomi di armi, armature, accessori e forzieri usare «del Predatore delle Cripte» (es. «Spada del Predatore delle Cripte», «Corazza del Predatore delle Cripte della Difesa», «Spada del Predatore delle Cripte Potenziata»). Calco su FR «Rôdeur des cryptes» e DE «Krypta-Schleicher». Riferimenti: `corpus/flat/Item.json#32418.9` e segg. |
| Crypt [materiali] | [della] Cripta | Decisione dell'utente | Materiali di potenziamento per equipaggiamento Cryptlurker: Crypt Ester -> Estere della Cripta, Crypt Twine -> Spago della Cripta, Crypt Dusting -> Polvere della Cripta. Riferimenti: `corpus/flat/Item.json#32156.9`, `#32157.9`, `#32158.9`. |
| Artifact(s) (Esplorazione Cosmica) | Manufatto / manufatti | Decisione dell'utente riconfermata l'11 novembre 2026 | Reperti analizzati dai droni nelle rovine; usare «manufatto» al singolare e «manufatti» al plurale. Riferimenti: `corpus/flat/EObjName.json#EObjName#2015138.0:target`; `corpus/flat/EObjName.json#EObjName#2015138.2:target`. |
| Ancient Record(s) | Registro Antico / registri antichi | Decisione dell'utente | Nome dei dati recuperati dall'analisi dei manufatti; usare «registro antico» al singolare e «registri antichi» al plurale. Riferimenti: `corpus/flat/Item.json#Item#50411.0:target`; `corpus/flat/Item.json#Item#50411.9:target`. |
| Aide's Attentive Angel | Angelo Custode dell'Aiutante | Decisione dell'utente | Titolo di reputazione di Charlemend. «Angelo» mantiene il genere grammaticale maschile anche riferito al personaggio femminile; non alternare con «Anima», «attento» o «premuroso» per questo titolo. |
| Appointed to House Leveilleur | Incaricato della Casata Leveilleur | Decisione dell'utente | Variante femminile: «Incaricata della Casata Leveilleur». Titolo di reputazione assegnato da Ameliance al giocatore: accordare mediante SeString. |
| Garlond Ironworks | Officine Garlond | Decisione dell'utente | Nome dell'azienda di Cid. Varianti ammesse in prosa: «Officine». Mantenere il plurale e accordare articoli, verbi e possessivi; estendere la forma ai riferimenti aziendali di equipaggiamento e documenti. Non modificare gli identificatori tecnici. |
| Titoli nobiliari di Ishgard | Lord, Lady, Lord Comandante | Decisione dell'utente | I titoli nobiliari e di rango feudale di Ishgard (Lord, Lady) si mantengono in inglese: non tradurli con «Dama» o simili adattamenti. Forme allocutive e di deferenza come «mio signore», «mia signora», «sua santità», restano invece perfettamente naturali e valide nel dialogo. |
| Heavenspillar / heavenspillars | Pilastro Celeste / Pilastri Celesti | Decisione dell'utente | Specie arborea gigantesca, anche nella metafora usata da Beatin per il giocatore; «pilastro» conserva il genere grammaticale maschile indipendentemente dal personaggio. Estendere ai materiali e alle descrizioni; non usare «colonna celeste», «Spillacielo» o il nome inglese. Riferimenti: `corpus/custom/000/RegFstWdkGuild_00029.json#custom/000/RegFstWdkGuild_00029#TEXT_REGFSTWDKGUILD_00029_BEATINE_000_050:target`; `#20:description`; `corpus/flat/EventItem.json#EventItem#2002122.0:target`. |
| Group Pose | Posa di Gruppo | `corpus/flat/Addon.json#Addon#13138:target` | Decisione dell'utente; nome della funzione. In prosa minuscolo: «posa di gruppo». |
| Aethernet | Eternet | Decisione dell'utente | Rete di teletrasporto locale; distinta dall'Eterite e dal Faro Eterico. |
| Preferred World | Mondo Preferito | Decisione dell'utente | Nome della categoria di server; per Preferred+ World usare «Mondo Preferito+». Eccezione: la label composta Preferred World Bonus usa «Bonus Mondo Preferenziale» per decisione utente distinta (corpus/flat/Status.json#Status#1411.0:target; corpus/flat/LogMessage.json#1415-1417). |
| Watchlist | Lista di controllo | Decisione dell'utente | Nome dell'elenco degli obiettivi seguiti. Riferimenti: `system/addon.json#3374-3377`; `system/logmessage.json#1426-1428`. |
| Minion (famiglio non combattente) | minion | Decisione dell'utente | Decisione dell'utente: mantenere il termine inglese; riferimento: `system/logmessage.json#1325`; distinguere dal compagno da battaglia. |

**Decisione dell'utente:** `Tower of Babil` si rende **Torre di Babil**; adatta articoli e preposizioni, senza tradurre le menzioni generiche di `tower`. Riferimento: `quests/master/completion.json#11469:translation`; `@corpus/cut_scene/060/VoiceMan_06001.json#TEXT_VOICEMAN_06001_006460_YSHTOLA:target`.


### Decisioni utente — toponimi del Firmamento e Bozja

| Inglese | Italiano | Fonte | Uso |
| --- | --- | --- | --- |
| Risensong Quarter / District | Rione Cantorisorto | Decisione dell'utente | Nome del quartiere del Firmamento; per le zone orientale e occidentale usare «Rione Cantorisorto Orientale/Occidentale». Riferimenti: `PlaceName#3640.0/.2`, `#3645`, `#3646`; FATE 1668–1685. |
| Bright Ballad's Passage | Passaggio della Ballata Radiosa | Decisione dell'utente | Toponimo nel quartiere del Firmamento. |
| Dreamer's Run | Cammino dei Sognatori | Decisione dell'utente | Luogo della Festa delle Uova; usare anche nei nomi del portiere e nei riferimenti alle quest. |
| Ice Bombard(s) | Bombarda / Bombarde di ghiaccio | Decisione dell'utente riconfermata l'11 novembre 2026 | Nome della creatura; singolare «Bombarda di ghiaccio», plurale «Bombarde di ghiaccio». Sostituisce «Piro/Piros di ghiaccio» per questo referente; distinti ice bomb e Bombard senza Ice. Riferimenti: `corpus/flat/BNpcName.json#BNpcName#10193.0:target`; `#BNpcName#10193.2:target`; `corpus/flat/Fate.json#Fate#1710.1:target`; `corpus/quest/040/FesSum701_04082.json#quest/040/FesSum701_04082#TEXT_FESSUM701_04082_SEQ_05:target`. |
| Resistance appropriator(s) | Incaricato / Incaricati della Resistenza | Decisione dell'utente | Ruolo dei PNG addetti al recupero di materiali magitec e ceruleo. |
| Llofii the Forthright | Llofii la Schietta | corpus/flat/Fate.json#Fate#1609.3:target | Epiteto del personaggio; mantenere la stessa forma nei riferimenti. |
| Gilbrisbert the Puppetmaster | Gilbrisbert il Burattinaio | corpus/flat/Fate.json#Fate#1737.1:target | Titolo del personaggio; usare questa forma anche nei riferimenti. |
| 4th-make Famfrit | Famfrit della IV Legione | corpus/flat/Fate.json#Fate#1737.1:target | Designazione dell'entità. |
| Tower of Zot | Torre di Zot | Decisione dell'utente | Riferimento: `world/placename.json#3736/#3890:translation`. Toponimo; adattare articoli e preposizioni al contesto. |
| Drifting dynamite | dinamite fluttuante | `corpus/flat/BNpcName.json#BNpcName#11176.0:target` | Nome della creatura; plurale «dinamiti fluttuanti». |
| Boosted cleaner | pulitore potenziato | `corpus/flat/BNpcName.json#BNpcName#11177.0:target` | Nome della macchina; plurale «pulitori potenziati». |

### Decisioni utente — creature e materiali

| Inglese | Italiano | Fonte | Uso |
| --- | --- | --- | --- |
| Bombard(s) | Piro / Piros (forma superata) | Decisione dell'utente superata il 13 novembre 2026 | La scelta precedente per i Bombard della Festa del Fuoco Lunare è sostituita da Bombardo/Bombardi; Piro/Piros resta per la creatura distinta Bomb. L'eccezione Ice Bombard resta Bombarda/Bombarde di ghiaccio. Riferimenti storici: `Fate#1710.0/.1`; `BNpcName#15593–#15608`. |
| Luncheon toad(s) | Rospo / rospi da pranzo | Decisione dell'utente | Nome della creatura; usare anche in descrizioni e composti. Riferimenti: `BNpcName#10673.0/.2`; `Fate#1748.1`. |
| Snapweed(s) | Nepente / nepenti | Decisione dell'utente | Specie vegetale; usare nei nomi e nella prosa, es. «nepenti che sputano acido». Riferimenti: `BNpcName#8603.0/.2`; `Fate#1750.1`. |
| Cloudtrap(s) | pianta acchiappanubi / piante acchiappanubi | Decisione dell'utente del 13 novembre 2026 | Nome della pianta nemica; uniformare `BNpcName#4537.0/.2`, `#4933.0/.2`, `#9315.0/.2`, `#9628.0/.2`, `#12823.0/.2` e la prosa in `EventItemHelp#2002059`. EN/hash verificati. |
| Polis Hawk(s) | vespa Pepsis dell'Aquapolis / vespe Pepsis dell'Aquapolis | Decisione dell'utente del 13 novembre 2026 | Nome del nemico di Aquapolis; FR specifica la vespa Pepsis. Canone limitato a `BNpcName#5115.0/.2`. EN/hash verificati. |
| luncheon toadskin | pelle di rospo da pranzo | Decisione dell'utente | Materiale ricavato dal rospo da pranzo; usare la forma nei nomi degli oggetti e nella prosa. |
| Electrope | Elettrope | Decisione dell'utente | Nome della creatura/materiale; mantenere la grafia elettrope. Fonte e decisione già registrata in `ffxiv-language-pack-it/glossary/overrides.json` (`electrope`). Sostituisce la forma legacy «Elettropo». |
| Firehorn / Iceclaw / Thunderwing | Corno di Fuoco / Corni di Fuoco; Artiglio di Ghiaccio / Artigli di Ghiaccio; Ala Tonante / Ali Tonanti | Decisione dell'utente del 13 novembre 2026 | Nomi delle creature; usare le forme al singolare e al plurale. Riferimenti EN/hash verificati: `corpus/flat/BNpcName.json#BNpcName#2630.0/.2`, `#2631.0/.2`, `#2632.0/.2`; le forme singolari ricorrono in `corpus/flat/Status.json#Status#464.1`, `#465.1`. FR/DE confermano i composti descrittivi. |
| Harrier (nemico) | predone / predoni | Decisione dell'utente del 13 novembre 2026 | Per i nemici dei campi nome: `corpus/flat/BNpcName.json#BNpcName#2782–#2785`, `#2990`, `#3034`, `#3182`; il messaggio `LogMessage#2323` identifica il #2785. Non applicare all'uccello, reso «albanella», né al sintagma narrativo `frogman harriers` (`quest/014/HeaVnz029_01479`). EN/hash verificati. |
| White Joker | Joker Bianco | Decisione dell'utente del 13 novembre 2026 | Nome del ricercato di rango B, uno scoiattolo: `corpus/flat/BNpcName.json#BNpcName#2919.0/.2`; `corpus/custom/001/RegFstNotoriousMonsterHintF1_00194` (nome e descrizione). |
| Stinging Sophie | Sophie Pungente | Decisione dell'utente del 13 novembre 2026 | Nome del ricercato di rango B, un calabrone gigante: `corpus/flat/BNpcName.json#BNpcName#2920.0/.2`; `corpus/custom/001/RegFstNotoriousMonsterHintF2_00195` (nome e descrizione). |
| Monarch Ogrefly | Libellula Ogre Monarca | Decisione dell'utente del 13 novembre 2026 | Nome del ricercato di rango B, un vilomorfo: `corpus/flat/BNpcName.json#BNpcName#2921.0/.2`; `corpus/custom/001/RegFstNotoriousMonsterHintF3_00196` (nome e descrizione). |


### Decisione utente — toponimi

| Inglese | Italiano | Fonte | Uso |
| --- | --- | --- | --- |
| Buscarron's Druthers / the Druthers | Locanda di Buscarron | Decisione dell'utente | Nome della locanda; usare anche nei riferimenti brevi e adattare articoli e preposizioni. Mantenere le locuzioni inglesi my druthers («se dipendesse da me») nel senso idiomatico di “preferenza”. Riferimento: `PlaceName#119.0/.2`. Decisione dell'utente dell'11 novembre 2026: la stessa forma vale anche per il titolo del Diario Esplorazione `corpus/flat/Adventure.json#Adventure#2162731.13:target`; la vecchia variante «Il Capriccio di Buscarron» e' superata in quel campo. |
| Summerford Farms | Fattorie di Guado d'Estate | Decisione dell'utente | Toponimo agricolo; estendere la forma ai riferimenti alle Fattorie di Summerford e adattare articoli e preposizioni al contesto. Riferimento: `data/translations/world/placename.json#184:translation`. |
| Standing Corses | I Cadaveri Eretti | Decisione dell'utente | Toponimo; usare il nome completo e adattare articoli e preposizioni al contesto. Riferimento legacy: `corpus/flat/PlaceName.json#PlaceName#72.0:target`. |
| Little Solace | Piccolo Rifugio | Decisione dell'utente | Toponimo; usare «Piccolo Rifugio» e adattare articoli e preposizioni al maschile. Riferimento legacy: `data/translations/world/placename.json#113:translation`. |
| Aleport | Portobirra | Decisione dell'utente | Toponimo; usare «Portobirra» e adattare articoli e preposizioni al contesto. Riferimenti legacy: `data/translations/world/placename.json#223:translation`, `#368:translation` (Molo di Portobirra). |
| Fallgourd Float / Fallgourd | Zuccacaduta | Decisione dell'utente | Toponimo dell'insediamento e della zona di pesca; usare «Zuccacaduta» in tutte le occorrenze pertinenti. Riferimenti legacy: `data/translations/world/placename.json#140/#962:translation`. |

### Decisione utente — funzioni dell'interfaccia

| Inglese | Italiano | Fonte | Uso |
| --- | --- | --- | --- |
| Dreamfitting | Prova Onirica | Decisione dell'utente | Nome della funzione; usare la maiuscola quando identifica la funzione e adeguare articoli e preposizioni. Riferimenti: `Addon#14620`; `Addon#8483`. |
| Toggle Score | Alterna Punteggio | `corpus/flat/EmjAddon.json#EmjAddon#7:target` | Etichetta del comando per alternare la visualizzazione del punteggio nel Mahjong Domano; forma compatta scelta dall'utente per rientrare nello spazio disponibile della UI. |

### Decisione utente — oggetti

| Inglese | Italiano | Fonte | Uso |
| --- | --- | --- | --- |
| truesight smoke bomb(s) | bomba/e fumogena/e rivelatrice/i | Decisione dell'utente | Nome dell'oggetto; usare le forme singolare e plurale anche in oggetti, interazioni e notifiche. Riferimenti: `EventItem#2002005`; `EObjName#2007412`; `LogMessage#2719/#2742`; `HalloweenEntrance#...261/#...263`. |


## Nomi dei Loporrit (Decisione dell'utente)

Convenzione editoriale: i nomi dei Loporrit seguono gli adattamenti confermati dall'utente (prevalentemente imperativi in `-alo`/`-ilo`, con alcune forme in `-olo`; `Way`/`Ways` isolato → `Lo`).

| Forma sorgente | Forma italiana | Fonte sorgente / Nota d'uso |
| :--- | :--- | :--- |
| Aimingway | Púntalo | Decisione dell'utente. Adattamento Loporrit aggiornato. |
| Blastingway | Scóppialo | Decisione dell'utente. Adattamento Loporrit aggiornato. |
| Blossomingway | Sbóccialo | Decisione dell'utente. Adattamento Loporrit aggiornato. |
| Boostingway | Cáricalo | Decisione dell'utente. Adattamento Loporrit aggiornato. |
| Broodingway | Crúcciolo | Decisione dell'utente. Adattamento in stile nani di Biancaneve (`-olo`). |
| Buildingway | Fábbricalo | Decisione dell'utente. Adattamento Loporrit aggiornato. |
| Campingway | Téndalo | Decisione dell'utente. Adattamento Loporrit aggiornato. |
| Cheatingway | Fúrbolo | Decisione dell'utente. Adattamento in stile nani di Biancaneve (`-olo`). |
| Coiningway | Monétalo | Decisione dell'utente. Adattamento Loporrit aggiornato. |
| Commandingway | Comándalo | Decisione dell'utente. Adattamento Loporrit aggiornato. |
| Cookingway | Cucínalo | Decisione dell'utente. Adattamento Loporrit aggiornato. |
| Counselingway | Consíglialo | Decisione dell'utente. Adattamento Loporrit aggiornato. |
| Craftingway | Artigiánolo | Decisione dell'utente. Adattamento in stile nani di Biancaneve (`-olo`). |
| Cruisingway | Návigalo | Decisione dell'utente. Adattamento Loporrit aggiornato. |
| Crushingway | Schiáccialo | Decisione dell'utente. Adattamento Loporrit aggiornato. |
| Dancingway | Dánzalo | Decisione dell'utente. Adattamento Loporrit aggiornato. |
| Demolishingway | Abbáttilo | Decisione dell'utente. Adattamento Loporrit aggiornato. |
| Desertingway | Desértolo | Decisione dell'utente. Adattamento in stile nani di Biancaneve (`-olo`). |
| Diggingway | Scávalo | Decisione dell'utente. Adattamento Loporrit aggiornato. |
| Divingway | Túffalo | Decisione dell'utente. Adattamento Loporrit aggiornato. |
| Dramatizingway | Drámmalo | Decisione dell'utente. Adattamento Loporrit aggiornato. |
| Dreamingway | Sógnalo | Decisione dell'utente. Adattamento Loporrit aggiornato. |
| Drivingway | Pilótalo | Decisione dell'utente. Adattamento Loporrit aggiornato. |
| Droningway | Rónzalo | Decisione dell'utente. Adattamento Loporrit aggiornato. |
| Enchantingway | Incántalo | Decisione dell'utente. Adattamento Loporrit aggiornato. |
| Eyeballingway | Adócchialo | Decisione dell'utente. Adattamento Loporrit aggiornato. |
| Fallingway | Rúzzolo | Decisione dell'utente. Adattamento in stile nani di Biancaneve (`-olo`). |
| Fightingway | Combáttilo | Decisione dell'utente. Adattamento Loporrit aggiornato. |
| Fishingway | Péscalo | Decisione dell'utente. Adattamento Loporrit aggiornato. |
| Findingway | Tróvalo | Decisione dell'utente. Adattamento Loporrit aggiornato. |
| Fixingway | Aggiústalo | Decisione dell'utente. Adattamento Loporrit aggiornato. |
| Floppingway | Cióndolo | Decisione dell'utente. Adattamento in stile nani di Biancaneve (`-olo`). |
| Forbiddingway | Proibítolo | Decisione dell'utente. Adattamento in stile nani di Biancaneve (`-olo`). |
| Fusingway | Fóndilo | Decisione dell'utente. Adattamento Loporrit aggiornato. |
| Gamingway | Giócalo | Decisione dell'utente. Adattamento Loporrit aggiornato. |
| Goingmyway | Vagabóndolo | Decisione dell'utente. Adattamento in stile nani di Biancaneve (`-olo`). |
| Greeningway | Piántalo | Decisione dell'utente. Adattamento Loporrit aggiornato. |
| Grindingway | Mácinalo | Decisione dell'utente. Adattamento Loporrit aggiornato. |
| Growingway | Créscilo | Decisione dell'utente. Adattamento Loporrit aggiornato. |
| Guidingway | Guídalo | Decisione dell'utente. Adattamento Loporrit aggiornato. |
| Hoppingway | Sáltalo | Decisione dell'utente. Adattamento Loporrit aggiornato. |
| Hummingway | Mórmolo | Decisione dell'utente. Adattamento in stile nani di Biancaneve (`-olo`). |
| Huntingway | Cáccialo | Decisione dell'utente. Adattamento Loporrit aggiornato. |
| Inspectingway | Contróllalo | Decisione dell'utente. Adattamento Loporrit aggiornato. |
| Inventingway | Invéntalo | Decisione dell'utente. Adattamento Loporrit aggiornato. |
| Jammingway | Rítmalo | Decisione dell'utente. Adattamento Loporrit aggiornato. |
| Keepingway | Custódilo | Decisione dell'utente. Adattamento Loporrit aggiornato. |
| Knockingway | Bússalo | Decisione dell'utente. Adattamento Loporrit aggiornato. |
| Learningway | Impáralo | Decisione dell'utente. Adattamento Loporrit aggiornato. |
| Lightingway | Lumínalo | Decisione dell'utente. Adattamento Loporrit aggiornato. |
| Limingway | Rímalo | Decisione dell'utente. Adattamento Loporrit aggiornato. |
| Livingway | Vívilo | Decisione dell'utente. Adattamento Loporrit aggiornato. |
| Lovingway | Adóralo | Decisione dell'utente. Adattamento Loporrit aggiornato. |
| Lurkingway | Furtívolo | Decisione dell'utente. Adattamento in stile nani di Biancaneve (`-olo`). |
| Managingway | Organízzalo | Decisione dell'utente. Adattamento Loporrit aggiornato. |
| Mappingway | Cartográfalo | Decisione dell'utente. Adattamento Loporrit aggiornato. |
| Mixingway | Méscolo | Decisione dell'utente. Adattamento in stile nani di Biancaneve (`-olo`). |
| Mopingway | Bróntolo | Decisione dell'utente. Adattamento in stile nani di Biancaneve (`-olo`). |
| Namingway | Nóminalo | Decisione dell'utente. Adattamento Loporrit aggiornato. |
| Nothingway | Ozíolo | Decisione dell'utente. Adattamento in stile nani di Biancaneve (`-olo`). |
| Orbitingway | Gíralo | Decisione dell'utente. Adattamento Loporrit aggiornato. |
| Packingway | Bagágliolo | Decisione dell'utente. Adattamento in stile nani di Biancaneve (`-olo`). |
| Paintingway | Píttalo | Decisione dell'utente. Adattamento Loporrit aggiornato. |
| Phasingway | Régolo | Decisione dell'utente. Adattamento in stile nani di Biancaneve (`-olo`). |
| Pickingway | Préndilo | Decisione dell'utente. Adattamento Loporrit aggiornato. |
| Piercingway | Trivéllalo | Decisione dell'utente. Adattamento Loporrit aggiornato. |
| Pipingway | Túbolo | Decisione dell'utente. Adattamento in stile nani di Biancaneve (`-olo`). |
| Protectingway | Protéggilo | Decisione dell'utente. Adattamento Loporrit aggiornato. |
| Puddingway | Budínolo | Decisione dell'utente. Adattamento in stile nani di Biancaneve (`-olo`). |
| Readingway | Léggilo | Decisione dell'utente. Adattamento Loporrit aggiornato. |
| Recordingway | Regístralo | Decisione dell'utente. Adattamento Loporrit aggiornato. |
| Removingway | Sgómbralo | Decisione dell'utente. Adattamento Loporrit aggiornato. |
| Repairingway | Ripáralo | Decisione dell'utente. Adattamento Loporrit aggiornato. |
| Reportingway | Notizíalo | Decisione dell'utente. Adattamento Loporrit aggiornato. |
| Researchingway | Studíalo | Decisione dell'utente. Adattamento Loporrit aggiornato. |
| Ridingway | Caválcalo | Decisione dell'utente. Adattamento Loporrit aggiornato. |
| Runningway | Córrilo | Decisione dell'utente. Adattamento Loporrit aggiornato. |
| Savingway | Sálvalo | Decisione dell'utente. Adattamento Loporrit aggiornato. |
| Scanningway | Scansiónalo | Decisione dell'utente. Adattamento Loporrit aggiornato. |
| Searchingway | Cércalo | Decisione dell'utente. Adattamento Loporrit aggiornato. |
| Servingway | Maggiordómolo | Decisione dell'utente. Adattamento in stile nani di Biancaneve (`-olo`). |
| Shakingway | Scuótilo | Decisione dell'utente. Adattamento Loporrit aggiornato. |
| Shiningway | Luccícalo | Decisione dell'utente. Adattamento Loporrit aggiornato. |
| Shootingway | Spáralo | Decisione dell'utente. Adattamento Loporrit aggiornato. |
| Singingway | Cántalo | Decisione dell'utente. Adattamento Loporrit aggiornato. |
| Skippingway | Bálzalo | Decisione dell'utente. Adattamento Loporrit aggiornato. |
| Sleepingway | Písolo | Decisione dell'utente. Adattamento in stile nani di Biancaneve (`-olo`). |
| Snappingway | Schióccalo | Decisione dell'utente. Adattamento Loporrit aggiornato. |
| Sparkingway | Scintíllalo | Decisione dell'utente. Adattamento Loporrit aggiornato. |
| Splittingway | Spáccalo | Decisione dell'utente. Adattamento Loporrit aggiornato. |
| Stuffingway | Pupázzolo | Decisione dell'utente. Adattamento in stile nani di Biancaneve (`-olo`). |
| Surfingway | Súrfalo | Decisione dell'utente. Adattamento Loporrit aggiornato. |
| Sweepingway | Spázzalo | Decisione dell'utente. Adattamento Loporrit aggiornato. |
| Talkingway | Spiégalo | Decisione dell'utente. Adattamento Loporrit aggiornato. |
| Terrifyingway | Spavéntalo | Decisione dell'utente. Adattamento Loporrit aggiornato. |
| Theorizingway | Teorízzalo | Decisione dell'utente. Adattamento Loporrit aggiornato. |
| Thinkingway | Pénsalo | Decisione dell'utente. Adattamento Loporrit aggiornato. |
| Thrillingway | Brívidolo | Decisione dell'utente. Adattamento in stile nani di Biancaneve (`-olo`). |
| Tradingway | Véndilo | Decisione dell'utente. Adattamento Loporrit aggiornato. |
| Trainingway | Addéstralo | Decisione dell'utente. Adattamento Loporrit aggiornato. |
| Warringway | Ménalo | Decisione dell'utente. Adattamento Loporrit aggiornato. |
| Watchingway | Guárdalo | Decisione dell'utente. Adattamento Loporrit aggiornato. |
| Weavingway | Fílalo | Decisione dell'utente. Adattamento Loporrit aggiornato. |
| Weddingway | Innéstalo | Decisione dell'utente. Adattamento Loporrit aggiornato. |
| Winningway | Triónfalo | Decisione dell'utente. Adattamento Loporrit aggiornato. |
| Wobblingway | Dóndolo | Decisione dell'utente. Adattamento in stile nani di Biancaneve (`-olo`). |
| Workingway | Lavóralo | Decisione dell'utente. Adattamento Loporrit aggiornato. |
| Yawningway | Sbadíglialo | Decisione dell'utente. Adattamento Loporrit aggiornato. |
| chefingway | Cucínalo | Decisione dell'utente. Adattamento Loporrit aggiornato. |
| chefingways | Cucínali | Decisione dell'utente. Adattamento Loporrit aggiornato. |
| helpingway | Aiútalo | Decisione dell'utente. Adattamento Loporrit aggiornato. |
| Dreaming Ways | Sógnalo | Decisione dell'utente. Nome della società alleata / fazione Loporrit (es. `i Sógnalo`). |
| Way / Ways | Lo | Decisione dell'utente. Appellativo generico dei Loporrit in prosa/titoli, invariabile (es. `un Lo`, `i nostri Lo`). |

## Decisioni terminologiche da repertori legacy

Decisioni utente su etichette e denominazioni legacy. Applicare solo al referente e al campo indicati; non estendere a omonimi nella prosa.

| Inglese | Italiano | Fonte | Uso |
| --- | --- | --- | --- |
| The Wolves' Den | L'Antro dei Lupi | Decisione dell'utente | corpus/flat/ContentUICategory.json#ContentUICategory#1:target; destinazione PvP, articoli flessi nel contesto. |
| Game QA | QA del Gioco | Decisione dell'utente | corpus/flat/OnlineStatus.json#OnlineStatus#1:target; solo etichetta OnlineStatus. |
| Battle Mentor | Mentore di Battaglia | Decisione dell'utente | corpus/flat/OnlineStatus.json#OnlineStatus#11:target; solo etichetta OnlineStatus. |
| Viewing Cutscene | In una Scena | Decisione dell'utente | corpus/flat/OnlineStatus.json#OnlineStatus#15:target; solo etichetta OnlineStatus. |
| Camera Mode | Modalità Telecamera | Decisione dell'utente | corpus/flat/OnlineStatus.json#OnlineStatus#18:target; solo etichetta OnlineStatus. |
| Trade Mentor | Mentore dei Mestieri | Decisione dell'utente | corpus/flat/OnlineStatus.json#OnlineStatus#29:target; solo etichetta OnlineStatus. |
| Alliance Leader | Capo dell'Alleanza | Decisione dell'utente | corpus/flat/OnlineStatus.json#OnlineStatus#33:target; solo etichetta OnlineStatus. |
| Self | Se stesso | Decisione dell'utente | corpus/flat/XBMActionTarget.json#XBMActionTarget#1:target; solo tipo di bersaglio. |
| Ground | Terreno | Decisione dell'utente | corpus/flat/XBMActionTarget.json#XBMActionTarget#2:target; solo tipo di bersaglio. |
| Highest Enmity | Massima Ostilità | Decisione dell'utente | corpus/flat/XBMActionTarget.json#XBMActionTarget#3:target; solo tipo di bersaglio. |
| Monster Toss | Mostro nel Cesto | Decisione dell'utente | corpus/flat/GoldSaucerArcadeMachine.json#GoldSaucerArcadeMachine#2359297.39:target; titolo arcade. |
| Crystal Tower Striker | Il Martello della Torre di Cristallo | Decisione dell'utente | corpus/flat/GoldSaucerArcadeMachine.json#GoldSaucerArcadeMachine#2359299.39:target; titolo arcade. |
| Cuff-a-Cur | Picchia Chi Può | Decisione dell'utente | corpus/flat/GoldSaucerArcadeMachine.json#GoldSaucerArcadeMachine#2359300.39:target; titolo arcade. |
| The Finer Miner | Il Minatore Matto | Decisione dell'utente | corpus/flat/GoldSaucerArcadeMachine.json#GoldSaucerArcadeMachine#2359301.39:target; titolo arcade. |
| Out on a Limb | Il Potatore Matto | Decisione dell'utente | corpus/flat/GoldSaucerArcadeMachine.json#GoldSaucerArcadeMachine#2359302.39:target; titolo arcade; escludere l'idioma comune. |
| All | Tutte | Decisione dell'utente | corpus/flat/FCActivityCategory.json#FCActivityCategory#0:target; solo categoria FCActivityCategory. |
| Entitlements | Vantaggi | Decisione dell'utente | corpus/flat/FCActivityCategory.json#FCActivityCategory#1:target; solo categoria FCActivityCategory. |
| Company Workshop | Officina della Compagnia | Decisione dell'utente | corpus/flat/FCActivityCategory.json#FCActivityCategory#8:target; solo categoria FCActivityCategory. |
| Airship/Submersible | Aeronavi/Sommergibili | Decisione dell'utente | corpus/flat/FCActivityCategory.json#FCActivityCategory#9:target; solo categoria FCActivityCategory. |
| Scrip Exchange | Scambio Gettoni | Decisione dell'utente | shops/inclusionshop.json#3801094/#3801096/#3801097/#3801103:translation. |
| Gatherers' Scrip Exchange | Scambio Gettoni dei Raccoglitori | Decisione dell'utente | corpus/flat/InclusionShop.json#InclusionShop#3801095:target. |
| Apex | Supremo | Decisione dell'utente | corpus/flat/XBMScoreRank.json#XBMScoreRank#1:target; grado XBMScoreRank. |
| Elite | Élite | Decisione dell'utente | corpus/flat/XBMScoreRank.json#XBMScoreRank#2:target; grado XBMScoreRank. |
| Journeyman | Praticante | Decisione dell'utente | corpus/flat/XBMScoreRank.json#XBMScoreRank#6:target; grado XBMScoreRank. |
| Novice | Novizio | Decisione dell'utente | corpus/flat/XBMScoreRank.json#XBMScoreRank#7:target; grado XBMScoreRank. |
| Same | Uguale | Decisione dell'utente | corpus/flat/TripleTriadRule.json#TripleTriadRule#4.0:target. |
| Sudden Death | A Oltranza | Decisione dell'utente | corpus/flat/TripleTriadRule.json#TripleTriadRule#5.0:target. |
| Random | Casuale | Decisione dell'utente | corpus/flat/TripleTriadRule.json#TripleTriadRule#7.0:target. |
| Reverse | Inverso | Decisione dell'utente | corpus/flat/TripleTriadRule.json#TripleTriadRule#10.0:target. |
| Ascension | Ascensione | Decisione dell'utente | corpus/flat/TripleTriadRule.json#TripleTriadRule#12.0:target. |
| Descension | Discensione | Decisione dell'utente | corpus/flat/TripleTriadRule.json#TripleTriadRule#13.0:target. |
| Only C10 / No C10 | Solo Costo 10 / Escluso Costo 10 | Decisione dell'utente | minigames/minionrules.json#1/#3:translation_name; forma estesa del costo. |
| Under 60 DEF | Meno di 60 DIF | Decisione dell'utente | corpus/flat/MinionRules.json#MinionRules#4.0:target; usare DIF anche in #4.1. |
| Only Critters | Solo Animali | Decisione dell'utente | corpus/flat/MinionRules.json#MinionRules#5.0:target; nel testo #5.1 usare «animale». |
| Swift AP Regen | Rigenerazione PA Rapida | Decisione dell'utente | corpus/flat/MinionRules.json#MinionRules#9.0:target. |
| Search Eyes Damaged | Occhi Vigili Danneggiati | Decisione dell'utente | corpus/flat/MinionRules.json#MinionRules#11.0:target. |
| ATK Bonus | Bonus ATT | Decisione dell'utente | corpus/flat/MinionRules.json#MinionRules#12.0:target. |
| Poppet | Burattino | Decisione dell'utente | corpus/flat/MinionRace.json#MinionRace#3:target e minionrules.json#7:translation_name/#7:translation_description; plurale «Burattini»; solo categoria di mascotte, non bambole o creature di altri referenti. |

| Gordhonite asteroid belt | cintura di asteroidi di Gordhon | Decisione dell'utente | InstanceContentTextData#27029: solo la descrizione nella memoria di Stigma-4; PlaceName#3785 resta distinto. |
| Gordhonites | Gordhoniani | Decisione dell'utente | InstanceContentTextData#27030: popolo di Gordhon nella prosa della memoria di Stigma-4; non estendere alle etichette di nemici o macchine. |

## Slay negli obiettivi di combattimento

Decisione dell'utente: per *Slay* negli obiettivi di combattimento preferire **sconfiggere** (imperativo **Sconfiggi**) a **uccidere / Uccidi**. Applicare anche alle descrizioni del diario e ai richiami allo stesso obiettivo, coniugando secondo la frase e conservando quantita', bersagli, condizioni e terminologia canonica.

La regola riguarda gli incarichi ordinari in cui conta vincere lo scontro; non e' una sostituzione globale di ogni riferimento alla morte. Conservare una resa esplicita come **uccidere** quando la morte, un omicidio, un'esecuzione o la distinzione fra sconfitta e uccisione e' rilevante per il significato o la scena. Non estendere la regola a nomi propri, titoli, nomi di azioni o suffissi come *of Slaying*. Valutare i dialoghi nel loro contesto, senza attenuare minacce o eventi narrativi espliciti.

Fonte: richiesta dell'utente del 9 novembre 2026; esempio sorgente `corpus/quest/001/ClsArc997_00134.json#quest/001/ClsArc997_00134#TEXT_CLSARC997_00134_TODO_03` (*Slay tree slugs.*). La registrazione della regola non attesta che le occorrenze del corpus siano gia' state riconciliate.

## Forma degli obiettivi operativi delle quest

Decisione dell'utente: rivolgersi al giocatore con l'imperativo alla seconda persona singolare negli obiettivi operativi delle quest (per esempio «Parla», «Sconfiggi», «Raccogli», «Consegna»), invece dell'infinito prescrittivo. Valutare funzione del campo e sorgente completa: non applicare la forma ai titoli, ai frammenti nominali, agli stati di avanzamento, al diario o ai dialoghi. L'imperativo dell'interfaccia non cambia il registro allocutivo dei personaggi. Conservare condizioni, quantita', referenti, macro e nomi canonici.

Fonte: richiesta dell'utente del 9 novembre 2026; ambito `corpus/quest/`, tutti gli obiettivi operativi verificati, inclusi quelli gia' revisionati.

## Nomi dei negozi di Wachumeqimeqi e reputazione CraftWorks nella UI

- **Nomi dei negozi di Wachumeqimeqi** (`XRral Soj Metalwares`, `Epistles by Pameka`, `Xeerol Ja Juicecraft`, `Shunye's Apothecary`, `Fish Fancies Donuhanu`): decisione dell'utente del 10 novembre 2026 di allineare `corpus/flat/BankaCraftWorks.json#BankaCraftWorks#0–#4:target` alle etichette italiane della UI (`corpus/flat/Addon.json#Addon#14451:target` e `corpus/flat/QuestRedoChapterUI.json#QuestRedoChapterUI#199.8–#203.8:target`): **Articoli Metallici XRral Soj**, **Epistole di Pameka**, **Succhi Artigianali Xeerol Ja**, **Farmacia di Shunye**, **Fantasie Ittiche Donuhanu**. La registrazione non attesta la riconciliazione di `JournalGenre#211–#215` e delle missioni `KinGla*`.
- **Esteem / Esteem Level / esteem gauge** nel sistema CraftWorks: decisione dell'utente del 10 novembre 2026 di usare **reputazione** / **livello di reputazione** / **indicatore di reputazione** in `corpus/flat/BankaCraftWorks.json#BankaCraftWorks#0–#4:target` per coerenza con l'etichetta condivisa della UI (`corpus/flat/Addon.json#Addon#12560:target` **Livello di Reputazione**, `#12561:target` **Reputazione**). La registrazione non attesta la riconciliazione di `corpus/flat/SharlayanCraftWorks.json` e `corpus/flat/HugeCraftworksNpc.json`.

## Silfide / Silfidi (Sylph / Sylphs)

Decisione dell'utente del 10 novembre 2026: sostituire **silfo/silfi** (e i relativi sostantivi **silfa/silfe**) con **silfide/silfidi** in tutto il corpus. Estensione confermata dall'utente il 14 novembre 2026: applicare la forma anche ai riferimenti generici a **Sylph/Sylphs** per il popolo e le creature, incluse le etichette dei nemici e dei parlanti; il nome proprio **Sylphie** resta invariato. Adattare al genere grammaticale femminile articoli, preposizioni, aggettivi, pronomi e participi (inclusi gli accordi di `Item#7912.0/.2/.9` «Flagello/Flagelli delle Silfidi» e `Item#41117.8` «nel santuario delle Silfidi»).

- **Sylpheed / Sylpheeds**: nemici costituiti da Silfidi asservite da Ramuh; nei composti anteporre **silfide / silfidi** al tratto e accordare al femminile (per esempio «silfide ringhiante / silfidi ringhianti» e «silfide strillatrice / silfidi strillatrici»). Applicare la forma anche nei testi di missione. Riferimenti EN/hash verificati: corpus/flat/BNpcName.json#BNpcName#67.0/.2, #68.0/.2, #69.0/.2, #70.0/.2, #167.0/.2, #2313.0/.2, #2320.0/.2, #2321.0/.2; corpus/quest/011/JobSmn001_01126, corpus/quest/012/BanSyl201_01267, BanSyl202_01268, BanSyl109_01265.
- **Aggettivi**: convertire **silfa/silfe** in posizione aggettivale in **silfica/silfiche** (es. «incantatrice silfica», «tribù silfiche»); mantenere **silfico/a/i/he** già attestati (es. «cultura silfica», «ricordo silfico») e le forme già presenti con «silfide/delle silfidi» (es. «venditore silfide», «lampione delle silfidi»).
- **Etichette e giochi di parole adattati**: `Stain#44.5/.6` (*Sylph Green*) → **Verde Silfide**; `Fate#1857.0` (*Don't Be Sylphish*) → **Non Essere Silfidista**; `Achievement#870.1` (*Sylph-assured*) → **Silfide fidata**; `Achievement#867.1–#869.1` (*Sylph-conscious I–III*) → **Consapevolezza delle Silfidi I–III**; `Quest#66256` / `CompleteJournal#2823` (*Sylph Says*) → **Silfide comanda** / **La Silfide Dice**.
- **Esclusioni**: il nome proprio **Sylphie** resta invariato; le etichette proprie seguono le decisioni specifiche documentate. L'autoreferenza `questo qui / questa qui` segue il singolo parlante già documentato in `register.json`.

## Iaguaro / Iaguari (Coeurl / Coeurls)

Decisione dell'utente del 10 novembre 2026: estendere **iaguaro / iaguari** a tutto il corpus in sostituzione di **coeurl**, adattando articoli e preposizioni (`lo iaguaro`, `uno iaguaro`, `gli iaguari`, `dello iaguaro`, `degli iaguari`), concordanze, titoli e composti:

- **Soprannome `Coeurlfist`**: **Pugnoiaguaro** (`Ivon Pugnoiaguaro`; gioco di parole *Coeurlpaw* -> **Zampaiaguaro**). Supera la precedente eccezione `Pugno di Coeurl`.
- **Banda `Coeurlclaw(s)`**: **Zanne di Iaguaro** (`Bracconiere delle Zanne di Iaguaro`, `Re delle Zanne di Iaguaro`, `delle Zanne di Iaguaro`), unificando le varianti pregresse (`Coeurlclaw`, `Zannadiaguaro`, `Artigli di Iaguaro`, `Unghie di Coeurl`).
- **Mostri e PNG composti**: `Coeurlregina` -> **Iaguaroregina**; `bandercoeurl` -> **banderiaguaro / banderiaguari**; `Coeurl o' Nine Tails` -> **Iaguaro a Nove Code**; `Sleeping/Angry/Frightened Coeurl` -> **Iaguaro Dormiente / Furioso / Spaventato**; `Head of the Coeurl` -> **Testa dello Iaguaro**; `coeurl sruti/smriti/prana` -> **iaguaro Sruti/Smriti/Prana**.
- **Monaco e abilità**: `Coeurl Form` -> **Forma Iaguaro / Postura Iaguaro** (`forma di iaguaro`); `Pouncing Coeurl` -> **Iaguaro Balzante**; `Coeurl Whisper` -> **Sussurro dello Iaguaro**; `Coeurl's Fury` -> **Furia dello Iaguaro**; `Coeurl Chakra` -> **Chakra dello Iaguaro** (`Chakra Iaguaro`).
- **Titoli, oggetti e testi vari**: `Enter the Coeurl` -> **L'Arrivo dello Iaguaro**; `Coeurl Beach` -> **da spiaggia di iaguaro** / **Spiaggia di Iaguaro**; `FishParameter#669.0` (*Ku'er*) adattato con `«iaguaro»`.
- **Esclusioni**: `CreditListText#4642` (nome del Mondo nei crediti, invariato per regola di progetto) e `Action#699`–`#700` (in giapponese *microchu* `コチュー`, non *coeurl*).


## Doxy's Pull

Decisione dell'utente: tradurre il toponimo *Doxy's Pull* con «Canale del Diavolo». Usare articoli e preposizioni secondo la frase completa; nei frammenti interrotti conservare l'interruzione. Ambito: tutte le occorrenze narrative pertinenti.


### Termini di AkatsukiNoteString

Decisione dell'utente dell'11 novembre 2026: mantenere le forme del corpus per Spirit Vessel («Ricettacolo dell'Anima», #113–#114), Tural Vidraal (invariato, #147–#148), The Storm Surge («La Guerra dei Fulmini», #150–#151), Oblivion (nome dell'organizzazione invariato, #156–#157), Vow of Resolve of Tuliyollal («Voto della Risolutezza di Tuliyollal», #168) e King of Resolve of Alexandria («Re della Risolutezza di Alexandria», #176). I numeri rimandano a `corpus/flat/AkatsukiNoteString.json`; applicare le stesse scelte ai richiami agli stessi referenti, senza estenderle agli usi comuni di oblio, determinazione o ai ricettacoli di altro tipo.
**Riconciliazione terminologica:** `Shades' Triangle` → **Triangolo delle Ombre**. Usare il toponimo per i riferimenti allo stesso tratto di mare, con articoli e preposizioni accordati alla frase; non estenderlo a usi figurati o omonimi. Fonti EN/hash verificati: `corpus/flat/ContentFinderConditionTransient.json#ContentFinderConditionTransient#1018/#1093/#1114`; `corpus/flat/ContentsTutorialPage.json#ContentsTutorialPage#25`; `corpus/quest/053/KinGkd001_05309.json#TEXT_KINGKD001_05309_SEQ_01`.
