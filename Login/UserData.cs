using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login
{
    public static class UserData
    {
        // Dictionary untuk menyimpan username dan password pengguna biasa
        public static Dictionary<string, string> users = new Dictionary<string, string>();
        // Add admin username and password
        public static string AdminUsername = "admin";
        public static string AdminPassword = "admin123";

        // Muat data pengguna dari file (kecuali admin)
        public static void LoadUserData()
        {
            if (File.Exists("users.txt"))
            {
                foreach (var line in File.ReadAllLines("users.txt"))
                {
                    var parts = line.Split(':');
                    if (parts.Length == 2)
                    {
                        users[parts[0]] = parts[1];
                    }
                }
            }
        }

        // Simpan data pengguna ke file
        public static void SaveUserData()
        {
            using (StreamWriter writer = new StreamWriter("users.txt"))
            {
                foreach (var user in users)
                {
                    writer.WriteLine($"{user.Key}:{user.Value}");
                }
            }
        }
    }
}
