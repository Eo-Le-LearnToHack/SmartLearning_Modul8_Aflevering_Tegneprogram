using Tegneprogram;

// Skriv dit program her.
// God fornøjelse

Firkant Firkant1 = new("Black");
Firkant1.Hojde = 300;
Firkant1.Bredde = 600;
Firkant1.X = 100;
Firkant1.Y = 100;

int forskydningXpos = Firkant1.Bredde / 16;         //1 enhed forskydning i X position defineres her
int forskydningYpos = Firkant1.Hojde / 12;          //1 enhed forskydning i Y position defineres her

Cirkel Cirkel1 = new("Blue");
Cirkel1.Diameter = 3*forskydningXpos;               //Diameter af cirklerne defineres her.
Cirkel1.X = Firkant1.X + 4*forskydningXpos;
Cirkel1.Y = Firkant1.Y + 5*forskydningYpos;         //Position Y af Cirkel1, Cirkel3 og Cirkel5 defineres her.

Cirkel Cirkel2 = new("Yellow");
Cirkel2.Diameter = Cirkel1.Diameter;
Cirkel2.X = Firkant1.X + 6*forskydningXpos;
Cirkel2.Y = Firkant1.Y + 7*forskydningYpos;         //Position Y af Cirkel2 og Cirkel4 defineres her.

Cirkel Cirkel3 = new("Black");
Cirkel3.Diameter = Cirkel1.Diameter;
Cirkel3.X = Firkant1.X + 8*forskydningXpos;
Cirkel3.Y = Cirkel1.Y;

Cirkel Cirkel4 = new("Green");
Cirkel4.Diameter = Cirkel1.Diameter;
Cirkel4.X = Firkant1.X + 10*forskydningXpos;
Cirkel4.Y = Cirkel2.Y;

Cirkel Cirkel5 = new("Red");
Cirkel5.Diameter = Cirkel1.Diameter;
Cirkel5.X = Firkant1.X + 12*forskydningXpos;
Cirkel5.Y = Cirkel1.Y;

Firkant[] arrayFirkant = new Firkant[] { Firkant1 };
Cirkel[] arrayCirkel = new Cirkel[] { Cirkel1, Cirkel2, Cirkel3, Cirkel4, Cirkel5 };

Tegning Tegning1 = new();
Tegning1.Tegn(arrayFirkant, arrayCirkel);