using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entity.Concrete;
using Entity.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class EfContactManager : IContactService
    {
        private IContactDal _contactDal;

        public EfContactManager(IContactDal contactDal)
        {
            _contactDal = contactDal;
        }

        public IResult Add(Contact contact)
        {
            _contactDal.Add(contact);
            return new SuccessResult();
        }

        public IResult Delete(Contact contact)
        {
            _contactDal.Delete(contact);
            return new SuccessResult();
        }

        public IDataResult<Contact> Get(int Id)
        {
            return new SuccessDataResult<Contact>(_contactDal.Get(x => x.ContactId == Id));
        }

        public IDataResult<List<Contact>> GetAll()
        {
            return new SuccessDataResult<List<Contact>>(_contactDal.GetAll());
        }

        public IDataResult<ContactDetailsDto> GetContactDetailWithName(string name)
        {
            return new SuccessDataResult<ContactDetailsDto>(_contactDal.GetContactsWithDetail().Where(x => x.Name == name).FirstOrDefault());
        }

        public IDataResult<List<ContactDetailsDto>> GetContactsDetail()
        {
            return new SuccessDataResult<List<ContactDetailsDto>>(_contactDal.GetContactsWithDetail());
        }

        public IResult Update(Contact contact)
        {
            _contactDal.Update(contact);
            return new SuccessResult();
        }
        public IDataResult<List<ContactDetailsDto>> ListByLocation()
        {
            var result = _contactDal.GetContactsWithDetail();
  
            return new SuccessDataResult<List<ContactDetailsDto>>(_contactDal.GetContactsWithDetail());
        }


    }
}
