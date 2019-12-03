using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;

namespace WindowsUiAutomation
{
    public class WindowHandle
    {
        /* https://bit.ly/2Re1GrT */
        public void ActiveWindow(int id)
        {
            //Interaction.AppActivate("Calculator");
            Interaction.AppActivate(id);
        }
        public void ActiveWindow(string title)
        {
            //Interaction.AppActivate("Calculator");
            Interaction.AppActivate(title);
        }
    }
}
