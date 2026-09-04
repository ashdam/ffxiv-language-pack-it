# FFXIV Language Pack (IT)

Traduzione italiana di Final Fantasy XIV, servita nel gioco da
[Gubal Library](https://github.com/ashdam/gubal-library). Questo repository è il corpus: il testo
tradotto, il glossario che lo governa e le release del pack.

## Cosa c'è qui

| | |
|---|---|
| `corpus/` | Una riga per ogni linea del gioco, speculare a `ffxiv-corpus-en/corpus/`. |
| `glossary/` | I termini decisi, il registro di ogni parlante e le osservazioni fatte a schermo. [docs/glossary.md](docs/glossary.md). |
| `docs/` | Riferimento: macro, fogli, glossario, processo. |
| `pack.json` | Chi è questo pack e dove pubblica. |

## Come si traduce una riga

Ogni file di `corpus/` ha lo stesso percorso del suo omologo in `ffxiv-corpus-en/corpus/`, e ogni
riga la stessa `gameKey`. Si compila `target`; `gameKey`, `hash` e `gameVersion` non si toccano.

```json
{ "gameKey": "quest/041/AktKba101_04102#TEXT_AKTKBA101_04102_ALFONSE_000_002", "hash": "95F09EC7040EEA03", "target": "" }
```

L'inglese, il francese e il giapponese di quella riga sono nel file omologo di `ffxiv-corpus-en`.
Le macro `<...>` si copiano tali e quali. Un `target` vuoto significa «non tradotto» per tutti;
mai un segnaposto con del testo.

Tutorial con schermate: https://eorzea-in-spanish.ashdam.workers.dev/translate/it.html

## Cosa è tradotto

Niente, ancora. La tabella la genera il conteggio del progetto e non si modifica a mano.

## Una riga tradotta male

https://github.com/ashdam/ffxiv-language-pack-it/issues
