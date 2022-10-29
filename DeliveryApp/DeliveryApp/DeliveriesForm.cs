using DeliveryApp.Contexts;
using DeliveryApp.Models;
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
    public partial class DeliveriesForm : Form
    {
        private readonly DeliveriesContext _deliveriesContext;

        public DeliveriesForm(DeliveriesContext deliveriesContext)
        {
            InitializeComponent();
            _deliveriesContext = deliveriesContext;
            InitDeliveriesTable();
        }
        /// <summary>
        /// Ініціалізація візуальної таблиці доставок
        /// </summary>
        private void InitDeliveriesTable()
        {
            //Деактивувати кнопки дій по замовчуванню
            BStart.Enabled = BFinish.Enabled = false;
            //Привязка візуальної таблиці до таблиці в базі данних
            DGDeliveries.DataSource = _deliveriesContext.Deliveries.Local.ToBindingList();
            //Не показуємо колонку з ІД типу доставки
            DGDeliveries.Columns["DeliveryTypeId"].Visible = false;
            UpdateActionButtons();
        }

        private async void CreateButton_Click(object sender, EventArgs e)
        {
            //Створюємо форму створення доставки з передачою контексту БД
            AddDelivery addDeliveryForm = new AddDelivery(_deliveriesContext);
            //Вичікуємо асихнронну задачу з поверенням створеннеї доставки
            Delivery delivery = await addDeliveryForm.CreateDelivery();
            //Якщо була одержана не null доставка - додаємо її в базу даних
            if (delivery != null)
            {
                //Додаємо її в контекст
                _deliveriesContext.Deliveries.Add(delivery);
                //Зберігаємо в базу данних
                await _deliveriesContext.SaveChangesAsync();
            }
        }

        private void BTypes_Click(object sender, EventArgs e)
        {
            //Створємо і запускаємо форму показу типів доставки
            DeliveryTypes deliveryTypesForm = new DeliveryTypes(_deliveriesContext);
            deliveryTypesForm.Show();
        }

        private void DGDeliveries_SelectionChanged(object sender, EventArgs e)
        {
            //Оновити кнопки дій при виборі доставки в таблиці
            UpdateActionButtons();
        }

        /// <summary>
        /// Метод оновлення стану кнопок-дій для вибраної доставки
        /// </summary>
        private void UpdateActionButtons()
        {
            ProcessCurrentDelivery(delivery =>
            {
                //Дія старту активна якщо доставка не розпочата
                BStart.Enabled = delivery.Status == DeliveryStatus.NotStarted;
                //Дія фінішу активна якщо доставка розпочата
                BFinish.Enabled = delivery.Status == DeliveryStatus.OnTheWay;
            });
        }

        /// <summary>
        /// Метод для передачі функції обробки вибраної доставки в таблиці
        /// </summary>
        /// <param name="deliveryAction">Функція для обробки</param>
        private void ProcessCurrentDelivery(System.Action<Delivery> deliveryAction)
        {
            //Якщо вибрано якийсь рядок і цей рядок містить доставку, то виконати над нею функцію
            if (DGDeliveries.CurrentRow == null) return;
            if (DGDeliveries.CurrentRow.DataBoundItem is Delivery delivery)
            {
                if (delivery != null)
                {
                    deliveryAction?.Invoke(delivery);
                }
            }
        }

        private void BStart_Click(object sender, EventArgs e)
        {
            //Обробляємо вибрану доставку
            ProcessCurrentDelivery(delivery =>
            {
                //Якщо доставка не стартувала
                if (delivery.Status == DeliveryStatus.NotStarted)
                {
                    //Відправити доставку
                    delivery.Status = DeliveryStatus.OnTheWay;
                    //Запамятати її час відправки
                    delivery.StartTime = DateTime.Now;
                    //Зберегти зміни в базу данних
                    _deliveriesContext.SaveChanges();
                    //Оновити візуальну таблицю
                    DGDeliveries.Refresh();
                    //Оновлюємо стан кнопок дій
                    UpdateActionButtons();
                }
            });
        }

        private void BFinish_Click(object sender, EventArgs e)
        {
            //Обробляємо вибрану доставку
            ProcessCurrentDelivery(delivery =>
            {
                //Якщо доставка в процесі
                if (delivery.Status == DeliveryStatus.OnTheWay)
                {
                    //Оголошуємо її як доставлену
                    delivery.Status = DeliveryStatus.Deliveried;
                    //Записуємо час доставки
                    delivery.FinishTime = DateTime.Now;
                    //Зберігаємо зміни в базу данних
                    _deliveriesContext.SaveChanges();
                    //Оновлюємо візуальну таблицю
                    DGDeliveries.Refresh();
                    //Оновлюємо стан кнопок дій
                    UpdateActionButtons();
                }
            });
        }
    }
}
