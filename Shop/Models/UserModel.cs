using System;
using System.ComponentModel.DataAnnotations;

namespace Shop.Models
{
    public class UserModel
    {
        public int UserId { get; set; }
        [Required(ErrorMessage = "Введите логин или email")]
        public string UserName { get; set; }
        public string Email { get; set; }

        [Required(ErrorMessage = "Введите пароль")]
        public string Password { get; set; }
        public virtual int RoleId { get; set; }
        public DateTime LastLogon { get; set; }
    }
}