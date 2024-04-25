using System.ComponentModel.DataAnnotations;

namespace FYPSwaggerApi.Models
{
    public class user_model
    {
        [Key]
        public int userId { get; set; }

        public required string userName { get; set; }

        public required string userEmail { get; set; }

        public required string userPhone { get; set; }
    }
}
