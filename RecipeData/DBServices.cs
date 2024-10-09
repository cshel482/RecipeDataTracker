using RecipeData.Models;
using Microsoft.Data.SqlClient;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Google.Protobuf.WellKnownTypes;
using System.Windows.Forms.VisualStyles;
using System.Diagnostics.Metrics;



namespace RecipeData
{
    internal class DBServices
    {

        public static void CreateMealTable()
        {
            string constring = DatabaseConnection.DbConnection();
            using (MySqlConnection con = new MySqlConnection(constring))
            {
                con.Open();
                string query = "CREATE TABLE IF NOT EXISTS meal_data (" +
    
    "Meal VARCHAR(255) PRIMARY KEY, " +
    "UserID INT, " +
    "FOREIGN KEY (UserID) REFERENCES login_data(UserID)" +
");";



                using (MySqlCommand cmd = new MySqlCommand(query, con))
                {
                    MySqlDataReader reader = cmd.ExecuteReader();

                }
            }
        }

        public static void CreateLoginTable()
        {
            string constring = DatabaseConnection.DbConnection();
            using (MySqlConnection con = new MySqlConnection(constring))
            {
                con.Open();
                string query = "CREATE TABLE IF NOT EXISTS login_data (" +
    "UserID INT PRIMARY KEY AUTO_INCREMENT, " +
    "FirstName VARCHAR(255), " +
    "LastName VARCHAR(255), " +
    "Username VARCHAR(255), " +
    "Password VARCHAR(255)" +
");";



                using (MySqlCommand cmd = new MySqlCommand(query, con))
                {
                    MySqlDataReader reader = cmd.ExecuteReader();

                }
            }
        }

        public static void CreateCocktailTable()
        {
            string constring = DatabaseConnection.DbConnection();
            using (MySqlConnection con = new MySqlConnection(constring))
            {
                con.Open();
                string query = "CREATE TABLE IF NOT EXISTS cocktail_data (" +
    "Meal VARCHAR(255), " +
    "UserID INT," +
    "CocktailIng1 VARCHAR(255), " +
    "CocktailIng2 VARCHAR(255), " +
    "CocktailIng3 VARCHAR(255), " +
    "CocktailIng4 VARCHAR(255), " +
    "CocktailIng5 VARCHAR(255), " +
    "CocktailIng6 VARCHAR(255), " +
    "CocktailIng7 VARCHAR(255), " +
    "CocktailIng8 VARCHAR(255), " +
    "CocktailIng9 VARCHAR(255), " +
    "CocktailIng10 VARCHAR(255), " +
    "CocktailIng11 VARCHAR(255), " +
    "CocktailIng12 VARCHAR(255), " +
    "CocktailIng13 VARCHAR(255), " +
    "CocktailIng14 VARCHAR(255), " +
    "CocktailIng15 VARCHAR(255), " +
    "CocktailMsr1 VARCHAR(255), " +
    "CocktailMsr2 VARCHAR(255), " +
    "CocktailMsr3 VARCHAR(255), " +
    "CocktailMsr4 VARCHAR(255), " +
    "CocktailMsr5 VARCHAR(255), " +
    "CocktailMsr6 VARCHAR(255), " +
    "CocktailMsr7 VARCHAR(255), " +
    "CocktailMsr8 VARCHAR(255), " +
    "CocktailMsr9 VARCHAR(255), " +
    "CocktailMsr10 VARCHAR(255), " +
    "CocktailMsr11 VARCHAR(255), " +
    "CocktailMsr12 VARCHAR(255), " +
    "CocktailMsr13 VARCHAR(255), " +
    "CocktailMsr14 VARCHAR(255), " +
    "CocktailMsr15 VARCHAR(255), " +
    "FOREIGN KEY (Meal) REFERENCES meal_data(Meal)," +
    "FOREIGN KEY (UserID) REFERENCES login_data(UserID)" +
");";



                using (MySqlCommand cmd = new MySqlCommand(query, con))
                {
                    MySqlDataReader reader = cmd.ExecuteReader();

                }
            }
        }

