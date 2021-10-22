using Microsoft.Data.Sqlite;
using System;
using System.Data;
using System.Data.SQLite;
using System.Text;

namespace DataToConsole
{
    class Program
    {

        public static void ShowProhibitedProducts(SQLiteCommand selectCMD)
        {
            selectCMD.CommandText = "SELECT * FROM Prohibited_products";
            selectCMD.CommandType = CommandType.Text;
            SQLiteDataReader myReader = selectCMD.ExecuteReader();

            Console.WriteLine("product_id\tname\t\talternative\t\tinfo");
            while (myReader.Read())
            {
                Console.WriteLine(myReader["product_id"] + "\t\t" + myReader["name"] + "\t\t" + myReader["alternative"] + "\t\t" + myReader["info"]);
            }
        }

        public static void ShowGuardians(SQLiteCommand selectCMD)
        {
            selectCMD.CommandText = "SELECT * FROM Guardians";
            selectCMD.CommandType = CommandType.Text;
            SQLiteDataReader myReader = selectCMD.ExecuteReader();

            Console.WriteLine("guardian_id\tunder_guardian_ship_id");
            while (myReader.Read())
            {
                Console.WriteLine(myReader["guardian_id"] + "\t\t" + myReader["under_guardian_ship_id"]);
            }
        }

        public static void ShowTakingMedication(SQLiteCommand selectCMD)
        {
            selectCMD.CommandText = "SELECT * FROM Taking_medication";
            selectCMD.CommandType = CommandType.Text;
            SQLiteDataReader myReader = selectCMD.ExecuteReader();

            Console.WriteLine("id\tuser_id\t\tdata\t\t\t\tchecking");
            while (myReader.Read())
            {
                Console.WriteLine(myReader["id"] + "\t" + myReader["user_id"] + "\t\t" + myReader["data"] + "\t\t" + myReader["checking"]);
            }
        }

        public static void ShowUsersAnswers(SQLiteCommand selectCMD)
        {
            selectCMD.CommandText = "SELECT * FROM User_answers";
            selectCMD.CommandType = CommandType.Text;
            SQLiteDataReader myReader = selectCMD.ExecuteReader();

            Console.WriteLine("id\tuser_id\t\tanswer\t\tnumber_question");
            while (myReader.Read())
            {
                Console.WriteLine(myReader["id"] + "\t" + myReader["user_id"] + "\t\t" + myReader["answer"] + "\t\t" + myReader["number_question"]);
            }
        }

        public static void ShowUsers(SQLiteCommand selectCMD)
        {
            selectCMD.CommandText = "SELECT * FROM Users";
            selectCMD.CommandType = CommandType.Text;
            SQLiteDataReader myReader = selectCMD.ExecuteReader();

            Console.WriteLine("user_id\tname\t\tage\t\tphone number\t\tinfo\t\t\t\t\tlogin\t\tpassword");
            while (myReader.Read())
            {
                Console.WriteLine(myReader["user_id"] + "\t" + myReader["name"] + "\t\t" + myReader["age"] + "\t\t" + myReader["phone_number"]
                    + "\t\t" + myReader["info"] + "\t\t" + myReader["login"] + "\t\t" + myReader["password"]);
            }
        }

        public static void ShowAllergensDetermination(SQLiteCommand selectCMD)
        {
            selectCMD.CommandText = "SELECT * FROM Allergens_determination";
            selectCMD.CommandType = CommandType.Text;
            SQLiteDataReader myReader = selectCMD.ExecuteReader();

            Console.WriteLine("id\tquestion\t\t\tvariant1\t\tvariant2\t\tvariant3\t\tvariant4");
            while (myReader.Read())
            {
                Console.WriteLine(myReader["id"] + "\t" + myReader["question"] + "\t\t" + myReader["variant1"] + "\t\t" + myReader["variant2"]
                    + "\t\t" + myReader["variant3"] + "\t\t" + myReader["variant4"]);
            }
        }




        static void Main(string[] args)
        {
           
            string connectionString = @" Data Source = c:\Users\annac\Allergens\Allergens.db";

            using (SQLiteConnection con = new SQLiteConnection(connectionString))
            {
                    con.Open();

                    using (SQLiteCommand selectCMD = con.CreateCommand())
                    {              
                       //call function
                    }                   

               
            }
        }
    }
}
