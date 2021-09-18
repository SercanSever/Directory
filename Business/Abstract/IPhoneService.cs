﻿using Core.Utilities.Results;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IPhoneService
    {
        IDataResult<List<Phone>> GetAll();
        IDataResult<Phone> Get(int Id);
        IDataResult<Phone> GetWithContactId(int contactId);
    }
}
