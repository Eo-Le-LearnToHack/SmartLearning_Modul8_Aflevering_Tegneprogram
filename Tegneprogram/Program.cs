using Tegneprogram;

// Skriv dit program her.
// God fornøjelse

Firkant[] Firkant = new Firkant[1] { new Firkant("Black") };
Firkant[0].Hojde = 300;
Firkant[0].Bredde = 600;
Firkant[0].X = 100;
Firkant[0].Y = 100;

int forskydningXpos = Firkant[0].Bredde / 16;         //1 enhed forskydning i X position defineres her
int forskydningYpos = Firkant[0].Hojde / 12;          //1 enhed forskydning i Y position defineres her

Cirkel[] Cirkel = new Cirkel[5]
{new Cirkel("Blue"),
new Cirkel("Yellow"),
new Cirkel("Black"),
new Cirkel("Green"),
new Cirkel("Red")};

for (int i = 0; i < Cirkel.Length; i++)
{
    Cirkel[i].Diameter = 3 * forskydningXpos;                                                   //Diameter af cirklerne defineres her.
    Cirkel[i].X = Firkant[0].X + (i * 2 + 4) * forskydningXpos;                                 //Position X af alle 5 cirkler defineres her.
    if (i < 2) { Cirkel[i].Y = Firkant[0].Y + (i * 2 + 5) * forskydningYpos; }                  //Position Y af Cirkel 1 og 2 defineres her.
    else if (i == 2 || i == 4) { Cirkel[i].Y = Cirkel[0].Y; }                                   //Position Y for Cirkel 3 og 5
    else if (i == 3) { Cirkel[i].Y = Cirkel[1].Y; }                                             //Position Y for Cirkel 4.
}

Tegning Tegning = new();
Tegning.Tegn(Firkant, Cirkel);