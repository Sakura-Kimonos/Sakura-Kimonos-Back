
using Entities.Enums;

namespace Entities.Entities
{
    public class UserItem
    {
        public UserItem() { }
        public int Id { get; set; }
        //public int IdRol { get; set; }
        public UserRolEnum UserRol {get; set; }
        public string UserName { get; set; }
        public DateTime InsertDate { get; set; }
        public DateTime UpdateDate { get; set; }
        public bool IsActive { get; set; }
        public string Password { get; set; }
        public string EncryptedPassword { get; set; }

    }
}
