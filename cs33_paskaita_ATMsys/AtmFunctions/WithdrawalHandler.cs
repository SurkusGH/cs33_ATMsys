using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs33_paskaita_ATMsys.AtmFunctions
{
    public class WithdrawalHandler
    {
        public static string Sum = "";
        public static string WitthdrawalConstructor(string input)
        {
            Sum += input;
            return Sum;
        }
        public static List<UserDataType> Withdraw(List<UserDataType> userList, int cardIndicator)
        {
            userList[cardIndicator].Balance = userList[cardIndicator].Balance - int.Parse(Sum);
            userList[cardIndicator].OperationsLimit = userList[cardIndicator].OperationsLimit - 1;
            userList[cardIndicator].LastFiveOperations.Insert(0, Sum);
            userList[cardIndicator].LastFiveOperations.RemoveAt(5);
            CsvDataHandler.WriteDataToCsv(userList);
            Sum = "";
            return userList;
        }
    }
}
