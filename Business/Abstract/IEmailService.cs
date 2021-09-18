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
        IDataResult<Email> GetWithContactId(int contactId);
    }
}
