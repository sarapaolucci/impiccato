Console.WriteLine("Benvenuto nel gioco dell'impiccato, scegli il tema tra Stati, Animali ecc");
string tema = Console.ReadLine();
if(tema == "Stati")
{
    
}
void stampaopzioni(string x)
{
    string[] lines = File.ReadAllLines("Stati.txt"); // Legge tutte le righe e le mette in un vettore
    Console.WriteLine("Ora scegli la difficoltà tra facile, medio e difficile");
    string difficoltà = Console.ReadLine();
    int i = 0, j = 0;
    if (difficoltà == "facile")
    {
        j = 5;
    }
    else if (difficoltà == "medio")
    {
        i = 5;
        j = 10;
    }
    for (int a = i; a < j; a++)
    {
        Console.WriteLine(lines[a]);
    }
}
