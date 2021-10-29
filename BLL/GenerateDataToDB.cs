using Microsoft.Data.Sqlite;
using System;
using System.Data;
using System.Data.SQLite;
using System.Text;

class ProgramGenerateData
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

        public static string RandomDay()
        {
            Random gen = new Random();
            DateTime start = new DateTime(2020, 1, 1);
            int range = (DateTime.Today - start).Days;
            return start.AddDays(gen.Next(range)).ToString();
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
                     
        public static void AddUsers(SQLiteCommand cmd, Random rnd, SQLiteConnection con)
        {
            Users user = new Users();
                    
           


            cmd.CommandText = @"INSERT INTO Users (UserId, Name,Age,Phone,Info,Login,Password) VALUES ( @User_id,@Name, @Age, @Phone,@Info, @Login, @Password )";
            cmd.Connection = con;
            
            
            
            
            cmd.Parameters.Add(new SQLiteParameter("@User_id"));
            cmd.Parameters.Add(new SQLiteParameter("@Name", user.SetName(GetRandomTextUpper(5))));
            cmd.Parameters.Add(new SQLiteParameter("@Age", user.SetAge(rnd.Next(16, 60))));
            cmd.Parameters.Add(new SQLiteParameter("@Phone", GetRandomTelNo()));
            cmd.Parameters.Add(new SQLiteParameter("@Info", user.SetInfo(GetRandomTextUpper(30))));
            cmd.Parameters.Add(new SQLiteParameter("@Login", user.SetLogin(GetRandomTextUpper(6))));
            cmd.Parameters.Add(new SQLiteParameter("@Password", user.SetPassword(GetRandomTextUpper(4))));

            con.Open();
        }

        public static void AddAnswers(SQLiteCommand cmd, Random rnd, SQLiteConnection con)
        {
            Answers ans = new Answers();
           
            string[] names = new string[] { "A", "B", "C", "D" };
            int answersIndex = rnd.Next(names.Length);


            cmd.CommandText = @"INSERT INTO Answers (AnswerId, AnswerText, QuestionRef) VALUES (@Id, @answerText, @questionRef)";
            cmd.Connection = con;

            cmd.Parameters.Add(new SQLiteParameter("@Id"));
            cmd.Parameters.Add(new SQLiteParameter("@answerText", names[answersIndex]));
            cmd.Parameters.Add(new SQLiteParameter("@questionRef", ans.SetQuestionRef(rnd.Next(1, 40))));
 

            con.Open();
        }
        
        public static void AddMedicationSchedule(SQLiteCommand cmd, Random rnd, SQLiteConnection con)
        {

            MedicationSchedule schedule = new MedicationSchedule();
                   
           


            cmd.CommandText = @"INSERT INTO MedicationSchedule (MedicationSсheduleID, UserRef, Date, Taken) VALUES (@Id,@UserRef, @Data,@Taken )";
            cmd.Connection = con;
            cmd.Parameters.Add(new SQLiteParameter("@Id"));
            cmd.Parameters.Add(new SQLiteParameter("@UserRef", schedule.SetUserRef(rnd.Next(1, 40))));
            cmd.Parameters.Add(new SQLiteParameter("@Data", schedule.SetDate(RandomDay())));
            cmd.Parameters.Add(new SQLiteParameter("@Taken", schedule.SetTake(rnd.Next(0, 2))));

            con.Open();
        }

        public static void AddGuardian(SQLiteCommand cmd, Random rnd, SQLiteConnection con)
        {
            Guardians guard = new Guardians();


            cmd.CommandText = @"INSERT INTO Guardians (GuardianId, GuardianUserRef, UnderGuardianshipUserRef ) VALUES (@Guardian_id,@GuardianUserRef, @UnderGuardianshipUserRef)";
            cmd.Connection = con;
            cmd.Parameters.Add(new SQLiteParameter("@Guardian_id"));
            cmd.Parameters.Add(new SQLiteParameter("@GuardianUserRef", guard.SetGuardianUserRef(rnd.Next(1, 40))));
            cmd.Parameters.Add(new SQLiteParameter("@UnderGuardianshipUserRef", guard.SetUnderGuardianshipUserRef(rnd.Next(1, 40))));

            con.Open();

        }

        public static void AddProhibitedProducts(SQLiteCommand cmd, Random rnd, SQLiteConnection con)
        {

            ProhibitedProducts prod = new ProhibitedProducts();
            int sizeElement = rnd.Next(4, 15);
            
            cmd.CommandText = @"INSERT INTO ProhibitedProducts (ProductID, Name, Alternative, Info) VALUES (@ProductID,@Name,@Alternative, @Info)";
            cmd.Connection = con;
            cmd.Parameters.Add(new SQLiteParameter("@ProductID"));
            cmd.Parameters.Add(new SQLiteParameter("@Name", prod.SetName(GetRandomTextUpper(sizeElement))));
            cmd.Parameters.Add(new SQLiteParameter("@Alternative", prod.SetAlternative(GetRandomTextUpper(sizeElement))));
            cmd.Parameters.Add(new SQLiteParameter("@Info", prod.SetInfo(GetRandomTextUpper(sizeElement))));

            con.Open();
        }

        public static void AddQuestions(SQLiteCommand cmd, Random rnd, SQLiteConnection con)
        {
            int sizeElement = rnd.Next(4, 15);
            Questions quest = new Questions();
            cmd.CommandText = @"INSERT INTO Questions (QuestionID, QuestionText) VALUES (@QuestionID,@QuestionText)";
            cmd.Connection = con;
            cmd.Parameters.Add(new SQLiteParameter("@QuestionID"));
            cmd.Parameters.Add(new SQLiteParameter("@QuestionText", quest.SetQuestionText(GetRandomTextUpper(sizeElement))));

            con.Open();

        }

        public static void AddUserAnswers(SQLiteCommand cmd, Random rnd, SQLiteConnection con)
        {
            int Element = rnd.Next(1, 40);
            UserAnswers answ = new UserAnswers();
            cmd.CommandText = @"INSERT INTO UserAnswers (UserAnswerID, UserRef, AnswerRef) VALUES (@UserAnswerID,@UserRef, @AnswerRef)";
            cmd.Connection = con;
            cmd.Parameters.Add(new SQLiteParameter("@UserAnswerID"));
            cmd.Parameters.Add(new SQLiteParameter("@UserRef", answ.SetUserRef(Element)));
            cmd.Parameters.Add(new SQLiteParameter("@AnswerRef", answ.SetAnswerRef(Element)));

            con.Open();

        }

        public static void CallFunctionGenerateData()
        {
            int dataQuantity = 40;

            string connectionString = @" Data Source = Path to DB";
            for (int j = 0; j < dataQuantity; j++)
            {

                using (SQLiteConnection con = new SQLiteConnection(connectionString))
                {

                    try
                    {
                        SQLiteCommand cmd = new SQLiteCommand();
                        Random rnd = new Random();

                       // call func exm. AddUserAnswers(cmd, rnd, con);

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