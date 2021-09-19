using Business.Abstract;
using Entity.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactsController : ControllerBase
    {
        private IContactService _contactService;

        public ContactsController(IContactService contactService)
        {
            _contactService = contactService;
        }

        [HttpGet("getAllContacts")]
        public IActionResult GetAll()
        {
            var result = _contactService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result.Message);
        }
        [HttpGet("getAllContactsDetails")]
        public IActionResult GetAllContactsDetails()
        {
            var result = _contactService.GetContactsDetail();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result.Message);
        }
        [HttpGet("getContactWithId")]
        public IActionResult GetContactWithId(int id)
        {
            var result = _contactService.Get(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result.Message);
        }
        [HttpPost("addContact")]
        public IActionResult AddContact(Contact contact)
        {
            var result = _contactService.Add(contact);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result.Message);
        }
        [HttpPost("updateContact")]
        public IActionResult UpdateContact(Contact contact)
        {
            var result = _contactService.Update(contact);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result.Message);
        }
        [HttpPut("deleteContact")]
        public IActionResult DeleteContact(Contact contact)
        {
            var result = _contactService.Delete(contact);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result.Message);
        }

    }
}
