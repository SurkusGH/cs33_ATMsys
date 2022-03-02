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
        public static bool PasswordValidation(List<UserDataType> userList, int cardIndicator)
        {
            if (userList[cardIndicator].Password == Password && userList[cardIndicator].PasswordInputLimit < 4 && userList[cardIndicator].IsBlocked == false)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static void PasswordInputLimitCounter(List<UserDataType> userList, int cardIndicator)
        {
            userList[cardIndicator].PasswordInputLimit += 1;
            CsvDataHandler.WriteDataToCsv(userList);
        }
        public static void ResetPasswordInputLimit(List<UserDataType> userList, int cardIndicator)
        {
            userList[cardIndicator].PasswordInputLimit = 0;
            CsvDataHandler.WriteDataToCsv(userList);
        }

        public static void CardBlocking(List<UserDataType> userList, int cardIndicator)
        {
            userList[cardIndicator].IsBlocked = true;
            CsvDataHandler.WriteDataToCsv(userList);
        }
    }
}
