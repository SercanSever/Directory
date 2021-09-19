using Business.Abstract;
using DataAccess.Abstract;
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
    public class InformationsController : ControllerBase
    {
        private IEmailService _emailService;

        public InformationsController(IEmailService emailService)
        {
            _emailService = emailService;
        }
        #region Email

        #endregion
        [HttpGet("getAllEmails")]
        public IActionResult GetAllEmails()
        {
            var result = _emailService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result.Message);
        }
        [HttpGet("getEmailWithId")]
        public IActionResult GetAllEmails(int Id)
        {
            var result = _emailService.Get(Id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result.Message);
        }
        [HttpGet("getEmailsWithContactId")]
        public IActionResult GetEmailsWithContactId(int Id)
        {
            var result = _emailService.GetWithContactId(Id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result.Message);
        }

        [HttpPost("contact/addEmail")]
        public IActionResult AddEmail(Email email)
        {
            var result = _emailService.Add(email);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result.Message);
        }
        [HttpPost("contact/updateEmail")]
        public IActionResult UpdateEmail(Email email)
        {
            var result = _emailService.Update(email);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result.Message);
        }
        [HttpPut("contact/deleteEmail")]
        public IActionResult DeleteEmail(Email email)
        {
            var result = _emailService.Delete(email);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result.Message);
        }
    }
}
