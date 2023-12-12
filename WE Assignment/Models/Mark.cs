using System.ComponentModel.DataAnnotations;

namespace WE_Assignment.Models
{
    public class Mark
    {
        [Key]
        public int Mid { get; set; }
        public int Sid { get; set; }
        public int Score { get; set; }
    }
}
