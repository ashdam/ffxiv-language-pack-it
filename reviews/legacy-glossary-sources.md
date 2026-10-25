# Fonti legacy per il glossario italiano

## Primo lotto applicato: ClassJob, BaseParam, MainCommand

Primo controllo terminologico applicato al main: 87 campi ClassJob (nomi già allineati al legacy), 73 etichette BaseParam con le descrizioni collegate e 99 etichette MainCommand. Le descrizioni sono state controllate per i nomi interessati; questo non equivale alla revisione editoriale completa di tutta la prosa.

Il glossario overrides.json riceve **189 nuove voci** e **7 aggiornamenti a regole esistenti**. Fonte prioritaria per l’adattamento: legacy, come confermato dall’utente. Le rese main più precise e naturali sono mantenute quando conservano la corretta terminologia.

Correzioni effettuate in questo lotto, rispetto alla fotografia di inizio passaggio:

| Foglio | Target modificati |
|---|---:|
| BaseParam | 27 |
| MainCommand | 2 |
| ActionCategory | 1 |
| ContentType | 1 |
| Description | 2 |
| NotebookDivisionCategory | 1 |
| ContentRoulette | 2 |
| HowTo | 1 |
| MainCommandCategory | 1 |
| Status | 1 |
| **Totale** | **39** |

- Ripristinati i nomi italiani delle classi nelle descrizioni degli attributi e i nomi italiani degli stati nelle resistenze. Haste segue la decisione già confermata nel glossario legacy; Maestria e Schivata recuperano l’adattamento legacy.
- Conservate le etichette main semanticamente più precise: Probabilità di Colpo Diretto, Potenza Magica Offensiva, Potenza Magica Curativa e Velocità delle Tecniche. Per Block si mantiene la distinzione rispetto a Parry.
- Aggiornate le regole che lasciavano Gunbreaker, Viper, Free Company e Beastmaster in inglese. Conjurer segue la decisione precedente Incantatore/Incantatrice, senza confonderlo con Evocatore.
- Integrate le otto scelte presenti nel CSV. Ritorno riguarda azione e relative etichette, non il pulsante di navigazione Indietro. Arciere resta la forma base senza invalidare Arciera. Le varianti femminili Maga Rossa, Lanciera e Taumaturga sono conservate come forme attestate.
- Corretto l’ordine italiano della voce con parametro dinamico: Impostazioni <switchplatform(1)>, con macro preservata.
- Verificati JSON, metadati, ID, campi estranei e controlli SeString prima/dopo. Le altre eccezioni del glossario, compresa Gold Saucer, sono preservate. Nessuna modifica al CSV delle scelte.

La copertura del resto del corpus e di PlaceName va affrontata nei lotti successivi: questa base non certifica che tutta la prosa main sia già stata riconciliata.

---


Censimento del 25 ottobre 2026. Fonte esclusiva: `dev/data/translations/`. Questo è un elenco ragionato di fonti da controllare: non modifica i glossari attivi e non attribuisce nuove approvazioni.

## Da dove cominciare

Il primo passaggio comprende **26 file e 981 coppie inglese/italiano distinte**. È la parte più breve: classi, popoli, nomi dei sistemi, attributi, categorie e comandi. Gli otto repertori portanti servono poi per coprire mosse, stati, mostri, personaggi e luoghi: da soli contengono 46.956 coppie distinte.

| Passaggio | File | Coppie distinte nel passaggio | Uso |
|---|---:|---:|---|
| 1. Nucleo breve | 26 | 981 | Revisione manuale iniziale. |
| 2. Repertori portanti | 8 | 46.956 | Copertura dei nomi principali; revisionare per dominio. |
| 3. Completamenti | 119 | 6.278 | Gradi, compagni, attività e sistemi secondari. |
| 4. Fogli misti | 11 | 13.295 | Selezionare i termini: le coppie qui comprendono anche frasi. |

L’inventario completo comprende **164 file candidati**. I passaggi 1–3 producono **53.140 coppie distinte** dopo la deduplicazione fra file; 45.391 hanno una resa italiana diversa dall’inglese. Non sono ancora termini approvati: restano possibili segnaposto, fasce numeriche, varianti e stringhe con payload.

Non si può ottenere un glossario piccolo e insieme includere tutte le mosse nemiche e tutti i nomi dei PNG. La lista dei file resta consultabile; il glossario completo richiede invece una revisione progressiva. Non viene generato un unico dump di tutte le coppie.

