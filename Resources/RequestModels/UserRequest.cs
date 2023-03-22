using Entities.Entities;


namespace Resources.RequestModels
{
    public class UserRequest
    {
        public int Rol { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
     

        public UserItem ToUserItem()
        {
            var userItem = new UserItem();

            userItem.Rol = Rol;
            userItem.UserName = UserName;
            userItem.Password = Password;
            userItem.InsertDate = DateTime.Now;
            userItem.UpdateDate = DateTime.Now;
            userItem.IsActive = true;

            return userItem;
        }
    }
}
