using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Scheduling_Application.Types;
using Scheduling_Application.Model;
using System.IO;

namespace Scheduling_Application
{
    public static class Authentication
    {
        private static bool _initialized = false;
        private static user _user = null;
        private static bool _loggedOut = false;
        private static U06hKtEntities _db;
        private static readonly string _LogFileName = ".\\securityLog.txt";

        public static bool Initialize(U06hKtEntities db)
        {
            if (_initialized)
                return _initialized;
            _db = db;
            if (_db == null)
                return _initialized;
            _initialized = true;

            return _initialized;
        }

        public static bool LogIn()
        {
            bool repeat = true;
            Scheduling_Application.login frm = new Scheduling_Application.login();
            while (repeat)
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    user usr = _db.users.FirstOrDefault(u => u.userName == frm.UserName);
                    if (usr != null)
                    {
                        if (usr.password == frm.Password)
                        {
                            _user = usr;
                            if (_user.active == 1)
                            {
                                _loggedOut = false;
                                File.AppendAllText(_LogFileName, $"User {_user.userName}: Loged in at: {DateTime.Now}\n");
                                return true;
                            }
                            else
                                MessageBox.Show(string.Format(Properties.strings.InactiveUser, _user.userName));
                        }
                        else
                        {
                           MessageBox.Show(Properties.strings.WrongNamePassword);
                        }
                    }
                    else
                        MessageBox.Show(Properties.strings.WrongNamePassword);
                }
                else
                    repeat = false;
            }
            return false;
        }

        public static void LogOut()
        {
            File.AppendAllText(_LogFileName, $"User {_user.userName}: Loged out at: {DateTime.Now}\n");
            _loggedOut = true;
            _user = null;
        }

        public static string getUserName()
        {
            if (_user != null)
                return _user.userName;
            return string.Empty;
        }

        public static user getUser()
        {
            return _user;
        }

        public static bool isLoggedIn()
        {
            return _user != null;
        }
        public static bool isLoggedOut()
        {
            return _loggedOut;
        }

        public static void Deinitialize()
        {
            if (_initialized)
                return;
            _db = null;
            _initialized = false;

        }
    }
}
