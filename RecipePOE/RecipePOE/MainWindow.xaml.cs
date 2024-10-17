using POE;
using System.Windows;
using System.Windows.Controls;

namespace RecipePOE
{
    public partial class MainWindow : Window
    {
        private Dictionary<string, Recipe> dictionaryRecipe = new Dictionary<string, Recipe>();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void AddRecipeButton_Click(object sender, RoutedEventArgs e)
        {
            // Add Recipe button click logic here
            AddRecipeWindow addRecipeWindow = new AddRecipeWindow(dictionaryRecipe);
            addRecipeWindow.ShowDialog();
        }

        private void SearchRecipeButton_Click(object sender, RoutedEventArgs e)
        {
            string recipeName = Microsoft.VisualBasic.Interaction.InputBox("Enter recipe name:", "Search Recipe", "");
            if (dictionaryRecipe.ContainsKey(recipeName))
            {
                RecipeDetailsTextBox.Text = dictionaryRecipe[recipeName].GetDetails();
            }
            else
            {
                MessageBox.Show("Recipe not found.");
            }
        }

        private void DisplayRecipeButton_Click(object sender, RoutedEventArgs e)
        {
            // Display Recipe button click logic here
            MessageBox.Show("Display Recipe button clicked");
        }

        private void ExitButton_Click(object sender, RoutedEventArgs e)
        {
            // Exit button click logic here
            Application.Current.Shutdown();
        }

        private void RecipeDetailsTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            // RecipeDetailsTextBox text changed logic here
        }

        private void ApplyScaleButton_Click(object sender, RoutedEventArgs e)
        {
            // Apply Scale button click logic here
            MessageBox.Show("Apply Scale button clicked");
        }

        private void ResetQuantitiesButton_Click(object sender, RoutedEventArgs e)
        {
            // Reset Quantities button click logic here
            MessageBox.Show("Reset Quantities button clicked");
        }

        private void FilterIngredientTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            // FilterIngredientTextBox text changed logic here
        }

        private void FilterByIngredientButton_Click(object sender, RoutedEventArgs e)
        {
            // Filter by Ingredient button click logic here
            MessageBox.Show("Filter by Ingredient button clicked");
        }

        private void FoodGroupComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // FoodGroupComboBox selection changed logic here
        }

        private void FilterByFoodGroupButton_Click(object sender, RoutedEventArgs e)
        {
            // Filter by Food Group button click logic here
            MessageBox.Show("Filter by Food Group button clicked");
        }

        private void MaxCaloriesTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            // MaxCaloriesTextBox text changed logic here
        }

        private void FilterByCaloriesButton_Click(object sender, RoutedEventArgs e)
        {
            // Filter by Calories button click logic here
            MessageBox.Show("Filter by Calories button clicked");
        }

        private void ShowMenuPieChartButton_Click(object sender, RoutedEventArgs e)
        {
            // Show Menu Pie Chart button click logic here
            MessageBox.Show("Show Menu Pie Chart button clicked");
        }
    }
}
