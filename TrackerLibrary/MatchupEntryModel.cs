using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    /// <summary>
    /// represents one team in the matchup.
    /// </summary>
    public class MatchupEntryModel
    {
        public TeamModel TeamCompeting { get; set; }

        /// <summary>
        /// represents score for this particular team.
        /// </summary>
        public double Score { get; set; }

        /// <summary>
        /// represents the matchup that this team came 
        /// from as the winner.
        /// </summary>
        public MatchupModel ParentMatchup { get; set; }
    }
}
