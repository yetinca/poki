namespace poki.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class GroupsOfParticipants
  {
    public GroupsOfParticipants()
    {

    }
        public int ID { get; set; }

        public int GroupID { get; set; }

        public int ParticipantID { get; set; }

        public virtual Groups Groups { get; set; }

        public virtual Participants Participants { get; set; }
    }
}
