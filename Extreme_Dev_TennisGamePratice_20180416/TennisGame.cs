using System.Collections.Generic;

namespace Extreme_Dev_TennisGamePratice_20180416
{
    public class TennisGame
    {
        private int _firstPlayerScore;

        private Dictionary<int, string> _scoreLookup = new Dictionary<int, string>
        {
            {0, "Love"},
            {1, "Fifteen"},
            {2, "Thirty"},
            {3, "Forty"},
        };

        private int _secondPlayerScore;

        public string Scroe()
        {
            if (_firstPlayerScore == 1 && _secondPlayerScore == 1)
            {
                return "Fifteen All";
            }
            if (_firstPlayerScore != _secondPlayerScore)
            {
                return _scoreLookup[_firstPlayerScore] + " " + _scoreLookup[_secondPlayerScore];
            }
            return "Love All";
        }

        public void FirstPlayerScore()
        {
            _firstPlayerScore++;
        }

        public void SecondPlayerScore()
        {
            _secondPlayerScore++;
        }
    }
}