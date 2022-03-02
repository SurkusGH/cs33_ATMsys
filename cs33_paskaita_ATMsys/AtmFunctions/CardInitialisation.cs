using cs33_paskaita_ATMsys.GUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs33_paskaita_ATMsys.AtmFunctions
{
    public class CardInitialisation
    {
        public static CsvDataHandler Handler = new CsvDataHandler();
        public static List<UserDataType> Users = new List<UserDataType>();
        public static List<UserDataType> LoadCards()
        {
            Users = Handler.ReadCsvData();
            return Users;
        }
        public static string CardSelector(int index)
        {
            var userSelected = Users[index];
            string dataPrinting = $"\n\n\n   Vartotojo ID: *{userSelected.UserID}*";
            if (Users[index].IsBlocked == false)
                {
                dataPrinting += $"\n   Sveiki {userSelected.Name}, įveskite slaptažodį." +
                                $"\n   Įvestis: ";
                return dataPrinting;
                }
            if (Users[index].IsBlocked == true)
                {
                dataPrinting += $"\n   Sveiki {userSelected.Name}" +
                                $"\n   Jūsų Kortelė yra (!)" +
                                $"\n   (!) BLOKUOTA. ";
                return dataPrinting;
                }   
                return dataPrinting;
            //foreach (var item in collection)
            //{

            //}
        }
    }
}
