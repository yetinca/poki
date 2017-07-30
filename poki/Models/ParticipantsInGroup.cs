namespace poki.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ParticipantsInGroup
    {
    public ParticipantsInGroup()
    {
      Results = new HashSet<Results>();
    }
        public int ID { get; set; }

        public int GroupsID { get; set; }

        public int ParticipantsID { get; set; }

        public virtual Groups Groups { get; set; }

        public virtual Participants Participants { get; set; }

        public virtual ICollection<Results> Results { get; set; }
    }
}
