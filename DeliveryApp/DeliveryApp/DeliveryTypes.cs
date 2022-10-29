using DeliveryApp.Contexts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeliveryApp
{
    public partial class DeliveryTypes : Form
    {
        private readonly DeliveriesContext _deliveriesContext;

        public DeliveryTypes(DeliveriesContext deliveriesContext)
        {
            InitializeComponent();
            _deliveriesContext = deliveriesContext;
            InitTypesTable();
        }

        /// <summary>
        /// Ініціалізація візуальної таблиці з типами доставки
        /// </summary>
        private void InitTypesTable()
        {
            //Заповнення таблиці з бази данних
            DGTypes.DataSource = _deliveriesContext.DeliveryTypes.Local.ToBindingList();
            //Відключення показу головного ключа
            DGTypes.Columns["DeliveryTypeId"].Visible = false;
        }

        private void DeliveryTypes_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Зберігаємо зміни в БД по закриттю вікна
            _deliveriesContext.SaveChanges();
        }
    }
}
