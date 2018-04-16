using System.Collections.Generic;

namespace Extreme_Dev_TennisGamePratice_20180416
{
    public class TennisGame
    {
        private int _firstPlayerScore;

        public string Scroe()
        {
            var scoreLookup = new Dictionary<int, string>
            {
                {1, "Fifteen"},
                {2, "Thirty"}
            };
            if (_firstPlayerScore > 0)
            {
                return scoreLookup[_firstPlayerScore] + " Love";
            }
            return "Love All";
        }

        public void FirstPlayerScore()
        {
            _firstPlayerScore++;
        }
    }
}