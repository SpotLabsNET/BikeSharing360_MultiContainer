﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Email.Api.Controllers
{
    [Route("api/email")]
    public class EmailApiController : Controller
    {

        // POST api/email
        [HttpPost]
        public IActionResult Post([FromBody]dynamic data)
        {
            bool result = SendThankYouEmail(
                (string)data.FirstName,
                (string)data.Email
                );
            string response;
            if (result)
                response = "Message Sent";
            else
                response = "Message Send Failure";

            return Ok (new { Message = response });
        }











        bool SendThankYouEmail(string firstName, string email)
        {
            return true;
        }
    }
}
