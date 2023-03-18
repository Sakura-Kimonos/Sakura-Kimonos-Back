using API.IServices;
using Entities.Entities;
using Logic.ILogic;
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

        public int InsertUser(UserItem userItem)
        {
            //var newUserRequest = userRequest.ToUserItem();
            return _userLogic.InsertUser(userItem);
        }

        public void UpdateUser(UserItem userItem)
        {
            _userLogic.UpdateUser(userItem);
        }
    }
}
