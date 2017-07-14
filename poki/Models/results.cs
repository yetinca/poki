namespace poki.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class results

    {
        public results()
    {

    }

        public int ID { get; set; }

        public int ParticipantID { get; set; }

        public DateTime StartTime { get; set; }

        public DateTime EndTime { get; set; }

        public short Pytanie1 { get; set; }

        public short Pytanie2 { get; set; }

        public short Pytanie3 { get; set; }

        public virtual Persons Persons { get; set; }
    }
}
