# High Level
- es gibt mehrere Welten
## Welt
- Die Welt in in einem karthesischen Koordinatensystem angelegt (x = 10, y = 10)
- in jeder Welt gibt es mehrere Städte (n = 5)
- Städte haben einen zufälligen Namen
- Städte haben eine zufällige Position
- Städte haben einen minimalen Abstand (d = 5)

## Stadt
- In jeder Stadt gibt es bis zu n Patrizier, n = 3
- Der Spieler kann ein Patrizier in einer Stadt werden
- Man kann zwischen den Städten reisen
- Es gibt eine variable Anzahl von Einwohner pro Stadt
- Die Stadt besitzt Geld und einen Markt, auf dem Ressourcen gehandelt werden

## Markt
- Der Markt dient zum Austausch der Waren und wird von der Stadt unterhalten
- Für jede der Ressourcen gibt es
	- Einkaufspreis
	- Verkaufspreis
	- Bestand
Patrizier können an die Stadt verkaufen oder von der Stadt kaufen
## Ressourcen
Es gibt die folgenden Ressourcen, die ein Patrizier und eine Stadt besitzen kann
- Geld
- Nahrung
- Holz
- Erz

Nahrung, Holz und Erz, die die Stadt besitzt, werden auf dem Markt angeboten.
Der Lagerbestand der Stadt und des Patriziers kann beliebig groß werden.

## Zeit
- Die Zeit in der Simulation verstreicht
- Es gibt Jahre
- jedes Jahr hat 12 Monate
- Jeder Monat hat 4 Wochen
- Jede Woche hat 7 Tage

Pro Tick in der Simulation wird ein Tag weitergezählt

## Einwohner
- Einwohner können verschiedene Berufe annehmen
	- Bauer (generiert Nahrung)
	- Holzfäller (generiert Holz)
	- Bergmann (generiert Erz)
Der Ertrag pro Einwohner sei zunächst konstant

Die generierte Ware wird direkt an die Stadt gegeben

Einwohner benötigen verschiedene Ressourcen
- Pro Woche benötigen Einwohner 1 Nahrung
- Pro Monat benötigen Einwohner 1 Holz
- Pro Jahr benötigen Einwohner 1 Erz

Wenn auf dem Markt keine Nahrung zur Verfügung steht, reduziert sich die Bevölkerung um n%
