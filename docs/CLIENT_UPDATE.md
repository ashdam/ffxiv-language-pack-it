# Aggiornamento del corpus inglese

Questo pack contiene traduzioni e risorse italiane. L'estrazione dal gioco appartiene al progetto del corpus sorgente;
non si esegue il vecchio Extractor dev in questo repository.

1. Controlla `git status` e `git diff`, conserva il lavoro corrente e identifica la versione sorgente precedente e quella nuova.
2. Usa un checkout affidabile di `ffxiv-corpus-en` alla versione prevista. `../ffxiv-corpus-en` e' una posizione comoda, non obbligatoria.
3. Confronta per percorso e gameKey: aggiunti, rimossi, hash cambiati. Distingui cambi reali del testo da modifiche ai metadati. Non allineare per numero di riga o solo per testo inglese.
4. Conserva i target italiani correnti come memoria. Per un hash cambiato leggi vecchia e nuova sorgente: modifica il target soltanto quanto richiesto dal nuovo significato, conservando canone e voce. Aggiorna l'hash solo dopo questa verifica.
5. Non eliminare automaticamente voci rimosse e non sovrascrivere interi fogli con HEAD o con una vecchia copia. Tratta le rimozioni come decisione di integrazione da verificare nel flusso di aggiornamento del pack.
6. Traduci le voci nuove secondo [Traduzione](TRANSLATION.md); le modificate seguono [Revisione](REVISION.md). Glossari e schede locali restano i riferimenti editoriali.
7. Controlla il perimetro aggiornato con [SeString](SESTRING_TOOL.md), confronta struttura e metadati e registra soltanto i residui reali.

Gli asset e la tabella `corpus/ui/banners.json` richiedono un lavoro separato e autorizzato: un testo aggiornato non prova
che la corrispondente texture sia stata aggiornata. Non modificare layout, texture o esclusioni d'inventario per azzerare
un rapporto testuale. Non effettuare rebuild, release o deploy durante l'aggiornamento editoriale.
