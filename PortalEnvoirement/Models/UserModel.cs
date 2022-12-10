namespace PortalEnvoirement.Models
{
    public class UserModel
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }     
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public DateTime UpdatedDate { get; set; } = DateTime.Now;
        public string Username { get; set; }

        public string Password { get; set; }

        public string PasswordHash { get; set; } = null;
  
        public string PasswordSalt { get; set; } = null;
        public string PasswordSaltHash { get; set; } = null;
        

    }
}
