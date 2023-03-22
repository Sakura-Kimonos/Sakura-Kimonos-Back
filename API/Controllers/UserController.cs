using API.IServices;
using API.Services;
using Data;
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
        public int InsertUser([FromForm] UserRequest userRequest)
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

        [HttpDelete(Name = "DeactivateUser")]
        public void DeactivateUser([FromQuery] int id)
        {
            _userService.DeactivateUser(id);
        }

        //[HttpGet(Name = "GetBirthdayEmployee")]
        //public List<ProductItem> GetBirthdayEmployee()
        //{

        //    //sin virtual
        //    //var employee = _serviceContext.Set<EmployeeItem>().Where(p => p.Id == employeeId).First();
        //    //var person = _serviceContext.Set<PersonItem>().Where(p => p.Id == employee.IdPerson).First();
        //    //return person.BirthDay;

        //    //con virtual

        //    var employeeList = _serviceContext.Set<EmployeeItem>().Where(p => p.IsActive);
        //    var first = employeeList.FirstOrDefault();
        //    return first.Person.BirthDay;
    }
 }