## 1. Nucleo breve

| Categoria | File legacy | Campi sorgente | Coppie distinte | Diverse da EN |
|---|---|---|---:|---:|
| Classi e popoli | [world/classjob.json](../../dev/data/translations/world/classjob.json) | `name; col_4` | 45 | 43 |
| Classi e popoli | [world/classjobcategory.json](../../dev/data/translations/world/classjobcategory.json) | `original` | 154 | 137 |
| Classi e popoli | [world/race.json](../../dev/data/translations/world/race.json) | `name_masculine; name_feminine` | 8 | 0 |
| Classi e popoli | [world/tribe.json](../../dev/data/translations/world/tribe.json) | `name_masculine; name_feminine` | 16 | 12 |
| Classi e popoli | [world/beasttribe.json](../../dev/data/translations/world/beasttribe.json) | `name` | 20 | 7 |
| Classi e popoli | [world/grandcompany.json](../../dev/data/translations/world/grandcompany.json) | `name` | 4 | 4 |
| Classi e popoli | [world/guardiandeity.json](../../dev/data/translations/world/guardiandeity.json) | `original` | 12 | 12 |
| Sistemi e interfaccia | [system/baseparam.json](../../dev/data/translations/system/baseparam.json) | `name` | 73 | 72 |
| Sistemi e interfaccia | [system/maincommand.json](../../dev/data/translations/system/maincommand.json) | `name` | 99 | 98 |
| Sistemi e interfaccia | [system/maincommandcategory.json](../../dev/data/translations/system/maincommandcategory.json) | `original` | 7 | 6 |
| Sistemi e interfaccia | [system/hud.json](../../dev/data/translations/system/hud.json) | `name` | 104 | 101 |
| Sistemi e interfaccia | [system/notebookdivisioncategory.json](../../dev/data/translations/system/notebookdivisioncategory.json) | `original` | 9 | 9 |
| Combattimento | [combat/actioncategory.json](../../dev/data/translations/combat/actioncategory.json) | `original` | 14 | 14 |
| Combattimento | [combat/attacktype.json](../../dev/data/translations/combat/attacktype.json) | `original` | 8 | 8 |
| Combattimento | [combat/generalaction.json](../../dev/data/translations/combat/generalaction.json) | `name` | 42 | 42 |
| Combattimento | [combat/petaction.json](../../dev/data/translations/combat/petaction.json) | `name` | 40 | 40 |
| Combattimento | [combat/classjobactionuicategory.json](../../dev/data/translations/combat/classjobactionuicategory.json) | `name` | 20 | 19 |
| Attivita | [activities/contenttype.json](../../dev/data/translations/activities/contenttype.json) | `original` | 36 | 29 |
| Attivita | [activities/contentuicategory.json](../../dev/data/translations/activities/contentuicategory.json) | `original` | 50 | 47 |
| Attivita | [activities/contentroulette.json](../../dev/data/translations/activities/contentroulette.json) | `name; description` | 42 | 38 |
| Attivita | [activities/mkdsupportjob.json](../../dev/data/translations/activities/mkdsupportjob.json) | `name` | 24 | 24 |
| Creazione e raccolta | [crafting/craftaction.json](../../dev/data/translations/crafting/craftaction.json) | `name` | 69 | 69 |
| Creazione e raccolta | [crafting/crafttype.json](../../dev/data/translations/crafting/crafttype.json) | `original` | 8 | 8 |
| Creazione e raccolta | [crafting/gatheringtype.json](../../dev/data/translations/crafting/gatheringtype.json) | `original` | 5 | 5 |
| Sociale | [social/companyaction.json](../../dev/data/translations/social/companyaction.json) | `name` | 49 | 49 |
| Sociale | [social/onlinestatus.json](../../dev/data/translations/social/onlinestatus.json) | `original` | 46 | 44 |

Le colonne sono quelle della sorgente; si prende la traduzione corrispondente. Le colonne `description` sono escluse salvo le eccezioni indicate nel CSV.

## 2. Repertori portanti

