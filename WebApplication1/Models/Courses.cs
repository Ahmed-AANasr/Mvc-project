using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Models
{
    public class Courses
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Degree { get; set; }
        public int MinDegree { get; set; }

        [ForeignKey("dep")]
        public int dep_id { get; set; }
        public Department dep { get; set; }
    }
}