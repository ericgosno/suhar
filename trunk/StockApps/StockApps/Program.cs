using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace StockApps
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new _sellingTransactionList());
            //Application.Run(new BankReport());
            //Application.Run(new sellingReport());
        }
    }
}
