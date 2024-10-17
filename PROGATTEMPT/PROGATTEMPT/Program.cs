// See https://aka.ms/new-console-template for more information

using System;
using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;

public class Recipe
{
    public int RecipeID { get; set; }

    public int NumberOfIngredients { get; set; }

    public int NumberOfSteps { get; set; }

    public Ingredient[] Ingredients { get; set; }

    public Step[] Steps { get; set; }

    public Recipe()
    {
        Ingredients = new Ingredient[0];
        Steps = new Step[0];
    }

    // Method to scale ingredient quantities by a factor of 2
    public void ScaleRecpie(double factor)
    {
        foreach (var ingredient in Ingredients)
        {

            ingredient.Quantity *= factor;
        }
    }

    // Method to reset quantities to original 
    public void ResetQuantites()
    {
        //Note:assuming original quantities are stored
        //Such as,in a database or separate variable
        //of this example,we reset them to default
        foreach (var ingredient in Ingredients)
        {
            ingredient.Quantity = 1.0;
        }
    }

    //Method to clear all data and start a new recipe
    public void ClearRecipe()
    {
        NumberOfIngredients = 0;
        NumberOfSteps = 0;
        Ingredients = new Ingredient[0];
        Steps = new Step[0];
    }
}

public class Ingredient
{
    public int IngredientID { get; set; }

    public int RecipeID { get; set; }

    public string Name { get; set; }

    public double Quantity { get; set; }

    public string UnitOfMeasurement { get; set; }
}

public class Step
{

    public int StepID { get; set; }
    public int RecipeInt { get; set; }
    public string Description { get; set; }
    public int RecipeID { get; internal set; }
}

class Program
{
    private static int i;

    static void Main(string[] args)
    {
        // Create a new recipe
        Recipe myRecipe = new Recipe();

        //User enters recipe details
        Console.WriteLine("Enter the number of ingredients");
        myRecipe.NumberOfIngredients = int.Parse(Console.ReadLine());

        myRecipe.Ingredients = new Ingredient[myRecipe.NumberOfIngredients];
        for (int i = 0; i < myRecipe.NumberOfIngredients; i++) 
        {
            Console.WriteLine($"Enter the name of ingredients");
            string name = Console.ReadLine();

            Console.WriteLine($"Enter the quantity");
            double quantity = int.Parse(Console.ReadLine());

            Console.WriteLine($"Enter the unit of measurement");
            string unitOfMeasurement = Console.ReadLine();

            myRecipe.Ingredients[i] = new Ingredient
            {
                IngredientID = i + 1,
                RecipeID = myRecipe.RecipeID,
                Name = name,
                Quantity = quantity,
                UnitOfMeasurement = unitOfMeasurement,
            };
        }

        Console.WriteLine("Enter the number of steps");
        myRecipe.NumberOfSteps = int.Parse(Console.ReadLine());

        myRecipe.Steps = new Step[myRecipe.NumberOfSteps];
        for (int i = 0; i < myRecipe.NumberOfSteps; i++) ;
        {
            Console.WriteLine($"Enter step {i + 1}:");
            string description = Console.ReadLine();

            myRecipe.Steps[i] = new Step
            {
                StepID = i + 1,
                RecipeID = myRecipe.RecipeID,
                Description = description
            };
        }

        
    }
}

