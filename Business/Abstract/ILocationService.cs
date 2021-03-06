using Core.Utilities.Results;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ILocationService
    {
        IDataResult<List<Location>> GetAll();
        IDataResult<Location> Get(int Id);
        IDataResult<List<Location>> GetWithContactId(int contactId);
        IResult Add(Location location);
        IResult Update(Location location);
        IResult Delete(Location location);
    }
}
