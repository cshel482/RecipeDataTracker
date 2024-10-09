using Microsoft.IdentityModel.Tokens;
using Newtonsoft.Json.Linq;
using RecipeData.Models;
using System;
using System.Net.Http;
using System.Windows.Forms;

namespace RecipeData
{
    public partial class Form1 : Form
    {

        CocktailModel cocktailModel;
        RecipeModel recipeModel;
        MealModel mealModel;
        int globalUserID;



        public Form1(int userID)
        {
            globalUserID = userID;
            InitializeComponent();
            DBServices.CreateLoginTable();
            DBServices.CreateMealTable();
            DBServices.CreateRecipeTable();
            DBServices.CreateCocktailTable();
            FillComboBox();
        }

        private void FillComboBox()
        {
            cmbMeals.Items.Clear();
            List<string> mealNames = DBServices.QueryAllMealNamesList(globalUserID); ;
            foreach (var meal in mealNames)
            {
                cmbMeals.Items.Add(meal);
            }


        }

        private async void BtnSearch_Click(object sender, EventArgs e)
        {
            string recipeName = txtRecipe.Text;
            string cocktailName = txtCocktail.Text;

            if (!recipeName.IsNullOrEmpty() || !cocktailName.IsNullOrEmpty())
            {

                string recipeApiUrl = $"https://www.themealdb.com/api/json/v1/1/search.php?s={recipeName}";
                string cocktailApiUrl = $"https://www.thecocktaildb.com/api/json/v1/1/search.php?s={cocktailName}";

                using (HttpClient client = new HttpClient())
                {

                    HttpResponseMessage recipeResponse = await client.GetAsync(recipeApiUrl);

                    if (recipeResponse.IsSuccessStatusCode)
                    {
                        string recipeResponseBody = await recipeResponse.Content.ReadAsStringAsync();
                        JObject recipeJsonObject = JObject.Parse(recipeResponseBody);

                        JArray mealsArray = (JArray)recipeJsonObject["meals"];

                        if (mealsArray != null && mealsArray.Count > 0)
                        {
                            JObject firstMeal = (JObject)mealsArray[0];

                            lblRecIng1.Text = (string)firstMeal["strIngredient1"];
                            lblRecIng2.Text = (string)firstMeal["strIngredient2"];
                            lblRecIng3.Text = (string)firstMeal["strIngredient3"];
                            lblRecIng4.Text = (string)firstMeal["strIngredient4"];
                            lblRecIng5.Text = (string)firstMeal["strIngredient5"];
                            lblRecIng6.Text = (string)firstMeal["strIngredient6"];
                            lblRecIng7.Text = (string)firstMeal["strIngredient7"];
                            lblRecIng8.Text = (string)firstMeal["strIngredient8"];
                            lblRecIng9.Text = (string)firstMeal["strIngredient9"];
                            lblRecIng10.Text = (string)firstMeal["strIngredient10"];
                            lblRecIng11.Text = (string)firstMeal["strIngredient11"];
                            lblRecIng12.Text = (string)firstMeal["strIngredient12"];
                            lblRecIng13.Text = (string)firstMeal["strIngredient13"];
                            lblRecIng14.Text = (string)firstMeal["strIngredient14"];
                            lblRecIng15.Text = (string)firstMeal["strIngredient15"];
                            lblRecIng16.Text = (string)firstMeal["strIngredient16"];
                            lblRecIng17.Text = (string)firstMeal["strIngredient17"];
                            lblRecIng18.Text = (string)firstMeal["strIngredient18"];
                            lblRecIng19.Text = (string)firstMeal["strIngredient19"];
                            lblRecIng20.Text = (string)firstMeal["strIngredient20"];

                            lblRecMsr1.Text = (string)firstMeal["strMeasure1"];
                            lblRecMsr2.Text = (string)firstMeal["strMeasure2"];
                            lblRecMsr3.Text = (string)firstMeal["strMeasure3"];
                            lblRecMsr4.Text = (string)firstMeal["strMeasure4"];
                            lblRecMsr5.Text = (string)firstMeal["strMeasure5"];
                            lblRecMsr6.Text = (string)firstMeal["strMeasure6"];
                            lblRecMsr7.Text = (string)firstMeal["strMeasure7"];
                            lblRecMsr8.Text = (string)firstMeal["strMeasure8"];
                            lblRecMsr9.Text = (string)firstMeal["strMeasure9"];
                            lblRecMsr10.Text = (string)firstMeal["strMeasure10"];
                            lblRecMsr11.Text = (string)firstMeal["strMeasure11"];
                            lblRecMsr12.Text = (string)firstMeal["strMeasure12"];
                            lblRecMsr13.Text = (string)firstMeal["strMeasure13"];
                            lblRecMsr14.Text = (string)firstMeal["strMeasure14"];
                            lblRecMsr15.Text = (string)firstMeal["strMeasure15"];
                            lblRecMsr16.Text = (string)firstMeal["strMeasure16"];
                            lblRecMsr17.Text = (string)firstMeal["strMeasure17"];
                            lblRecMsr18.Text = (string)firstMeal["strMeasure18"];
                            lblRecMsr19.Text = (string)firstMeal["strMeasure19"];
                            lblRecMsr20.Text = (string)firstMeal["strMeasure20"];

                            lblRecipeInstructions.Text = (string)firstMeal["strInstructions"];

                            recipeModel = new RecipeModel();
                            recipeModel.RecipeIng1 = (string)firstMeal["strIngredient1"];
                            recipeModel.RecipeIng2 = (string)firstMeal["strIngredient2"];
                            recipeModel.RecipeIng3 = (string)firstMeal["strIngredient3"];
                            recipeModel.RecipeIng4 = (string)firstMeal["strIngredient4"];
                            recipeModel.RecipeIng5 = (string)firstMeal["strIngredient5"];
                            recipeModel.RecipeIng6 = (string)firstMeal["strIngredient6"];
                            recipeModel.RecipeIng7 = (string)firstMeal["strIngredient7"];
                            recipeModel.RecipeIng8 = (string)firstMeal["strIngredient8"];
                            recipeModel.RecipeIng9 = (string)firstMeal["strIngredient9"];
                            recipeModel.RecipeIng10 = (string)firstMeal["strIngredient10"];
                            recipeModel.RecipeIng11 = (string)firstMeal["strIngredient11"];
                            recipeModel.RecipeIng12 = (string)firstMeal["strIngredient12"];
                            recipeModel.RecipeIng13 = (string)firstMeal["strIngredient13"];
                            recipeModel.RecipeIng14 = (string)firstMeal["strIngredient14"];
                            recipeModel.RecipeIng15 = (string)firstMeal["strIngredient15"];
                            recipeModel.RecipeIng16 = (string)firstMeal["strIngredient16"];
                            recipeModel.RecipeIng17 = (string)firstMeal["strIngredient17"];
                            recipeModel.RecipeIng18 = (string)firstMeal["strIngredient18"];
                            recipeModel.RecipeIng19 = (string)firstMeal["strIngredient19"];
                            recipeModel.RecipeIng20 = (string)firstMeal["strIngredient20"];
                            recipeModel.RecipeMsr1 = (string)firstMeal["strMeasure1"];
                            recipeModel.RecipeMsr2 = (string)firstMeal["strMeasure2"];
                            recipeModel.RecipeMsr3 = (string)firstMeal["strMeasure3"];
                            recipeModel.RecipeMsr4 = (string)firstMeal["strMeasure4"];
                            recipeModel.RecipeMsr5 = (string)firstMeal["strMeasure5"];
                            recipeModel.RecipeMsr6 = (string)firstMeal["strMeasure6"];
                            recipeModel.RecipeMsr7 = (string)firstMeal["strMeasure7"];
                            recipeModel.RecipeMsr8 = (string)firstMeal["strMeasure8"];
                            recipeModel.RecipeMsr9 = (string)firstMeal["strMeasure9"];
                            recipeModel.RecipeMsr10 = (string)firstMeal["strMeasure10"];
                            recipeModel.RecipeMsr11 = (string)firstMeal["strMeasure11"];
                            recipeModel.RecipeMsr12 = (string)firstMeal["strMeasure12"];
                            recipeModel.RecipeMsr13 = (string)firstMeal["strMeasure13"];
                            recipeModel.RecipeMsr14 = (string)firstMeal["strMeasure14"];
                            recipeModel.RecipeMsr15 = (string)firstMeal["strMeasure15"];
                            recipeModel.RecipeMsr16 = (string)firstMeal["strMeasure16"];
                            recipeModel.RecipeMsr17 = (string)firstMeal["strMeasure17"];
                            recipeModel.RecipeMsr18 = (string)firstMeal["strMeasure18"];
                            recipeModel.RecipeMsr19 = (string)firstMeal["strMeasure19"];
                            recipeModel.RecipeMsr20 = (string)firstMeal["strMeasure20"];
                            recipeModel.RecipeInstructions = (string)firstMeal["strInstructions"];
                            recipeModel.Meal = txtMealName.Text;
                            recipeModel.UserID = globalUserID;
                        }
                        else
                        {

                            lblError.Text = "Recipe was not found";
                        }
                    }
                    else
                    {
                        Console.WriteLine($"Error: {recipeResponse.StatusCode} - {recipeResponse.ReasonPhrase}");
                    }
                    mealModel = new MealModel();

                    ///////////////////////////////////////////
                    mealModel.userID = globalUserID;
                    mealModel.Meal = txtMealName.Text;
                    ///////////////////////////////////////////
                }

                using (HttpClient client = new HttpClient())
                {

                    HttpResponseMessage cocktailResponse = await client.GetAsync(cocktailApiUrl);

                    if (cocktailResponse.IsSuccessStatusCode)
                    {
                        string cocktailResponseBody = await cocktailResponse.Content.ReadAsStringAsync();
                        JObject cocktailJsonObject = JObject.Parse(cocktailResponseBody);

                        JArray cocktailArray = (JArray)cocktailJsonObject["drinks"];


                        if (cocktailArray != null && cocktailArray.Count > 0)
                        {
                            JObject firstCocktail = (JObject)cocktailArray[0];

                            lblCocIng1.Text = (string)firstCocktail["strIngredient1"];
                            lblCocIng2.Text = (string)firstCocktail["strIngredient2"];
                            lblCocIng3.Text = (string)firstCocktail["strIngredient3"];
                            lblCocIng4.Text = (string)firstCocktail["strIngredient4"];
                            lblCocIng5.Text = (string)firstCocktail["strIngredient5"];
                            lblCocIng6.Text = (string)firstCocktail["strIngredient6"];
                            lblCocIng7.Text = (string)firstCocktail["strIngredient7"];
                            lblCocIng8.Text = (string)firstCocktail["strIngredient8"];
                            lblCocIng9.Text = (string)firstCocktail["strIngredient9"];
                            lblCocIng10.Text = (string)firstCocktail["strIngredient10"];
                            lblCocIng11.Text = (string)firstCocktail["strIngredient11"];
                            lblCocIng12.Text = (string)firstCocktail["strIngredient12"];
                            lblCocIng13.Text = (string)firstCocktail["strIngredient13"];
                            lblCocIng14.Text = (string)firstCocktail["strIngredient14"];
                            lblCocIng15.Text = (string)firstCocktail["strIngredient15"];

                            lblCocMsr1.Text = (string)firstCocktail["strMeasure1"];
                            lblCocMsr2.Text = (string)firstCocktail["strMeasure2"];
                            lblCocMsr3.Text = (string)firstCocktail["strMeasure3"];
                            lblCocMsr4.Text = (string)firstCocktail["strMeasure4"];
                            lblCocMsr5.Text = (string)firstCocktail["strMeasure5"];
                            lblCocMsr6.Text = (string)firstCocktail["strMeasure6"];
                            lblCocMsr7.Text = (string)firstCocktail["strMeasure7"];
                            lblCocMsr8.Text = (string)firstCocktail["strMeasure8"];
                            lblCocMsr9.Text = (string)firstCocktail["strMeasure9"];
                            lblCocMsr10.Text = (string)firstCocktail["strMeasure10"];
                            lblCocMsr11.Text = (string)firstCocktail["strMeasure11"];
                            lblCocMsr12.Text = (string)firstCocktail["strMeasure12"];
                            lblCocMsr13.Text = (string)firstCocktail["strMeasure13"];
                            lblCocMsr14.Text = (string)firstCocktail["strMeasure14"];
                            lblCocMsr15.Text = (string)firstCocktail["strMeasure15"];

                            cocktailModel = new CocktailModel();
                            cocktailModel.Meal = txtMealName.Text;
                            cocktailModel.CocktailIng1 = (string)firstCocktail["strIngredient1"];
                            cocktailModel.CocktailIng2 = (string)firstCocktail["strIngredient2"];
                            cocktailModel.CocktailIng3 = (string)firstCocktail["strIngredient3"];
                            cocktailModel.CocktailIng4 = (string)firstCocktail["strIngredient4"];
                            cocktailModel.CocktailIng5 = (string)firstCocktail["strIngredient5"];
                            cocktailModel.CocktailIng6 = (string)firstCocktail["strIngredient6"];
                            cocktailModel.CocktailIng7 = (string)firstCocktail["strIngredient7"];
                            cocktailModel.CocktailIng8 = (string)firstCocktail["strIngredient8"];
                            cocktailModel.CocktailIng9 = (string)firstCocktail["strIngredient9"];
                            cocktailModel.CocktailIng10 = (string)firstCocktail["strIngredient10"];
                            cocktailModel.CocktailIng11 = (string)firstCocktail["strIngredient11"];
                            cocktailModel.CocktailIng12 = (string)firstCocktail["strIngredient12"];
                            cocktailModel.CocktailIng13 = (string)firstCocktail["strIngredient13"];
                            cocktailModel.CocktailIng14 = (string)firstCocktail["strIngredient14"];
                            cocktailModel.CocktailIng15 = (string)firstCocktail["strIngredient15"];
                            cocktailModel.CocktailMsr1 = (string)firstCocktail["strMeasure1"];
                            cocktailModel.CocktailMsr2 = (string)firstCocktail["strMeasure2"];
                            cocktailModel.CocktailMsr3 = (string)firstCocktail["strMeasure3"];
                            cocktailModel.CocktailMsr4 = (string)firstCocktail["strMeasure4"];
                            cocktailModel.CocktailMsr5 = (string)firstCocktail["strMeasure5"];
                            cocktailModel.CocktailMsr6 = (string)firstCocktail["strMeasure6"];
                            cocktailModel.CocktailMsr7 = (string)firstCocktail["strMeasure7"];
                            cocktailModel.CocktailMsr8 = (string)firstCocktail["strMeasure8"];
                            cocktailModel.CocktailMsr9 = (string)firstCocktail["strMeasure9"];
                            cocktailModel.CocktailMsr10 = (string)firstCocktail["strMeasure10"];
                            cocktailModel.CocktailMsr11 = (string)firstCocktail["strMeasure11"];
                            cocktailModel.CocktailMsr12 = (string)firstCocktail["strMeasure12"];
                            cocktailModel.CocktailMsr13 = (string)firstCocktail["strMeasure13"];
                            cocktailModel.CocktailMsr14 = (string)firstCocktail["strMeasure14"];
                            cocktailModel.CocktailMsr15 = (string)firstCocktail["strMeasure15"];
                            cocktailModel.UserID = globalUserID;
                        }
                    }
                    else
                    {
                        Console.WriteLine($"Error: {cocktailResponse.StatusCode} - {cocktailResponse.ReasonPhrase}");
                    }
                }

                BtnSaveMeal.Visible = true;
            }
            else 
            {
                lblError.Text = "Fields cannot be blank";
            }
        }

