using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicaPOO
{
    static class Program
    {
     
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Splash());
        }
        //static void Main()
        //{
        //    Application.SetHighDpiMode(HighDpiMode.SystemAware);
        //    Application.EnableVisualStyles();
        //    Application.SetCompatibleTextRenderingDefault(false);
        //    Application.Run(new AppointmentBooking("ivanialebron@gmail.com"));
        //}
    }
}
