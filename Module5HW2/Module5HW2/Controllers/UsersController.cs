using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Module5HW2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        [HttpPost]
        [Route("Register")]
        public string Register([FromForm] User user)
        {
            return $"Email:{user.Email}\n" +
                $"Password:{user.Password}";
        }
    }
}
