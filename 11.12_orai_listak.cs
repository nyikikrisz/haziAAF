List<string> gyumolcs = new List<string> {  "alma", "körte", "szilva", "barack" };

Console.WriteLine($"A lista { gyumolcs.Count} hosszú.");

gyumolcs.Add("szőlő");
gyumolcs.Insert(0, "eper");

Console.WriteLine(gyumolcs);
Console.WriteLine($"az első: {gyumolcs[0]} az utolso: {gyumolcs[gyumolcs.Count-1]}");


//XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX

List<int> szamok = new List<int> ();

bool sikerult;
int szam;

for (int i = 0; i < 5;  i++)
{
	do
	{
		sikerult = false;
		Console.Write($"adj meg egy számot ({i+1}. szam): ");
		sikerult = int.TryParse(Console.ReadLine(), out szam);
	} while (sikerult=false);
	szamok.Add(szam);
}

for (int i = 5; i > 0; i--)
	Console.Write(szamok[i-1]);
Console.WriteLine();

//XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX

int osszeg = 0;
szamok.Clear(); 
for (int i = 0; i < 31; i += 2)
{
	szamok.Add(i);
	osszeg += i;
}
Console.WriteLine(string.Join(", ", szamok));
Console.WriteLine($"{szamok.Count} db páros szám van Összegük: {osszeg}");


//XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX

List<string> nevek = new List<string> ();
string nev;
do
{
	
	Console.Write("Nev (kilépés ures sor): ");
	nev = Console.ReadLine();
	nevek.Add(nev);
	if (nevek.Contains(nev))
	{
		Console.WriteLine("Ez a nv már szerepel");
		nev = "";
	}
} while (nev != "");

for (int i = 0;i <nevek.Count;i++)
	Console.WriteLine($"{i+1}. {nevek[i]}");


//XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX
int [] dolgozatok={72, 45, 88, 30, 50, 91, 49, 66};
List<int> sikeres= new List<int> ();
List<int> sikertelen= new List<int> ();

for (int i = 0;i < dolgozatok.Length ; i++)
{
	if (dolgozatok[i] >= 50)
		sikeres.Add(dolgozatok[i]);
	else
		sikertelen.Add(i+1);
}
Console.WriteLine(string.Join(", ", sikeres));
Console.WriteLine(string.Join(", ", sikertelen));

double szazalek =(sikeres.Count  / dolgozatok.Length + sikeres.Count % dolgozatok.Length) * 100;
Console.WriteLine($"Sikeres: {szazalek}%"); 

