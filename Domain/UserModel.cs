using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.Cache;
using DataAccess;

namespace Domain
{
    public class UserModel
    {
        Users users = new Users();
        public bool LoginUser(string user, string pass)
        {
            return users.Login(user,pass);
        }

        //"Любой метод" для безопасности и права пользователя 
        public void AnyMethod()
        {
            //Условие,где спрашиваем, что такое позиция пользователя, вошедшего в систему 
            if (UserCache.Position == Positions.Administrator)
            {
                //Код
            }
            if (UserCache.Position == Positions.Employees || UserCache.Position == Positions.Guest)
            {
                //Kod
            }
        }
    }
}
