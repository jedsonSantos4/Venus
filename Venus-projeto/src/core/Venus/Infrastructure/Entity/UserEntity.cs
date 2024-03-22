using Domain.Enum;

namespace Infrastructure.Entity
{
    public class UserEntity : BaseEntity
    {
        
        public string Nome { get; set; }
        
        public string Email { get; set; }
        public string Password { get; set; }
        
        public Role Role { get; set; }

        public UserEntity()
        {
            Role = Role.User;
        }

    }
}
