using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace WE_Assignment.Models
{
    public class Enrolled
    {
        [Key]
        public int Id { get; set; }
        public int Cid { get; set; }
        public int Sid { get; set; }
    }
}
