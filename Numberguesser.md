# Projekt-Dokumentation


Atputharasa

| Datum | Version | Zusammenfassung                                              |
| ----- | ------- | ------------------------------------------------------------ |
| 23.08.22| 0.0.1   | ✍️ Jedes Mal, wenn Sie an dem Projekt arbeiten, fügen Sie hier eine neue Zeile ein und beschreiben in *einem* Satz, was Sie erreicht haben. |
|       | ...     |                                                              |
|       | 1.0.0   |                                                              |

## 1 Informieren

### 1.1 Ihr Projekt

In diesem Projekt erstelle ich einen number guessing game.

### 1.2 User Stories

| US-№ | Verbindlichkeit | Typ  | Beschreibung                       |
| ---- | --------------- | ---- | ---------------------------------- |
| 1    |  Muss               |  Funktional    | Als ein Spieler möchte ich das mir gesagt wird, ob ich die richtige Zahl eraten habe oder nicht, damit ich weiss ob ich gewonnen habe.|
| 2 |     Muss            | Funktional     |  Als ein Programmierer muss ich den Spieler Hinweise geben, ob die richtige Zahl grösser oder kleiner ist als das eingegebe Zahl, damit der Spieler weiss, ob er nah an der richtigen Zahl dran ist.                                |
| 3 | Muss | Funktional| Als ein Programmierer muss ich den Spieler eine neue Runde gewähren, damit er weiter spielen kann.|
| 4 | Kann | Qualität | Als ein Pogrammierer kann ich den Spieler einen Glückwunsch ausrichten, damit er eine kleine Freude hat.|
| 5 | Muss | Qualität | Als ein Programmierer möchte ich das nur Zahlen zwischen 1-100 auf dem Eingabefeld eingetragen wird, damit das Spiel funktioniert. |

✍️ Jede User Story hat eine ganzzahlige Nummer (1, 2, 3 etc.), eine Verbindlichkeit (Muss oder Kann?), und einen Typ (Funktional, Qualität, Rand). Die User Story selber hat folgende Form: *Als ein 🤷‍♂️ möchte ich 🤷‍♂️, damit 🤷‍♂️*.

### 1.3 Testfälle

| TC-№ | Ausgangslage | Eingabe | Erwartete Ausgabe |
| ---- | ------------ | ------- | ----------------- |
| 1.1  |  Applikation gestartet, zufällige Zahl ist bereits generiert, wartet auf Benutzereingabe            |    77     |   Leider ist es die falsche Antwort!
Versuchen Sie es erneut!|
| 2.1 |  Applikation gestartet, zufällige Zahl ist bereits generiert, wartet auf Benutzereingabe             |   77      | Das eingegebene Zahl ist grösser als das generierte Zahl?                |
| 3.1 | Applikation gestartet, hat das Spiel gewonnen, Möchten Sie eine neue Runde starten? | ja | startet eine neue Runde |
| 4.1 | Applikation gestartet, zufällige Zahl ist bereits generiert, der Spieler hat richtig geraten | 47 | Gratulation für die richtige Antwort! |
| 5.1 | Applikation gestartet, zufällige Zahl ist bereits generiert, wartet auf Benutzereingabe | 1000 | Geben Sie Zahlen zwischen 1-100 ein! |

✍️ Die Nummer hat das Format `N.m`, wobei `N` die Nummer der User Story ist, die der Testfall abdeckt, und `m` von `1` an nach oben gezählt. Beispiel: Der dritte Testfall, der die zweite User Story abdeckt, hat also die Nummer `2.3`.

### 1.4 Diagramme
![number guessing game](https://user-images.githubusercontent.com/110893260/186102885-27e93a13-31f5-4919-817d-6314a1eaf1a9.png)



## 2 Planen

| AP-№ | Frist | Zuständig | Beschreibung | geplante Zeit |
| ---- | ----- | --------- | ------------ | ------------- |
| 1.A  |       |           |              |               |
| ...  |       |           |              |               |

Total: 

✍️ Die Nummer hat das Format `N.m`, wobei `N` die Nummer der User Story ist, auf die sich das Arbeitspaket bezieht, und `m` von `A` an nach oben buchstabiert. Beispiel: Das dritte Arbeitspaket, das die zweite User Story betrifft, hat also die Nummer `2.C`.

✍️ Ein Arbeitspaket sollte etwa 45' für eine Person in Anspruch nehmen. Die totale Anzahl Arbeitspakete sollte etwa Folgendem entsprechen: `Anzahl R-Sitzungen` ╳ `Anzahl Gruppenmitglieder` ╳ `4`. Wenn Sie also zu dritt an einem Projekt arbeiten, für welches zwei R-Sitzungen geplant sind, sollten Sie auf `2` ╳ `3` ╳`4` = `24` Arbeitspakete kommen. Sollten Sie merken, dass Sie hier nicht genügend Arbeitspakte haben, denken Sie sich weitere "Kann"-User Stories für Kapitel 1.2 aus.

## 3 Entscheiden

✍️ Dokumentieren Sie hier Ihre Entscheidungen und Annahmen, die Sie im Bezug auf Ihre User Stories und die Implementierung getroffen haben.

## 4 Realisieren

| AP-№ | Datum | Zuständig | geplante Zeit | tatsächliche Zeit |
| ---- | ----- | --------- | ------------- | ----------------- |
| 1.A  |       |           |               |                   |
| ...  |       |           |               |                   |

✍️ Tragen Sie jedes Mal, wenn Sie ein Arbeitspaket abschließen, hier ein, wie lang Sie effektiv dafür hatten.

## 5 Kontrollieren

### 5.1 Testprotokoll

| TC-№ | Datum | Resultat | Tester |
| ---- | ----- | -------- | ------ |
| 1.1  |       |          |        |
| ...  |       |          |        |

✍️ Vergessen Sie nicht, ein Fazit hinzuzufügen, welches das Test-Ergebnis einordnet.

### 5.2 Exploratives Testen

| BR-№ | Ausgangslage | Eingabe | Erwartete Ausgabe | Tatsächliche Ausgabe |
| ---- | ------------ | ------- | ----------------- | -------------------- |
| I    |              |         |                   |                      |
| ...  |              |         |                   |                      |

✍️ Verwenden Sie römische Ziffern für Ihre Bug Reports, also I, II, III, IV etc.

## 6 Auswerten

✍️ Fügen Sie hier eine Verknüpfung zu Ihrem Lern-Bericht ein.
