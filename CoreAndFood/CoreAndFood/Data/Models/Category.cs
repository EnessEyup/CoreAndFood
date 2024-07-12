using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CoreAndFood.Data.Models
{
    public class Category
    {

        public int ID { get;  internal set; }
         [Required(ErrorMessage ="Category Name Can Not Be Empty")] 
         [StringLength(20,ErrorMessage ="Pls Enter Between 4-20 Characters",MinimumLength = 4)]
        public string CategoryName { get; set; }
        public string CategoryDescription { get; set; }

        public bool Status { get; set; }

        public List<Food> foods { get; set; }


    }
}
