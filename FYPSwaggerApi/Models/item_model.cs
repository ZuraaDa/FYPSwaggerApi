using System.ComponentModel.DataAnnotations;

namespace FYPSwaggerApi.Models
{
    public class item_model
    {
        [Key]
        public int itemId { get; set; }

        public required string itemName { get; set; }

        public required string itemPrice { get; set; }

        public required string itemDescription { get; set; }

        public required string itemLeft {  get; set; }

        
    }
}
