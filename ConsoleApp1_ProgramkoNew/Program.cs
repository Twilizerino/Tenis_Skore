/*

using System.Runtime.Intrinsics.Arm;

try
{
    Console.WriteLine("Zadejte A: ");

    var a = Console.ReadLine();

    Console.WriteLine("Zadeejte B: ");

    var b = Console.ReadLine();

    int vysledek = int.Parse(a) / int.Parse(b);

    Console.WriteLine(vysledek);
}catch(Exception e)
{
    Console.WriteLine("Nastala chyba." + e.Message);
}

Console.WriteLine("Pokračuj");
Console.ReadLine();



public enum Tvar {
    obdelnik,
    ctverec,
    trojuhelnik,
}

Console.WriteLine("Zadej velikost");
obrazec2.velikost = int.Parse(Console.ReadLine());

Console.WriteLine("Zadej tvar");
obrazec2.tvar = Console.ReadLine();
Obrazec obrazec2 = new Obrazec(5, "tvar");

Console.WriteLine("Mam zde objekt: " + obrazec2);
Console.WriteLine("Který má velikost: " + obrazec2.velikost);
Console.WriteLine("A tvar: " + obrazec2.tvar);

public class Obrazec
{
    public int velikost;
    public string tvar;

    public Obrazec(int nastavVelikost, string nastavTvar);

    public void CoJsem()
    {
        Console.WriteLine("Který má velikost: " + velikost);
        Console.WriteLine("A tvar: " + tvar);
    }

    public int Kolik()
    {
        return 0;
    }
}





using System.Runtime.CompilerServices;

Auto objektAuto1 = new Auto();
System.Console.WriteLine("Zadejte vstup pro značku: ");
string vstup = Console.ReadLine();
objektAuto1.Znacka = vstup;
System.Console.WriteLine("Zadejte vstup pro barvu:");
objektAuto1.Barva = Console.ReadLine();
objektAuto1.ZapniMotor();
objektAuto1.VypisZnacku();
Console.WriteLine("Barva auta je: " + objektAuto1.VratBarvu()); 
*/

/*
S: " + Znacka);
    }

    public string VratZnacku()
    {
        return Znacka;
    }

    public string VratBarvu()
    {
        return Barva;
    }
}

*/
/*

class Tenis_Game
{
    static void Main()
    {
        int bodyA = 0, bodyB = 0;
        int gemyA = 0, gemyB = 0;
        int setyA = 0, setyB = 0;

        while (true)
        {
            Console.WriteLine("Zadejte body (1 - bod hráče A, 2 - bod hráče B, 3 - konec):");
            string? input = Console.ReadLine();

            if (int.TryParse(input, out int akce))
            {

            switch (akce)
            {
                case 1:
                    bodyA++;
                    Console.WriteLine("Bod pro hráče A");
                    break;
                case 2:
                    bodyB++;
                    Console.WriteLine("Bod pro hráče B");
                    break;
                case 3:
                    Console.WriteLine("Konec hry!");
                    return;
                default:
                    Console.WriteLine("Nope!");
                    continue;
            }

            }

            if (bodyA >= 4 && bodyB >= 4)
            {
                if (bodyA == bodyB + 1)
                {
                    Console.WriteLine("Advantage hráče A!");
                }
                else if (bodyB == bodyA + 1)
                {
                    Console.WriteLine("Advantage hráče B!");
                }
            }

            //body na gemy
            if (bodyA >= 4 && bodyA >= bodyB + 2)
            {
                gemyA++;
                bodyA = 0;
                bodyB = 0;
            }
            else if (bodyB >= 4 && bodyB >= bodyA + 2)
            {
                gemyB++;
                bodyA = 0;
                bodyB = 0;
            }

            //gemy na sety
            if (gemyA >= 6 && gemyA >= gemyB + 2)
            {
                setyA++;
                gemyA = 0;
                gemyB = 0;
            }
            else if (gemyB >= 6 && gemyB >= gemyA + 2)
            {
                setyB++;
                gemyA = 0;
                gemyB = 0;
            }

            //Výpis stavu hry
            Console.WriteLine($"Body: A={bodyA}, B={bodyB}");
            Console.WriteLine($"Gemy: A={gemyA}, B={gemyB}");
            Console.WriteLine($"Sety: A={setyA}, B={setyB}");
        }
    }
}

*/


int bodyA = 0, bodyB = 0, gemyA = 0, gemyB = 0, setyA = 0, setyB = 0;

while (true)
{
    Console.WriteLine("Zadejte body (1 - bod hráče A, 2 - bod hráče B, 3 - konec):");
    string? input = Console.ReadLine();

    if (int.TryParse(input, out int akce))
    {
        switch (akce)
        {
            case 1:
                bodyA++;
                Console.WriteLine("Bod pro hráče A");
                break;
            case 2:
                bodyB++;
                Console.WriteLine("Bod pro hráče B");
                break;
            case 3:
                Console.WriteLine("Konec hry!");
                return;
            default:
                Console.WriteLine("Nope!");
                continue;
        }
    }
    else
    {
        Console.WriteLine("Nope!");
        continue;
    }

    //výhody
    if (bodyA >= 3 && bodyB >= 3)
    {
        if (bodyA == bodyB + 1)
        {
            Console.WriteLine("Advantage hráče A!");
        }
        else if (bodyB == bodyA + 1)
        {
            Console.WriteLine("Advantage hráče B!");
        }
    }

    //body na gemy
    if ((bodyA >= 4 && bodyA >= bodyB + 2) || (bodyA == 4 && bodyB < 3))
    {
        gemyA++;
        bodyA = 0;
        bodyB = 0;
        Console.WriteLine("Hráč A získal gem!");
    }
    else if ((bodyB >= 4 && bodyB >= bodyA + 2) || (bodyB == 4 && bodyA < 3))
    {
        gemyB++;
        bodyA = 0;
        bodyB = 0;
        Console.WriteLine("Hráč B získal gem!");
    }
    
    //gemy na sety
    if (gemyA >= 6 && gemyA >= gemyB + 2)
    {
        setyA++;
        gemyA = 0;
        gemyB = 0;
        Console.WriteLine("Hráč A získal set!");
    }
    else if (gemyB >= 6 && gemyB >= gemyA + 2)
    {
        setyB++;
        gemyA = 0;
        gemyB = 0;
        Console.WriteLine("Hráč B získal set!");
    }

    //Výpis  stavu hry
    string scoreA = bodyA switch { 0 => "0", 1 => "15", 2 => "30", 3 => "40", _ => "Advantage" };
    string scoreB = bodyB switch { 0 => "0", 1 => "15", 2 => "30", 3 => "40", _ => "Advantage" };

    Console.WriteLine($"Skóre: A={scoreA}, B={scoreB}");
    Console.WriteLine($"Gemy: A={gemyA}, B={gemyB}");
    Console.WriteLine($"Sety: A={setyA}, B={setyB}");
}