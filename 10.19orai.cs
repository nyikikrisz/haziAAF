using System.Security.Cryptography;

int i = 1;
int rnd = 0;


Console.WriteLine("Saját megoldás");


for (i = 1; i <= 10; i++)
{
    for (int j = 1; j <= 10; j++)
    {
        rnd = Random.Shared.Next(100);
        if (rnd > 9)
            Console.Write($"{rnd} ");
        else
            Console.Write($"{0}{rnd} ");
    }
    Console.WriteLine();
}
Console.WriteLine("\n-----------------------------------\n");

Console.WriteLine("Jó megoldás");
for (i = 1; i < 11; i++)
{
    for (int j = 1; j <= 10; j++)
    {
        rnd = Random.Shared.Next(100);
        Console.Write($"{rnd:00} ");
    }
    Console.WriteLine();
}

Console.WriteLine("\n\n-----------------------------------\n\n");

int osszeg = 0;
int db = 0;
int dbp = 0;
;

for (i = 1; i < 100; i++)
{
    rnd = Random.Shared.Next(10);
    osszeg += rnd;
    if (osszeg % 2 == 0)
        dbp += 1;
    db += 1;
}

double avg = osszeg / db;
Console.WriteLine($"Összegük: {osszeg},    {dbp} darab páros volt,    Átlaguk: {avg}");

Console.WriteLine("\n-----------------------------------");
Console.WriteLine("-----------------------------------\n");

for (i = 1; i <= 10; i++)
{
    for (int j = 1; j <= 10; j++)
    {
        rnd = Random.Shared.Next(100);
        if (3 < i && i < 8 && 3 < j && j < 8)
            Console.Write($"   ");
        else
            Console.Write($"{rnd:00} ");
    }
    Console.WriteLine();
}
Console.WriteLine("\n-----------------------------------\n");


for (i = 1; i <= 10; i++)
{
    for (int j = 1; j <= 10; j++)
    {
        rnd = Random.Shared.Next(100);
        if (3 < i && i < 8 && 3 < j && j < 8)
            Console.Write($"   ");
        else
            if (rnd % 2 == 0)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write($"{rnd:00} ");
                Console.ResetColor();
            }

            else
            {
                Console.Write($"{rnd:00} ");
            }
    }
    Console.WriteLine();
}
Console.WriteLine("\n-----------------------------------"); 
Console.WriteLine("-----------------------------------");
Console.WriteLine("-----------------------------------\n");


int eletkor;
bool siker = false;
do
{
    Console.Write("Kérlek add meg az életkorod");
    eletkor = int.Parse(Console.ReadLine());
    if (0 < eletkor && eletkor < 120)
    {
        Console.WriteLine($"Köszönjük Életkorod: {eletkor}");
        siker = true;
    }
    else
    {
        Console.WriteLine($"Sajnáljuk valami félre ment (a megadott életkorod: {eletkor})");
    }

} while (siker == false);



Console.WriteLine("\n-----------------------------------\n");

Console.WriteLine("\n-----------------------------------");
Console.WriteLine("-----------------------------------");
Console.WriteLine("-----------------------------------\n");
Console.WriteLine("\nSZORGALMI\n");


for (i = 1; i <= 10; i++)
{
    for (int j = 1; j <= 10; j++)
    {
        rnd = Random.Shared.Next(100);


        if (2 >= i || i >= 9 || 2 >= j || j >= 9)
            Console.Write($"{rnd:00} ");
        else
        {
            if (i == 5 || 6 == i)
                if (j == 5 || 6 == j)
                    Console.Write($"{rnd:00} ");
                else
                    Console.Write($"   ");
            else
                Console.Write($"   ");
        }
    }
    Console.WriteLine();
}
