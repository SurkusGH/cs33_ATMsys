using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs33_paskaita_ATMsys.AtmFunctions
{
    public class PasswordAuthentication
    {
        public static string Password = "";
        public static string PasswordConstructor(string input)
        {
            Password += input;
            return Password;
        }
        public static bool PasswordValidation(List<UserDataType> userList, int cardIndicator, int counter)
        {
            if (userList[cardIndicator].Password == Password && counter < 4)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static void CardBlocking(List<UserDataType> userList, int cardIndicator)
        {
            var dataWriter = new CsvDataHandler();
            userList[cardIndicator].Name = "Blokuota";
            userList[cardIndicator].UserID = "Blokuota";
            userList[cardIndicator].Password = "Blokuota";
            dataWriter.WriteDataToCsv(userList);
        }
    }
}
