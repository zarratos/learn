using System;

namespace DAL
{
    public class User
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public virtual int RoleId { get; set; }
        public DateTime LastLogon { get; set; }
    }
}
