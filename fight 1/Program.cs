int Gattouzhp = 100;
int JasminaKhanhp = 100;

string Gattouzname = "Gattouz";
string Jasminaname = "Jasmina Khan";
while (Gattouzhp > 0 && JasminaKhanhp > 0)
{
    Console.WriteLine("----------NY RUNDA----------");
    Console.WriteLine($"{Gattouzname}: {Gattouzhp}  {Jasminaname}:{JasminaKhanhp}");

    int gattouzdamage = Random.Shared.Next(20);
    JasminaKhanhp -= gattouzdamage;
    JasminaKhanhp = Math.Max(0, JasminaKhanhp);
    Console.WriteLine($"{Gattouzname} gör {gattouzdamage} skada på {Jasminaname}");

    int jasminadamage = Random.Shared.Next(20);
    Gattouzhp -= jasminadamage;
    Gattouzhp = Math.Max(0,Gattouzhp);
    Console.WriteLine($"{Jasminaname} gör {jasminadamage} skada på {Gattouzname}");
    Console.WriteLine("Tryck på valfri knapp för att försätta striden genom tiderna, stridernas strid.");
    Console.ReadKey();
}
Console.WriteLine("---------------Striden är slut---------------");
if (Gattouzhp == 0 && JasminaKhanhp == 0 )
{
    Console.WriteLine("STRIDEN BLEV OAVGJORD");
}
else if (Gattouzhp == 0)
{
    Console.WriteLine($"{Jasminaname} slaktade dig nacas");
}
else
{
    Console.WriteLine($"{Gattouzname} Dammade din görre jaoo");
}
Console.WriteLine("Tryck på valfri knapp för att avsluta programet");
Console.ReadKey();