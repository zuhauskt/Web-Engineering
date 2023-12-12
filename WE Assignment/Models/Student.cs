using System.ComponentModel.DataAnnotations;

namespace WE_Assignment.Models
{
    public class Student
    {
        [Key]
        public int Sid { get; set; }
        public string Sname { get; set; }
        public string Major { get; set; }
        public string Standing { get; set; }

        public DateTime Birthdate { get; set; }
    }
}
