using DeliveryApp.Contexts;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeliveryApp
{
    static class Program
    {

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Створення контексту бази даних
            DeliveriesContext context = new DeliveriesContext();
            //Підвантаження локальних таблиць
            context.Deliveries.Load();
            context.DeliveryTypes.Load();
            //Передача контексту на головну форму
            Application.Run(new DeliveriesForm(context));
        }
    }
}
