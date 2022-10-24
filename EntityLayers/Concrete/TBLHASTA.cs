using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace EntityLayers.Concrete
{
    public class TBLHASTA
    {
        [Key]
        public int HASTAID { get; set; }
        
        public String HASTAAD { get; set; }

        public Boolean HASTAPASIF { get; set; }
 
        [UIHint("tinymce_full_compressed"), AllowHtml]
       
        public String HASTAADRESBILGI { get; set; }

        public ICollection<TBLODEME> TBLODEMEs { get; set; }

        public ICollection<TBLISLER> TBLISLERs { get; set; }

    }
}