| File legacy | Righe | Coppie distinte | Campi e utilizzo |
|---|---:|---:|---|
| [combat/action.json](../../dev/data/translations/combat/action.json) | 45.518 | 14.077 | `original`. Obbligatori per tutte le mosse (incluse nemiche), stati e tratti. Deduplicare, conservando tutti gli ID. |
| [combat/status.json](../../dev/data/translations/combat/status.json) | 4.791 | 3.238 | `name`. Obbligatori per tutte le mosse (incluse nemiche), stati e tratti. Deduplicare, conservando tutti gli ID. |
| [combat/trait.json](../../dev/data/translations/combat/trait.json) | 682 | 482 | `original`. Obbligatori per tutte le mosse (incluse nemiche), stati e tratti. Deduplicare, conservando tutti gli ID. |
| [world/bnpcname.json](../../dev/data/translations/world/bnpcname.json) | 14.793 | 13.330 | `name`. Nomi di nemici, boss, PNG, personaggi e qualifiche. I plurali restano come riferimento di flessione. description contiene il plurale, da conservare per le flessioni, non nel conteggio dei nomi base. |
| [world/enpcresident.json](../../dev/data/translations/world/enpcresident.json) | 30.996 | 10.013 | `name; col_2`. Nomi di nemici, boss, PNG, personaggi e qualifiche. I plurali restano come riferimento di flessione. description e il plurale, non una biografia; col_2 e la qualifica del PNG. |
| [world/placename.json](../../dev/data/translations/world/placename.json) | 5.302 | 4.607 | `name`. Toponimi, luoghi interagibili, oggetti di scena e nomi di dungeon/prove/raid. EObjName non e inventario Item. Tre traduzioni non hanno la sorgente inglese legacy (ID 2, 3, 4): recuperare tramite ID dal corpus inglese, con verifica del referente. |
| [world/eobjname.json](../../dev/data/translations/world/eobjname.json) | 8.191 | 2.499 | `name`. Toponimi, luoghi interagibili, oggetti di scena e nomi di dungeon/prove/raid. EObjName non e inventario Item. |
| [world/contentfindercondition.json](../../dev/data/translations/world/contentfindercondition.json) | 863 | 709 | `original`. Toponimi, luoghi interagibili, oggetti di scena e nomi di dungeon/prove/raid. EObjName non e inventario Item. |

Per BNpcName/ENpcResident il campo `description` contiene generalmente il plurale: conservarlo come forma collegata al nome, senza raddoppiare il lavoro con tutti gli ID ripetuti. In ENpcResident `col_2` contiene qualifiche come “Levemete” e titoli di servizio. EObjName comprende nomi di oggetti di scena e interazioni, non il catalogo Item.

## 3. Completamenti per sistema

Il CSV dettaglia ogni file. I conteggi seguenti deduplicano anche le coppie ripetute fra i file dello stesso gruppo.

