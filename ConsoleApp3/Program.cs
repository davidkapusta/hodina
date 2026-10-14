Console.Write("Cena tovaru: ");
double cena = int.Parse(Console.ReadLine());
Console.Write("Zľavový kupón: ");
double kupon = int.Parse(Console.ReadLine());

double finalnaCena = VypocitajCenuPoZlave(cena, kupon);

Console.WriteLine($"Pôvodná cena: {cena} EUR");
Console.WriteLine($"Cena po zľave: {finalnaCena} EUR");
Console.ReadKey();

double VypocitajCenuPoZlave(double povodnaCena, double ZlavaVEurovach)
{
    Console.WriteLine();
} 