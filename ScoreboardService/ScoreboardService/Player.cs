using System;
using System.Collections.Generic;
using System.Text;

namespace ScoreboardService
{
    public class Player
    {
        private string _name;
        public string Name { get => _name; set => SetName(value); }
        public int Score { get; set; }

        public Player(string name, int score)
        {
            SetName(name);
            Score = score;
        }

        private void SetName(string name)
        {
            if (name.Length > 0)
                _name = name;
            else throw new ArgumentException("Name must contain at least 1 character.");
        }

        public override bool Equals(object obj)
        {
            var toCompareWith = obj as Player;
            if (toCompareWith != null)
            {
                if (toCompareWith.Name == this.Name &&
                    toCompareWith.Score == this.Score)
                    return true;
            }
            return false;
        }

        public override int GetHashCode()
        {
            var hashCode = -980142008;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(_name);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Name);
            hashCode = hashCode * -1521134295 + Score.GetHashCode();
            return hashCode;
        }
    }
}
