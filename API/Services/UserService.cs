using API.IServices;
using Entities.Entities;
using Logic.ILogic;
using Logic.Logic;
using Resources.FilterModels;
using Resources.RequestModels;

namespace API.Services
{
    public class UserService : IUserService
    {
        private readonly IUserLogic _userLogic;
        //private readonly IUserSecurityLogic _userSecurityLogic;
        public UserService(IUserLogic userLogic)
        {
            _userLogic = userLogic;
            //_userSecurityLogic = userSecurityLogic;
        }

        public void DeleteUser(int id)
        {
            _userLogic.DeleteUser(id);
        }

        public List<UserItem> GetAllUsers()
        {
            return _userLogic.GetAllUsers();
        }

        public List<UserItem> GetUsersByCriteria(UserFilter userFilter)
        {
            return _userLogic.GetUsersByCriteria(userFilter);
        }

        public int InsertUser(UserRequest userRequest)
        {
            var newUserRequest = userRequest.ToUserItem();
            return _userLogic.InsertUser(newUserRequest);
        }

        public void UpdateUser(UserItem userItem)
        {
            _userLogic.UpdateUser(userItem);
        }

        void IUserService.DeactivateUser(int id)
        {
            _userLogic.DeactivateUser(id);
        }
    }
}
