using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security.Principal;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Program
{
    class Methods
    {
        #region Properties
        public static int fiveOrMore;

        public readonly static string[] championNames =
        { "Aatrox", "Ahri", "Akali", "Akshan", "Alistar", "Amumu", "Anivia", "Annie", "Aphelios", "Ashe",
        "Aurelion Sol", "Azir", "Bard", "Bel'Veth", "Blitzcrank", "Brand", "Braum", "Briar", "Caitlyn",
        "Camille", "Cassiopeia", "Cho'Gath", "Corki", "Darius", "Diana", "Draven", "Dr. Mundo", "Ekko",
        "Elise", "Evelynn", "Ezreal", "Fiddlesticks", "Fiora", "Fizz", "Galio", "Gangplank", "Garen",
        "Gnar", "Gragas", "Graves", "Gwen", "Hecarim", "Heimerdinger", "Hwei", "Illaoi", "Irelia",
        "Ivern", "Janna", "Jarvan IV", "Jax", "Jayce", "Jhin", "Jinx", "Kai'Sa", "Kalista", "Karma",
        "Karthus", "Kassadin", "Katarina", "Kayle", "Kayn", "Kennen", "Kha'Zix", "Kindred", "Kled",
        "Kog'Maw", "K'Sante", "LeBlanc", "Lee Sin", "Leona", "Lillia", "Lissandra", "Lucian", "Lulu",
        "Lux", "Malphite", "Malzahar", "Maokai", "Master Yi", "Milio", "Miss Fortune", "Wukong", "Mordekaiser",
        "Morgana", "Naafiri", "Nami", "Nasus", "Nautilus", "Neeko", "Nidalee", "Nilah", "Nocturne",
        "Nunu & Willump", "Olaf", "Orianna", "Ornn", "Pantheon", "Poppy", "Pyke", "Qiyana", "Quinn",
        "Rakan", "Rammus", "Rek'Sai", "Rell", "Renata Glasc", "Renekton", "Rengar", "Riven", "Rumble",
        "Ryze", "Samira", "Sejuani", "Senna", "Seraphine", "Sett", "Shaco", "Shen", "Shyvana", "Singed",
        "Sion", "Sivir", "Skarner", "Smolder", "Sona", "Soraka", "Swain", "Sylas", "Syndra", "Tahm Kench",
        "Taliyah", "Talon", "Taric", "Teemo", "Thresh", "Tristana", "Trundle", "Tryndamere", "Twisted Fate",
        "Twitch", "Udyr", "Urgot", "Varus", "Vayne", "Veigar", "Vel'Koz", "Vex", "Vi", "Viego", "Viktor",
        "Vladimir", "Volibear", "Warwick", "Xayah", "Xerath", "Xin Zhao", "Yasuo", "Yone", "Yorick", "Yuumi",
        "Zac", "Zed", "Zeri", "Ziggs", "Zilean", "Zoe", "Zyra" };
        #endregion

        #region Math
        public static void ProgressBar(int ticks, int progressValue, int maxValue)
        {
            double result = Convert.ToDouble(progressValue / Convert.ToDouble(maxValue)) * 100;
            int printBar = Convert.ToInt32(result) / (ticks / 4);

            int equalsNumber = printBar;
            int whiteSpaceNumber = ticks - printBar;

            if (equalsNumber >= ticks)
            {
                equalsNumber = ticks;
            }

            Console.Write("[");
            for (int i = 0; i < equalsNumber; i++)
            {
                Console.Write("=");
            }
            for (int i = 0; i < whiteSpaceNumber; i++)
            {
                Console.Write(" ");
            }
            Console.Write("]");
            Console.Write(result.ToString(" 00.00") + "%");
        }
        public static string[] arraySubstraction(string[] biggerArray, string[] smallerArray)
        {
            List<string> biggerList = new List<string>(biggerArray);

            foreach (string str in smallerArray)
            {
                biggerList.Remove(str);
            }

            return biggerList.ToArray();
        }
        #endregion

        #region Commands
        public static void Display(string type)
        {
            Console.Clear();

            switch (type)
            {
                case "DISPLAY ALL":
                    Console.Clear();
                    foreach (Champion champion in Program._Champions)
                    {
                        ProgressBar(20, champion.ChampionPoints, 21600);
                        Console.WriteLine(" " + champion.ChampionName);
                    }
                    break;
                case "DISPLAY DONE":
                    foreach (Champion champion in Program._Champions)
                    {
                        if (champion.ChampionPoints >= 21600)
                        {
                            ProgressBar(20, champion.ChampionPoints, 21600);
                            Console.WriteLine(" " + champion.ChampionName);
                        }
                    }
                    break;
                case "DISPLAY MISSING":
                    foreach (Champion champion in Program._Champions)
                    {
                        if (champion.ChampionPoints < 21600)
                        {
                            ProgressBar(20, champion.ChampionPoints, 21600);
                            Console.WriteLine(" " + champion.ChampionName);
                        }
                    }
                    break;
            }
            Console.WriteLine("\n");
            Console.WriteLine("Press ENTER to return to menu.");
            Console.ReadLine();
            MenuMeneger.Menu();
        }

        public static void Help()
        {
            Console.Clear();
            string fileContent;
            using (StreamReader reader = new StreamReader(Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.ToString(), "MenuMeneger.cs")))
            {
                fileContent = reader.ReadToEnd();
            }

            string switchBlock = fileContent.Substring(fileContent.IndexOf("switch (command)"), fileContent.IndexOf("default:") - fileContent.IndexOf("switch (command)"));

            string[] commands = System.Text.RegularExpressions.Regex.Matches(switchBlock, @"case ""([^""]+)""").Cast<System.Text.RegularExpressions.Match>().Select(m => m.Groups[1].Value).ToArray();

            foreach (string command in commands)
            {
                Console.WriteLine(command);
            }

            Console.WriteLine("\n");
            Console.WriteLine("Press ENTER to return to menu.");
            Console.ReadLine();
            MenuMeneger.Menu();
        }

        public static void Disconnect()
        {
            Program.Main();
        }
        public static void Exit()
        {
            Environment.Exit(0);
        }

        public static void Compare()
        {
            List<string> ara = ApiService.getPointsFromMatch();
            foreach (string line in ara)
            {
                Console.WriteLine(line);
            }
        }
        #endregion
    }
}