| Gruppo | File legacy | Coppie distinte |
|---|---|---:|
| Identita e denominazioni | [world/pet.json](../../dev/data/translations/world/pet.json), [world/companion.json](../../dev/data/translations/world/companion.json), [world/mount.json](../../dev/data/translations/world/mount.json), [world/title.json](../../dev/data/translations/world/title.json), [world/beastreputationrank.json](../../dev/data/translations/world/beastreputationrank.json), [world/gcrankgridaniafemaletext.json](../../dev/data/translations/world/gcrankgridaniafemaletext.json), [world/gcrankgridaniamaletext.json](../../dev/data/translations/world/gcrankgridaniamaletext.json), [world/gcranklimsafemaletext.json](../../dev/data/translations/world/gcranklimsafemaletext.json), [world/gcranklimsamaletext.json](../../dev/data/translations/world/gcranklimsamaletext.json), [world/gcrankuldahfemaletext.json](../../dev/data/translations/world/gcrankuldahfemaletext.json), [world/gcrankuldahmaletext.json](../../dev/data/translations/world/gcrankuldahmaletext.json) | 2.398 |
| Personaggi e ruoli | [system/dawnmemberuiparam.json](../../dev/data/translations/system/dawnmemberuiparam.json), [dialogue/snipetalkname.json](../../dev/data/translations/dialogue/snipetalkname.json) | 105 |
| Luoghi | [world/town.json](../../dev/data/translations/world/town.json), [world/aetheryte.json](../../dev/data/translations/world/aetheryte.json), [world/mjiname.json](../../dev/data/translations/world/mjiname.json), [world/adventure.json](../../dev/data/translations/world/adventure.json), [world/weather.json](../../dev/data/translations/world/weather.json), [crafting/gatheringpointname.json](../../dev/data/translations/crafting/gatheringpointname.json), [crafting/airshipexplorationpoint.json](../../dev/data/translations/crafting/airshipexplorationpoint.json), [crafting/submarineexploration.json](../../dev/data/translations/crafting/submarineexploration.json), [crafting/submarinemap.json](../../dev/data/translations/crafting/submarinemap.json), [activities/ikdroute.json](../../dev/data/translations/activities/ikdroute.json), [activities/vvdnotebookseries.json](../../dev/data/translations/activities/vvdnotebookseries.json) | 696 |
| Luoghi e lore | [world/mkdlore.json](../../dev/data/translations/world/mkdlore.json) | 59 |
| Combattimento e meccaniche | [combat/actioncomboroute.json](../../dev/data/translations/combat/actioncomboroute.json), [combat/bgcarmyaction.json](../../dev/data/translations/combat/bgcarmyaction.json), [combat/buddyaction.json](../../dev/data/translations/combat/buddyaction.json), [combat/mkdtrait.json](../../dev/data/translations/combat/mkdtrait.json), [combat/pvpselecttrait.json](../../dev/data/translations/combat/pvpselecttrait.json), [combat/companionmove.json](../../dev/data/translations/combat/companionmove.json), [combat/fieldmarker.json](../../dev/data/translations/combat/fieldmarker.json), [combat/marker.json](../../dev/data/translations/combat/marker.json), [activities/contentgauge.json](../../dev/data/translations/activities/contentgauge.json), [activities/eventaction.json](../../dev/data/translations/activities/eventaction.json), [activities/deepdungeon.json](../../dev/data/translations/activities/deepdungeon.json), [activities/deepdungeonflooreffectui.json](../../dev/data/translations/activities/deepdungeonflooreffectui.json), [activities/deepdungeonequipment.json](../../dev/data/translations/activities/deepdungeonequipment.json) | 305 |
| Sistemi e interfaccia | [system/howtocategory.json](../../dev/data/translations/system/howtocategory.json), [system/notebookdivision.json](../../dev/data/translations/system/notebookdivision.json), [system/logkind.json](../../dev/data/translations/system/logkind.json), [system/logfilter.json](../../dev/data/translations/system/logfilter.json), [world/emote.json](../../dev/data/translations/world/emote.json), [world/emotecategory.json](../../dev/data/translations/world/emotecategory.json), [world/achievementcategory.json](../../dev/data/translations/world/achievementcategory.json), [world/achievementkind.json](../../dev/data/translations/world/achievementkind.json), [system/howto.json](../../dev/data/translations/system/howto.json), [system/description.json](../../dev/data/translations/system/description.json), [system/exversion.json](../../dev/data/translations/system/exversion.json), [system/eventtutorial.json](../../dev/data/translations/system/eventtutorial.json) | 989 |
| Sociale | [social/fcauthority.json](../../dev/data/translations/social/fcauthority.json), [social/fcauthoritycategory.json](../../dev/data/translations/social/fcauthoritycategory.json), [social/fcrights.json](../../dev/data/translations/social/fcrights.json), [social/fchierarchy.json](../../dev/data/translations/social/fchierarchy.json), [social/fcreputation.json](../../dev/data/translations/social/fcreputation.json), [social/fcchestname.json](../../dev/data/translations/social/fcchestname.json), [social/fcactivitycategory.json](../../dev/data/translations/social/fcactivitycategory.json), [social/circleactivity.json](../../dev/data/translations/social/circleactivity.json), [social/gcarmycandidatecategory.json](../../dev/data/translations/social/gcarmycandidatecategory.json), [social/gcarmyexpeditiontype.json](../../dev/data/translations/social/gcarmyexpeditiontype.json), [social/gcarmytraining.json](../../dev/data/translations/social/gcarmytraining.json), [social/retainertaskrandom.json](../../dev/data/translations/social/retainertaskrandom.json), [social/mateauthoritycategory.json](../../dev/data/translations/social/mateauthoritycategory.json) | 259 |
| Creazione e raccolta | [crafting/gatheringsubcategory.json](../../dev/data/translations/crafting/gatheringsubcategory.json), [crafting/recipesubcategory.json](../../dev/data/translations/crafting/recipesubcategory.json), [crafting/airshipexplorationparamtype.json](../../dev/data/translations/crafting/airshipexplorationparamtype.json), [crafting/companycraftdraftcategory.json](../../dev/data/translations/crafting/companycraftdraftcategory.json), [crafting/companycraftmanufactorystate.json](../../dev/data/translations/crafting/companycraftmanufactorystate.json), [crafting/companycrafttype.json](../../dev/data/translations/crafting/companycrafttype.json), [crafting/submarinespeccategory.json](../../dev/data/translations/crafting/submarinespeccategory.json), [crafting/mjicraftworksobjecttheme.json](../../dev/data/translations/crafting/mjicraftworksobjecttheme.json), [crafting/wksitemsubcategory.json](../../dev/data/translations/crafting/wksitemsubcategory.json) | 117 |
| Alloggi e profili | [housing/furniturecatalogcategory.json](../../dev/data/translations/housing/furniturecatalogcategory.json), [housing/yardcatalogcategory.json](../../dev/data/translations/housing/yardcatalogcategory.json), [housing/housingappeal.json](../../dev/data/translations/housing/housingappeal.json), [housing/housingemploymentnpcrace.json](../../dev/data/translations/housing/housingemploymentnpcrace.json), [housing/housingmateauthority.json](../../dev/data/translations/housing/housingmateauthority.json), [housing/housingrenovation.json](../../dev/data/translations/housing/housingrenovation.json), [housing/characarddesigncategory.json](../../dev/data/translations/housing/characarddesigncategory.json), [housing/characardplaystyle.json](../../dev/data/translations/housing/characardplaystyle.json), [housing/groupposestampcategory.json](../../dev/data/translations/housing/groupposestampcategory.json), [housing/mjihudmode.json](../../dev/data/translations/housing/mjihudmode.json), [housing/orchestrioncategory.json](../../dev/data/translations/housing/orchestrioncategory.json), [housing/tofuobjectcategory.json](../../dev/data/translations/housing/tofuobjectcategory.json), [housing/tofupresetcategory.json](../../dev/data/translations/housing/tofupresetcategory.json) | 174 |
| Negozi | [shops/gilshop.json](../../dev/data/translations/shops/gilshop.json), [shops/specialshop.json](../../dev/data/translations/shops/specialshop.json), [shops/inclusionshop.json](../../dev/data/translations/shops/inclusionshop.json), [shops/inclusionshopcategory.json](../../dev/data/translations/shops/inclusionshopcategory.json), [shops/disposalshop.json](../../dev/data/translations/shops/disposalshop.json), [shops/disposalshopfiltertype.json](../../dev/data/translations/shops/disposalshopfiltertype.json), [shops/collectablesshop.json](../../dev/data/translations/shops/collectablesshop.json), [shops/gcshopitemcategory.json](../../dev/data/translations/shops/gcshopitemcategory.json), [shops/specialshopitemcategory.json](../../dev/data/translations/shops/specialshopitemcategory.json), [shops/fittingshopcategory.json](../../dev/data/translations/shops/fittingshopcategory.json), [shops/mjidisposalshopuicategory.json](../../dev/data/translations/shops/mjidisposalshopuicategory.json) | 979 |
| Minigiochi | [minigames/tripletriadrule.json](../../dev/data/translations/minigames/tripletriadrule.json), [minigames/tripletriadcompetition.json](../../dev/data/translations/minigames/tripletriadcompetition.json), [minigames/tripletriadcardtype.json](../../dev/data/translations/minigames/tripletriadcardtype.json), [minigames/goldsaucerarcademachine.json](../../dev/data/translations/minigames/goldsaucerarcademachine.json), [minigames/colosseummatchrank.json](../../dev/data/translations/minigames/colosseummatchrank.json), [minigames/minionrace.json](../../dev/data/translations/minigames/minionrace.json), [minigames/minionrules.json](../../dev/data/translations/minigames/minionrules.json), [minigames/minionskilltype.json](../../dev/data/translations/minigames/minionskilltype.json), [minigames/chocoboraceability.json](../../dev/data/translations/minigames/chocoboraceability.json), [minigames/minigameturnbreakaction.json](../../dev/data/translations/minigames/minigameturnbreakaction.json), [minigames/minigameturnbreakstatus.json](../../dev/data/translations/minigames/minigameturnbreakstatus.json), [minigames/racingchocoboparam.json](../../dev/data/translations/minigames/racingchocoboparam.json), [minigames/racingchocobonamecategory.json](../../dev/data/translations/minigames/racingchocobonamecategory.json), [minigames/perform.json](../../dev/data/translations/minigames/perform.json), [combat/xbmactioneffecttype.json](../../dev/data/translations/combat/xbmactioneffecttype.json), [combat/xbmactiontarget.json](../../dev/data/translations/combat/xbmactiontarget.json), [combat/xbmelement.json](../../dev/data/translations/combat/xbmelement.json), [combat/xbmscorebonus.json](../../dev/data/translations/combat/xbmscorebonus.json), [combat/xbmscorerank.json](../../dev/data/translations/combat/xbmscorerank.json) | 264 |
| Regioni e infrastruttura | [world/worldphysicaldc.json](../../dev/data/translations/world/worldphysicaldc.json), [world/worldregiongroup.json](../../dev/data/translations/world/worldregiongroup.json) | 9 |
| Attività | [activities/massivepccontent.json](../../dev/data/translations/activities/massivepccontent.json), [activities/publiccontent.json](../../dev/data/translations/activities/publiccontent.json) | 2 |

