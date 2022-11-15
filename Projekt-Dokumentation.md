
# Projekt-Dokumentation


Cyril Lutziger, Simon Veljkovic, Samuel Lucena, Julius Burlet, Timo Goedertier

| Datum | Version | Zusammenfassung                                              |
| ----- | ------- | ------------------------------------------------------------ |
| 25.10.2022| 0.0.1 | Heute wurden uns oder die Projekte vorgestellt und wir haben unser Projekt ausgewählt und begonnen. Wir haben ein paar User Stories kreiert, die Dokumentation erstellt und ein PAP erstellt. Zudem haben wir haben die Aufgaben untereinander eingeteilt (Wer was macht). |
| 01.11.2022| 0.0.2 | Aufgaben von letzter Woche wurden erfüllt, und das Programm funktioniert. Es wurden auch neue User Stories geschrieben, sodass alle programmieren können.|
| 08.11.2022| 0.0.3 | Neue User Stories wurden geschrieben und auch erfüllt. Der Code des Programms wurde verfeinert, und wir sind heute mit dem Programm fertig geworden, welches funktioniert und nutzbar ist|
| 15.11.2022| 1.0.0 | An der Projekt-Dokumentation und dem Lernbericht wurde gearbeitet.|

## 1 Informieren

### 1.1 Ihr Projekt

Wir programmieren einen Vokabelübersetzer in Fremdsprachen.

### 1.2 User Stories

| US-№ | Verbindlichkeit | Typ  | Beschreibung                       |
| ---- | --------------- | ---- | ---------------------------------- |
|1|Muss|Funktional|Als User möchte ich meine eigene Wörterliste in das Programm einfügen können und damit lernen.|
|2|Muss|Funktional|Als User möchte ich meine Wörterliste erstellen können und als Datei gespeichert haben.|
|3|Muss|Funktional| Als ein User möchte ich, dass ich das Wort erneut eingeben kann, wenn meine Antwort falsch ist. |     
|4|Muss|Funktional| Als ein User möchte ich, dass ich nicht nur von Hauptsprache zu Fremdsprache, sondern auch umgekehrt übersetzen kann.|
|5|Muss|Qualität|Als ein User möchte ich, dass bei 3 gescheiterten Versuchen automatisch die richtige Lösung erscheint. |   
|6|Kann|Funktional| Als ein User möchte ich, dass ich, sobald ich alle Wörter übersetzt habe, meinen Score sehen kann. |
|7|Muss|Randbedingung|Das Programm wird in C# geschrieben.|

### 1.3 Testfälle

| TC-№ | Ausgangslage | Eingabe | Erwartete Ausgabe |
| ---- | ------------ | ------- | ----------------- |
|1.1|Programm ist gestartet|Dateipfad zum Ordner|Inhalt des Ordners mit Zahlen|
|1.2|Programm ist gestartet|Kein Pfad zu einer Datei|"Please write down a valid directory Path"|
|1.3|Programm ist gestartet|Genauer Dateipfad(mit existierender Datei)|Auswahl der verschiedenen Varianten, wie man übersetzen möchte.|
|1.4|1.1|2|Auswahl der verschiedenen Varianten, wie man übersetzen möchte.|
|1.5|1.1|>max zahl angezeigt|Type a number between 1 and (anz dateien) or [new]|
|2.1|1.1|new|Give your file a name: |
|2.2|2.1|banane|If you want to stop type [stp] If you made a mistake type[ret] Word: |
|2.3|2.1|Name einer bereits existierender Datei|"This file already exists"|
|3.1|2.2, tree ---> |Buam|"Wrong!", tree --->|
|4.1|1.3|1/2|tree --->|
|5.1|2.2, tree ---> |3mal falsche Eingaben|"The answer was: "Baum" press Enter to continue."|
|6.1|Letztes Wort wurde übersetzt|Enter|"You have x out of y Points."|


### 1.4 Diagramme
<img src="https://user-images.githubusercontent.com/110893288/199201748-bc23c79d-41f0-413a-9f05-a80301698ae5.png" width="450">




## 2 Planen

| AP-№ | Frist | Zuständig | Beschreibung | geplante Zeit |
| ---- | ----- | --------- | ------------ | ------------- |
|      |       |           |              |               |
|      |       |           |              |               |
|      |       |           |              |               |
|      |       |           |              |               |
|      |       |           |              |               |
|      |       |           |              |               |
|      |       |           |              |               |
|      |       |           |              |               |

Total: 


## 3 Entscheiden



## 4 Realisieren

| AP-№ | Datum | Zuständig | geplante Zeit | tatsächliche Zeit |
| ---- | ----- | --------- | ------------- | ----------------- |
| 1.A  |       |           |               |                   |
| 2.A  |       |           |               |                   |
| 3.A  |       |           |               |                   |
| 4.A  |       |           |               |                   |
| 5.A  |       |           |               |                   |
| 6.A  |       |           |               |                   |
| 7.A  |       |           |               |                   |
| 8.A  |       |           |               |                   |

## 5 Kontrollieren

### 5.1 Testprotokoll

|  TC-№ | Datum | Resultat | Tester |
| ----- | -------- | ------ | ------- |
|       |          |        |         |
|       |          |        |         |
|       |          |        |         |



### 5.2 Exploratives Testen

| BR-№ | Ausgangslage | Eingabe | Erwartete Ausgabe | Tatsächliche Ausgabe |
| ---- | ------------ | ------- | ----------------- | -------------------- |
| 1    |              |         |                   |                      |

## 6 Auswerten
