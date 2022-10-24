using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayers.Concrete
{
    public class TBLISLER
    {
        [Key]
        public int ISID { get; set; }

        public String ISACIKLAMA { get; set; }

        public DateTime ISTARIH { get; set; }

        public int? DOKTORID { get; set; }

        public virtual TBLDOKTOR TBLDOKTOR { get; set; }

        public int? HASTAID { get; set; }

        public virtual TBLHASTA TBLHASTA { get; set; }


    }
}
