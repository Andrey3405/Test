﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test.Interface
{
    interface IFormMethods
    {
        //Методы
        DialogResult ShowDialog();
        DialogResult DialogResult { get; set; }
    }
}
