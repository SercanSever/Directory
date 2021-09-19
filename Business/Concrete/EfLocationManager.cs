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

        public IResult Add(Location location)
        {
            _locationDal.Add(location);
            return new SuccessResult();
        }

        public IResult Delete(Location location)
        {
            _locationDal.Delete(location);
            return new SuccessResult();
        }

        public IDataResult<Location> Get(int Id)
        {
            return new SuccessDataResult<Location>(_locationDal.Get(x => x.LocationId == Id));
        }

        public IDataResult<List<Location>> GetAll()
        {
            return new SuccessDataResult<List<Location>>(_locationDal.GetAll());
        }

        public IDataResult<List<Location>> GetWithContactId(int contactId)
        {
            return new SuccessDataResult<List<Location>>(_locationDal.GetAll(x => x.ContactId == contactId));
        }

        public IResult Update(Location location)
        {
            _locationDal.Update(location);
            return new SuccessResult();
        }
    }
}
