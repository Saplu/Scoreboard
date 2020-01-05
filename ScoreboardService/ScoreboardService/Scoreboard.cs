using System;
using System.Collections.Generic;
using System.Linq;

namespace ScoreboardService
{
    public class Scoreboard : IScoreboard
    {
        private List<Player> _players;

        public List<Player> Players { get => _players; }

        public Scoreboard()
        {
            _players = new List<Player>();
        }

        public Scoreboard(List<Player> players)
        {
            _players = players;
        }

        public void AddPlayer(string name, int score)
        {
            var player = new Player(name, score);
            _players.Add(player);
        }

        public void SortByScore(bool descending = true)
        {
            if (descending)
            {
                _players = _players.OrderByDescending(p => p.Score).ToList();
            }
            else _players = _players.OrderBy(p => p.Score).ToList();
        }
    }
}
