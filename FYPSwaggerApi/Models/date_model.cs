using System.ComponentModel.DataAnnotations;

namespace FYPSwaggerApi.Models
{
    public class date_model
    {
        [Key]
        public int dateId {  get; set; }

        public required String current_Date { get; set; }
    }
}
