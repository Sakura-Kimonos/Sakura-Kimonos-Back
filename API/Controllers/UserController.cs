using API.IServices;
using Entities.Entities;
using Microsoft.AspNetCore.Mvc;
using Resources.FilterModels;
using Resources.RequestModels;
//using Security.IServices;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class UserController : ControllerBase
    {
        //private readonly IUserSecurityService _userSecurityService;
        private readonly IUserService _userService;
        public UserController(IUserService userService)
        {
            //_userSecurityService = userSecurityService;
            _userService = userService;
        }
        //[HttpPost(Name = "LoginUser")]
        //public string Login([FromBody] LoginRequest loginRequest)
        //{

        //    return _userSecurityService.GenerateAuthorizationToken(loginRequest.UserName, loginRequest.UserPassword);
        //}

        [HttpPost(Name = "InsertUser")]
        public int InsertUser([FromBody] UserRequest userRequest)
        {
            return _userService.InsertUser(userRequest);
        }

        [HttpGet(Name = "GetAllUsers")]
        public List<UserItem> GetAll()
        {
            return _userService.GetAllUsers();
        }

        [HttpPatch(Name = "ModifyUser")]
        public void Patch([FromBody] UserItem userItem)
        {
            _userService.UpdateUser(userItem);
        }

        [HttpDelete(Name = "DeleteUser")]
        public void Delete([FromQuery] int id)
        {
            _userService.DeleteUser(id);
        }

        [HttpGet(Name = "GetUsersByCriteria")]
        public List<UserItem> GetByCriteria([FromQuery] UserFilter userFilter)
        {
            return _userService.GetUsersByCriteria(userFilter);
        }
    }
}
