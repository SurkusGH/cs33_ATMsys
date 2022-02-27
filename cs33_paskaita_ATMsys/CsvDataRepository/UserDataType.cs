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
        public string UserID { get; set; }
        public string Password { get; set; }
        public decimal Balance { get; set; }
        public List<string> Operations { get; set; }

        public UserDataType(string name = "", string lastName = "", string userID = "", string password = "",
                            decimal balance = 0, List<string> operations = null)
        {
            Name = name;
            LastName = lastName;
            UserID = userID;
            Password = password;
            Balance = balance;
            Operations = operations;
        }
    }
}
