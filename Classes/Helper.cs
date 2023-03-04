using OOOSportProducts.Classes.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOOSportProducts.Classes
{
    public static class Helper
    {
        public static DB DB;
        public static User User;
        public static FormAction FormAction;
    }

    public enum FormAction
    {
        Добавление,
        Редактирование
    }
}