        private void BtnSaveMeal_Click(object sender, EventArgs e)
        {
            if (!radioUpdate.Checked)
            {
                DBServices.InsertMealData(mealModel);
                DBServices.InsertRecipeData(recipeModel);
                DBServices.InsertCocktailData(cocktailModel);
                cmbMeals.Items.Add(mealModel.Meal);
            }
            else 
            {
                DBServices.DeleteRecipe(mealModel.Meal, globalUserID);
                DBServices.DeleteCocktail(mealModel.Meal, globalUserID);
                DBServices.DeleteMeal(mealModel.Meal, globalUserID);

                DBServices.InsertMealData(mealModel);
                DBServices.InsertRecipeData(recipeModel);
                DBServices.InsertCocktailData(cocktailModel);
            }
            

        }

        private void cmbMeals_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedMeal = cmbMeals.SelectedItem.ToString();
            lblRecIng1.Text = DBServices.QueryRecipeIngredientList(selectedMeal, 1, globalUserID);
            lblRecIng2.Text = DBServices.QueryRecipeIngredientList(selectedMeal, 2, globalUserID);
            lblRecIng3.Text = DBServices.QueryRecipeIngredientList(selectedMeal, 3, globalUserID);
            lblRecIng4.Text = DBServices.QueryRecipeIngredientList(selectedMeal, 4, globalUserID);
            lblRecIng5.Text = DBServices.QueryRecipeIngredientList(selectedMeal, 5, globalUserID);
            lblRecIng6.Text = DBServices.QueryRecipeIngredientList(selectedMeal, 6, globalUserID);
            lblRecIng7.Text = DBServices.QueryRecipeIngredientList(selectedMeal, 7, globalUserID);
            lblRecIng8.Text = DBServices.QueryRecipeIngredientList(selectedMeal, 8, globalUserID);
            lblRecIng9.Text = DBServices.QueryRecipeIngredientList(selectedMeal, 9, globalUserID);
            lblRecIng10.Text = DBServices.QueryRecipeIngredientList(selectedMeal, 10, globalUserID);
            lblRecIng11.Text = DBServices.QueryRecipeIngredientList(selectedMeal, 11, globalUserID);
            lblRecIng12.Text = DBServices.QueryRecipeIngredientList(selectedMeal, 12, globalUserID);
            lblRecIng13.Text = DBServices.QueryRecipeIngredientList(selectedMeal, 13, globalUserID);
            lblRecIng14.Text = DBServices.QueryRecipeIngredientList(selectedMeal, 14, globalUserID);
            lblRecIng15.Text = DBServices.QueryRecipeIngredientList(selectedMeal, 15, globalUserID);
            lblRecIng16.Text = DBServices.QueryRecipeIngredientList(selectedMeal, 16, globalUserID);
            lblRecIng17.Text = DBServices.QueryRecipeIngredientList(selectedMeal, 17, globalUserID);
            lblRecIng18.Text = DBServices.QueryRecipeIngredientList(selectedMeal, 18, globalUserID);
            lblRecIng19.Text = DBServices.QueryRecipeIngredientList(selectedMeal, 19, globalUserID);
            lblRecIng20.Text = DBServices.QueryRecipeIngredientList(selectedMeal, 20, globalUserID);
            lblRecMsr1.Text = DBServices.QueryRecipeMeasureList(selectedMeal, 1, globalUserID);
            lblRecMsr2.Text = DBServices.QueryRecipeMeasureList(selectedMeal, 2, globalUserID);
            lblRecMsr3.Text = DBServices.QueryRecipeMeasureList(selectedMeal, 3, globalUserID);
            lblRecMsr4.Text = DBServices.QueryRecipeMeasureList(selectedMeal, 4, globalUserID);
            lblRecMsr5.Text = DBServices.QueryRecipeMeasureList(selectedMeal, 5, globalUserID);
            lblRecMsr6.Text = DBServices.QueryRecipeMeasureList(selectedMeal, 6, globalUserID);
            lblRecMsr7.Text = DBServices.QueryRecipeMeasureList(selectedMeal, 7, globalUserID);
            lblRecMsr8.Text = DBServices.QueryRecipeMeasureList(selectedMeal, 8, globalUserID);
            lblRecMsr9.Text = DBServices.QueryRecipeMeasureList(selectedMeal, 9, globalUserID);
            lblRecMsr10.Text = DBServices.QueryRecipeMeasureList(selectedMeal, 10, globalUserID);
            lblRecMsr11.Text = DBServices.QueryRecipeMeasureList(selectedMeal, 11, globalUserID);
            lblRecMsr12.Text = DBServices.QueryRecipeMeasureList(selectedMeal, 12, globalUserID);
            lblRecMsr13.Text = DBServices.QueryRecipeMeasureList(selectedMeal, 13, globalUserID);
            lblRecMsr14.Text = DBServices.QueryRecipeMeasureList(selectedMeal, 14, globalUserID);
            lblRecMsr15.Text = DBServices.QueryRecipeMeasureList(selectedMeal, 15, globalUserID);
            lblRecMsr16.Text = DBServices.QueryRecipeMeasureList(selectedMeal, 16, globalUserID);
            lblRecMsr17.Text = DBServices.QueryRecipeMeasureList(selectedMeal, 17, globalUserID);
            lblRecMsr18.Text = DBServices.QueryRecipeMeasureList(selectedMeal, 18, globalUserID);
            lblRecMsr19.Text = DBServices.QueryRecipeMeasureList(selectedMeal, 19, globalUserID);
            lblRecMsr20.Text = DBServices.QueryRecipeMeasureList(selectedMeal, 20, globalUserID);
            lblCocIng1.Text = DBServices.QueryCocktailIngredientList(selectedMeal, 1, globalUserID);
            lblCocIng2.Text = DBServices.QueryCocktailIngredientList(selectedMeal, 2, globalUserID);
            lblCocIng3.Text = DBServices.QueryCocktailIngredientList(selectedMeal, 3, globalUserID);
            lblCocIng4.Text = DBServices.QueryCocktailIngredientList(selectedMeal, 4, globalUserID);
            lblCocIng5.Text = DBServices.QueryCocktailIngredientList(selectedMeal, 5, globalUserID);
            lblCocIng6.Text = DBServices.QueryCocktailIngredientList(selectedMeal, 6, globalUserID);
            lblCocIng7.Text = DBServices.QueryCocktailIngredientList(selectedMeal, 7, globalUserID);
            lblCocIng8.Text = DBServices.QueryCocktailIngredientList(selectedMeal, 8, globalUserID);
            lblCocIng9.Text = DBServices.QueryCocktailIngredientList(selectedMeal, 9, globalUserID);
            lblCocIng10.Text = DBServices.QueryCocktailIngredientList(selectedMeal, 10, globalUserID);
            lblCocIng11.Text = DBServices.QueryCocktailIngredientList(selectedMeal, 11, globalUserID);
            lblCocIng12.Text = DBServices.QueryCocktailIngredientList(selectedMeal, 12, globalUserID);
            lblCocIng13.Text = DBServices.QueryCocktailIngredientList(selectedMeal, 13, globalUserID);
            lblCocIng14.Text = DBServices.QueryCocktailIngredientList(selectedMeal, 14, globalUserID);
            lblCocIng15.Text = DBServices.QueryCocktailIngredientList(selectedMeal, 15, globalUserID);
            lblCocMsr1.Text = DBServices.QueryCocktailMeasureList(selectedMeal, 1, globalUserID);
            lblCocMsr2.Text = DBServices.QueryCocktailMeasureList(selectedMeal, 2, globalUserID);
            lblCocMsr3.Text = DBServices.QueryCocktailMeasureList(selectedMeal, 3, globalUserID);
            lblCocMsr4.Text = DBServices.QueryCocktailMeasureList(selectedMeal, 4, globalUserID);
            lblCocMsr5.Text = DBServices.QueryCocktailMeasureList(selectedMeal, 5, globalUserID);
            lblCocMsr6.Text = DBServices.QueryCocktailMeasureList(selectedMeal, 6, globalUserID);
            lblCocMsr7.Text = DBServices.QueryCocktailMeasureList(selectedMeal, 7, globalUserID);
            lblCocMsr8.Text = DBServices.QueryCocktailMeasureList(selectedMeal, 8, globalUserID);
            lblCocMsr9.Text = DBServices.QueryCocktailMeasureList(selectedMeal, 9, globalUserID);
            lblCocMsr10.Text = DBServices.QueryCocktailMeasureList(selectedMeal, 10, globalUserID);
            lblCocMsr11.Text = DBServices.QueryCocktailMeasureList(selectedMeal, 11, globalUserID);
            lblCocMsr12.Text = DBServices.QueryCocktailMeasureList(selectedMeal, 12, globalUserID);
            lblCocMsr13.Text = DBServices.QueryCocktailMeasureList(selectedMeal, 13, globalUserID);
            lblCocMsr14.Text = DBServices.QueryCocktailMeasureList(selectedMeal, 14, globalUserID);
            lblCocMsr15.Text = DBServices.QueryCocktailMeasureList(selectedMeal, 15, globalUserID);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            string meal = cmbMeals.SelectedItem.ToString();
            if (radioBtn.Checked && !meal.IsNullOrEmpty())
            {
                DBServices.DeleteRecipe(meal, globalUserID);
                DBServices.DeleteCocktail(meal, globalUserID);
                DBServices.DeleteMeal(meal, globalUserID);
            }
            else 
            {
                lblError.Text = "Make sure you have the delete button checked before you delete ";
            }
        }
    }
}
