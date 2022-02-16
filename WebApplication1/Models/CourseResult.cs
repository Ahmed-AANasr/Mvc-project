using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Models
{
    public class CourseResult
    {
        public int ID { get; set; }
        public decimal Degree { get; set; }

        [ForeignKey("crs")]
        public int? crs_id { get; set; }
        public Courses crs { get; set; }

        [ForeignKey("train")]
        public int train_id { get; set; }
        public Trainee train { get; set; }
    }
}
