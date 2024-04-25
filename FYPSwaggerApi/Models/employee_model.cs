using System.ComponentModel.DataAnnotations;

namespace FYPSwaggerApi.Models
{
    public class employee_model
    {
        [Key]
        public int employeeId { get; set; }

        public required string employeeName { get; set;}

        public required string employeeEmail { get; set; }

        public required string employeePhone { get; set;}

        


        
    }
}
