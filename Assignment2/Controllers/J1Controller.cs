using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment2.Controllers
{
    public class J1Controller : ApiController
    {
        /// <summary>
        /// Calculates the total calories of the meal based on selected items.
        /// </summary>
        /// <param name="burger">
        /// Integer representing the burger choice.
        /// </param>
        /// <param name="drink">
        /// Integer representing the drink choice.
        /// </param>
        /// <param name="side">
        /// Integer representing the side choice.
        /// </param>
        /// <param name="dessert">
        /// Integer representing the dessert choice.
        /// </param>
        /// <returns>
        /// Total calorie count of the meal.
        /// </returns>
        /// <example>
        /// GET api/J1/Menu/4/4/4/4 => "Your total calorie count is 0"
        /// </example>
        /// <example>
        /// GET api/J1/Menu/1/2/3/4 => "Your total calorie count is 691"
        /// </example>
        [HttpGet]
        [Route("api/J1/Menu/{burger}/{drink}/{side}/{dessert}")]
        public string TotalCalories(int burger, int drink, int side, int dessert)
        {
            int burgerCalorie = GetBurgerCalories(burger);
            int drinkCalorie = GetDrinkCalories(drink);
            int sideCalorie = GetSideCalories(side);
            int dessertCalorie = GetDessertCalories(dessert);

            int totalCalories = burgerCalorie + drinkCalorie + sideCalorie + dessertCalorie;

            return $"Your total calorie count is {totalCalories}";
        }
        private int GetBurgerCalories(int choice)
        {
            switch (choice)
            {
                case 1: return 461;
                case 2: return 431;
                case 3: return 420;
                default: return 0;
            }
        }
        private int GetDrinkCalories(int choice)
        {
            switch (choice)
            {
                case 1: return 130;
                case 2: return 160;
                case 3: return 118;
                default: return 0;
            }
        }
        private int GetSideCalories(int choice)
        {
            switch (choice)
            {
                case 1: return 100;
                case 2: return 57;
                case 3: return 70;
                default: return 0;
            }
        }
        private int GetDessertCalories(int choice)
        {
            switch (choice)
            {
                case 1: return 167;
                case 2: return 266;
                case 3: return 75;
                default: return 0;
            }
        }
    }
}
