using Newtonsoft.Json;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Numerics;
using System.Threading.Tasks;

namespace Program
{
    public class ApiService
    {
        public static List<Champion> getPoints(string nick, string tag)
        {
            List<Champion> champions = new List<Champion>();

            Task<string> puuidTask = GetPuuidAPI(Program.ApiKey, nick, tag);
            puuidTask.Wait();
            string puuid = puuidTask.Result;
            Program.Puuid = puuid;

            Task<Dictionary<int, int>> pointsTask = GetPointsAPI(Program.ApiKey, puuid);
            pointsTask.Wait();
            Dictionary<int, int> masteryPoints = pointsTask.Result;

            List<Champion> Champions = new List<Champion>();

            foreach (var item in masteryPoints)
            {
                Champion champion = new Champion(item.Key, item.Value);
                Champions.Add(champion);
            }

            string[] createdNames = new string[Champions.Count()];
            int index = 0;

            foreach (Champion champion in Champions)
            {
                createdNames[index] = champion.ChampionName;
                index++;
            }

            string[] notCreatedNames = Methods.arraySubstraction(Methods.championNames, createdNames);

            foreach (string name in notCreatedNames)
            {
                Champion champion = new Champion(championId: 0, championPoints: 0, championName: name);
                Champions.Add(champion);
            }

            foreach (var item in Champions)
            {
                champions.Add(item);
            }

            return champions;
        }

        //public static Dictionary<string, List<Champion>> getPointsFromMatch()
        //{

        //}
        public static List<string> getPointsFromMatch()
        {
            Task<List<string>> nameTask = GetNamesFromMatchAPI(Program.ApiKey, Program.Puuid);
            nameTask.Wait();
            List<string> names = nameTask.Result;
            return names;

        }
        public static async Task<string> GetPuuidAPI(string apiKey, string nick, string tag)
        {
            using (var httpClient = new HttpClient())
            {
                string apiUrl = $"https://europe.api.riotgames.com/riot/account/v1/accounts/by-riot-id/{nick}/{tag}?api_key={apiKey}";

                HttpResponseMessage response = await httpClient.GetAsync(apiUrl);

                if (response.IsSuccessStatusCode)
                {
                    string jsonResponse = await response.Content.ReadAsStringAsync();
                    dynamic responseData = JsonConvert.DeserializeObject(jsonResponse);
                    string puuid = responseData.puuid;
                    return puuid;
                }
                else
                {
                    return "error";
                }
            }
        }

        public static async Task<Dictionary<int, int>> GetPointsAPI(string apiKey, string puuid)
        {
            Dictionary<int, int> masteryPoints = new Dictionary<int, int>();

            using (var httpClient = new HttpClient())
            {

                string apiUrl = $"https://eun1.api.riotgames.com/lol/champion-mastery/v4/champion-masteries/by-puuid/" +
                    $"{puuid}?api_key={apiKey}";

                HttpResponseMessage response = await httpClient.GetAsync(apiUrl);

                string responseBody = await response.Content.ReadAsStringAsync();

                var pointList = Newtonsoft.Json.JsonConvert.DeserializeObject<List<dynamic>>(responseBody);

                foreach (var item in pointList)
                {
                    int championId = item.championId;
                    int masteryPointsItem = item.championPoints;
                    masteryPoints.Add(championId, masteryPointsItem);
                }

                return masteryPoints;
            }
        }
        public static async Task<List<string>> GetNamesFromMatchAPI(string apiKey, string puuid)
        {
            List<string> puuidList = new List<string>();

            using (var httpClient = new HttpClient())
            {
                string apiUrl = $"https://eun1.api.riotgames.com/lol/spectator/v5/active-games/by-summoner/" +
                    $"{puuid}?api_key={apiKey}";

                HttpResponseMessage response = await httpClient.GetAsync(apiUrl);

                string responseBody = await response.Content.ReadAsStringAsync();

                var playerList = Newtonsoft.Json.JsonConvert.DeserializeObject<List<dynamic>>(responseBody);

                foreach (var player in playerList)
                {
                    puuidList.Add(player.puuid);
                }

                return puuidList;

            }
        }

    }

}

