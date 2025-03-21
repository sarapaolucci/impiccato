Random random = new Random();
string stampaparola(string x,ref int n)
{
    string[] lines = File.ReadAllLines(x); // Legge tutte le righe e le mette in un vettore
    bool e = false;
    int i = 0, j = 0, l = 0;
    while (e == false)
    {
        Console.WriteLine("Scegli la difficoltà: \n a) Facile (5 tentativi) \n b) Medio (7 tentativi)  \n c) Difficile (10 tentativi )");
        string difficolta = Console.ReadLine();
        difficolta = difficolta.ToLower();
        if (difficolta == "facile" || difficolta == "a")
        {
            j = 5;
            l = 9;
            e = true;
            n = 5;
        }
        else if (difficolta == "medio" || difficolta == "b")
        {
            i = 5;
            j = 10;
            l = 8;
            e = true;
            n = 7;
        }
        else if (difficolta == "difficile" || difficolta == "c")
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
void trattini(string parola, ref string[] par)
{
    for (int i = 0; i < parola.Length; i++)
    {
        par[i] = "_ ";
    }
}
void provalettera ( ref string [] par, string[]r)
{
    Console.WriteLine("Inserisci lettera");
    string l = Console.ReadLine();
    for (int i = 0; i < r.Length; i++)
    {
        if (r[i] == l)
        {
            par[i] = l;
        }
    }
}
void stamparray(string[]a)
{
    for(int i = 0; i < a.Length; i++)
    {
        Console.Write(a[i]);
    }
    Console.WriteLine();
}
Console.WriteLine("Benvenuto nel gioco dell'impiccato");
string parola = "";
int ntentativi = 0;
bool y = true;
string paroleindovinate = "Ancora non hai indovinato nessuna parola";
while (y == true)
{
    Console.WriteLine("Segli cosa vuoi fare \n a) Indovina la parola \n b) Elenco parole indovinate \n c) Esci");
    string mossa = Console.ReadLine();
    if (mossa.ToLower() == "a")
    {
        bool o = false;
        while (o == false)
        {
            Console.WriteLine("Scegli tema tra: \n a) stati \n b) cantanti \n c) film \n d) serie");
            string tema = Console.ReadLine();
            tema = tema.ToLower();
            if (tema == "stati" || tema == "a")
            {
                string x = "Stati.txt";
                parola = stampaparola(x, ref ntentativi);
                o = true;
            }
            else if (tema == "serie" || tema == "d")
            {
                string x = "Serie.txt";
                parola = stampaparola(x, ref ntentativi);
                o = true;
            }
            else if (tema == "film" || tema == "c")
            {
                string x = "Film.txt";
                parola = stampaparola(x, ref ntentativi);
                o = true;
            }
            else if (tema == "cantanti" || tema == "b")
            {
                string x = "Cantanti.txt";
                parola = stampaparola(x, ref ntentativi);
                o = true;
            }
            else
            {
                Console.WriteLine("Hai sbagliato a scrivere");
            }
        }
        Console.WriteLine(parola);
        string[] par = new string[parola.Length];
        trattini(parola, ref par);
        stamparray(par);
        bool j = true;
        string[] r = parola.Split("");
        while (j == true)
        {
            Console.WriteLine("Dimmi cosa vuoi fare ora: \n a) Prova lettera \n b) Indovina parola \n c) Indizi limitati (A scelta tra prima, ultima lettera o entrambe)\n d) Oggetti jolly (lettera casuale) ");
            string cosa = Console.ReadLine();
            if (cosa == "a" || cosa.ToLower() == "prova lettera")
            {
                provalettera(ref par , r);
                stamparray(par);
                j = false;
            }
            else if (cosa == "b" || cosa.ToLower() == "indovina parola")
            {
                
            }
            else if (cosa == "c" || cosa.ToLower() == "indizi limitati")
            {
                
            }
            else if (cosa == "d" || cosa.ToLower() == "oggetti jolly")
            {
                
            }
            else
            {
                Console.WriteLine("Hai sbagliato a scrivere");
            }
            if(ntentativi == 0)
            {
                Console.WriteLine("Hai esaurito i tentativi!!! La parola era " + parola);
                j = false;
            }
            Console.WriteLine("------------------------------------------");
        }
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
Console.WriteLine(parola);
Console.WriteLine(ntentativi);
