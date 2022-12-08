using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
 
        static void testDB()
        {
            if (DALTuaSach.Instance.DelTuaSach(1))
                Console.WriteLine("Xoa thanh cong");
        }
        static void Main()
        {
            Thread t = new Thread(Start);

            t.SetApartmentState(ApartmentState.STA);

            t.Start();

            t.Join();
            
        }

        static void Start()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //testDB();
            //System.Console.Read();
            Application.Run(new fLogin());
        }
    }
}
