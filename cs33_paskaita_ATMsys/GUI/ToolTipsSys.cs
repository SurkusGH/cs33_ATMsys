using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs33_paskaita_ATMsys.GUI
{
    public class ToolTipsSys
    {
        public static string TurnOnTooltip()
        {
            string ToolTip = $"\n <--Pasirinkite kortelę" +
                             $"\n\n\n\n <--Pasirinkite kortelę" + 
                             $"\n\n\n\n <--Pasirinkite kortelę" +
                             $"\n\n\n\n <--Pasirinkite kortelę";
            return ToolTip;
        }

        public static string CardInsertTooltip()
        {
            string ToolTip = $"              Rinkitės veiksmą -->" +
                             $"\n\n              Rinkitės veiksmą -->" +
                             $"\n\n              Rinkitės veiksmą -->" +
                             $"\n\n\n     SLAPTAŽODIS TEISINGAS";
            return ToolTip;
        }

        public static string InputToolTip()
        {
            string ToolTip = $"\n\n\n Kiek pinigų gryninsite?" +
                             $"\n\n\n               Skaitinė įvestis -->" +
                             $"\n\n               Skaitinė įvestis -->" +
                             $"\n\n               Skaitinė įvestis -->" +
                             $"\n\n               Skaitinė įvestis -->";
            return ToolTip;
        }
    }
}
