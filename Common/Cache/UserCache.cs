using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Cache
    //Для временного хранения данных
{
    //В статическом классе ценности являются постоянным 
    //Данные о пользователе, который входит в систему
    public static class UserCache
    {
        public static int Id { get; set; }
        public static string Name { get; set; }
        public static string Position { get; set; }
        public static string Email { get; set; }

    }
}
