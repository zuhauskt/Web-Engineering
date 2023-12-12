using System.ComponentModel.DataAnnotations;

namespace WE_Assignment.Models
{
    public class Class
    {

        [Key]
        public int Cid { get; set; }
        public string name { get; set; }
        public string RoomNumber { get; set; }
        public int Fid { get; set; }
        public int Enrolled { get; set; }
        public int Deptid { get; set; }
    }
}
