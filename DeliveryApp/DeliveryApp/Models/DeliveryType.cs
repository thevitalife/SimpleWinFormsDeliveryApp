namespace DeliveryApp.Models
{
    public class DeliveryType
    {
        public int DeliveryTypeId { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }

        //Перетворення в стрічку даного типу - Назва (Ціна)
        public override string ToString()
        {
            return $"{Name} ({Price})";
        }
    }
}
