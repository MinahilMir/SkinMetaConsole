using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkinMetaConsole
{
    public static class CurrentUser
    {
        public static int UserID { get; set; }
        public static string Email { get; set; }

        public static bool IsAuthenticated => UserID > 0;

        public static void Logout()
        {
            UserID = 0;
            Email = null;
        }
    }
}
