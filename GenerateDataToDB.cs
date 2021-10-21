using System;
using System.Data.SQLite;
using System.Text;

namespace AddDataSQLlite
{
    class Program
    {
        public static string GetRandomTextUpper(int size)
        {
            StringBuilder builder = new StringBuilder();
            Random random = new Random();
            for (int i = 0; i < size; i++)
            {
                builder.Append(Convert.ToChar(Convert.ToInt32(Math.Floor(26 * random.NextDouble() + 65))));
            }

            return builder.ToString();
        }    

        public static DateTime RandomDay()
        {
            Random gen = new Random();
            DateTime start = new DateTime(2020, 1, 1);
            int range = (DateTime.Today - start).Days;
            return start.AddDays(gen.Next(range));
        }
        
        static string GetRandomTelNo()
        {
            Random rand = new Random();
            StringBuilder telNo = new StringBuilder(12);
            int number;
            for (int i = 0; i < 3; i++)
            {
                number = rand.Next(0, 8); 
                telNo = telNo.Append(number.ToString());
            }
            telNo = telNo.Append("-");
            number = rand.Next(0, 743);
            telNo = telNo.Append(String.Format("{0:D3}", number));
            telNo = telNo.Append("-");
            number = rand.Next(0, 10000); 
            telNo = telNo.Append(String.Format("{0:D4}", number));
            return telNo.ToString();
        }
        
        public static void AddAllergensDetermination(SQLiteCommand cmd, Random rnd, SQLiteConnection con)
        {
            int iduser_id = rnd.Next(1, 40);

            cmd.CommandText = @"INSERT INTO Allergens_determination (id, question,variant1,variant2,variant3,variant4) 
                    VALUES ( @Id,@Question, @Variant1, @Variant2,@Variant3, @Variant4)";
            cmd.Connection = con;
            string textQuestion = GetRandomTextUpper(20);
            string textVariant = GetRandomTextUpper(10);

            cmd.Parameters.Add(new SQLiteParameter("@Id"));
            cmd.Parameters.Add(new SQLiteParameter("@Question", textQuestion));
            cmd.Parameters.Add(new SQLiteParameter("@Variant1", textVariant));
            cmd.Parameters.Add(new SQLiteParameter("@Variant2", textVariant));
            cmd.Parameters.Add(new SQLiteParameter("@Variant3", textVariant));
            cmd.Parameters.Add(new SQLiteParameter("@Variant4", textVariant));
            con.Open();
        }

        public static void AddUsers(SQLiteCommand cmd, Random rnd, SQLiteConnection con)
        {
            int iduser_id = rnd.Next(1, 40);
            int ageUser = rnd.Next(16, 60);


            cmd.CommandText = @"INSERT INTO Users (user_id, name,age,phone_number,info,login,password) VALUES ( @User_id,@Name, @Age, @Phone,@Info, @Login, @Password )";
            cmd.Connection = con;
            string textname = GetRandomTextUpper(5);
            string textInfo = GetRandomTextUpper(30);
            string textLogin = GetRandomTextUpper(6);
            string textPassword = GetRandomTextUpper(4);
            cmd.Parameters.Add(new SQLiteParameter("@User_id"));
            cmd.Parameters.Add(new SQLiteParameter("@Name", textname));
            cmd.Parameters.Add(new SQLiteParameter("@Age", ageUser));
            cmd.Parameters.Add(new SQLiteParameter("@Phone", GetRandomTelNo()));
            cmd.Parameters.Add(new SQLiteParameter("@Info", textInfo));
            cmd.Parameters.Add(new SQLiteParameter("@Login", textLogin));
            cmd.Parameters.Add(new SQLiteParameter("@Password", textPassword));

            con.Open();
        }

