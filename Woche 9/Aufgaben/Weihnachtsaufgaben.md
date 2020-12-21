# Aufgaben über die Weihnachtstage
Diese Aufgaben beinhalten vor allem Klassen (mit Feldern, Properties) und ein paar Aufgaben zum Lesen und Schreiben einer Datei.

Die Lösungen sind wie immer im Unterordner zu finden.  
**Beachte diesmal**: es gibt nur eine Lösung für alle Aufgaben!

## Aufgaben zu Klassen
### Aufgabe 1: Rentiere 🎄
Erstellt zunächst eine Klasse mit dem Namen `Rentier`.  
Die Klasse soll folgende **öffentliche** Felder besitzen:
- `name`
- `alter`
- `roteNase`, was einen Wahrheitswert speichern soll

Sobald die Klasse existiert erstellt in der Main-Methode zwei neue Objekte dieser Klasse mit dem Namen `dasher` und `rudolph`.  
Ändert auch jedem Objekt die Felder folgendermaßen:
- `dasher` hat den Namen `Dasher`, das `alter` 17 und keine `roteNase`
- `rudolph` hat den Namen `Rudolph`, das `alter` 18 und hat eine `roteNase`

Schreibt -- auch in der Main Methode -- ein paar `Console.WriteLine()`-Statements, damit folgende Ausgabe erreicht wird:

```bash
--- Dasher ---
Dasher ist 17 Jahre alt und hat keine Rote Nase.
Nicht so schlimm.

--- Rudolph ---
Rudolph ist 18 Jahre alt und hat eine rote Nase.
```

Die Ausgabe "`Nicht so schlimm.`" soll bei jedem Rentier erscheinen, welches keine rote Nase hat.

### Aufgabe 2: Schlitten 🛷

Fügt zur Klasse `Rentier` nun einen **Parameter**-Konstruktor hinzu, welche alle Felder übergeben bekommt und diese intern setzt.

Erstellt eine weitere Klasse namens `Schlitten`.

Diese Klasse hat ein einziges **nicht**-öffentliches Feld.  
Dieses Feld soll ein Array mit dem Namen `rentiere` und der Größe `9` sein.

Schreibe für dieses Feld eine Standard-Property (Getter/Setter), wobei der Setter noch nicht benutzt werden soll, damit dieses Feld von außen benutzt werden kann.  
Über einen **Parameter**-Konstruktor soll in die Klasse `Schlitten` ein Array von Rentieren übergeben werden, welches das interne Array überschreibt.

Sobald diese Funktionen implementiert sind, führe folgende Main aus:
```csharp
static void Main(string[] args) 
{
    Schlitten meinSchlitten = new Schlitten(
        new Rentier[] {
            new Rentier("Dasher", 17, false),
            new Rentier("Dancer", 17, false),
            new Rentier("Prancer", 15, false),
            new Rentier("Vixon", 16, false),
            new Rentier("Comet", 16, false),
            new Rentier("Cupid", 18, false),
            new Rentier("Donner", 16, false),
            new Rentier("Blitzen", 17, false),
            new Rentier("Rudolph", 18, true)
        }
    );
    
    Console.WriteLine(meinSchlitten.Rentiere);   
}
```

### Aufgabe 3: Schönere Ausgabe

Da die Ausgabe aus **Aufgabe 2** nicht so schön aussieht wie gewollt, ändere den Getter für das private Feld `rentiere` in der Klasse `Schlitten` wie folgt:  
Der Getter soll nun nicht mehr (den Speicherplatz vom)/das Array zurückgeben, sondern einen String in folgender Form:
```bash
Dasher ist 17 und hat keine rote Nase.
Dancer ist 17 und hat keine rote Nase.
Prancer ist 15 und hat keine rote Nase.
// ...
Rudolph ist 18 und hat eine rote Nase.
```

### Aufgabe 4: Das Rentier darf auch was 🦌
Noch sind die Felder in der Klasse `rentier` **öffentlich**.
Ändert die Felder in der Klasse zunächst auf **nicht**-öffentlich und schreibt für jedes Feld Getter UND Setter, welche nicht eingeschränkt sind.

Sobald das geschehen ist, schreibt einen weiteren Getter (kein Setter) names `SchoeneAusgabe`, welche aus den Feldern einen String in folgender Form bastelt (wie oben):
```bash
Rudolph ist 18 und hat eine rote Nase.
```
Ändert nun den Getter in der Klasse `Schlitten` dahingehend ab, dass für jedes Rentier der `SchoeneAusgabe`-Getter benutzt wird.

### Aufgabe 5: Lesen aus einer Datei

Anbei findet ihr eine Datei, welche Rentiere aller Art enthält.  
Schreibt in der Klasse `Schlitten` eine Methode, für welche kein Objekt erstellt werden muss, welche die Datei einliest und ein neues Schlitten-Objekt mit allen Rentieren zurückgibt.

Die Datei hat folgendes Format:
```bash
Rudolph,18,ja
Dancer,17,nein
```


