using System.Collections.Generic;

namespace Extreme_Dev_TennisGamePratice_20180416
{
    public class TennisGame
    {
        private int _firstPlayerScore;

        private Dictionary<int, string> _scoreLookup = new Dictionary<int, string>
        {
            {1, "Fifteen"},
            {2, "Thirty"},
            {3, "Forty"}
        };

        public string Scroe()
        {
            if (_firstPlayerScore > 0)
            {
                return _scoreLookup[_firstPlayerScore] + " Love";
            }
            return "Love All";
        }

        public void FirstPlayerScore()
        {
            _firstPlayerScore++;
        }
    }
}