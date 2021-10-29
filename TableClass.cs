using System;
using System.Data;
using System.Data.SQLite;
using System.Text;

    public class Users
    {
        private int UserId;
        private string Name;
        private int Age;
        private string Phone;
        private string Info;
        private string Login;
        private string Password;

        public Users() { }
        public Users (int UserId, string Name, int Age, string Phone, string Info, string Login, string Password)
        {
            this.UserId = UserId;
            this.Name = Name;
            this.Phone = Phone;
            this.Info = Info;
            this.Login = Login;
            this.Password = Password;
        }

        public int GetUserId() { return UserId; }
        public int SetUserId(int userId) { return UserId = userId; }

        public string GetName() { return Name; }
        public string SetName(string name) { return Name = name; }

        public int GetAge() { return Age; }
        public int SetAge(int age) { return Age = age; }

        public string GetPhone() { return Phone; }
        public string SetPhone(string phone) { return Phone = phone; }

        public string GetInfo() { return Info; }
        public string SetInfo(string info) { return Info = info; }

        public string GetLogin() { return Login; }
        public string SetLogin(string login) { return Login = login; }

        public string GetPassword() { return Password; }
        public string SetPassword(string password) { return Password = password; }

    }

    public class Answers
    {
        private int AnswerId;
        private string AnswerText;
        private int QuestionRef;

        public Answers() { }
        public Answers(int AnswerId, string AnswerText, int QuestionRef)
        {
            this.AnswerId = AnswerId;
            this.AnswerText = AnswerText;
            this.QuestionRef = QuestionRef;

        }
        public int GetAnswerId() { return AnswerId; }
        public int SetAnswerId(int answerId) { return AnswerId = answerId; }
        public string GetAnswerText() { return AnswerText; }
        public string SetAge(string answerText) { return AnswerText = answerText; }
        public int GetQuestionRef() { return QuestionRef; }
        public int SetQuestionRef(int questionRef) { return QuestionRef = questionRef; }



    }

    public class Guardians
    {
        private int GuardianId;
        private int GuardianUserRef;
        private int UnderGuardianshipUserRef;

        public Guardians() { }
        public Guardians (int GuardianId, int GuardianUserRef, int UnderGuardianshipUserRef)
        {
            this.GuardianId = GuardianId;
            this.GuardianUserRef = GuardianUserRef;
            this.UnderGuardianshipUserRef = UnderGuardianshipUserRef;
        }

        public int GetGuardianId() { return GuardianId; }
        public int SetGuardianId(int guardianId) { return GuardianId = guardianId; }

        public int GetGuardianUserRef() { return GuardianUserRef; }
        public int SetGuardianUserRef(int guardianUserRef) { return GuardianUserRef = guardianUserRef; }

        public int GetUnderGuardianshipUserRef() { return UnderGuardianshipUserRef; }
        public int SetUnderGuardianshipUserRef(int underGuardianshipUserRef) { return UnderGuardianshipUserRef = underGuardianshipUserRef; }



    }

    public class MedicationSchedule
    {
        private int MedicationScheduleId;
        private int UserRef;
        private string Date;
        private int Take;

        public MedicationSchedule() { }
        public MedicationSchedule(int MedicationScheduleId, int UserRef, string Date, int Take)
        {
            this.MedicationScheduleId = MedicationScheduleId;
            this.UserRef = UserRef;
            this.Date = Date;
            this.Take = Take;
        }

        public int GetMedicationScheduleId() { return MedicationScheduleId; }
        public int SetMedicationScheduleId(int medicationScheduleId) { return MedicationScheduleId = medicationScheduleId; }

        public int GetUserRef() { return UserRef; }
        public int SetUserRef(int userRef) { return UserRef = userRef; }

        public string GetDate() { return Date; }
        public string SetDate(string date) { return Date = date; }

        public int GetTake() { return Take; }
        public int SetTake(int take) { return Take = take; }

    }

    public class ProhibitedProducts
    {
        private int ProductID;
        private string Name;
        private string Alternative;
        private string Info;

        public ProhibitedProducts() { }
        public ProhibitedProducts(int ProductID, string Name, string Alternative, string Info)
        {
            this.ProductID = ProductID;
            this.Name = Name;
            this.Alternative = Alternative;
            this.Info = Info;
        }

        public int GetProductID() { return ProductID; }
        public int SetProductID(int productID) { return ProductID = productID; }

        public string GetName() { return Name; }
        public string SetName(string name) { return Name = name; }

        public string GetAlternative() { return Alternative; }
        public string SetAlternative(string alternative) { return Alternative = alternative; }

        public string GetInfo() { return Info; }
        public string SetInfo(string info) { return Info = info; }
    }

    public class Questions
    {
        private int QuestionID;
        private string QuestionText;

        public Questions() { }
        public Questions(int QuestionID, string QuestionText)
        {
            this.QuestionID = QuestionID;
            this.QuestionText = QuestionText;
        }

        public int GetQuestionID() { return QuestionID; }
        public int SetQuestionID(int questionID) { return QuestionID = questionID; }

        public string GetQuestionText() { return QuestionText; }
        public string SetQuestionText(string questionText) { return QuestionText = questionText; }

    }

    public class UserAnswers
    {
        private int UserAnswerID;
        private int UserRef;
        private int AnswerRef;

        public UserAnswers() { }
        public UserAnswers(int UserAnswerID, int UserRef, int AnswerRef)
        {
            this.UserAnswerID = UserAnswerID;
            this.UserRef = UserRef;
            this.AnswerRef = AnswerRef;
        }

        public int GetUserAnswerID() { return UserAnswerID; }
        public int SetQueUserAnswerID(int userAnswerID) { return UserAnswerID = userAnswerID; }

        public int GetUserUserRef() { return UserRef; }
        public int SetUserRef(int userRef) { return UserRef = userRef; }

        public int GetAnswerRef() { return AnswerRef; }
        public int SetAnswerRef(int answerRef) { return AnswerRef = answerRef; }

    }