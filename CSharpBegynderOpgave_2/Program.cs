﻿/*   Opgave 2
    - Udvid dit visitkort fra sidst ved at gøre brug af Forskellige datatyper, variabler og user input.
    - Se bunden af koden for eksempler
 */

int xPosition = 5;
int yPosition = 1;

Console.SetCursorPosition(xPosition, yPosition);
Console.WriteLine("X");


string StrengVariabel = "TestStreng";
Console.WriteLine(StrengVariabel);

int IntegerVariabel1 = 5;
int IntegerVariabel2 = 5;
Console.WriteLine(IntegerVariabel1 + IntegerVariabel2);

Console.WriteLine("Hvad er dit navn?");
string navn = Console.ReadLine();

Console.WriteLine("Navn sofus");
   








/*
    Console.SetCursorPosition(5, 1); //Sætter cursorens start position.

    string StrengVariabel = "Blablabla"; //En streng er det samme som en tekst.
    int IntegerVariabel = 0; //En Integer er et Heltal
    double DoubleVariable = 0.5; //En double er et komma-tal
    bool ErEnBoolVariabel = true; //En bool kan have 2 værdier. true eller false.    

    Console.ReadLine(); //Læser brugeren input og returnere en streng. kan f.eks gemmes i en variabel.
    
 */