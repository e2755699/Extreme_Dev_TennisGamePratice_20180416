﻿using System.Collections.Generic;

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
            if (_firstPlayerScore != _secondPlayerScore)
            {
                return _scoreLookup[_firstPlayerScore] + " " + _scoreLookup[_secondPlayerScore];
            }
            if (_secondPlayerScore > 0)
            {
                return "Love " + _scoreLookup[_secondPlayerScore];
            }
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

        public void SecondPlayerScore()
        {
            _secondPlayerScore++;
        }
    }
}