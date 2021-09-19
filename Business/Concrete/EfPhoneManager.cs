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
    public class EfPhoneManager : IPhoneService
    {
        private IPhoneDal _phoneDal;

        public EfPhoneManager(IPhoneDal phoneDal)
        {
            _phoneDal = phoneDal;
        }

        public IResult Add(Phone phone)
        {
            _phoneDal.Add(phone);
            return new SuccessResult();
        }

        public IResult Delete(Phone phone)
        {
            _phoneDal.Delete(phone);
            return new SuccessResult();
        }

        public IDataResult<Phone> Get(int Id)
        {
            return new SuccessDataResult<Phone>(_phoneDal.Get(x => x.PhoneId == Id));
        }

        public IDataResult<List<Phone>> GetAll()
        {
            return new SuccessDataResult<List<Phone>>(_phoneDal.GetAll());
        }

        public IDataResult<List<Phone>> GetWithContactId(int contactId)
        {
            return new SuccessDataResult<List<Phone>>(_phoneDal.GetAll(x => x.ContactId == contactId));
        }

        public IResult Update(Phone phone)
        {
            _phoneDal.Update(phone);
            return new SuccessResult();
        }
    }
}
