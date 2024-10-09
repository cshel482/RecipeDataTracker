using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeData.Models
{
    internal class MealModel
    {
        [Key]
        public string Meal { get; set; }
        public int userID { get; set; }
    }
}
