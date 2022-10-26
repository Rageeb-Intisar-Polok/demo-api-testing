using Choton_1_demo_api.Models;
using CoreApiResponse;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Choton_1_demo_api.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class UserController : BaseController
    {
        User _user;
        public UserController()
        {
            _user = new User();
            _user.Name = "Rageeb Intisar";
            _user.Password = "demo password for testing";
        }

        [HttpGet]
        public IActionResult getInfo()
        {
            try
            {
                return CustomResult("Data loaded successfully. ", _user);
            }
            catch(Exception ex)
            {
                return CustomResult(ex.Message, System.Net.HttpStatusCode.BadRequest);
            }
        }

        [HttpPost]
        public IActionResult setName(string proposed_name)
        {
            try
            {
                _user.Name = proposed_name;
                return CustomResult("Name is set successfully", _user);
            }
            catch(Exception ex)
            {
                return CustomResult(ex.Message, System.Net.HttpStatusCode.BadRequest);
            }
        }

        [HttpPost]

        public IActionResult setPassword(string proposed_password)
        {
            try
            {
                _user.Password = proposed_password;
                return CustomResult("Password is set successfully", _user);
            }
            catch (Exception ex)
            {
                return CustomResult(ex.Message, System.Net.HttpStatusCode.BadRequest);
            }
        }

    }
}
