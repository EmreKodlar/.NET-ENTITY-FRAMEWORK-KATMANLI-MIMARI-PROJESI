using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using EntityLayers.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFrameWork
{
    public class EFOdemeDal : GenericRepository<TBLODEME>, IOdemeDal
    {
    }
}
