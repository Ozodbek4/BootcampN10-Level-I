using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Net;
using System.Net.Mail;
using N20HomeImtixon.Services;

namespace ImtixonOy1C_.Services
{
    internal class RegistrationService : User
    {
        // these are check valid or invalid
        private bool _IsValidFirstName;
        private bool _IsValidLastName;
        private bool _IsValidEmail;
        private bool _IsEmailSecond;

        
        protected List<User> Users = new List<User>();

        // method Register
        public void Register(string firstName, string lastName, string email, string name = "")
        {
            bool checkAdd = Add(UserFirstName, UserLastName, UserEmail, UserName); // call Add method
            if (checkAdd)
            {
                bool CheckSendEmail = SendEmail(UserEmail);
                if (CheckSendEmail)
                {
                    Users[Users.Count - 1].IsActived = true;
                }
            }
        }

        // method SendEmail
        public bool SendEmail(string receiverAddress)
        {
            try // send message to UserEmail
            {
                var mail = new MailMessage("anvarjonovozodbek416@gmail.com", receiverAddress);
                mail.Subject = "Siz muvaffaqiyatli registratsiyadan o'tdingiz";
                mail.Body = "Hurmatli {{User FirstName}} {{User LastName}}, siz registratsiyadan muvaffaqiyatli o'tdingiz"
                    .Replace("{{User FirstName}}", UserFirstName)
                    .Replace("{{User LastName}}", UserLastName);
                var smtpClient = new SmtpClient("smtp.gmail.com", 587); // Replace with your SMTP server address and port
                smtpClient.Credentials = new NetworkCredential("sultonbek.rakhimov.recovery@gmail.com", "szabguksrhwsbtie");
                smtpClient.EnableSsl = true;

                smtpClient.Send(mail);
                return true;
            }
            catch // for exeption
            {
                return false;
            }
        }
        
        // Method check
        public bool CheckName()
        {
            if (string.IsNullOrEmpty(UserFirstName) || string.IsNullOrEmpty(UserLastName)) return false; // check null not to read next part of code and it helps to read faster
            Regex NameRegex = new Regex("^[A-Za-z\\s.'-]{2,40}$");
            if (NameRegex.IsMatch(UserFirstName)) // this is for out massage which is "Invalid FirstName" to console 
                _IsValidFirstName = true;
            else _IsValidFirstName = false;
            if (NameRegex.IsMatch(UserLastName)) // this for out massage which is "Invalid LastName" to console
                _IsValidLastName = true;
            else _IsValidLastName = false;
            if (_IsValidFirstName && _IsValidLastName) { return true; } // if both of them are true, it return true to Add method
            return false;
        }
        public bool CheckEmailAddress()
        {
            if (string.IsNullOrEmpty(UserEmail)) return false; //  check null not to read next part of code and it helps to read faster as CheckName()
            int count = 0;
            foreach (var user in Users) // this is massage which is "Siz oldin ro'yxatdan o'tdingiz", and stop code here
            {
                count++;
                if (user.UserEmail == UserEmail)
                {
                    _IsEmailSecond = false;
                    return false;
                }
            }
            _IsEmailSecond = true; // make message that "Siz oldin ro'xatdan o'tdingiz"
            Regex EmailRegex = new Regex("^((?!\\.)[\\w\\-_.]*[^.])(@\\w+)(\\.\\w+(\\.\\w+)?[^.\\W])$");
            if (EmailRegex.IsMatch(UserEmail)) // check email
            { 
                _IsValidEmail = true; // valid message
                return true;
            }
            _IsValidEmail = false;
            return false;
        }

        public string GenerateUserName(string userName)
        {
            if (userName == "") // make userName as user's name
            {
                userName = UserFirstName;
            }
            for (int i = 0; i < Users.Count; i++) // make new userName
            {
                if (userName == Users[i].UserName)
                {
                    Random random = new Random();
                    userName += random.Next(0, 10).ToString();
                    i = 0; // basic part, if user[0] == "vali1", and random choose 1, and userName == "vali" + "1",  trouble with userName
                }
            }
            return userName;
        }

        protected bool Add(string userFirstName, string userLastName, string userEmail, string userName = "")
        {
            CheckName(); // run CHeck method
            CheckEmailAddress(); // run CheckEmailAddress
            if (_IsValidFirstName == false) // message
            {
                Console.WriteLine("Invalid Firstname");
            }
            if (_IsValidLastName == false) // message
            {
                Console.WriteLine("Invalid Lastname");
            }
            if (_IsEmailSecond == false && _IsValidEmail && _IsValidFirstName && _IsValidLastName) // message
            {
                Console.WriteLine("Siz olding ro'yxatdan o'tgansiz");
            }
            else if(_IsValidEmail == false) // message
            {
                Console.WriteLine("Invalid Email Address");
            }
            if (_IsValidFirstName && _IsValidLastName && _IsValidEmail && _IsEmailSecond) // three method return true
            {
                if (userName == "") // optional
                {
                    userName = GenerateUserName(userName); // generate new userName
                }
                else
                {
                    foreach (var user in Users)
                    {
                        if (user.UserName == userName) // if there is same userName, make other userName
                        {
                            userName = GenerateUserName(userName);
                            break;
                        }
                    }
                }
                // all method make true the new user add to list
                Users.Add(new User() { UserFirstName = userFirstName, UserLastName = userLastName, UserEmail = userEmail, UserName = userName });
                return true;
            }
            return false;
        }

        public void Display() // method display, show users
        {
            foreach (var User in Users)
            {
                Console.WriteLine($"{User.UserFirstName} {User.UserLastName}");
            }
        }
    }
}
