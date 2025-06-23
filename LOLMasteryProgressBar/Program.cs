using System;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Xml.Serialization;


namespace Program
{
    public class Program
    {
        public const string ApiKey = "";
        public static List<Champion> _Champions = new List<Champion>();
        public static string Nickname { get; set; }
        public static string Tag { get; set; }
        public static string Puuid { get; set; }
        public static void Main()
        {
            Methods.fiveOrMore = 0;
            Console.Clear();
            MenuMeneger.UserService();
            _Champions = ApiService.getPoints(Nickname, Tag);
            MenuMeneger.Menu(true);
        }
    }
}
