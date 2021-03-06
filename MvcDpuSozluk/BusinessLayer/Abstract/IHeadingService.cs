using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IHeadingService
    {
        List<Heading> GetList();
        List<Heading> GetListByWriter(int id);
        List<Heading> GetListByCategory(int id);
        void HeadingAddBL(Heading heading);
        Heading GetByID(int id);
        Heading GetByCatID(int id);
    }
}