        public static void CreateRecipeTable()
        {
            string constring = DatabaseConnection.DbConnection();
            using (MySqlConnection con = new MySqlConnection(constring))
            {
                con.Open();
                string query = "CREATE TABLE IF NOT EXISTS recipe_data (" +
            "Meal VARCHAR(255), " +
            "UserID INT," +
            "RecipeIng1 VARCHAR(255), " +
            "RecipeIng2 VARCHAR(255), " +
            "RecipeIng3 VARCHAR(255), " +
            "RecipeIng4 VARCHAR(255), " +
            "RecipeIng5 VARCHAR(255), " +
            "RecipeIng6 VARCHAR(255), " +
            "RecipeIng7 VARCHAR(255), " +
            "RecipeIng8 VARCHAR(255), " +
            "RecipeIng9 VARCHAR(255), " +
            "RecipeIng10 VARCHAR(255), " +
            "RecipeIng11 VARCHAR(255), " +
            "RecipeIng12 VARCHAR(255), " +
            "RecipeIng13 VARCHAR(255), " +
            "RecipeIng14 VARCHAR(255), " +
            "RecipeIng15 VARCHAR(255), " +
            "RecipeIng16 VARCHAR(255), " +
            "RecipeIng17 VARCHAR(255), " +
            "RecipeIng18 VARCHAR(255), " +
            "RecipeIng19 VARCHAR(255), " +
            "RecipeIng20 VARCHAR(255), " +
            "RecipeMsr1 VARCHAR(255), " +
            "RecipeMsr2 VARCHAR(255), " +
            "RecipeMsr3 VARCHAR(255), " +
            "RecipeMsr4 VARCHAR(255), " +
            "RecipeMsr5 VARCHAR(255), " +
            "RecipeMsr6 VARCHAR(255), " +
            "RecipeMsr7 VARCHAR(255), " +
            "RecipeMsr8 VARCHAR(255), " +
            "RecipeMsr9 VARCHAR(255), " +
            "RecipeMsr10 VARCHAR(255), " +
            "RecipeMsr11 VARCHAR(255), " +
            "RecipeMsr12 VARCHAR(255), " +
            "RecipeMsr13 VARCHAR(255), " +
            "RecipeMsr14 VARCHAR(255), " +
            "RecipeMsr15 VARCHAR(255), " +
            "RecipeMsr16 VARCHAR(255), " +
            "RecipeMsr17 VARCHAR(255), " +
            "RecipeMsr18 VARCHAR(255), " +
            "RecipeMsr19 VARCHAR(255), " +
            "RecipeMsr20 VARCHAR(255)," +
            "FOREIGN KEY (Meal) REFERENCES meal_data(Meal)," +
            "FOREIGN KEY (UserID) REFERENCES login_data(UserID)" +
");";


                using (MySqlCommand cmd = new MySqlCommand(query, con))
                {
                    MySqlDataReader reader = cmd.ExecuteReader();
                    
                }
            }
        }

        public static string QueryUsernameData(LoginModel model) 
        {
            string constring = DatabaseConnection.DbConnection();
            using (MySqlConnection con = new MySqlConnection(constring))
            {
                con.Open();
                string query = "SELECT Username" +
                " FROM login_data " +
                                "WHERE Username = '" + model.username + "';";
                using (MySqlCommand cmd = new MySqlCommand(query, con))
                {
                    object result = cmd.ExecuteScalar();

                    if (result != null)
                    {
                        return result.ToString();
                    }

                }
                return null;
            }
        }

        public static string QueryUserIdData(LoginModel model) 
        {
            string constring = DatabaseConnection.DbConnection();
            using (MySqlConnection con = new MySqlConnection(constring))
            {
                con.Open();
                string query = "SELECT UserID" +
                " FROM login_data " +
                                "WHERE Password = '" + model.password + "';";
                using (MySqlCommand cmd = new MySqlCommand(query, con))
                {
                    object result = cmd.ExecuteScalar();

                    if (result != null)
                    {
                        return result.ToString();
                    }

                }
                return null;
            }
        }
        public static string QueryPasswordData(LoginModel model)
        {
            string constring = DatabaseConnection.DbConnection();
            using (MySqlConnection con = new MySqlConnection(constring))
            {
                con.Open();
                string query = "SELECT Password" +
                " FROM login_data " +
                                "WHERE Password = '" + model.password + "';";
                using (MySqlCommand cmd = new MySqlCommand(query, con))
                {
                    object result = cmd.ExecuteScalar();

                    if (result != null)
                    {
                        return result.ToString();
                    }

                }
                return null;
            }
        }

        public static string QueryRecipeIngredientList(string meal, int counter, int globalUserID)
        {
            string constring = DatabaseConnection.DbConnection();
            using (MySqlConnection con = new MySqlConnection(constring))
            {
                con.Open();
                string query = "SELECT RecipeIng" + counter + 
                " FROM recipe_data " +
                                "WHERE Meal = '" + meal + "' AND UserID = " + globalUserID + ";";
                using (MySqlCommand cmd = new MySqlCommand(query, con))
                {
                    object result = cmd.ExecuteScalar();

                    if (result != null)
                    {
                        return result.ToString();
                    }

                }
                return null;
            }
        }

