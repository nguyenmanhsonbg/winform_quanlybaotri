using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.UserSkins;
using DevExpress.Skins;
using DevExpress.LookAndFeel;
using System.Threading;

namespace HS_QuanLyBaoTri
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            System.Globalization.CultureInfo cultureInfo = new System.Globalization.CultureInfo("en-US");

            // Creating the DateTime Information specific to our application.
            System.Globalization.DateTimeFormatInfo dateTimeInfo = new System.Globalization.DateTimeFormatInfo();
            // Defining various date and time formats.
            dateTimeInfo.DateSeparator = "/";
            //dateTimeInfo.LongDatePattern = "dd-MMM-yyyy";
            dateTimeInfo.ShortDatePattern = "dd-MM-yyyy";
            //dateTimeInfo.LongTimePattern = "hh:mm:ss";
            //dateTimeInfo.ShortTimePattern = "hh:mm";
            // Setting application wide date time format.
            cultureInfo.DateTimeFormat = dateTimeInfo;
            // Assigning our custom Culture to the application.

            Application.CurrentCulture = cultureInfo;
            Thread.CurrentThread.CurrentCulture = cultureInfo;
            Thread.CurrentThread.CurrentUICulture = cultureInfo;

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            BonusSkins.Register();
            SkinManager.EnableFormSkins();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            BonusSkins.Register();
            SkinManager.EnableFormSkins();
            UserLookAndFeel.Default.SetSkinStyle("DevExpress Style");
       
            frmLogIn f_login = new frmLogIn();
            if (f_login.ShowDialog() == DialogResult.OK)
            {
                Application.Run(new frmMain());
            }
        }
    }
}