Note di campo: in `Perform` il nome dello strumento sta in `description`, mentre `name` è un identificatore audio. In `Title` `description` fornisce una variante di genere. In `DawnMemberUIParam` compaiono sia i nomi dei compagni sia i loro ruoli e le relative varianti. `HowTo` fornisce titoli di tutorial: selezionare i nomi dei sistemi, senza imporre l’intero titolo come termine globale.

## 4. Fogli misti: estrazione puntuale

| File legacy | Righe | Criterio |
|---|---:|---|
| [combat/xpvpgroupactivity.json](../../dev/data/translations/combat/xpvpgroupactivity.json) | 12 | Contiene nomi di facoltà, organizzazioni, mestieri o gruppi dentro istruzioni: estrarre i soli nomi, voce per voce. |
| [crafting/bankacraftworks.json](../../dev/data/translations/crafting/bankacraftworks.json) | 5 | Contiene nomi di facoltà, organizzazioni, mestieri o gruppi dentro istruzioni: estrarre i soli nomi, voce per voce. |
| [crafting/sharlayancraftworks.json](../../dev/data/translations/crafting/sharlayancraftworks.json) | 5 | Contiene nomi di facoltà, organizzazioni, mestieri o gruppi dentro istruzioni: estrarre i soli nomi, voce per voce. |
| [crafting/hugecraftworksnpc.json](../../dev/data/translations/crafting/hugecraftworksnpc.json) | 5 | Contiene nomi di facoltà, organizzazioni, mestieri o gruppi dentro istruzioni: estrarre i soli nomi, voce per voce. |
| [system/addon.json](../../dev/data/translations/system/addon.json) | 14.976 | Contengono termini essenziali insieme a frasi, opzioni, tutorial o identificatori: estrarre etichette voce per voce, mai in blocco. |
| [system/lobby.json](../../dev/data/translations/system/lobby.json) | 975 | Contengono termini essenziali insieme a frasi, opzioni, tutorial o identificatori: estrarre etichette voce per voce, mai in blocco. |
| [system/configkey.json](../../dev/data/translations/system/configkey.json) | 432 | Contengono termini essenziali insieme a frasi, opzioni, tutorial o identificatori: estrarre etichette voce per voce, mai in blocco. Nessun foglio omonimo nel main: utile come fonte lessicale, ma nessun trasferimento diretto per nome file. |
| [system/descriptionstring.json](../../dev/data/translations/system/descriptionstring.json) | 1.646 | Contengono termini essenziali insieme a frasi, opzioni, tutorial o identificatori: estrarre etichette voce per voce, mai in blocco. |
| [minigames/goldsaucertextdata.json](../../dev/data/translations/minigames/goldsaucertextdata.json) | 89 | Selezionare nomi propri di sistemi/modalita; escludere istruzioni, dialoghi e titoli solo narrativi. |
| [minigames/minionstage.json](../../dev/data/translations/minigames/minionstage.json) | 24 | Selezionare nomi propri di sistemi/modalita; escludere istruzioni, dialoghi e titoli solo narrativi. |
| [system/akatsukinotestring.json](../../dev/data/translations/system/akatsukinotestring.json) | 197 | Selezionare intestazioni di personaggi, titoli e organizzazioni; escludere biografie. |

