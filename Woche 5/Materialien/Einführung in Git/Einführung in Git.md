# Einführung in Git und GitHub

Dieses Write-Up dient als kleine Übersicht über Git und GitHub, welches gut als Cheat-Sheet benutzt werden kann. Es beinhaltet dabei allerdings nur die Grundfunktionen, welche Git bietet.

## Was ist Git?

Git ist ein Version Control System (VCS), welche die Zusammenarbeit von mehreren Personen auf einer Codebase ohne Konflikte ermöglicht.

Dabei ist GitHub eine Art Cloud, auf welcher Code gehostet werden kann, damit die Zusammenarbeit online funktionieren kann. Neben GitHub gibt es auch andere Anbieter von Git: GitLab und BitBucket sind als Beispiele zu nennen.

## Download von Git

Um Git herunterzuladen, einfach die Executable/Package von 

 [https://git-scm.com/downloads](https://git-scm.com/downloads)

herunterladen und installieren.

Hierbei können die Standard-Einstellungen, welche vorgegeben werden, ohne Problem beibehalten werden.

## Benutzung von Git

Git arbeitet auf ganz normalen Ordnern. Änderungen in diesen Ordnern können je nach Wunsch getracked und überwacht werden.

Folgende Ordnerstruktur liegt uns vor:

```bash
test-folder/
├── important-files/
│   ├── test.txt
│   └── secrets.txt
├── work.txt
└── changes.txt
```

### Befehl: git init

Um aus diesem Ordner ein Git-Verzeichnis (auch: Git-Repository) zu erstellen, führt man in diesem Ordner auf dem Terminal/Eingabeaufforderung folgenden Befehl aus:

```bash
~ cd Desktop/test-folder
~ git init
```

Initialized empty Git repository in /Users/janetschel/Desktop/test-folder

### Befehl: git status

Mit folgendem Befehl können wir nun Dateien und Ordner anschauen, welche Git in diesem Ordner bekannt sind:

```bash
~ git:(master) git status  # der Befehl ist nur git status
```

Untracked files:
	changes.txt
	important-files/
	work.txt

### Befehl: git add

Untracked files, sind Dateien und Ordner, welche Git zwar erkannt hat, aber trotzdem noch nicht überwacht werden. Wollen wir nun Dateien zum Tracking hinzufügen benutzen wir:

```bash
~ git:(master) git add changes.txt
~ git:(master) git add work.txt
```

Changes to be committed:
	new file:   changes.txt
	new file:   work.txt

Untracked files:
	important-files/

Rot hinterlegte Dateien und Ordner sind also Dateien, welche von Git nicht erfasst sind (oder: welche Änderungen beinhalten)

Mit dem Befehl

```bash
~ git:(master) git add .
```

können sofort alle noch nicht getrackten Dateien zum Tracking hinzugefügt werden.

Changes to be committed:
	new file:   changes.txt
	new file:   important-files/secrets.txt
	new file:   important-files/test.txt
	new file:   work.txt

Wir ändern nun work.txt indem wir eine Zeile hinzufügen:

```bash
~ git:(master) git status
```

Changes to be committed:
	new file:   changes.txt
	new file:   important-files/secrets.txt
	new file:   important-files/test.txt
	new file:   work.txt

Changes not staged for commit:
	modified:   work.txt

Hier ist nun zu erkennen, dass Git erkannt hat, dass sich unsere Datei geändert hat (zu erkennen an dem Keyword modified)

Mit

```bash
~ git:(master) git add work.txt
```

können wir diese Änderung nun wieder hinzufügen.

### Befehl: git commit

Zum endgültigen Speichern dieser Änderungen wird

```bash
~ git:(master) git commit -m "Anlegen erster Dateien"
```

benutzt. Mit der Flag -m geben wir einen Kommentar zu diesem Commit ein.

[master (root-commit) e1689f4] Anlegen erster Dateien
 4 files changed, 1 insertions(+)
 create mode 100644 changes.txt
 create mode 100644 important-files/secrets.txt
 create mode 100644 important-files/test.txt
 create mode 100644 work.txt

**Achtung**: die Dateien und Ordnerstrukturen in diesem Commit sind nun **für immer** historisiert und nachvollziehbar. Falls also aus Versehen ein Passwort (oder andere sensible Daten) in einem Commit stehen, sind diese für immer ersichtlich, auch wenn diese Dateien im Nachhinein mit einem weiteren Commit gelöscht werden.

Da noch alles lokal passiert ist das erstmal kein Problem. Sobald mit GitHub gearbeitet wird ist es wichtig, die Dateien noch einmal vor einem Commit zu überprüfen, damit keine ungenwollte Daten an andere geleaked wird.

### Befehl: git checkout

Noch befinden wir uns bei jeder Änderung, welche wir machen, auf dem sog. master-branch. 
Dieser ist unser **HEAD**, also die Haupt-Codebasis, auf welcher gearbeitet wird.

Wenn wir jetzt eine Änderung machen wollen (bspw. ein neues Feature implementieren), dies allerdings nicht auf der master-branch machen wollen, da wird nicht sicher sind, dass alles ohne Bugs reibungslos funktioniert, erstellen wir uns einen neuen branch.

Der master-branch wird immer so behandelt, damit er zu jeder Zeit "Production Ready" ist.

```bash
~ git:(master) git checkout -b neuer-branch
```

Wir benutzen die -b Flag, um einen neuen branch zu erstellen, welcher bisher noch nicht existiert, und wechseln mit checkout direkt in diesen branch.

Switched to a new branch 'neuer-branch'

In diesem Branch können wir nun alle Änderungen machen, welche wir wollen.
Zur Vereinfachung erstellen wir uns jetzt auf diesen Branch eine neue Datei mit dem Namen newFile.txt:

```bash
~ git:(neuer-branch) touch new-file.txt
~ git:(neuer-branch) open new-file.txt

# Dies sind Befehle von Bash und nicht von Git. Wir erstellen einfach eine neue
# Datei und öffnen diese, um Änderungen zu machen. Geht auch ganz normal
# mit Maus und Tastatur
```

```bash
test-folder/
├── important-files/
│   ├── test.txt
│   └── secrets.txt
├── work.txt
├── **new-file.txt**
└── changes.txt
```

Diese Änderung speichern wir nun wieder und wechseln auf den master-branch zurück

```bash
~ git:(neuer-branch) git add new-file.txt
~ git:(neuer-branch) git commit -m "Neue Datei erstellt"
~ git:(neuer-branch) git checkout master # keine -b Flag, master existiert schon
```

[neuer-branch 99bed2b] Neue Datei erstellt
 1 file changed, 0 insertions(+), 0 deletions(-)
 create mode 100644 new-file.txt

Switched to branch 'master'

Nun ist folgendes zu beobachten:

```bash
test-folder/
├── important-files/
│   ├── test.txt
│   └── secrets.txt
├── work.txt
└── changes.txt
```

Die neue Datei, welche in dem branch neuer-branch erstellt und gespeichert wurde, befindet sich nicht in unserem master-branch.

Das hat den Grund, dass Änderungen in branches unabhängig voneinander sind. Somit ermöglicht Git, dass mehrere Entwickler an einer Codebasis arbeiten, ohne Konflikte zu verursachen.

### Befehl: git merge

Um jetzt die Dateien vom branch neuer-branch nach master zu bekommen, weil bspw. die Änderungen fertig sind und Bug-frei funktionieren, benutzen wir folgenden Befehl im master-branch:

```bash
~ git:(master) git merge neuer-branch
```

Updating e1689f4..99bed2b
 new-file.txt | 1 +
 1 file changed, 1 insertions(+)
 create mode 100644 new-file.txt

Nun sehen wir, dass unsere Dateien und Änderungen vom neuer-branch auch im master-branch vorhanden sind.

Wir erzwingen folgendes:

```bash
~ git:(master) open work.txt # Hinzufügen der Zeile "Hallo" in work.txt
~ git:(master) git add work.txt
~ git:(master) git commit -m "Änderungen in work.txt"
~ git:(master) git checkout neuer-branch
~ git:(neuer-branch) open work.txt # Hinzufügen der Zeile "Hallo**1**" in work.txt
~ git:(neuer-branch) git add work.txt
~ git:(neuer-branch) git commit -m "Änderungen in work.txt"
~ git:(neuer-branch) git checkout master
```

Mit diesen Änderungen haben wir einen sog. merge-conflict erzwungen.

In zwei branches, gibt es zwei verschiedene Änderungen an der gleichen Datei, welche im Konflikt zueinander stehen. Wenn dies passiert, kann Git nicht wissen, welche Änderung wir übernommen haben wollen.

Führen wir nun also

```bash
~ git:(master) git merge neuer-branch
```

aus, kommt es zu einem Konflikt:

Auto-merging work.txt
CONFLICT (content): Merge conflict in work.txt
Automatic merge failed; fix conflicts and then commit the result.

Wenn wir uns nun die Datei work.txt anschauen, sehen wir folgendes:

```bash
1 <<<<<<< HEAD (master)
2 Hallo
3 =======
4 Hallo1
5 >>>>>>> neuer-branch
```

Git zeigt uns also beide Änderungen an und wir müssen entscheiden, welche wir behalten wollen.
Wir löschen also alles das, was nicht gewünscht ist.

In diesem Fall, da ich Hallo1 behalten will, lösche ich Zeilen 1, 2, 3 und 5

```bash
1 Hallo1
```

und commite die Datei:

```bash
~ git:(master) git add work.txt
~ git:(master) git commit -m "Merge Conflict beseitigt"
```

[master 45b2228] Merge Conflict beseitigt

Nun ist der merge fertig und wir haben auch wieder alle Änderungen im master-branch.

Falls wir andere Änderungen commiten wollen, bevor der Merge Conflict **komplett** behoben ist, kriegen wir folgende Meldung:

error: Committing is not possible because you have unmerged files.
fatal: Exiting because of an unresolved conflict.

## Einbindung von GitHub

### Eigenes GitHub-Repository einbinden

Da bisher alles nur lokal passiert ist, wir aber andere Leute an unserem Code mitarbeiten lassen wollen, benutzen wir ein GitHub Repository. 

Dafür gehen wir zunächst auf [https://github.com/new](https://github.com/new) und erstellen uns ein neues Repository (Name ist hierbei egal). In diesem Fall: github-test

In unserem lokalen Ordner müssen wir nun dieses Repository hinzufügen:

```bash
~ git:(master) git remote add origin https://github.com/janetschel/**github-test**.git
```

Damit ist unser online-Repository mit unserem lokalen Verzeichnis verbunden.

Wenn wir Änderungen hochladen wollen, müssen wir diese zunächst ganz normale commiten und dann **pushen**:

```bash
~ git:(master) git commit -m "Irgendwelche Änderungen"
~ git:(master) git push -u origin master # -u origin master nur beim ersten push
```

remote: Resolving deltas: 100% (7/7), done.
To https://github.com/janetschel/github-test.git
   7010c74..825d378  master -> master

Somit sind unsere lokalen Änderungen nun öffentlich. Weitere Änderungen:

```bash
~ git:(master) open work.txt   # Änderung in dieser Datei
~ git:(master) git add work.txt
~ git:(master) git commit -m "Test commit"
~ git:(master) git push
```

### Fremdes GitHub-Repository benutzen

Um eine fremdes Repository lokal zu erhalten, suchen wir auf GitHub zunächst ein Repository, welches wir lokal benutzen wollen.

In diesem Fall benutzen wir das Repository vom Tutorium ([https://github.com/janetschel/ProgTutoriumWS2020](https://github.com/janetschel/ProgTutoriumWS2020.git))

Bei einem Klick auf "Code" finden wir die URL dieses Projekts zum lokale aufsetzen. Diese kopieren wir uns und geben in irgendeinem Ordner auf unsren PC auf dem Terminal folgende Befehle ein:

 

```bash
~ git clone https://github.com/janetschel/ProgTutoriumWS2020.git
```

Cloning into 'ProgTutoriumWS2020'...
remote: Enumerating objects: 542, done.
remote: Counting objects: 100% (542/542), done.
remote: Compressing objects: 100% (336/336), done.
remote: Total 542 (delta 191), reused 442 (delta 115), pack-reused 0
Receiving objects: 100% (542/542), 886.60 KiB | 1.23 MiB/s, done.
Resolving deltas: 100% (191/191), done.

Somit haben wir nun eine lokale Kopie dieses Verzeichnisses auf unserem Rechner.

Bei weiteren Änderungen in diesem Repository reicht im Ordner ein einfaches:

```bash
~ cd ProgTutoriumWS2020
~ git:(master) git pull
```

um alle neuen Änderungen lokal zu kopieren.

Falls keine Änderungen zwischen dem lokalen Repository und dem GitHub-Repository bestehen, kriegen wir folgende Info-Message auf der Konsole.

Already up to date.

### Tipp für fremde GitHub-Repositories

Falls man keine lokale Kopie des Repositories erstellen möchte, es aber trotzdem wiederfinden mag, hat GitHub ein "Star"-Feature.

Damit kann man GitHub-Repositories Sterne geben, welche so ähnlich funktionieren wie ein privates Bookmark (dafür braucht ihr ein GitHub-Account)

Am Beispiel vom Tutorium-Repo: [https://github.com/janetschel/ProgTutoriumWS2020](https://github.com/janetschel/ProgTutoriumWS2020.git)

Bei einem Klick auf "Star" erstellen wir uns ein Bookmark.

Dies würde ich auch jedem empfehlen, da ihr früher oder später (spätestens am Semesterende) aus dem Moodle-Kurs fliegt. Somit habt ihr noch alle Übungen auf alle Zeit verfügbar.

## Häufigere Fehler / FAQ

Dieses Kapitel wird nach und nach bei auftretenden Fragen ergänzt.

**F:** Bei Befehlen wie *git add* oder *git commit* wird folgende Fehlermeldung ausgegeben:
    "fatal: not a git repository (or any of the parent directories): .git"

**A:** Das liegt daran, dass ihr euer Git-Repository lokal nicht angelegt habt. Ein

```bash
~ git init
```

behebt hierbei euer Problem.
