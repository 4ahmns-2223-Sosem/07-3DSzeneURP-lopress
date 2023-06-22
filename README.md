# 07-3DSzeneURP-lopress

## Beschreibung:
+ 3D Szene für ein gemeinsames Schulprojekt zum Thema "Klima und Energie".
+ Eine informative VR Umgebung soll einem die verschiedenen Bereiche eines Kohlekraftwerkes näherbringen. Man befindet sich auf dem Gelände eines solchen und kann sich mithilfe von kurzen Infopodcasts zu den verschiedenen Bereichen informieren. Dazu muss man zu den roten Infoständern gehen - sobald man in der Nähe eines solchen ist, aktiviert sich ein Text und das Audio wird aktiviert. Sobald man diesen Bereich wieder verlässt, wird beides wieder deaktiviert.
+ Es muss die Szene "KohlekraftwerkGame" gestartet werden. Wenn man in den Cube mit dem "Zurück"-Text hineinläuft, kommt man in die "UebersichtsSzeneSmeervs".

## Entwicklungsplattform:
+ Windows 11
+ Visual Studio 2019
+ Unity 2020.3.18f

## Einblicke ins Konzept und Game:
![grafik](https://user-images.githubusercontent.com/90834282/231729171-0206d0a3-5c3b-48d7-9fa6-abfd57dbb24b.png)
![Screenshot 2023-06-22 120540](https://github.com/4ahmns-2223-Sosem/07-3DSzeneURP-lopress/assets/90834282/ff79ad6f-2d0a-413a-b06e-0f2a0fdbe2ac)

## Audios:
+ Mono: Erklärstimme (Abbau, Kühltürme, Rohre, Wassererhitzung)
+ Stereo Loops: Wind,	Maschine, Melodie
+ Quellen: https://freesound.org/people/felix.blume/sounds/666250/ https://freesound.org/people/newlocknew/sounds/607148/ https://freesound.org/people/craftcrest/sounds/325244/ https://freesound.org/people/DaveJf/sounds/681721/ https://freesound.org/people/PatrickLieberkind/sounds/396024/

## Syntaxelemente:
+ Methodendeklaration (script: "IfUndMethodeInfos"): Eine void OnTriggerEnter Methode -> wenn der Trigger betreten wird, passiert etwas (darin wird dann das if-Statement ausgeführt) 
+ If (script: "IfUndMethodeInfos"): If der tag ist Player, dann sollen Infos erscheinen und Erklärstimme abspielen. If false, dann soll es nicht mehr abspielen & wieder verschwinden.
+ Enum (script: "EnumFarbauswahl"): Welche Farbe hat der Erklärtext. Vier verschiedene Farben können ausgewählt werden. 
+ While (script: "WhileLichtDimmen"): Je mehr Zeit vergeht, desto dunkler wird es. Damit wird dargestellt, dass je mehr Kohle wir verbrennen desto weiter bergab geht es.  

## Lessons learned:
[x] mit git pushen/pullen
[x] Enums programmieren
[x] Scenes mit Hilfe eines Buttons switchen

## Limitationen:
eigentlich keine mehr :)

copyright by lopress
