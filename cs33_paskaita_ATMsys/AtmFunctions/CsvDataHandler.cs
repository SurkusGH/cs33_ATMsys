using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs33_paskaita_ATMsys
{
    public class CsvDataHandler
    {
        public void writedatatocsv(UserDataType userdatatype) // <-- metodas nenaudojamas
        {
            string path = $@"D:\GitHub\cs33_paskaita_ATMsys\cs33_paskaita_ATMsys\CsvDataRepository\UserData.csv";
            string dataString = Environment.NewLine + $"{userdatatype.Name}, " +
                                                      $"{userdatatype.LastName}, " +
                                                      $"{userdatatype.UserID}, " +
                                                      $"{userdatatype.Password}, " +
                                                      $"{userdatatype.Balance}, " +
                                                      $"{userdatatype.Operations}";
            File.AppendAllText(path, dataString);
        }
        public List<UserDataType> ReadCsvData()
        {
            string path = $@"D:\GitHub\cs33_paskaita_ATMsys\cs33_paskaita_ATMsys\CsvDataRepository\UserData.csv";
            var csvLineReader = new StreamReader(path);

            var cardData = new List<UserDataType>();

            while (!csvLineReader.EndOfStream)
            {
                var line = csvLineReader.ReadLine();
                string[] tempCache = line.Split(", ");

                cardData.Add(UserParser(tempCache));
            }
            return cardData;
        }
        public UserDataType UserParser(string[] tempCache)
        {
            var user = new UserDataType();
            user.Name = tempCache[0];
            user.LastName = tempCache[1];
            user.UserID = tempCache[2];
            user.Password = tempCache[3];
            user.Balance = decimal.Parse(tempCache[4]);
            user.Operations = tempCache[5].Split("> ").ToList();

            return user;
        }
    }
}
