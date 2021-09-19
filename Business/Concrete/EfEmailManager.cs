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
    public class EfEmailManager : IEmailService
    {
        private IEmailDal _emailDal;

        public EfEmailManager(IEmailDal emailDal)
        {
            _emailDal = emailDal;
        }

        public IResult Add(Email email)
        {
            _emailDal.Add(email);
            return new SuccessResult();
        }

        public IResult Delete(Email email)
        {
            _emailDal.Delete(email);
            return new SuccessResult();
        }
        public IResult Update(Email email)
        {
            _emailDal.Update(email);
            return new SuccessResult();
        }

        public IDataResult<Email> Get(int Id)
        {
            return new SuccessDataResult<Email>(_emailDal.Get(x => x.EmailId == Id));
        }

        public IDataResult<List<Email>> GetAll()
        {
            return new SuccessDataResult<List<Email>>(_emailDal.GetAll());
        }

        public IDataResult<List<Email>> GetWithContactId(int contactId)
        {
            return new SuccessDataResult<List<Email>>(_emailDal.GetAll(x => x.ContactId == contactId));
        }

      
    }
}
