using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class UserLogic
    {
        private readonly FileDataListSingleton source;

        public UserLogic()
        {
            source = FileDataListSingleton.GetInstance();
        }

        public void CreateOrUpdate(UserBindingModel model)
        {
            User element = source.Users.FirstOrDefault(
                rec => 
                rec.Login == model.Login 
                && 
                rec.Id != model.Id);
            if (element != null)
            {
                throw new Exception("Уже есть пользователь с таким логином");
            }
            if (model.Id.HasValue)
            {
                element = source.Users.FirstOrDefault(rec => rec.Id == model.Id);
                if (element == null)
                {
                    throw new Exception("Элемент не найден");
                }
            } else
            {
                int maxId = source.Users.Count > 0 ? source.Users.Max(rec => rec.Id) : 0;
                element = new User { Id = maxId + 1 };
                source.Users.Add(element);
            }
            element.Login = model.Login;
            element.Password = model.Password;
            element.PasswordRestrictions = model.PasswordRestrictions;
            element.Admin = model.Admin;
            element.Block = model.Block;
        }

        public void Delete(UserBindingModel model)
        {
            User element = source.Users.FirstOrDefault(rec => rec.Id ==
           model.Id);
            if (element != null)
            {
                source.Users.Remove(element);
            }
            else
            {
                throw new Exception("Элемент не найден");
            }
        }

        public List<UserBindingModel> Read(UserBindingModel model)
        {
            return source.Users
            .Where(rec => model == null || rec.Id == model.Id || (rec.Login == model.Login && rec.Password == model.Password))
            .Select(rec => new UserBindingModel
            {
                Id = rec.Id,
                Admin = rec.Admin,
                Block = rec.Block,
                Password = rec.Password,
                Login = rec.Login,
                PasswordRestrictions = rec.PasswordRestrictions             
            })
            .ToList();
        }

    }
}
