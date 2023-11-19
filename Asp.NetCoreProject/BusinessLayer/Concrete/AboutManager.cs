using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using EntityLayer.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class AboutManager : IAboutService
    {
        IAbautDal _aboutDal;

        public AboutManager(IAbautDal aboutDal)
        {
            _aboutDal = aboutDal;
        }

        public void Tadd(About t)
        {
            _aboutDal.Insert(t);
        }

        public void TDelete(About t) 
        {
            _aboutDal.Delete(t);
        }

        public About TGetById(int id)
        {
          return  _aboutDal.GetById(id);
        }

        public List<About> TGetList()
        {
           return  _aboutDal.GetList();
        }

        public void TUpdate(About t)
        {
            _aboutDal.Update(t);
        }
    }
}
