using AutoMapper;
using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using DataAccess.Context;
using Entity.Concrete;
using Entity.Dto;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class EfContactDal : EntityRepositoryBase<Contact, DirectoryContext>, IContactDal
    {
       

        public List<ContactDetailsDto> GetContactsWithDetail()
        {
            using (DirectoryContext context = new DirectoryContext())
            {
                var result = from c in context.Contacts
                             join e in context.Emails
                             on c.ContactId equals e.ContactId
                             join l in context.Location
                             on c.ContactId equals l.ContactId
                             join p in context.Phones
                             on c.ContactId equals p.ContactId
                             select new ContactDetailsDto
                             {
                                 ContactId = c.ContactId,
                                 Company = c.Company,
                                 Name = c.Name,
                                 LastName = c.LastName,
                                 Email = e.ContactEmail,
                                 Phone = p.ContactPhone,
                                 Location = l.ContactLocation
                             };
                return result.Distinct().ToList();
            }
        }
    }
}
