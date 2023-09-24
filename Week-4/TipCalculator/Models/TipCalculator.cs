using System.ComponentModel.DataAnnotations;

namespace TipCalculator.Models
{
    public class Calculator
    {
        [Required(ErrorMessage = "Please enter a value for cost of meal.")]
        [Range(0.0, 10000000.0, ErrorMessage = "Cost of meal must be greater than zero.")]
        public double? MealCost { get; set; }

        public double CalculateTip(double percent)
        {
            if (MealCost.HasValue)
            {
                //should be multiplying, not dividing these values
                double tip = MealCost.Value * percent;
                // added ';' at the end of the next line
                return tip;
            }
            else
            {
                return 0;
            }
        }
    }
}