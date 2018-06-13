using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDSL.ClassLibrary
{
    public class Game
    {
        private string gameNumber;

        private string homeTeam;

        private string homeGoals;

        private string awayTeam;

        private string awayGoals;

        public string AwayGoals
        {
            get { return awayGoals; }
            set { awayGoals = value; }
        }


        public string AwayTeam
        {
            get { return awayTeam; }
            set { awayTeam = value; }
        }


        public string HomeGoals
        {
            get { return homeGoals; }
            set { homeGoals = value; }
        }


        public string HomeTeam
        {
            get { return homeTeam; }
            set { homeTeam = value; }
        }


        public string GameNumber
        {
            get { return gameNumber; }
            set { gameNumber = value; }
        }

    }
}
