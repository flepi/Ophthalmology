﻿using System;
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
        public static int id { get; set; }
        public static string name { get; set; }
        public static string role { get; set; }
    }
}