        public static string QueryRecipeMeasureList(string meal, int counter, int globalUserID)
        {
            string constring = DatabaseConnection.DbConnection();
            using (MySqlConnection con = new MySqlConnection(constring))
            {
                con.Open();
                string query = "SELECT RecipeMsr" + counter +
                " FROM recipe_data " +
                                "WHERE Meal = '" + meal + "' AND UserID = " + globalUserID + ";";
                using (MySqlCommand cmd = new MySqlCommand(query, con))
                {
                    object result = cmd.ExecuteScalar();

                    if (result != null)
                    {
                        return result.ToString();
                    }

                }
                return null;
            }
        }

        public static string QueryCocktailIngredientList(string meal, int counter, int globalUserID)
        {
            string constring = DatabaseConnection.DbConnection();
            using (MySqlConnection con = new MySqlConnection(constring))
            {
                con.Open();
                string query = "SELECT CocktailIng" + counter +
                " FROM cocktail_data " +
                                "WHERE Meal = '" + meal + "' AND UserID = " + globalUserID + ";";
                using (MySqlCommand cmd = new MySqlCommand(query, con))
                {
                    object result = cmd.ExecuteScalar();

                    if (result != null)
                    {
                        return result.ToString();
                    }

                }
                return null;
            }
        }

        public static string QueryCocktailMeasureList(string meal, int counter, int globalUserID)
        {
            string constring = DatabaseConnection.DbConnection();
            using (MySqlConnection con = new MySqlConnection(constring))
            {
                con.Open();
                string query = "SELECT CocktailMsr" + counter +
                " FROM cocktail_data " +
                                "WHERE Meal = '" + meal + "' AND UserID = " + globalUserID + ";";
                using (MySqlCommand cmd = new MySqlCommand(query, con))
                {
                    object result = cmd.ExecuteScalar();

                    if (result != null)
                    {
                        return result.ToString();
                    }

                }
                return null;
            }
        }

        public static StringBuilder InsertLoginData(LoginModel model)
        {
            string constring = DatabaseConnection.DbConnection();
            using (MySqlConnection con = new MySqlConnection(constring))
            {
                con.Open();
                string query = "INSERT INTO login_data " +
                "VALUES (" + model.userID + ", '" + model.firstName + "', '" + model.lastName + "', '" + model.username + "', '" + model.password + "');";


                using (MySqlCommand cmd = new MySqlCommand(query, con))
                {
                    MySqlDataReader reader = cmd.ExecuteReader();
                    StringBuilder bu = new StringBuilder();

                    bu.Append("Successfully Signed Up");

                    return bu;
                }
            }
        }

        public static StringBuilder InsertMealData(MealModel model)
        {
            string constring = DatabaseConnection.DbConnection();
            using (MySqlConnection con = new MySqlConnection(constring))
            {
                con.Open();
                string query = "INSERT INTO meal_data " +
                "VALUES (" + "'" + model.Meal + "', " + model.userID + ");";


                using (MySqlCommand cmd = new MySqlCommand(query, con))
                {
                    MySqlDataReader reader = cmd.ExecuteReader();
                    StringBuilder bu = new StringBuilder();

                    bu.Append("Successfully Signed Up");

                    return bu;
                }
            }
        }

