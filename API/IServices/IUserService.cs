using Entities.Entities;
using Resources.FilterModels;
using Resources.RequestModels;

namespace API.IServices
{
    public interface IUserService
    {
        int InsertUser(UserItem userItem);
        void UpdateUser(UserItem userItem);
        void DeleteUser(int id);
        List<UserItem> GetAllUsers();
        List<UserItem> GetUsersByCriteria(UserFilter userFilter);
    }
}
