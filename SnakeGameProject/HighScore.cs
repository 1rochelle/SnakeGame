using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGameProject
{
    public static class HighScore
    {
        public static string Name { get; set; }
        public static int Score { get; set; }
        public static int Rank { get; }

        //public HighScore()
        //{

        //}

        //public HighScore(int score, string name)
        //{
        //    Name = name;
        //    Score = score;

        //}
        public static Dictionary<string, int> UserHighScores { get; set; }
        //call this method upon player death
        // -----Beginning of test code!!-----


        public static int nameCount { get; set; }
        public static string ShowPlayerScore(string name, int score)
        {
            string user = "";
            foreach (var playerName in UserHighScores.Keys)
            {
                if (playerName != name)
                {
                    nameCount++;
                    UserHighScores.Add(name, score);
                    return user = $"{name} {score}";
                }
                else
                {
                    nameCount++;
                    UserHighScores.Add(name + $"{nameCount}", score);
                    return user = $"{name} {score}";
                }
            }
            return user;
        }


        //public static void ShowPlayerResults(Dictionary<string, int> highScoreResults)
        //{

        //}
        //public static void DoingSomething()
        //{
        //    foreach (var player in UserHighScores.Values)
        //    {
        //        Console.WriteLine(player);
        //    }
        //}
    }
}
