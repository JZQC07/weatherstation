using System;
using System.Collections.Generic;

namespace weatherstation
{
    public class Program
    {
        public static void Menu()
        {
            while (true)
            {
                Console.WriteLine("Välkommen till väderstationen!");
                Console.WriteLine("Välj vad du vill göra.");
                Console.WriteLine("[L]ägg till temperaturmätning");
                Console.WriteLine("[S]kriv ut alla temperaturer");
                Console.WriteLine("[T]a bort temperaturmätning");
                Console.WriteLine("[A]vsluta");

                string menyval = Console.ReadLine().ToUpper();
                switch (menyval)
                {
                    case "L":
                        Console.Clear();
                        City.Add_temperature();
                        break;

                    case "S":
                        Console.Clear();
                        City.Print();
                        break;

                    case "T":
                        Console.Clear();
                        City.Remove();
                        break;

                    case "A":
                        Console.Clear();
                        Console.WriteLine("Tryck valfri tangent för att avsluta programmet...");
                        Console.ReadKey();
                        Environment.Exit(0);
                        break;

                    default:
                        Console.Clear();
                        Console.WriteLine("Du gjorde en konstig inmatning? Prova igen!");
                        break;
                }
            }
        }
        public static void Main(string[] args)
        {
            City.Stader();
            Menu();
        }
    }
    public class City
    {
        public static List<string> stader = new List<string>();
        public static List<int> temperatur = new List<int>();
        public static void Stader()
        {
            stader.Add("Stockholm"); stader.Add("Madrid"); stader.Add("Köpenhamn"); stader.Add("Oslo"); stader.Add("Rom");
            stader.Add("Amsterdam"); stader.Add("London"); stader.Add("Washington DC"); stader.Add("Helsinfgors");
        }
        
        public City() //Konstruktor
        {

        }
        public static void Names() //Lägger till valfria namn för städer i listan
        {

        }
        public static void Add_temperature() //Lägger till temperaturen för den specifika staden
        {
            while (true)
            {
                Console.WriteLine("Vill du välja mellan en stad i listan? Eller vill du lägga till en egen stad?");
                Console.WriteLine("1: Välj stad i listan");
                Console.WriteLine("2: Lägg till egen stad");
                string stadsval = Console.ReadLine();
                if (stadsval == "1")
                {
                    Stadslista();
                    
                }
                else if (stadsval == "2")
                {
                    
                    Add_city();
                    
                }
                else
                {
                    Console.WriteLine("Fel inmatning! Välj mellan [1] eller [2]!");
                }
            }
        }
        public static void Add_city()
        {
            while (true)
            {
                Console.WriteLine("Mata in namn på staden du vill lägga till.");
                stader.Add(Console.ReadLine());
                Console.WriteLine("Lägg till en ny stad? Eller gå tillbaka till menyn?");
                Console.WriteLine("[L] / [M] ?");
                string val = Console.ReadLine().ToUpper();
                if (val == "L")
                {
                    Add_city();
                }
                else if (val == "M")
                {
                    Program.Menu();
                }
                else
                {
                    Console.WriteLine("Jag förstod inte, mata in [M] eller [L]");
                }
            }
        }
        public static void Stadslista()
        {
            Console.WriteLine("Vilken stad vill du lägga till temperatur för?");
            for (int i = 0; i < stader.Count; i++)
            {
                Console.WriteLine(i + 1 + " " + stader[i]);
            }

        }
        public static void Print()
        {
            foreach (string i in stader)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();
            Console.WriteLine("Tryck valfri tangent för att gå tillbaka till menyn.");
            Console.ReadKey();
            Program.Menu();
        }
        public static void Remove()
        {

        }
    }
}