Addon è indispensabile per i sistemi privi di una tabella dedicata, ma non tutte le sue stringhe sono termini. ConfigKey usa spesso `name` per identificatori come `MOVE_FORE`: l’etichetta visibile è in `description`. HUD usa `name`; gli altri campi possono contenere codici interni. Le facoltà dello Studium, le botteghe di Wachumeqimeqi e le strutture del Crystarium sono nominate nelle istruzioni delle relative tabelle: estrarre i nomi, non le istruzioni intere.

## Varianti da controllare

[legacy-glossary-variants.csv](legacy-glossary-variants.csv) contiene **1.292 testi inglesi con più rese italiane** nei passaggi 1–3, con fonte e campo. **5 casi hanno già più rese all’interno del solo nucleo breve**. La colonna `priorita` li mette per primi; seguono i confronti fra nucleo e repertori, poi quelli estesi. I fogli misti sono esclusi da questo confronto.

Queste sono varianti candidate da valutare, non un elenco di errori: genere, omonimi, nomi di mosse e stati e titoli contestuali possono richiedere rese diverse. Il CSV conserva fino a quattro riferimenti per variante e indica gli ulteriori riferimenti ripetuti.

## Criteri per l’iniezione successiva

- Conservare percorso legacy, ID e campo. Collassare solo le coppie identiche, mantenendo i riferimenti a tutte le righe e la distinzione tra domini.
- Usare i campi selezionati nel CSV. Le descrizioni delle azioni e degli stati servono per il contesto, non sono voci nominali.
- Conservare i nomi che restano uguali all’inglese; la sola uguaglianza non prova l’approvazione e non autorizza automaticamente `protect: true`.
- Confrontare le rese con i glossari esistenti nel main: overrides, demonyms, tribes, creature-families, placename-override e i due repertori canonical-names. Le eccezioni vanno riesaminate prima di uniformare.
- Non usare una resa globale per ogni inglese omonimo: distinguere referente, ruolo, funzione, genere e forme plurali. I payload SeString richiedono un controllo specifico.
- PlaceName legacy ha tre traduzioni prive di inglese, ID 2, 3 e 4: recuperare la sorgente per ID dal corpus inglese e verificare il referente.
- ClassJob legacy ha un solo campo aggiuntivo `col_4`: non è un repertorio completo delle abbreviazioni. Le altre sigle richiedono confronto con main e sorgente inglese.
- La presenza di un foglio omonimo nel main, riportata nel CSV, non certifica ancora la corrispondenza fra le singole colonne. Le fonti senza foglio omonimo restano utilizzabili per il glossario dopo la verifica del contesto.

