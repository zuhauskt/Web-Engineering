using System.ComponentModel.DataAnnotations;

namespace WE_Assignment.Models
{
    public class Faculty
    {
        [Key]
        public int Cid { get; set; }
        public string Name { get; set; }
        public string RoomNumber { get; set; }
        public int Fid { get; set; }
        public int Deptid { get; set; }
    }
}
