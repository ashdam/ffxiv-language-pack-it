# Glossario italiano

Il canone e' conservato in questo repository; non serve il vecchio checkout dev.
Il corpus e' la memoria delle traduzioni correnti, senza implicare approvazione editoriale globale.

| File | Funzione |
| --- | --- |
| `Glossary.md` | Decisioni editoriali, varianti, accordi, registri e limiti d'uso. Include le regole discorsive e composte non rappresentabili da una coppia letterale. |
| `DECISIONS.md` | Scelte specifiche confermate durante la riconciliazione; risolve la precedenza rispetto alle forme storiche. |
| `overrides.json` | Termini, varianti e protezioni; leggere sempre la nota contestuale. |
| `demonyms.json`, `tribes.json` | Demonimi e nomi dei popoli. |
| `creature-families.json` | Famiglie di creature, forme e distinzioni semantiche. |
| `bnpc-canonical-names.json`, `enpc-canonical-names.json` | Eccezioni nominali legate alla gameKey del PNG. |
| `placename-override.json` | Toponimi legati alla gameKey e alla specifica variante visibile. |
| `register.json` | Registro degli interlocutori e attestazioni; non e' un elenco di sostituzioni. |
| `onomatopoeias.json`, `expressions.json`, `spelling.json` | Forme ammesse e risorse linguistiche per i controlli; non attestano da sole qualita' o approvazione. |

Le istruzioni dell'utente e le decisioni specifiche successive prevalgono sulle attestazioni storiche.
Una regola per gameKey o referente preciso non si estende automaticamente a omonimi o parole comuni.
Il nome di un luogo puo' includere l'articolo nell'etichetta e richiederne uno diverso nella frase.
Non usare i JSON come una lista di sostituzioni globali: lo stesso inglese puo' avere rese contestuali diverse.

Nei termini JSON, `protect: true` conserva l'inglese; `protect: false` richiede una resa italiana nel proprio ambito.
`it` e' la forma principale, `forms` contiene le varianti ammesse, `note` descrive fonti e limiti.
Non aggiungere una forma obsoleta a `forms` per far passare un controllo. Le note possono citare fonti storiche,
ma le regole e le decisioni necessarie al lavoro sono riportate localmente.

Per aggiornare il canone, applica la [riconciliazione](../../dev/docs/TRANSLATION.md#2-corpus-decisioni-e-discrepanze):
verifica referente e fonte, chiedi solo per conflitti reali irrisolti, uniforma i campi pertinenti e registra l'ambito.
Evita nuove copie complete del glossario o del corpus nei report.
