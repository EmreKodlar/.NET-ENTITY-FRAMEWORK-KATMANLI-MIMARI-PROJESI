using EntityLayers.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    class Context : DbContext 
    {
        public DbSet<TBLDOKTOR> TBLDOKTORs { get; set; }
        public DbSet<TBLHASTA> TBLHASTAs { get; set; }
        public DbSet<TBLODEME> TBLODEMEs { get; set; }
        public DbSet<TBLISLER> TBLISLERs { get; set; }

    }
}