## Esclusioni

- Tutta `items/`, compresi Item, EventItem, EventItemHelp, accessori e tinture. Restano fuori anche FishParameter, SpearfishingItem, SecretRecipeBook, WksCosmoToolName, TripleTriadCard e i brani di Orchestrion: sono oggetti, collezionabili o elenchi assimilabili.
- Dialoghi e missioni completi, LogMessage e tutorial completi, descrizioni Transient e lore dei famigli in XbmPet: fonti di contesto, non importazioni integrali da glossario.
- CharamakeName e RacingChocoboName: repertori per la generazione di nomi, non elenco canonico dei personaggi. Il nome del personaggio giocante è dinamico e non può essere fissato nel glossario.
- Crediti di persone reali, decorazioni singole, titoli di ogni achievement/FATE/missione e avvisi di piazzamento/rimozione degli arredi: aumenterebbero il volume con materiale poco pertinente.
- Nessuno stock dei negozi o singolo arredo: sono incluse soltanto categorie e servizi. Mascotte, famigli e cavalcature sono incluse come entità, non come oggetti che le sbloccano.

## Copertura e limiti

Questa è la base dei repertori nominali e tecnici disponibili nel legacy per le categorie richieste. Organizzazioni, concetti di lore e nomi presenti solo nella prosa richiedono estrazione puntuale dai fogli misti e dai dialoghi: la lista non certifica tutti i termini citati nel gioco. I conteggi non sostituiscono la revisione linguistica.

[Inventario completo CSV](legacy-glossary-sources.csv): priorità, categoria, percorso, righe, campi, coppie distinte, traduzioni senza inglese, varianti, payload e possibile foglio main. CSV UTF-8 con BOM e separatore punto e virgola per l’apertura in Excel.
