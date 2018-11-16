using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_1
{
    public class MealRepository
    {
        List<Meal> _meals = new List<Meal>();

        public void AddMealToList(Meal meal)
        {
            _meals.Add(meal);
        }

        public List<Meal> GetMeals()
        {
            return _meals;
        }
    }
}
