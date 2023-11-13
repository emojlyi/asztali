using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main()
    {
        List<Telek> telekLista = Beolvas("utca.txt");

        Console.WriteLine("2. feladat. A mintában " + telekLista.Count + " telek szerepel.");

        Console.Write("3. feladat. Kérjen be egy tulajdonos adószámát: ");
        int adoszam = int.Parse(Console.ReadLine());
        Telek talaltTelek = KeressTelek(telekLista, adoszam);
        if (talaltTelek != null)
        {
            Console.WriteLine(talaltTelek.Utca + " " + talaltTelek.Hazszam);
        }
        else
        {
            Console.WriteLine("Nem szerepel az adatállományban.");
        }

        Console.WriteLine("5. feladat");
        Dictionary<char, int> adosavok = SzamolAdoSavok(telekLista);
        foreach (var kvp in adosavok)
        {
            Console.WriteLine(kvp.Key + " sávba " + kvp.Value + " telek esik, az adó " + SzamolAdo(kvp.Key, telekLista) + " Ft.");
        }

        Console.WriteLine("6. feladat. A több sávba sorolt utcák:");
        List<string> tobbsavosUtcak = SzamolTobbsavosUtcak(telekLista);
        foreach (var utca in tobbsavosUtcak)
        {
            Console.WriteLine(utca);
        }

        AdoMentes(telekLista);
        Console.ReadKey();
    }

    static List<Telek> Beolvas(string fajlnev)
    {
        List<Telek> telekLista = new List<Telek>();
        string[] sorok = File.ReadAllLines(fajlnev);
        string[] adoSavok = sorok[0].Split(' ');
        char[] adoSavokChar = { 'A', 'B', 'C' };
        for (int i = 1; i < sorok.Length; i++)
        {
            string[] adatok = sorok[i].Split(' ');
            int adoszam = int.Parse(adatok[0]);
            string utca = adatok[1];
            string hazszam = adatok[2];
            char adosav = char.Parse(adatok[3]);
            int alapterulet = int.Parse(adatok[4]);
            telekLista.Add(new Telek(adoszam, utca, hazszam, adosav, alapterulet));
        }
        return telekLista;
    }

    static Telek KeressTelek(List<Telek> telekLista, int adoszam)
    {
        foreach (var telek in telekLista)
        {
            if (telek.AdoSzam == adoszam)
            {
                return telek;
            }
        }
        return null;
    }

    static Dictionary<char, int> SzamolAdoSavok(List<Telek> telekLista)
    {
        Dictionary<char, int> adoSavok = new Dictionary<char, int>();
        foreach (var telek in telekLista)
        {
            if (!adoSavok.ContainsKey(telek.AdoSav))
            {
                adoSavok[telek.AdoSav] = 1;
            }
            else
            {
                adoSavok[telek.AdoSav]++;
            }
        }
        return adoSavok;
    }

    static int SzamolAdo(char adosav, List<Telek> telekLista)
    {
        int adoSavAdo = 0;
        foreach (var telek in telekLista)
        {
            if (telek.AdoSav == adosav)
            {
                adoSavAdo += Ado(telek.AdoSav, telek.Alapterulet);
            }
        }
        return adoSavAdo;
    }

    static List<string> SzamolTobbsavosUtcak(List<Telek> telekLista)
    {
        List<string> tobbsavosUtcak = new List<string>();
        Dictionary<string, List<char>> utcaAdoSavok = new Dictionary<string, List<char>>();
        foreach (var telek in telekLista)
        {
            if (!utcaAdoSavok.ContainsKey(telek.Utca))
            {
                utcaAdoSavok[telek.Utca] = new List<char>();
            }
            if (!utcaAdoSavok[telek.Utca].Contains(telek.AdoSav))
            {
                utcaAdoSavok[telek.Utca].Add(telek.AdoSav);
            }
        }
        foreach (var kvp in utcaAdoSavok)
        {
            if (kvp.Value.Count > 1)
            {
                tobbsavosUtcak.Add(kvp.Key);
            }
        }
        return tobbsavosUtcak;
    }

    static int Ado(char adosav, int alapterulet)
    {
        Dictionary<char, int> adoSavok = new Dictionary<char, int>()
        {
            { 'A', 800 },
            { 'B', 600 },
            { 'C', 100 }
        };

        int ado = alapterulet * adoSavok[adosav];
        return ado > 10000 ? ado : 0;
    }

    static void AdoMentes(List<Telek> telekLista)
    {
        StreamWriter sw = new StreamWriter("fizetendo.txt");
        foreach (var telek in telekLista)
        {
            int ado = Ado(telek.AdoSav, telek.Alapterulet);
            if (ado > 0)
            {
                sw.WriteLine(telek.AdoSzam + " " + ado);
            }
        }
        sw.Close();
    }
}

class Telek
{
    public int AdoSzam { get; set; }
    public string Utca { get; set; }
    public string Hazszam { get; set; }
    public char AdoSav { get; set; }
    public int Alapterulet { get; set; }

    public Telek(int adoszam, string utca, string hazszam, char adosav, int alapterulet)
    {
        AdoSzam = adoszam;
        Utca = utca;
        Hazszam = hazszam;
        AdoSav = adosav;
        Alapterulet = alapterulet;
    }
}

