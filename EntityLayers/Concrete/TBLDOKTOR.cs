using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace EntityLayers.Concrete
{
    public class TBLDOKTOR
    {
        [Key]
        public int DOKTORID { get; set; }
        
        public String DOKTORAD { get; set; }

        public Boolean DOKTORPASIF { get; set; }
        [UIHint("tinymce_full_compressed"), AllowHtml]
        public String DOKTORADRESBILGI { get; set; }

        public ICollection<TBLODEME> TBLODEMEs { get; set; }

        public ICollection<TBLISLER> TBLISLERs { get; set; }

    }
}
