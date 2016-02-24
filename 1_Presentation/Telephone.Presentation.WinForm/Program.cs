using System;
using System.Threading;
using System.Windows.Forms;

namespace Telephone.Presentation.WinForm
{
    static class Program
    {
        private static Mutex mutex;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            System.Windows.Forms.Application.EnableVisualStyles();
            System.Windows.Forms.Application.SetCompatibleTextRenderingDefault(false);

            mutex = new Mutex(true, "Telephone.Presentation.WinForm.OnlyRun");
            if (mutex.WaitOne(0, false))
            {
                System.Windows.Forms.Application.Run(new MainForm());
                //System.Windows.Forms.Application.Run(new TestChartForm());
            }
            else
            {
                MessageBox.Show("程序已经在运行！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                System.Windows.Forms.Application.Exit();
            }
        }
    }
}
