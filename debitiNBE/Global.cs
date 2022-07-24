using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace debitiNBE
{
    static class Global
    {
        public static debitiNBEService.HttpEmulator HttpEmulator = new debitiNBEService.HttpEmulator(); 
        public static UserData UserData;
        static public bool loggedState = false;
    }
}
