using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N.H.T_Game
{
    public class Score
    {
        private string level;
        private string name;
        private int score;
        private string dateTime;

        public string Level
        {
            get { return level; }
            set { level = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Score1
        {
            get { return score; }
            set { score = value; }
        }

        public string DateTime
        {
            get { return dateTime; }
            set { dateTime = value; }
        }
    }
}
