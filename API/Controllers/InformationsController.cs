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
        private ILocationService _locationService;
        private IPhoneService _phoneService;

        public InformationsController(
            IEmailService emailService,
            ILocationService locationService,
            IPhoneService phoneService)
        {
            _emailService = emailService;
            _locationService = locationService;
            _phoneService = phoneService;
        }

        #region Email
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
        public IActionResult GetEmailWithId(int Id)
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
        #endregion

        #region Location
        [HttpGet("getAllLocations")]
        public IActionResult GetAllLocations()
        {
            var result = _locationService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result.Message);
        }
        [HttpGet("getLocationWithId")]
        public IActionResult GetLocatioWithId(int Id)
        {
            var result = _locationService.Get(Id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result.Message);
        }
        [HttpGet("getLocationsWithContactId")]
        public IActionResult GetLocationsWithContactId(int Id)
        {
            var result = _locationService.GetWithContactId(Id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result.Message);
        }
        [HttpPost("contact/addLocation")]
        public IActionResult AddLocation(Location location)
        {
            var result = _locationService.Add(location);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result.Message);
        }
        [HttpPost("contact/updateLocation")]
        public IActionResult UpdateLocation(Location location)
        {
            var result = _locationService.Update(location);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result.Message);
        }
        [HttpPut("contact/deleteLocation")]
        public IActionResult DeleteLocation(Location location)
        {
            var result = _locationService.Delete(location);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result.Message);
        }
        #endregion

        #region Phone
        [HttpGet("getAllPhones")]
        public IActionResult GetAllPhones()
        {
            var result = _phoneService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result.Message);
        }
        [HttpGet("getPhoneWithId")]
        public IActionResult GetPhoneWithId(int Id)
        {
            var result = _phoneService.Get(Id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result.Message);
        }
        [HttpGet("getPhonesWithContactId")]
        public IActionResult GetPhonesWithContactId(int Id)
        {
            var result = _phoneService.GetWithContactId(Id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result.Message);
        }
        [HttpPost("contact/addPhone")]
        public IActionResult AddPhone(Phone phone)
        {
            var result = _phoneService.Add(phone);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result.Message);
        }
        [HttpPost("contact/updatePhone")]
        public IActionResult UpdatePhone(Phone phone)
        {
            var result = _phoneService.Update(phone);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result.Message);
        }
        [HttpPut("contact/deletePhone")]
        public IActionResult DeletePhone(Phone phone)
        {
            var result = _phoneService.Delete(phone);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result.Message);
        }
        #endregion

    }
}
