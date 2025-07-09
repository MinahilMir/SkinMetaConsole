using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkinMetaConsole
{
    // Add this as a new class in your project
    public static class CurrentUserManager
    {
        // Store the current user's email
        public static string CurrentUserEmail { get; private set; }

        // Set the current user's email at login
        public static void SetCurrentUser(string email)
        {
            CurrentUserEmail = email;
        }

        // Clear the current user
        public static void ClearCurrentUser()
        {
            CurrentUserEmail = null;
        }
    }
}
