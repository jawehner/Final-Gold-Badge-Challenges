using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_1
{
    class ProgramUI
    {

        MealRepository _mealRepo = new MealRepository();

        List<Meal> _meals;

        public void Run()
        {
            _meals = _mealRepo.GetMeals();
            bool isRunning = true;
            while (isRunning)
            {
                Console.WriteLine("Choose an action:" +
                    "\n1. Create new meal" +
                    "\n2. See current menu" +
                    "\n3. Delete meal from menu" +
                    "\n4. Exit");

                int input = int.Parse(Console.ReadLine());
                switch (input)
                {
                    case 1:
                        CreateNewMeal();
                        break;
                    case 2:
                        SeeCurrentMenu();
                        break;
                    case 3:
                        DeleteMeal();
                        break;
                    case 4:
                        isRunning = false;
                        Console.WriteLine("Goodbye!");
                        Console.ReadLine();
                        break;
                    default:
                        Console.WriteLine("Invalid response.");
                        Console.ReadLine();
                        break;
                }
            }

            void CreateNewMeal()
            {
                Meal newMeal = new Meal();

                Console.WriteLine("Name of meal:");
                newMeal.Name = Console.ReadLine();

                Console.WriteLine("Meal description:");
                newMeal.Description = Console.ReadLine();

                Console.WriteLine("Meal ingredients:");
                newMeal.Ingredients = Console.ReadLine();

                Console.WriteLine("Meal ID number:");
                newMeal.Number = int.Parse(Console.ReadLine());

                _mealRepo.AddMealToList(newMeal);
            }

            void SeeCurrentMenu()
            {
                foreach (Meal content in _meals)
                {
                    Console.WriteLine(content.Name);
                }
            }

            void DeleteMeal()
            {
                Console.WriteLine("Enter the meal number ID you want to delete:");
                foreach (Meal meal in _meals)
                {
                    Console.WriteLine(meal.Number);
                }
                int deleteMeal = int.Parse(Console.ReadLine());

                foreach (Meal meal in _meals)
                {
                    if (deleteMeal == meal.Number)
                    {
                        _meals.Remove(meal);
                        break;
                    }
                }
            }
        }
    }
}