using EntityLayer.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IAbautDal : IGenericDal<About>
    {
        //İlgili CRUD OPERASYONLARI GENERİC İNTERFACE İÇİNDEN MİRAS ALINMIŞTIR.
        //void Delete(Contact t);
    }
}
