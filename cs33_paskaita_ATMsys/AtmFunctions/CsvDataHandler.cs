using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace cs33_paskaita_ATMsys
{
    public class CsvDataHandler
    {
        public void WriteDataToCsv(List<UserDataType> userDataList) // <-- metodas nenaudojamas
        {
            string path = $@"D:\GitHub\cs33_paskaita_ATMsys\cs33_paskaita_ATMsys\CsvDataRepository\UserData.csv";
            File.WriteAllText(path, string.Empty); // <-- išvalau rinkmėną, pridedu modifikuotą kontentą
            userDataList.ForEach(userData => File.AppendAllText(path, $"{userData.Name}, " +
                                                                      $"{userData.LastName}, " +
                                                                      $"{userData.UserID}, " +
                                                                      $"{userData.Password}, " +
                                                                      $"{userData.Balance}, " +
                                                                      $"{userData.OperationsLimit}, " +
                                                                      $"{userData.LastFiveOperations.Select(x => string.Concat($"{x}> "))}" +
                                                                      Environment.NewLine));
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
            csvLineReader.Close();
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
            user.OperationsLimit = int.Parse(tempCache[5]);
            user.LastFiveOperations = tempCache[6].Split("> ").ToList();

            return user;
        }
    }
}
