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
        //  (1) Programa turi “patikrinti” ar ádëta kortelë yra tinkama(susimuliuoti tarkim Guid’ø sulyginimà)
        //  (2) Saugoti faile vartotojø bankinës kortelës ir slaptaþodþiø informacijà ir pinigø sumà.
        //  (3) Papraðyti vartotojo ávesti slaptaþodá.
        //  (4) Ávedus blogai tris kartus iðjungti programà.
        //  (5) Ávedus taisyklingai prisijungti ir parodyti turimus pinigus.
        //  (6) Sëkmingai prisijungus turi bûti papildomi pasirinkimai:
        //  (7) Matyti turimus pinigus
        //  (8) 5 praeitos transakcijos
        //  (9) Pinigø iðsiëmimas
        // (10) Maksimumas pinigø iðsiëmimui turi bûti 1000e ir maksimalus transakcijø skaièius per dienà - 10.

        //  (!) Naudoti gali bet kà, improvizuokit:)
    }
}
