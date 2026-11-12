using System.Drawing;

void fejlec()
{
    Console.WriteLine("====================");
    Console.WriteLine("METODUSGYÁR");
    Console.WriteLine("====================");
}

fejlec();
Console.WriteLine("Itt kezdődik a munka.");
fejlec();

//XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX

void csillagsor()
{
    for (int i = 0; i < 21; i++)
    {
        Console.Write("*");
    }
    Console.WriteLine();
}
csillagsor();
Console.WriteLine("Csillagos ég");
csillagsor();

//XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX

void visszaszamlalas()
{
    for (int i = 5; i > 0; i--)
    {
        Console.Write($"{i} ");
        Thread.Sleep(1000);
    }
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("Rajt!");
    Console.ResetColor();
}

Console.WriteLine("Indul a verseny!");
visszaszamlalas();



//XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX

void paros()
{
    for (int i = 2; i <= 20; i += 2)
    {
        Console.Write($"{i} ");
    }
    Console.WriteLine();
}
Console.Write("Paros szamok: ");
paros();


//XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX
Console.WriteLine("XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
//XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX


void udvozol(string nev)
{
    Console.WriteLine($"Szia {nev} jó hogy itt vagy!");
}

udvozol("Anna");
udvozol("Bence");
udvozol("Csilla");
string barat = "Tamás";
udvozol(barat);

//XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX

void sor(int szam)
{
    for (int i = 0; i < szam; i++)
    {
        Console.Write("-");
    }
    Console.WriteLine();
}
sor(5);
sor(12);
sor(2);

//XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX
void lampa(bool kapcs)
{
    if (kapcs)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("A lámpa: BE");
        Console.ResetColor();
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("A lámpa: KI");
        Console.ResetColor();
    }

}

lampa(true);
lampa(false);
lampa(3 > 5);


//XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX

void homerseklet(double fok)
{
    if (fok < 0)
        Console.WriteLine($"{fok} fok: Fagy");
    else if (fok > 25)
        Console.WriteLine($"{fok} fok: Meleg");
    else
        Console.WriteLine($"{fok} fok: Kellemes");
}

homerseklet(-3.5);
homerseklet(12);
homerseklet(25);
homerseklet(31.2);

//XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX
Console.WriteLine("XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
//XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX


void teglalap(int oszlop, int sor)
{
    for (int i = 0; i < sor; i++)
    {
        for (int j = 0; j < oszlop; j++)
        {
            Console.Write("#");
        }
        Console.WriteLine();
    }
}

teglalap(6, 2);
Console.WriteLine();
teglalap(3, 3);

//XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX

void kiir(string szoveg, ConsoleColor szin)
{
    Console.ForegroundColor = szin;
    Console.WriteLine(szoveg);
    Console.ResetColor();
}

kiir("Sikeres mentés.", ConsoleColor.Green);
kiir("Kevés a szabad hely!", ConsoleColor.Yellow);
kiir("Hiba történt!", ConsoleColor.Red);
Console.WriteLine("Ez már az alapszín.");


//XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX


void vonal(char karakter = '-', int szam = 20)
{
    for (int i = 0; i < szam; i++)
        Console.Write($"{karakter}");
    Console.WriteLine();
}

vonal();
vonal('#');
vonal('*', 8);

//XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX


void arcimke(string nev, decimal ar, decimal szazalek = 0)
{
    decimal ujar = ar - (ar * (szazalek / 100));
    if (szazalek == 0)
        Console.WriteLine($"{nev}: {ar:N0}Ft");
    else
    {

        Console.WriteLine($"{nev}: {ar:N0}Ft --> {ujar:N0}Ft (-{szazalek}%) ");
    }
}

arcimke("Sapka", 3990m);
arcimke("Kabát", 24990m, 20);
arcimke("Sál", 5490m, 10);

//XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX
Console.WriteLine("XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
//XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX

string nevetker()
{
    Console.Write("Add meg a neved");
    string nev = Console.ReadLine();
    return (nev);
}
string nev = nevetker();
Console.WriteLine($"Szia, {nev}!");

//XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX

int egeszetker()
{
    Console.Write("Adj meg egy egész számot.");
    int szam = int.Parse(Console.ReadLine());
    return (szam);
}
int a = egeszetker();
int b = egeszetker();
Console.WriteLine($"Összegük: {a + b}");

//XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX

bool megerosites()
{
    string valasz;
    do
    {
        Console.Write("Biztoan ki aarsz lépni? (i/n)");
        valasz = Console.ReadLine();
        if (valasz == "i")
            return true;
        else if (valasz == "n")
            return false;
        else
            Console.WriteLine("Hiba");

    } while (valasz != "i" || valasz == "n");
    return false;
}


if (megerosites())
{
    Console.WriteLine("Viszlát!");
}
else
{
    Console.WriteLine("Akkor maradunk.");
}


//XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX
decimal arker()
{
    bool jo = false;
    decimal netto;

    do
    {
        Console.Write("Netto ár: ");
        netto = decimal.Parse(Console.ReadLine());
        if (netto > 0)
            jo = true;
        else
            Console.WriteLine("Pozitiv szamot adj meg!");

    } while (jo == false);
    return netto;
}

decimal netto = arker();
Console.WriteLine($"Bruttó ár: {netto * 1.27m:N0} Ft");


//XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX
Console.WriteLine("XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
//XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX




int negyzet(int szam)
{
    int negyzet=szam*szam;
    return negyzet;
}

Console.WriteLine(negyzet(7));
for (int i = 1; i <= 5; i++)
{
    Console.Write(negyzet(i) + " ");
}
Console.WriteLine();

//XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX

bool SzokoevE(int ev)
{
    if (ev % 400 == 0) { return true; }

    else 
    {
        if (ev % 4 == 0 && ev % 100 !=0)
        {
         return true;
        }
        else { return false; } 
    }
}

Console.WriteLine($"2024: {SzokoevE(2024)}");
Console.WriteLine($"1900: {SzokoevE(1900)}");
Console.WriteLine($"2000: {SzokoevE(2000)}");
if (!SzokoevE(2026))
{
    Console.WriteLine("2026 nem szökőév.");
}


//XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX
double Fahrenheit(double fok)
{
    fok = (fok * 9 / 5) + 32;
    return fok;
}

Console.WriteLine($"0 C = {Fahrenheit(0)} F");
Console.WriteLine($"100 C = {Fahrenheit(100)} F");
double ho = 36.6;
Console.WriteLine($"{ho} C = {Fahrenheit(ho):F1} F");


//XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX

string Ertekeles(int pont)
{
    if (100 >= pont && pont >= 90)
        return "jeles";

    else if (89 >= pont && pont >= 75)
        return "jó";

    else if (74 >= pont && pont >= 60)
        return "közepes";

    else if (59 >= pont && pont >= 50)
        return "elégséges";

    else if (49 >= pont && pont >= 0)
        return "elégtelen";

    else
        return "hiba";
}

Console.WriteLine($"45 pont: {Ertekeles(45)}");
Console.WriteLine($"74 pont: {Ertekeles(74)}");
Console.WriteLine($"90 pont: {Ertekeles(90)}");


//XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX

ConsoleColor jegyszine(int jegy)
{
    switch (jegy)
    {
        case 1:
            return ConsoleColor.Red;

        case 2:
            return ConsoleColor.DarkYellow;

        case 3:
            return ConsoleColor.Yellow;

        case 4:
            return ConsoleColor.Cyan;

        case 5:
            return ConsoleColor.Green;

        default: return ConsoleColor.White;


    };

}


for (int i = 1; i <= 5; i++)
{
    Console.ForegroundColor = jegyszine(i);

    Console.WriteLine($"Jegy: {i}");
}
Console.ResetColor();



//XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX
Console.WriteLine("XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
//XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX

double Atlag (double a, double b, double c)
{
    double atlag = (a + b + c) / 3;
    return atlag;
}

Console.WriteLine($"Átlag: {Atlag(4, 5, 3):F2}");
double eredmeny = Atlag(2.5, 3.5, 5);
Console.WriteLine($"Átlag: {eredmeny:F2}");

//XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX

decimal Brutto (decimal ar, decimal afa = 27)
{
    ar = ar + (ar * (afa / 100));
    return ar;
}

Console.WriteLine($"{Brutto(1000m):N0} Ft");
Console.WriteLine($"{Brutto(1000m, 5):N0} Ft");
decimal ar = Brutto(2500m, 18);
Console.WriteLine($"{ar:N0} Ft");
//XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX

string Ismetel(string szoveg, int ism, string koto=" ")
{
    string kesz="";
    for (int i = 1; i<ism; i++)
    {
        kesz+=$"{szoveg}{koto}";
    }
    kesz =kesz+szoveg;
    return kesz;
}

Console.WriteLine(Ismetel("ha", 3));
Console.WriteLine(Ismetel("bum", 4, "-"));
Console.WriteLine(Ismetel("tik-tak", 2, ", "));

//XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX

int SzamotKer(string szoveg, int alsh=1, int felh=10)
{
    int valasz;
    do
    {
        Console.WriteLine($"{szoveg} ({alsh}-{felh})");
        valasz = int.Parse(Console.ReadLine());
    } while (alsh < valasz && valasz > felh);
    return valasz;
}
int jegy = SzamotKer("Hányast kaptál", 1, 5);
int tetszes = SzamotKer("Mennyire tetszett");
Console.WriteLine($"Jegy: {jegy}, tetszés: {tetszes}");