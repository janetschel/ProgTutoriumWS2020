# Aufgaben zu Klassen

Nachdem im letzten Tutorium Klassen besprochen wurden, und auch die jetzige Praktikumsaufgabe von Klassen handelt, gibt es nun einige Übungsaufgaben zu Klassen.

Die Lösungen werden im Tutorium in der nächsten Woche besprochen.

## Aufgabe 1: Calculator
Schreibt eine Klasse `Calculator`, welche **keine** Felder, aber folgende Funktionen besitzen soll:
- `Add(x, y)`, welche die beiden Integer-Werte x und y zusammenzählt und zurückgibt
- `Sub(x, y)` für die Subtraktion
- `Mult(x, y)` für die Multiplikation
- `Div(x, y)` für die Division

Alle Funktionen haben logischerweise die gleiche Funktionsweise wie `Add(x, y)`. Das Ergebnis wird aus den Parametern x und y berechnet, und das Ergebnis zurückgegeben.

Die Funktionen sollen **ohne** ein Objekt der Klasse benutzt werden können.

**Tipp**: achte auf die Rückgabetypen der Funktionen.  
Wo machen welche Rückgabetypen Sinn?

## Aufgabe 2: Student
Schreibt eine Klasse `Student`, welche folgende Werte halten soll:
- Name: `string`
- Vorname: `string`
- Matrikelnummer: `int`
- ECTS: `unit`

Diese Felder sollen nicht von Außen einfach geändert werden können.  
Die Felder dürfen ergo nur durch Setter geändert werden können. Zudem soll ein Konstruktor existieren, welcher die Werte initial setzt.  
Implementiert zunächst ganz normale Getter und Setter, ohne spezielle Zusatzfunktionen:
```csharp
class Student 
{
    // Felder...

    // Getter und Setter
    public string Name 
    { 
        get { return name; }
        set { name = value }
    }

    // more code...
}
```

Zudem soll diese Klasse eine Funktion `void Spreche()` enthalten, welche **nur** mit einem bestimmten Student-Objekt aufgerufen werden kann, und alle Felder mit etwas Text ausgibt.

## Aufgabe 3: Student v2?
Ergänzt die Setter aus **Aufgabe 2** folgend:
- Der Name muss mindestens 3 Buchstaben haben
- Der Vorname hat keine extra Validierung
- Die Matrikelnummer darf nur 6-stellig sein und darf auch nicht negativ sein
- Die ECTS müssen (da wir davon ausgehen, dass wir ein guter Student sind) mindestens 30 und maximal 120 sein.

Falls eine dieser Kriterien bei einem Aufruf eines Setters nicht erfüllt ist, soll folgender Fehler geworfen werden:
```csharp
throw new Exception("Feld wurde nicht gesetzt, war nicht valide!");
```

## Aufgabe 4: hallohallohallo
Schreibt eine Klasse `Sprecher`, welche eine Funktion `void SageHallo(string name)` besitzt.

Diese Funktion soll bei einem Aufruf (nur von einem Objekt aus) folgenden Output auf der Konsole ausgeben:
```csharp
// Konsolenausgabe
// Hallo, <name>. Wie geht es dir heute?
```

Falls der Name eine Länge von 5, oder kleiner hat, soll zudem diese Ausgabe hinzukommen:
```csharp
// Konsolenausgabe
// Hallo, <name>. Wie geht es dir heute?
// Warum hast du so einen kurzen Namen?
```
---

Sobald das umgesetzt ist, soll diese Klasse eine weitere Funktion bekommen. Diese Funktion (`SageHalloHallo(int num)`) soll den String `hallo` num-mal (Paramter) auf der Konsole ausgeben (ohne newline).

Falls keine Nummer übergeben werden sollte, soll automatisch `hallohallohallohallo` ausgegeben werden (4 mal).

## Aufgabe 5: Exceptions

Schreibe eine Funktion (in der Hauptklasse) `UeberpruefeName(string name)`, welche eine Exception, mit folgenden Fehlermeldungen werfen soll:
- Fehlermeldung: `Name zu kurz`, falls der Name unter 10 Zeichen hat
- Fehlermeldung: `IMPOSTOR`, falls der Name "Jan" ist
- Fehlermeldung: `Name zu lang`, falls der Name über 100 Zeichen hat
- Fehlermeldung: `Das ist kein Name`, falls Buchstaben außer a bis z (oder A bis Z) in diesem Namen enthalten sind. **Achtung**: dt. Umlaute sind somit auch Buchstaben, welche **nicht** enhalten sein dürfen! 
- Falls keine der oben folgenden Fälle zutrifft, soll die Funktion keine Exception werden, sondern den Namen auf der Konsole in GROSSBUCHSTABEN ausgeben.

