using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class EfLocationManager : ILocationService
    {
        private ILocationDal _locationDal;

        public EfLocationManager(ILocationDal locationDal)
        {
            _locationDal = locationDal;
        }

        public IDataResult<Location> Get(int Id)
        {
            return new SuccessDataResult<Location>(_locationDal.Get(x => x.LocationId == Id));
        }

        public IDataResult<List<Location>> GetAll()
        {
            return new SuccessDataResult<List<Location>>(_locationDal.GetAll());
        }

        public IDataResult<Location> GetWithContactId(int contactId)
        {
            return new SuccessDataResult<Location>(_locationDal.Get(x => x.ContactId == contactId));
        }
    }
}
