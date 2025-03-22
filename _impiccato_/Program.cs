Random random = new Random();
string stampaparola(string x, ref int n,  ref int punti)
{
    string[] lines = File.ReadAllLines(x); // Legge tutte le righe e le mette in un vettore
    bool e = false;
    int i = 0, j = 0, l = 0;
    while (e == false)
    {
        Console.WriteLine("Scegli la difficoltà: \n a) Facile (5 tentativi) \n b) Medio (7 tentativi)  \n c) Difficile (10 tentativi)");
        string difficolta = Console.ReadLine();
        difficolta = difficolta.ToLower();
        if (difficolta == "facile" || difficolta == "a")
        {
            j = 5;
            l = 9;
            e = true;
            n = 5;
            punti = 3;
        }
        else if (difficolta == "medio" || difficolta == "b")
        {
            i = 5;
            j = 10;
            l = 8;
            e = true;
            n = 7;
            punti = 5;
        }
        else if (difficolta == "difficile" || difficolta == "c")
        {
            i = 10;
            j = 15;
            l = 12;
            e = true;
            n = 10;
            punti = 7;
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
void provalettera(ref string[] par, string[] r, string parola, ref int ntentativi, ref string lettere_provate)
{
    Console.WriteLine("Inserisci lettera (se sbagli sprechi un tentativo)");
    string l = Console.ReadLine();
    lettere_provate = lettere_provate + l + ", ";
    if (parola.Contains(l) == true)
    {
        Console.WriteLine("Hai indovinato la lettera!");
        for (int i = 0; i < r.Length; i++)
        {
            if (r[i] == l)
            {
                par[i] = l;
            }
        }
    }
    else
    {
        Console.WriteLine("Non hai indovinato la lettera!");
        ntentativi--;
    }
}
void stamparray(string[] a)
{
    for (int i = 0; i < a.Length; i++)
    {
        Console.Write(a[i]);
    }
    Console.WriteLine();
}
void provaparola(string parola, ref bool e, ref int n, ref string paroleindovinate)
{
    Console.WriteLine("Dimmi parola");
    string s = Console.ReadLine();
    if (s == parola)
    {
        Console.WriteLine("Hai indovinato!");
        paroleindovinate = paroleindovinate + parola + ", ";
        e = false;
    }
    else
    {
        Console.WriteLine("Hai sbagliato!");
        n--;
    }
}
void indizilimitati(ref string[] par, string[] r, ref int ntentativi)
{
    bool e = false;
    while (e == false)
    {
        Console.WriteLine("Quale lettere vuoi sapere? ti ricordo che ogni lettera costa un tentativo \n a) la prima \n b) l'ultima \n c) entrambe le lettere");
        string i = Console.ReadLine();
        if (i == "a")
        {
            par[0] = r[0];
            e = true;
            ntentativi--;
        }
        else if (i == "b")
        {
            par[par.Length - 1] = r[par.Length - 1];
            e = true;
            ntentativi--;
        }
        else if (i == "c")
        {
            par[par.Length - 1] = r[par.Length - 1];
            par[0] = r[0];
            e = true;
            ntentativi--;
            ntentativi--;
        }
        else
        {
            Console.WriteLine("Hai sbagliato a scrivere");
        }
    }
}
Console.WriteLine("Benvenuto nel gioco dell'impiccato \nOgni parola facile indovinata ti fa guadagnare 3 punti, ogni parola media 5 e ogni parola difficile 7");
string parola = "";
int punti = 0;
int puntitot = 0;
int ntentativi = 0;
bool y = true;
string paroleindovinate = "";
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
                parola = stampaparola(x, ref ntentativi, ref punti);
                o = true;
            }
            else if (tema == "serie" || tema == "d")
            {
                string x = "Serie.txt";
                parola = stampaparola(x, ref ntentativi, ref punti);
                o = true;
            }
            else if (tema == "film" || tema == "c")
            {
                string x = "Film.txt";
                parola = stampaparola(x, ref ntentativi, ref punti);
                o = true;
            }
            else if (tema == "cantanti" || tema == "b")
            {
                string x = "Cantanti.txt";
                parola = stampaparola(x, ref ntentativi, ref punti);
                o = true;
            }
            else
            {
                Console.WriteLine("Hai sbagliato a scrivere");
            }
        }
        string[] r = new string[parola.Length];
        for (int i = 0; i < parola.Length; i++)
        {
            r[i] = parola[i].ToString();
        }
        string[] par = new string[parola.Length];
        trattini(parola, ref par);
        stamparray(par);
        string lettere_provate = "";
        bool j = true;
        while (j == true)
        {
            Console.WriteLine("Dimmi cosa vuoi fare ora: \n a) Prova lettera \n b) Indovina parola \n c) Indizi limitati (A scelta tra prima, ultima lettera o entrambe. Ogni lettera ti costa un tentativo)");
            string cosa = Console.ReadLine();
            Console.WriteLine("I tentativi rimasti sono " + ntentativi);
            if (cosa == "a" || cosa.ToLower() == "prova lettera")
            {

                provalettera(ref par, r, parola, ref ntentativi, ref lettere_provate);
                stamparray(par);
                if (lettere_provate == "")
                {
                    Console.WriteLine("Ancora non hai provato nessuna lettera");
                }
                else
                {
                    Console.WriteLine("Le lettere provate sono: " + lettere_provate);
                }
            }
            else if (cosa == "b" || cosa.ToLower() == "indovina parola")
            {
                provaparola(parola, ref j, ref ntentativi, ref paroleindovinate);
            }
            else if (cosa == "c" || cosa.ToLower() == "indizi limitati")
            {
                indizilimitati(ref par, r, ref ntentativi);
                stamparray(par);
            }
            else
            {
                Console.WriteLine("Hai sbagliato a scrivere");
            }
            int u = 0;
            for (int i = 0; i < par.Length; i++)
            {
                if (par[i] == r[i])
                {
                    u++;
                }
            }
            if (u == r.Length)
            {
                Console.WriteLine("Hai indovinato!!!");
                paroleindovinate = paroleindovinate + parola + ", ";
                puntitot = puntitot + punti;
                j = false;
            }
            if (ntentativi == 0)
            {
                Console.WriteLine("Hai esaurito i tentativi!!! La parola era " + parola);
                j = false;
            }
            Console.WriteLine("------------------------------------------");
        }
    }
    else if (mossa.ToLower() == "b")
    {
        if(paroleindovinate == "")
        {
            Console.WriteLine("Non hai ancora indovinato nessuna parola!");
        }
        else
        {
            Console.WriteLine("Le parole indovinate sono: " + paroleindovinate);
        }
    }
    else if (mossa.ToLower() == "c")
    {
        if (paroleindovinate == "")
        {
            Console.WriteLine("Non hai ancora indovinato nessuna parola!");
        }
        else
        {
            Console.WriteLine("Le parole indovinate sono: " + paroleindovinate);
        }
        Console.WriteLine("Arrivederci, i tuoi punti sono " + punti);
        y = false;
    }
    else
    {
        Console.WriteLine("Hai sbagliato a scrivere");
    }
}