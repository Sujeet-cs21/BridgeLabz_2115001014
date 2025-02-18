using System;
using System.Collections.Generic;

namespace PP_18_02_25
{
    // Interface for Meal Plans
    public interface IMealPlan
    {
        string GetMealType();
        void DisplayMeal();
    }

    // Specific Meal Plan Types
    public class VegetarianMeal : IMealPlan
    {
        public string MealName { get; set; }
        public VegetarianMeal(string mealName) { MealName = mealName; }

        public string GetMealType() => "Vegetarian";

        public void DisplayMeal()
        {
            Console.WriteLine("Meal: " + MealName + " | Type: Vegetarian");
        }
    }

    public class VeganMeal : IMealPlan
    {
        public string MealName { get; set; }
        public VeganMeal(string mealName) { MealName = mealName; }

        public string GetMealType() => "Vegan";

        public void DisplayMeal()
        {
            Console.WriteLine("Meal: " + MealName + " | Type: Vegan");
        }
    }

    public class KetoMeal : IMealPlan
    {
        public string MealName { get; set; }
        public KetoMeal(string mealName) { MealName = mealName; }

        public string GetMealType() => "Keto";

        public void DisplayMeal()
        {
            Console.WriteLine("Meal: " + MealName + " | Type: Keto");
        }
    }

    public class HighProteinMeal : IMealPlan
    {
        public string MealName { get; set; }
        public HighProteinMeal(string mealName) { MealName = mealName; }

        public string GetMealType() => "High-Protein";

        public void DisplayMeal()
        {
            Console.WriteLine("Meal: " + MealName + " | Type: High-Protein");
        }
    }

    // Generic Meal Class
    public class Meal<T> where T : IMealPlan
    {
        public T MealPlan { get; set; }

        public Meal(T mealPlan)
        {
            MealPlan = mealPlan;
        }

        public void ShowMeal()
        {
            MealPlan.DisplayMeal();
        }
    }

    // Meal Plan Manager
    public class MealPlanGenerator
    {
        private List<IMealPlan> mealPlans = new List<IMealPlan>();

        // Generic Method to Add Meal Plans Dynamically
        public void AddMeal<T>(T meal) where T : IMealPlan
        {
            mealPlans.Add(meal);
        }

        // Display All Meal Plans
        public void DisplayMealPlans()
        {
            Console.WriteLine("\n--- Personalized Meal Plans ---");
            foreach (var meal in mealPlans)
            {
                meal.DisplayMeal();
            }
        }
    }
    // Main Program
    class Class4
    {
        public static void Main4()
        {
            // Create Meal Instances
            VegetarianMeal vegMeal = new VegetarianMeal("Grilled Veggie Bowl");
            VeganMeal veganMeal = new VeganMeal("Avocado Salad");
            KetoMeal ketoMeal = new KetoMeal("Cheese & Bacon Omelette");
            HighProteinMeal proteinMeal = new HighProteinMeal("Chicken Breast with Quinoa");

            // Meal Objects using Generic Class
            Meal<VegetarianMeal> meal1 = new Meal<VegetarianMeal>(vegMeal);
            Meal<VeganMeal> meal2 = new Meal<VeganMeal>(veganMeal);
            Meal<KetoMeal> meal3 = new Meal<KetoMeal>(ketoMeal);
            Meal<HighProteinMeal> meal4 = new Meal<HighProteinMeal>(proteinMeal);

            // Meal Plan Generator
            MealPlanGenerator generator = new MealPlanGenerator();
            generator.AddMeal(vegMeal);
            generator.AddMeal(veganMeal);
            generator.AddMeal(ketoMeal);
            generator.AddMeal(proteinMeal);

            // Display All Meal Plans
            generator.DisplayMealPlans();
        }
    }

}
