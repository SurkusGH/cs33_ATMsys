using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cs33_paskaita_ATMsys
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
        //  (1) Programa turi �patikrinti� ar �d�ta kortel� yra tinkama(susimuliuoti tarkim Guid�� sulyginim�)
        //  (2) Saugoti faile vartotoj� bankin�s kortel�s ir slapta�od�i� informacij� ir pinig� sum�.
        //  (3) Papra�yti vartotojo �vesti slapta�od�.
        //  (4) �vedus blogai tris kartus i�jungti program�.
        //  (5) �vedus taisyklingai prisijungti ir parodyti turimus pinigus.
        //  (6) S�kmingai prisijungus turi b�ti papildomi pasirinkimai:
        //  (7) Matyti turimus pinigus
        //  (8) 5 praeitos transakcijos
        //  (9) Pinig� i�si�mimas
        // (10) Maksimumas pinig� i�si�mimui turi b�ti 1000e ir maksimalus transakcij� skai�ius per dien� - 10.

        //  (!) Naudoti gali bet k�, improvizuokit:)
    }
}
