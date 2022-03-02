using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs33_paskaita_ATMsys
{
    public class UserDataType
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public int PasswordInputLimit { get; set; }
        public bool IsBlocked { get; set; }
        public string UserID { get; set; }
        public string Password { get; set; }
        public decimal Balance { get; set; }
        public int OperationsLimit { get; set; }
        public List<string> LastFiveOperations { get; set; }

        public UserDataType(string name = "", string lastName = "", int passwordInputLimit = 0, bool isBlocked = false, string userID = "",
                            string password = "", decimal balance = 0, int operationsLimit = 0, List<string> lastFiveOperations = null)
        {
            Name = name;
            LastName = lastName;
            PasswordInputLimit = passwordInputLimit;
            IsBlocked = isBlocked;
            UserID = userID;
            Password = password;
            Balance = balance;
            OperationsLimit = operationsLimit;
            LastFiveOperations = lastFiveOperations;
        }

        public override string? ToString() // <-- nebenaudosiu (?)
        {
            return $"{LastFiveOperations[0]}> " +
                   $"{LastFiveOperations[1]}> " +
                   $"{LastFiveOperations[2]}> " +
                   $"{LastFiveOperations[3]}> " +
                   $"{LastFiveOperations[4]}";
        }
    }
}
