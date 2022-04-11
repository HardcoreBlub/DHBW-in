﻿using System.Collections.Generic;

namespace DHB_Win.Models
{
    public partial class Bet
    {
        public Bet()
        {
            BetOptions = new HashSet<BetOption>();
        }

        public int BetId { get; set; }
        public int UidFk2 { get; set; }
        public string? Title { get; set; }
        public int? ExpPoints { get; set; }
        public int? Reward { get; set; }
        public string? Description { get; set; }

        public virtual User UidFk2Navigation { get; set; } = null!;
        public virtual Placement Placement { get; set; } = null!;
        public virtual ICollection<BetOption> BetOptions { get; set; }
    }
}