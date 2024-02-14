using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.IO;

namespace WPFKifir
{
    public class Diak : IFelvetelizo
    {
        string azonosito;
        string nev;
        string email;
        DateTime szuletesiEv;
        string ertcim;
        int matekPontszam;
        int magyarPontszam;
        public Diak(string sor)
        {
            string[] tomb = sor.Split(";");
            azonosito = tomb[0];
            nev = tomb[1];
            email = tomb[2];
            szuletesiEv = DateTime.Parse(tomb[3]);
            
            ertcim = tomb[4];
            matekPontszam = tomb[5] == "NULL" ? -1 : int.Parse(tomb[5]);
            magyarPontszam = tomb[6] == "NULL" ? -1 : int.Parse(tomb[6]);

        }
        public Diak(){}
        public String OM_Azonosito { get => azonosito; set => azonosito = value; }
        public String Neve  { get => nev; set => nev = value; }
        public String Email { get => email; set => email = value; }
        public DateTime SzuletesiDatum { get => szuletesiEv; set => szuletesiEv = value; }
        public string ErtesitesiCime { get => ertcim; set => ertcim = value; }
        public int Matematika { get => matekPontszam; set => matekPontszam = value; }
        public int Magyar { get => magyarPontszam; set => magyarPontszam = value; }

        public String CSVSortAdVissza() => $"{OM_Azonosito};{Neve};{Email};{SzuletesiDatum.Year}-{SzuletesiDatum.Month}-{SzuletesiDatum.Day};{ErtesitesiCime};{Matematika};{Magyar}";

        public void ModositCSVSorral(String csvString)
        {
            string[] tomb = csvString.Split(';');
            azonosito = tomb[0];
            nev = tomb[1];
            email = tomb[2];
            szuletesiEv = DateTime.Parse(tomb[3]);
            ertcim = tomb[4];
            matekPontszam = tomb[5] == "NULL" ? -1 : int.Parse(tomb[5]);
            magyarPontszam = tomb[6] == "NULL" ? -1 : int.Parse(tomb[6]);
        }
    }
}
