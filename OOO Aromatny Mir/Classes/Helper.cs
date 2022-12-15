using OOO_Aromatny_Mir.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static OOO_Aromatny_Mir.Classes.Helper;

namespace OOO_Aromatny_Mir.Classes
{
    public class Helper
    {
        public static ModelDB ModelDB;
        public static Entities.User CurrentUser;
        public enum UserRole { Администратор, Менеджер, Клиент };
        public static UserRole CurrentUserRole;
        
        public static void SetRole(string role)
        {
            CurrentUserRole = (UserRole)Enum.Parse(typeof(UserRole), role);
        }
    }

}