        public static void AddUsersAnswers(SQLiteCommand cmd, Random rnd, SQLiteConnection con)
        {
            int iduser_id = rnd.Next(1, 40);
            int numb_quest = rnd.Next(1, 20);
            string[] names = new string[] { "A", "B", "C", "D" };
            int answersIndex = rnd.Next(names.Length);


            cmd.CommandText = @"INSERT INTO User_answers (id, user_id, answer, number_question) VALUES (@Id, @User_id, @Answer, @Number_question)";
            cmd.Connection = con;

            cmd.Parameters.Add(new SQLiteParameter("@Id"));
            cmd.Parameters.Add(new SQLiteParameter("@User_id", iduser_id));
            cmd.Parameters.Add(new SQLiteParameter("@Answer", names[answersIndex]));
            cmd.Parameters.Add(new SQLiteParameter("@Number_question", numb_quest));


            con.Open();
        }

        public static void AddTakingMedication(SQLiteCommand cmd, Random rnd, SQLiteConnection con)
        {
            int idElementUnder_guardian_ship_id = rnd.Next(1, 40);
            string[] names = new string[] { "take", "half take", "not take" };
            int checkIndex = rnd.Next(names.Length);


            cmd.CommandText = @"INSERT INTO Taking_medication (id, user_id, data, checking) VALUES (@Id,@User_id, @Data,@Checking )";
            cmd.Connection = con;
            cmd.Parameters.Add(new SQLiteParameter("@Id"));
            cmd.Parameters.Add(new SQLiteParameter("@User_id", idElementUnder_guardian_ship_id));
            cmd.Parameters.Add(new SQLiteParameter("@Data", RandomDay()));
            cmd.Parameters.Add(new SQLiteParameter("@Checking", names[checkIndex]));


            con.Open();
        }

        public static void AddGuardian(SQLiteCommand cmd, Random rnd, SQLiteConnection con)
        {
            int idElementUnder_guardian_ship_id = rnd.Next(1, 40);


            cmd.CommandText = @"INSERT INTO Guardians (guardian_id, under_guardian_ship_id) VALUES (@Guardian_id,@Under_guardian_ship_id)";
            cmd.Connection = con;
            cmd.Parameters.Add(new SQLiteParameter("@Guardian_id"));
            cmd.Parameters.Add(new SQLiteParameter("@Under_guardian_ship_id", idElementUnder_guardian_ship_id));


            con.Open();

        }

        public static void AddProhibitedProducts(SQLiteCommand cmd, Random rnd, SQLiteConnection con)
        {
            int sizeElement = rnd.Next(4, 15);
            string randomName = GetRandomTextUpper(sizeElement);
            string randomAlternative = GetRandomTextUpper(sizeElement);
            string randomInfo = GetRandomTextUpper(sizeElement);

            cmd.CommandText = @"INSERT INTO Prohibited_products (product_id, name, alternative, info) VALUES (@Product_id,@Name,@Alternative, @Info)";
            cmd.Connection = con;
            cmd.Parameters.Add(new SQLiteParameter("@Product_id"));
            cmd.Parameters.Add(new SQLiteParameter("@Name", randomName));
            cmd.Parameters.Add(new SQLiteParameter("@Alternative", randomAlternative));
            cmd.Parameters.Add(new SQLiteParameter("@Info", randomInfo));

            con.Open();
        }

        static void Main(string[] args)
        {
            int n = 40;
            for (int j = 1; j < n; j++)
            {
               
                string connectionString = @" Data Source = c:\Users\annac\Allergens-1\Allergens.db";
               
                using (SQLiteConnection con = new SQLiteConnection(connectionString))
                {

                    try
                    {
                        SQLiteCommand cmd = new SQLiteCommand();
                        Random rnd = new Random();
                        AddAllergensDetermination(cmd, rnd, con);
                        AddUsers(cmd, rnd, con);
                        AddUsersAnswers(cmd, rnd, con);
                        AddTakingMedication(cmd, rnd, con);
                        AddGuardian(cmd, rnd, con);
                        AddProhibitedProducts(cmd, rnd, con);
                        int i = cmd.ExecuteNonQuery();
                        if (i == i)
                        {
                            Console.WriteLine("user added ");
                        }

                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex);
                    }
                }
            }
        }
    }
}
