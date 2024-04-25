using System.ComponentModel.DataAnnotations;

namespace FYPSwaggerApi.Models
{
    public class note_model
    {
        [Key]
        public int noteId { get; set; }

        public required string title { get; set; }

        public required string note { get; set; }

        public required string dateTime { get; set; }
    }
}
