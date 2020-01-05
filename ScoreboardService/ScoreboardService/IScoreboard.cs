using System;
using System.Collections.Generic;
using System.Text;

namespace ScoreboardService
{
    public interface IScoreboard
    {
        List<Player> Players { get; }
        void AddPlayer(string name, int score);
        void SortByScore(bool descending = true);
    }
}
