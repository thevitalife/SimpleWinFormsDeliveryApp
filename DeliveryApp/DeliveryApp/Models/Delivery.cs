using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliveryApp.Models
{
    public class Delivery
    {
        public int DeliveryId { get; set; }
        public string FromLocation { get; set; }
        public string ToLocation { get; set; }
        public DateTime? StartTime { get; set; }
        public DateTime? FinishTime { get; set; }
        public string Description { get; set; }
        public Decimal Mass { get; set; }
        public DeliveryStatus Status { get; set; }

        //Зовнішній ключ - тип доставки
        public int DeliveryTypeId { get; set; }
        public virtual DeliveryType DeliveryType {get; set;}
    }
}
