using Microsoft.Data.Sqlite;
using System;
using System.Data;
using System.Data.SQLite;
using System.Text;

namespace DataToConsole
{
    class Program
    {
        public static void ShowAnswers(SQLiteCommand selectCMD)
        {
            selectCMD.CommandText = "SELECT * FROM Answers";
            selectCMD.CommandType = CommandType.Text;
            SQLiteDataReader myReader = selectCMD.ExecuteReader();

            Console.WriteLine("AnswerID\tAnswerText\tQuestionRef");
            while (myReader.Read())
            {
                Console.WriteLine(myReader["AnswerID"] + "\t\t" + myReader["AnswerText"] + "\t\t" + myReader["QuestionRef"]);
            }
        }


        public static void ShowGuardians(SQLiteCommand selectCMD)
        {
             selectCMD.CommandText = "SELECT * FROM Guardians";
             selectCMD.CommandType = CommandType.Text;
             SQLiteDataReader myReader = selectCMD.ExecuteReader();

             Console.WriteLine("GuardianId\tGuardianUserRef\t\tUnderGuardianshipUserRef");
             while (myReader.Read())
             {
                 Console.WriteLine(myReader["GuardianId"] + "\t\t" + myReader["GuardianUserRef"] + "\t\t\t" + myReader["UnderGuardianshipUserRef"]);
             }
        }

            public static void ShowProhibitedProducts(SQLiteCommand selectCMD)
        {
            selectCMD.CommandText = "SELECT * FROM ProhibitedProducts";
            selectCMD.CommandType = CommandType.Text;
            SQLiteDataReader myReader = selectCMD.ExecuteReader();

            Console.WriteLine("ProductID\tName\t\t\tAlternative\t\tInfo");
            while (myReader.Read())
            {
                Console.WriteLine(myReader["ProductID"] + "\t\t" + myReader["Name"] + "\t\t" + myReader["Alternative"] + "\t\t" + myReader["Info"]);
            }
        }

       

        public static void ShowMedicationSchedule(SQLiteCommand selectCMD)
        {
            selectCMD.CommandText = "SELECT * FROM MedicationSchedule";
            selectCMD.CommandType = CommandType.Text;
            SQLiteDataReader myReader = selectCMD.ExecuteReader();

            Console.WriteLine("MedicationScheduleID\tUserRef\t\tDate\t\t\t\tTaken");
            while (myReader.Read())
            {
                Console.WriteLine(myReader["MedicationScheduleID"] + "\t" + myReader["UserRef"] + "\t\t" + myReader["Date"] + "\t\t" + myReader["Taken"]);
            }
        }
        public static void ShowQuestions(SQLiteCommand selectCMD)
        {
            selectCMD.CommandText = "SELECT * FROM Questions";
            selectCMD.CommandType = CommandType.Text;
            SQLiteDataReader myReader = selectCMD.ExecuteReader();

            Console.WriteLine("QuestionID\t\tQuestionText");
            while (myReader.Read())
            {
                Console.WriteLine(myReader["QuestionID"] + "\t\t\t" + myReader["QuestionText"]);
            }
        }

        public static void ShowUsersAnswers(SQLiteCommand selectCMD)
        {
            selectCMD.CommandText = "SELECT * FROM UserAnswers";
            selectCMD.CommandType = CommandType.Text;
            SQLiteDataReader myReader = selectCMD.ExecuteReader();

            Console.WriteLine("UserAnswerID\tUserRef\t\tAnswerRef");
            while (myReader.Read())
            {
                Console.WriteLine(myReader["UserAnswerID"] + "\t\t" + myReader["UserRef"] + "\t\t" + myReader["AnswerRef"]);
            }
        }

        public static void ShowUsers(SQLiteCommand selectCMD)
        {
            selectCMD.CommandText = "SELECT * FROM Users";
            selectCMD.CommandType = CommandType.Text;
            SQLiteDataReader myReader = selectCMD.ExecuteReader();

            Console.WriteLine("UserId\tName\t\tAge\t\tPhone\t\t\tInfo\t\t\t\t\tLogin\t\tPassword");
            while (myReader.Read())
            {
                Console.WriteLine(myReader["UserId"] + "\t" + myReader["Name"] + "\t\t" + myReader["Age"] + "\t\t" + myReader["Phone"]
                    + "\t\t" + myReader["Info"] + "\t\t" + myReader["Login"] + "\t\t" + myReader["Password"]);
            }
        }

        public static void CallFunction()
        {
            string connectionString = @" Data Source = Path to DB";

            using (SQLiteConnection con = new SQLiteConnection(connectionString))
            {
                con.Open();

                using (SQLiteCommand selectCMD = con.CreateCommand())
                {
                   //call function exm. ShowUsers(selectCMD);         
                }


            }
        }


        
    }
}
