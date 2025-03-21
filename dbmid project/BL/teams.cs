using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dbmid_project.BL
{
    internal class teams
    {
        public string team_name;
        public string eventn;
        public List<string> participants;
        // Constructor to initialize the team and participants list
        public teams(string teamName, string eventName, List<string> participantNames)
        {
            team_name = teamName;
            eventn = eventName;
            participants = participantNames; // Initialize the participants list
        }
    }
}
