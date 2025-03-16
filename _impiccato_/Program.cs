Random random = new Random();
Console.WriteLine("Benvenuto nel gioco dell'impiccato");
bool t = false;
string parola = "";
while(t == false)
{
    Console.WriteLine("Scegli tema tra stati, cantanti, film e serie");
    string tema = Console.ReadLine();
    tema = tema.ToLower();
    if (tema == "stati")
    {
        string x = "Stati.txt";
        parola = stampaopzioni(x);
        t = true;
    }
    else if (tema == "serie")
    {
        string x = "Serie.txt";
        parola = stampaopzioni(x);
        t = true;
    }
    else if (tema == "film")
    {
        string x = "Film.txt";
        parola = stampaopzioni(x);
        t = true;
    }
    else if (tema == "cantanti")
    {
        string x = "Cantanti.txt";
        parola = stampaopzioni(x);
        t = true;
    }
    else
    {
        Console.WriteLine("Hai sbagliato a scrivere");
    }
}
Console.WriteLine(parola);
string stampaopzioni(string x)
{
    string[] lines = File.ReadAllLines(x); // Legge tutte le righe e le mette in un vettore
    bool e = false;
    int i = 0, j = 0, l = 0;
    while (e == false)
    {
        Console.WriteLine("Scegli la difficoltà, tra facile, medio e difficile");
        string difficolta = Console.ReadLine();
        difficolta = difficolta.ToLower();
        if (difficolta == "facile")
        {
            j = 5;
            l = 9;
            e = true;
        }
        else if (difficolta == "medio")
        {
            i = 5;
            j = 10;
            l = 8;
            e = true;
        }
        else if (difficolta == "difficile")
        {
            i = 10;
            j = 15;
            l = 12;
            e = true;
        }
        else
        {
            Console.WriteLine("Hai sbagliato a scrivere");
        }
        
    }
    int r = random.Next(i, j);
    return lines[r].Substring(l);
}
