Random random = new Random();
<<<<<<< Updated upstream
string stampaopzioni(string x)
=======
Console.WriteLine("Benvenuto nel gioco dell'impiccato");
bool t = false;
string parola = "";
int ntentativi = 0;
while(t == false)
{
    Console.WriteLine("Scegli tema tra stati, cantanti, film e serie");
    string tema = Console.ReadLine();
    tema = tema.ToLower();
    if (tema == "stati")
    {
        string x = "Stati.txt";
        parola = stampaparola(x, ref ntentativi);
        t = true;
    }
    else if (tema == "serie")
    {
        string x = "Serie.txt";
        parola = stampaparola(x, ref ntentativi);
        t = true;
    }
    else if (tema == "film")
    {
        string x = "Film.txt";
        parola = stampaparola(x, ref ntentativi);
        t = true;
    }
    else if (tema == "cantanti")
    {
        string x = "Cantanti.txt";
        parola = stampaparola(x, ref ntentativi);
        t = true;
    }
    else
    {
        Console.WriteLine("Hai sbagliato a scrivere");
    }
}
Console.WriteLine(parola);
Console.WriteLine(ntentativi);
string stampaparola(string x,ref int n)
<<<<<<< Updated upstream
<<<<<<< Updated upstream
>>>>>>> Stashed changes
=======
>>>>>>> Stashed changes
=======
>>>>>>> Stashed changes
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
            n = 5;
        }
        else if (difficolta == "medio")
        {
            i = 5;
            j = 10;
            l = 8;
            e = true;
            n = 7;
        }
        else if (difficolta == "difficile")
        {
            i = 10;
            j = 15;
            l = 12;
            e = true;
            n = 10;
        }
        else
        {
            Console.WriteLine("Hai sbagliato a scrivere");
        }

    }
    int r = random.Next(i, j);
    return lines[r].Substring(l);
}
bool y = true;
string paroleindovinate = "Ancora non hai indovinato nessuna parola";
while (y == true)
{
    Console.WriteLine("Benvenuto nel gioco dell'impiccato,scegli cosa vuoi fare \n a) Indovina la parola \n b) Elenco parole indovinate \n c) Esci");
    string mossa = Console.ReadLine();
    if (mossa.ToLower() == "a")
    {
        bool t = false;
        string parola = "";
        while (t == false)
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
    }
    else if(mossa.ToLower() == "b")
    {
        Console.WriteLine(paroleindovinate);
    }
    else if(mossa.ToLower() == "c")
    {
        Console.WriteLine("Arrivederci");
        y = false;
    }
    else
    {
        Console.WriteLine("Hai sbagliato a scrivere");
    }
}
