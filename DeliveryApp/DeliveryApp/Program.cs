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
            //��������� ��������� ���� �����
            DeliveriesContext context = new DeliveriesContext();
            //ϳ����������� ��������� �������
            context.Deliveries.Load();
            context.DeliveryTypes.Load();
            //�������� ��������� �� ������� �����
            Application.Run(new DeliveriesForm(context));
        }
    }
}
