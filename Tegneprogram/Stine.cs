/* STINES MIDLERTIDIG LØSNING
using Tegneprogram;
using System;

// Skriv dit program her.
// God fornøjelse

//string[] farve = { "Black", "Blue", "Yellow", "Green", "Red" };

Firkant[] Firkant = new Firkant[1] { new Firkant("Black") };

Firkant[0].Hojde = 300;
Firkant[0].Bredde = 600;
Firkant[0].X = 100;
Firkant[0].Y = 100;


Cirkel[] Cirkel = new Cirkel[5] { new Cirkel("Blue"), new Cirkel("Yellow"), new Cirkel("Black"), new Cirkel("Green"), new Cirkel("Red") };

Cirkel[0].Diameter = 20;
Cirkel[0].X = 10;
Cirkel[0].Y = 60;

Cirkel[1].Diameter = 20;
Cirkel[1].X = 20;
Cirkel[1].Y = 40;

Cirkel[2].Diameter = 20;
Cirkel[2].X = 35;
Cirkel[2].Y = 60;

Cirkel[3].Diameter = 20;
Cirkel[3].X = 55;
Cirkel[3].Y = 40;

Cirkel[4].Diameter = 20;
Cirkel[4].X = 60;
Cirkel[4].Y = 60;

//Herunder opretter jeg en instans til klassen Tegning:

Tegning Tegning1 = new();

//herunder kalder jeg metoden Tegn via klassen Tegning:
//Metoden Tegn skal have to argumenter - firkant-array og cirkel-array

Tegning1.Tegn(Firkant, Cirkel);
*/