using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Scheduling_Application.Model;

namespace Scheduling_Application
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            using (U06hKtEntities db = new U06hKtEntities())
            {

                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);

                // Application reacts to either locale changes
                if (Thread.CurrentThread.CurrentUICulture != Thread.CurrentThread.CurrentCulture)
                    Thread.CurrentThread.CurrentUICulture = Thread.CurrentThread.CurrentCulture;

                Authentication.Initialize(db);
                bool repeat = true;
                while (repeat)
                {
                    if (Authentication.LogIn())
                    {
                        DateTime sFrom = DateTime.Now.ToUniversalTime();
                        DateTime sTo = DateTime.Now.AddMinutes(15).ToUniversalTime();
                        string uName = Authentication.getUserName();
                        var aList = db.appointments.Where(a => a.user.userName == uName && a.start > sFrom && a.start < sTo).OrderBy(a => a.start).ToList();
                        if (aList.Count() >= 1)
                        {
                            var a = aList[0];
                            MessageBox.Show($"Your upcoming {a.type} appointment with {a.customer.customerName} is currently set for {a.start.ToLocalTime()}.");
                        }
                        Application.Run(new MainScreen(db));
                    }
                    else
                        break;
                    repeat = Authentication.isLoggedOut();
                }
                Authentication.Deinitialize();
            }
        }
    }
}
