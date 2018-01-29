using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Test.Department;
using Test.Department.Presenter;
using Test.Department.View;

namespace Test
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            DepartmentPresenter presenter = new DepartmentPresenter();
            Form mainForm = presenter.ShowForm();
            if(presenter.ShowForm() != null)
                    Application.Run(mainForm);
        }
    }
}
