using System.ComponentModel.DataAnnotations;

namespace FYPSwaggerApi.Models
{
    public class order_model
    {
        [Key]
        public int orderId { get; set; }

        public required string orderItemName { get; set; }

        public required string orderItemDescritpion { get; set; }

        public required string orderItemPrice { get; set;}

        public required string orderQuantity { get; set; }

        public required string dateTime { get; set; }
    }
}
