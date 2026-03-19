using System.Text.Json;

namespace _2048
{
    internal class SaveScore
    {
        public static string path = "SaveBestScore";
        public static void Save(int score)
        {
            if (!File.Exists(path))
            {
                File.Create(path);
            }

            if (score > GetScore())
            {
                string savejson = JsonSerializer.Serialize(score);
                File.WriteAllText(path, savejson);
            }
        }
        public static int GetScore()
        {
            if (!File.Exists(path))
            {
                File.Create(path);
            }
            string savejson = File.ReadAllText(path);
            int score = 0;
            if (!string.IsNullOrWhiteSpace(savejson))
            {
                score = JsonSerializer.Deserialize<int>(savejson);
            }
            return score;
        }
    }
}
