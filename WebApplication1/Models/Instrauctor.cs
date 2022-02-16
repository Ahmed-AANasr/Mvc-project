using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Models
{
    public class Instrauctor
    {
        public int ID { get; set; }

        [Display(Name = "Instrauctor Name")]
        [Required(ErrorMessage ="Name Is Required")]
        [RegularExpression(pattern:"[a-zA-Z ]{3,}",
                                    ErrorMessage="Name Must Have Litters Only and More Than 3 Litters")]
        [Remote(action: "CheckName", controller: "Instrauctor", AdditionalFields = "ID", ErrorMessage = "Name is exist")]
        public string Name { get; set; }

        [Display(Name = "Instrauctor Salary")]
        [Required(ErrorMessage = "Salary Is Required")]
        [Range(minimum: 2000, maximum: 50000)]
       
        public decimal Salary { get; set; }

        [Display(Name = "Instrauctor Image")]
        [Required(ErrorMessage = "Image Is Required")]

        public string Image { get; set; }
        [Display(Name = "Instrauctor Address")]
        [Required(ErrorMessage = "Adress Is Required")]
        [CustomValidation]
        public string Address { get; set; }
        

        [ForeignKey("dep")]
        [Display(Name = "Department Name")]
        [Required(ErrorMessage = "Department Name Is Required")]
        public int  dep_id { get; set; }
        public Department dep { get; set; }

        [ForeignKey("crs")]
        [Display(Name = "Course Name")]
        [Required(ErrorMessage = "Course Name Is Required")]
        public int? crs_id{ get; set; }
        public Courses crs { get; set; }

    }
}
