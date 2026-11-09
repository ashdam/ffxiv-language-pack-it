# Chiusura del recupero e passaggio al pack italiano

9 novembre 2026. La migrazione dell'adattamento e' conclusa; non equivale all'approvazione editoriale globale del corpus.

## Conservato

Il corpus corrente e tutti i metadati sono rimasti invariati durante questo intervento. Restano le eccezioni di
`validator-reviews.json`, le regole JSON preesistenti, i registri dei parlanti e le decisioni specifiche confermate.
Le scelte correnti includono Altomonte, Mezzocolle, Triade della Discordia, Ultima Arma e gli adattamenti Loporrit in `-olo`.

## Trasferito

- 534 regole aggiunte a `glossary/overrides.json`, senza sovrascrivere i termini preesistenti.
- Note discorsive, varianti e regole composte conservate: tutte le 1.118 righe tabellari della fonte, inclusi i 101 nomi Loporrit, sono presenti in `glossary/Glossary.md`.
  I 101 nomi erano gia' coperti anche dai JSON nominali: nessun duplicato aggiunto per questi nomi.
- 167 scelte specifiche sintetizzate in `glossary/DECISIONS.md`, con indicazione delle decisioni successive prevalenti.
- AGENTS, guide di traduzione, revisione, aggiornamento e SeString adattate al formato gameKey/hash/target.
- Catalogo delle voci e nove raccolte di schede trasferiti in `docs/`; non trasferito il vecchio inventario tecnico audio.
- Parser locale `tools/PackCheck`, basato su Lumina, per sintassi macro e confronto opzionale con il corpus inglese.

Le attestazioni storiche rimaste nelle note documentano la provenienza, non richiedono accesso a dev.
Le regole composte, i suffissi e i registri non sono stati trasformati in sostituzioni globali.
Le forme marcate superate non sono varianti ammesse; le scelte specifiche successive prevalgono sulle righe storiche.

## Rimosso

41 file conclusi da `reviews/` (285.834.351 byte): prompt di obiettivi, censimenti intermedi, CSV di confronto,
log di recupero e report ridondanti. Backup esterno verificato prima della rimozione, indicato nel README della cartella.
Non e' stata svuotata la cronologia Git e non e' stato eseguito alcun reset.

## Verifica e limiti

Il parser Lumina sul corpus completo ha verificato 6.882 file e 869.862 campi, con hash EN concordi e zero errori.
Sono passati cinque controlli di integrazione (campi validi, duplicati, macro errate, sorgente mancante e ispezione), oltre a cinque regressioni macro che includono le parentesi annidate e le didascalie letterali che avevano causato errori di compilazione.
Il passaggio e' organizzativo e terminologico: non e' una nuova revisione linguistica completa o una prova nel client.
Le regole JSON mantengono il formato corrente del pack; il tool locale non riproduce tutta la pipeline GitHub.
Nessuna modifica a texture, layout, corpus inglese o vecchia memoria; nessun rebuild del client, deploy, commit o push.
