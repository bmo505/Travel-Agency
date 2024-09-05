using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task5
{
    public static class User
    {
        public static readonly string[] UserNames = { "admin", "Bilal", "Salah", "Amr", "Ibrahim" };
        public static readonly string[] Passwords = { "12", "34", "56", "78", "90" };
        public static bool Login(string username, string password)
        {

            for (int i = 0; i < UserNames.Length; i++)
            {
                if (UserNames[i] == username && Passwords[i] == password)
                {
                    return true;
                }
            }
            return false;
        }

    }
}