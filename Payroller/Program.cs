using System;
using System.Windows.Forms;

namespace Payroller
{
    static class Program
    {
        public static Loaded MainLoadedForm;
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            MainLoadedForm = new Loaded();
            Application.Run(MainLoadedForm);
        }
    }
}