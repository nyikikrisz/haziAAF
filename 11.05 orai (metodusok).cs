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
	for (int i=0; i<21; i++)
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
sor(2*10);

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

lampa (true);
lampa (false);
lampa (3 > 5);


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


void vonal(char karakter='-', int szam=20)
{
	for (int i = 0;i < szam; i++)
		Console.Write($"{karakter}");
	Console.WriteLine();
}

vonal();
vonal('#');
vonal('*', 8);

//XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX


void arcimke(string nev, decimal ar, decimal szazalek=0)
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
	return(nev);
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
