# Projekt-Dokumentation


Atputharasa

| Datum | Version | Zusammenfassung                                              |
| ----- | ------- | ------------------------------------------------------------ |
| 23.08.22| 0.0.1   | Ich schreibe meinen ersten Projektdokumentation.|
| 30.08.22      | 0.1.0   | Ich habe mein Programm umgesetzt und es läuft fehlerfrei.|                                                            |
|  06.09.22     | 1.0.0   | Ich habe das Projekt erfolgreich abgeschlossen.|
| 13.09.22 | 1.0.1| Ich habe die Test protokolliert und getestet.|

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



### 1.3 Testfälle

| TC-№ | Ausgangslage | Eingabe | Erwartete Ausgabe |
| ---- | ------------ | ------- | ----------------- |
| 1.1  |  Applikation gestartet, zufällige Zahl ist bereits generiert, wartet auf Benutzereingabe            |    27     | to low!|
| 2.1 |  Applikation gestartet, zufällige Zahl ist bereits generiert, wartet auf Benutzereingabe             |   77      | to high|
| 3.1 | Applikation gestartet, hat das Spiel gewonnen, Would you like to play again (Y/N): | y | startet eine neue Runde |
| 4.1 | Applikation gestartet, zufällige Zahl ist bereits generiert, der Spieler hat richtig geraten | 47 | YOU HAVE ACCOMPLISHED YOUR MISSION!  |
| 5.1 | Applikation gestartet, zufällige Zahl ist bereits generiert, wartet auf Benutzereingabe | vvvvf | Geben Sie Zahlen zwischen 1-100 ein! |


### 1.4 Diagramme
![number guessing game](https://user-images.githubusercontent.com/110893260/186102885-27e93a13-31f5-4919-817d-6314a1eaf1a9.png)



## 2 Planen

| AP-№ | Frist | Zuständig | Beschreibung | geplante Zeit |
| ---- | ----- | --------- | ------------ | ------------- |
| 1.A  | 30.8.22     | Ich          | Das Programm kann eine zufällige Zahl zwischen 1 und 100 generieren.           | 45'              |
| 1.B  | 30.8.22      | Ich           | Das Programm gibt ein Mitteilung, ob die Zahl richtig odere falsch ist            |45'              |
| 2.A | 30.8.22 | Ich | Das Programm soll es möglich machen, das der Spieler mehrmal schätzen kann. | 45'|
| 3.A | 30.8.22 | Ich | Das Programm gibt eine Meldung, ob die eingegebene Zahl zu hoch oder zu tief ist.|45'|
| 4.A | 30.8.22 | Ich | Das Programm kann nicht gestartet werden, wenn ein String verwendet wird.|45'|
| 5.A | 30.8.22 | Ich | Das Programm kann eine neue Runde starten, wenn der Spieler es möchte.|45'|


Total:`2`╳`1`╳`4`= 8 Arbeitspakete das sind 6h und Ich habe 4.5h gebraucht.


## 3 Entscheiden
Ich werde ein Programm schreiben, das eine Zufallszahl von 1 bis 100 erzeugt. Der Spieler muss dann eine Zahl von 1 bis 100 erraten, bis er die richtige Zahl findet. Jedes Mal, wenn der Spieler eine falsche Zahl errät, gibt das Programm eine Meldung aus, ob die erratene Zahl höher oder niedriger ist als die generierte Zahl. Sobald der Spieler die generierte Zahl gefunden hat, fragt das Programm, ob der Spieler eine weitere Runde spielen möchte.


## 4 Realisieren

| AP-№ | Datum | Zuständig | geplante Zeit | tatsächliche Zeit |
| ---- | ----- | --------- | ------------- | ----------------- |
| 1.A  | 30.8.22       | Ich           |  60'             | 30'                  |
| 1.B  | 30.8.22       | Ich           |  60'             | 40'                 |
| 2.A  | 30.8.22       | Ich           |  60'             | 20'                  |
| 3.A  | 30.8.22       | Ich           |  60'             | 25'                  |
| 4.A  | 30.8.22       | Ich           |  60'             | 5'                 |
| 5.A  | 30.8.22       | Ich           |  60'             | 60'                 |

## 5 Kontrollieren

### 5.1 Testprotokoll

| TC-№ | Datum | Resultat | Tester |
| ---- | ----- | -------- | ------ |
| 1.1  | 13.9.22       | Es funktioniert reibungslos.         | Ich       |
| 2.1  | 13.9.22       | Es funktioniert hervorragend.         | Ich       |
| 3.1  | 13.9.22       | Es funktioniert einwandfrei.         | Ich       |
| 4.1  | 13.9.22       | Es funktioniert fehlerfrei.        | Ich       |
| 5.1  | 13.9.22       | Es funktioniert exzellent.        | Ich       |

Es funktioniert alles, wie ich es erhofft habe.

### 5.2 Exploratives Testen

| BR-№ | Ausgangslage | Eingabe | Erwartete Ausgabe | Tatsächliche Ausgabe |
| ---- | ------------ | ------- | ----------------- | -------------------- |
| I    |              |         |                   |                      |
| ...  |              |         |                   |                      |



## 6 Auswerten

✍️ Fügen Sie hier eine Verknüpfung zu Ihrem Lern-Bericht ein.
