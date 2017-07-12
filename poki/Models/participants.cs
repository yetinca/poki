namespace poki.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class participants
    {
        public int ID { get; set; }

        public int GrupaID { get; set; }

        public int PersonID { get; set; }

        public virtual groups groups { get; set; }

        public virtual Persons Persons { get; set; }
    }
}