        public static List<string> QueryAllMealNamesList(int id) 
        {
            string constring = DatabaseConnection.DbConnection();
            using (MySqlConnection con = new MySqlConnection(constring))
            {
                con.Open();
                string query = "SELECT *" +
                                " FROM meal_data" + 
                                " WHERE " + id + " = UserID;";
                using (MySqlCommand cmd = new MySqlCommand(query, con))
                {
                    MySqlDataReader reader = cmd.ExecuteReader();
                    List<string> bu = new List<string>();
                    while (reader.Read())
                    {
                        bu.Add(reader.GetString(0));
                    }

                    return bu;

                }
            }
        }
        public static StringBuilder InsertRecipeData(RecipeModel model)
        {
            string constring = DatabaseConnection.DbConnection();
            using (MySqlConnection con = new MySqlConnection(constring))
            {
                con.Open();
                string query = "INSERT INTO recipe_data " +
                "VALUES ('" + model.Meal + "'," + model.UserID +  ", '" + model.RecipeIng1 + "', '" + model.RecipeIng2
                + "', '" + model.RecipeIng3 + "', '" + model.RecipeIng4 + "', '" + model.RecipeIng5
                + "', '" + model.RecipeIng6 + "', '" + model.RecipeIng7 + "', '" + model.RecipeIng8
                + "', '" + model.RecipeIng9 + "', '" + model.RecipeIng10 + "', '" + model.RecipeIng11
                + "', '" + model.RecipeIng12 + "', '" + model.RecipeIng13 + "', '" + model.RecipeIng14
                + "', '" + model.RecipeIng15 + "', '" + model.RecipeIng16 + "', '" + model.RecipeIng17
                + "', '" + model.RecipeIng18 + "', '" + model.RecipeIng19 + "', '" + model.RecipeIng20
                + "', '" + model.RecipeMsr1 + "', '" + model.RecipeMsr2 + "', '" + model.RecipeMsr3
                + "', '" + model.RecipeMsr4 + "', '" + model.RecipeMsr5 + "', '" + model.RecipeMsr6
                + "', '" + model.RecipeMsr7 + "', '" + model.RecipeMsr8 + "', '" + model.RecipeMsr9
                + "', '" + model.RecipeMsr10 + "', '" + model.RecipeMsr11 + "', '" + model.RecipeMsr12
                + "', '" + model.RecipeMsr13 + "', '" + model.RecipeMsr14 + "', '" + model.RecipeMsr15
                + "', '" + model.RecipeMsr16 + "', '" + model.RecipeMsr17
                + "', '" + model.RecipeMsr18 + "', '" + model.RecipeMsr19 + "', '" + model.RecipeMsr20 + "');";


                using (MySqlCommand cmd = new MySqlCommand(query, con))
                {
                    MySqlDataReader reader = cmd.ExecuteReader();
                    StringBuilder bu = new StringBuilder();

                    bu.Append("Recipe Added");

                    return bu;
                }
            }
        }
        public static StringBuilder InsertCocktailData(CocktailModel model)
        {
            string constring = DatabaseConnection.DbConnection();
            using (MySqlConnection con = new MySqlConnection(constring))
            {
                con.Open();
                string query = "INSERT INTO cocktail_data " +
                "VALUES ('" + model.Meal + "'," + model.UserID + ", '" + model.CocktailIng1 + "', '" + model.CocktailIng2
                + "', '" + model.CocktailIng3 + "', '" + model.CocktailIng4 + "', '" + model.CocktailIng5
                + "', '" + model.CocktailIng6 + "', '" + model.CocktailIng7 + "', '" + model.CocktailIng8
                + "', '" + model.CocktailIng9 + "', '" + model.CocktailIng10 + "', '" + model.CocktailIng11
                + "', '" + model.CocktailIng12 + "', '" + model.CocktailIng13 + "', '" + model.CocktailIng14
                + "', '" + model.CocktailIng15 + "', '" 
                + model.CocktailMsr1 + "', '" + model.CocktailMsr2 + "', '" + model.CocktailMsr3
                + "', '" + model.CocktailMsr4 + "', '" + model.CocktailMsr5 + "', '" + model.CocktailMsr6
                + "', '" + model.CocktailMsr7 + "', '" + model.CocktailMsr8 + "', '" + model.CocktailMsr9
                + "', '" + model.CocktailMsr10 + "', '" + model.CocktailMsr11 + "', '" + model.CocktailMsr12
                + "', '" + model.CocktailMsr13 + "', '" + model.CocktailMsr14 + "', '" + model.CocktailMsr15
                + "');";


                using (MySqlCommand cmd = new MySqlCommand(query, con))
                {
                    MySqlDataReader reader = cmd.ExecuteReader();
                    StringBuilder bu = new StringBuilder();

                    bu.Append("Cocktail Added");

                    return bu;
                }
            }
        }

        public static void DeleteMeal(string meal, int globalUserID) 
        {
            string constring = DatabaseConnection.DbConnection();
            using (MySqlConnection con = new MySqlConnection(constring))
            {
                con.Open();
                string query = "DELETE"  +
                " FROM meal_data " +
                                "WHERE Meal = '" + meal + "' AND UserID = " + globalUserID + ";";
                using (MySqlCommand cmd = new MySqlCommand(query, con))
                {
                    object result = cmd.ExecuteScalar();

                    if (result != null)
                    {
                        
                    }

                }
               
            }
        }

        public static void DeleteRecipe(string meal, int globalUserID)
        {
            string constring = DatabaseConnection.DbConnection();
            using (MySqlConnection con = new MySqlConnection(constring))
            {
                con.Open();
                string query = "DELETE" +
                " FROM recipe_data " +
                                "WHERE Meal = '" + meal + "' AND UserID = " + globalUserID + ";";
                using (MySqlCommand cmd = new MySqlCommand(query, con))
                {
                    object result = cmd.ExecuteScalar();

                    if (result != null)
                    {

                    }

                }

            }
        }
        public static void DeleteCocktail(string meal, int globalUserID)
        {
            string constring = DatabaseConnection.DbConnection();
            using (MySqlConnection con = new MySqlConnection(constring))
            {
                con.Open();
                string query = "DELETE" +
                " FROM cocktail_data " +
                                "WHERE Meal = '" + meal + "' AND UserID = " + globalUserID + ";";
                using (MySqlCommand cmd = new MySqlCommand(query, con))
                {
                    object result = cmd.ExecuteScalar();

                    if (result != null)
                    {

                    }

                }

            }
        }
    }
}
