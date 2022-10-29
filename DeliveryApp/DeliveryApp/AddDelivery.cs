using DeliveryApp.Contexts;
using DeliveryApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeliveryApp
{
    public partial class AddDelivery : Form
    {
        private TaskCompletionSource<Delivery> _taskCompletionSource; //Джерело асинхронної задачі
        private Delivery _result = null; //По закриттю асинхронна задача закінчується. Якщо було натиснуто "Додати" - результат не null
        private DeliveriesContext _deliveriesContext;

        public AddDelivery(DeliveriesContext deliveriesContext)
        {
            InitializeComponent();
            _deliveriesContext = deliveriesContext;
            InitTypes();
        }

        private void InitTypes()
        {
            //Формування випадаючого списку з типів доставки
            CBType.Items.AddRange(_deliveriesContext.DeliveryTypes.Local.Select((type, id) => type.Name).ToArray());
            //Вибір по замовчуванню найпершого
            if (CBType.Items.Count > 0) CBType.SelectedIndex = 0;
        }

        //Реалізація створення доставки через асинхронну задачу
        public Task<Delivery> CreateDelivery()
        {
            Show();
            _taskCompletionSource = new TaskCompletionSource<Delivery>();
            return _taskCompletionSource.Task;
        }

        private void BAdd_Click(object sender, EventArgs e)
        {
            //Зберігання результату по натисканню на кнопку
            _result = new Delivery()
            {
                Description = TBDescription.Text,
                FromLocation = TBFrom.Text,
                ToLocation = TBTo.Text,
                Status = DeliveryStatus.NotStarted,
                Mass = decimal.Parse(TBMass.Text),
                DeliveryTypeId = _deliveriesContext.DeliveryTypes.Local.ElementAt(CBType.SelectedIndex).DeliveryTypeId
            };
            //Закриття форми
            Close();
        }

        private void AddDelivery_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Завершення асинхронної задачі по закриттю форми
            _taskCompletionSource.SetResult(_result);
        }
    }
}
