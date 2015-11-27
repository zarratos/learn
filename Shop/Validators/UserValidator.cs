using System.Runtime.CompilerServices;
using System.Web.Mvc;
using Shop.Models;

namespace Shop.Validators
{
    public static class UserValidator
    {
        public static bool UserEmptyLoginValidate(UserModel model, ModelStateDictionary modelState)
        {
            if (model.UserName == null || model.Password == null)
                return false;
            if (model.UserName != "aaa")
            {
                modelState.AddModelError("UserName", "Неправильное имя пользователя или пароль");
                return false;
            }
            return true;
        }
    }
}