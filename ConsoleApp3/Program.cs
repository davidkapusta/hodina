Console.Write("Zadaj svoje meno: ");
string meno = Console.ReadLine();
PrivitajPouzivatela(meno);
Console.ReadKey();


void PrivitajPouzivatela(string meno)
{
    Console.WriteLine($"Ahoj {meno} ,sme radi, že si späť!" );
}

