using Core.Utilities.Results;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IContactService
    {
        IDataResult<List<Contact>> GetAll();
        IDataResult<Contact> Get(int Id);
        IResult Add(Contact contact);
        IResult Update(Contact contact);
        IResult Delete(Contact contact);
    }
}
