namespace poki.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Results

    {
        public Results()
    {

    }

        public int ID { get; set; }

        public int ParticipantsInGroupID { get; set; }

        public DateTime StartTime { get; set; }

        public DateTime EndTime { get; set; }

        public short Pytanie1 { get; set; }

        public short Pytanie2 { get; set; }

        public short Pytanie3 { get; set; }

        public short Pytanie4 { get; set; }

        public short Pytanie5 { get; set; }

        public virtual ParticipantsInGroup ParticipantsInGroup { get; set; }
    }
}
