# 00. Compiler

## Was ist ein Compiler ?

### Ein Compiler ist ein Programm, welches in einer höheren Programmiersprache geschreibenen Quellcode in binären, von Maschinen lesbaren Code übersetzt, und damit ein +- direkt ausführbares Programm, z.B eine .exe, erzeugt.

## Schaut mit dem Explorer in das Verzeichnis mit den 2 Files. Was hat sich verändert?

### Es wurden zwei Ordner automatisch erstellt, zum einen den `bin` Ordner sowie den `obj` Ordner.

## Was passiert, wenn ich im Code einen Fehler habe und `dotnet build` aufrufe?

### Wenn ich einen Fehler im Code habe, und versuche ihn auszuführen, dann schlägt der Build fehl und zeigt mir was/wo, z.B:
 `Compileme net10.0 fehlerhaft mit 1 Fehler(n) (0.2s)` ... `error CS0117: "Console" enthält keine Definition für "WiteLine".` ... `Erstellen von fehlerhaft mit 1 Fehler(n) in 1.0s`

# 01. First Steps

