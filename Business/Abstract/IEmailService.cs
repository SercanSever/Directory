using Core.Utilities.Results;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IEmailService
    {
        IDataResult<List<Email>> GetAll();
        IDataResult<Email> Get(int Id);
        IDataResult<List<Email>> GetWithContactId(int contactId);
        IResult Add(Email email);
        IResult Update(Email email);
        IResult Delete(Email email);
    }
}
