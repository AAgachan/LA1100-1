# LA1100-4: Lern-Bericht
Agachan Atputharasa

## Einleitung

Wir haben den Auftrag bekommen einen Number Guessing Game zu machen.

## Was habe ich gelernt?

Ich habe während der Projekt gelernt, wie man eine try und catch Schleife bildet und verwendet. Ich habe es gebraucht um eine Fehlermeldung rauszugeben, wenn man versucht etwas zu schreiben.


## Beschreibung

![ezgif-4-6a4ea42901](https://user-images.githubusercontent.com/110893260/189848907-f44b22e7-8e78-4211-a6b2-bf6755258d74.gif)
```Csharp
                      while (check == false)
                    {
                        try
                        {
                            Console.WriteLine("Guess a number between " + min + " - " + max + " : ");
                            guess = Convert.ToInt32(Console.ReadLine());
                            check = true;
                        }
                        catch
                        {
                            Console.WriteLine("Geben Sie Zahlen zwischen 1-100 ein!");
                            check = false;
                        }
                     }
                    check = false;
                    Console.WriteLine("Guess: " + guess);
 ```                       
Hier 

## Verifikation
Bei der ersten Medien sieht man das Endergebnis.
Auf der zweiten Medium sieht man wie ich es programmiert habe.
Auf der dritten Medium sieht man die Erklärung dafür.

# Reflektion zum Arbeitsprozess

Der Arbeitsprozess war sehr mühsam, denn ich hatte von nichts eine Ahnung wie man es programmiert. Ich habe sehr oft an mir selbst gezweifelt, ob ich überhaupt einen IMS Abschluss schaffe. Doch durch einge Youtube Videos sind die Selbstzweifel verschwunden und schlussendlich bin ich mit mir zufrieden gewesen, nach dem alles geklappt hat.

**VBV**: Hilfe holen, Youtube tutorial direkt anschauen
