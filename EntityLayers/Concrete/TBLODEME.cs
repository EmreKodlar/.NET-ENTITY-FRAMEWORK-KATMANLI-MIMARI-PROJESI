using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayers.Concrete
{
    public class TBLODEME
    {
        [Key]
        public int ODEMEID { get; set; }

        public float ODEMEMIKTAR { get; set; }

        public DateTime ODEMETARIH { get; set; }

        public int? DOKTORID { get; set; }

        public virtual TBLDOKTOR TBLDOKTOR { get; set; }

        public int? HASTAID  { get; set; }

        public virtual TBLHASTA TBLHASTA { get; set; }


    }
}
