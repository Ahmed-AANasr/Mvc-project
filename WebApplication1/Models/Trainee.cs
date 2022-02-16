using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Models
{
    public class Trainee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public string Adress { get; set; }
        public decimal Degree { get; set; }

        [ForeignKey("dep")]
        public int dep_id { get; set; }
        public Department dep { get; set; }

        [ForeignKey("crs")]
        public int? crs_id { get; set; }
        public Courses crs { get; set; }
    }
}
