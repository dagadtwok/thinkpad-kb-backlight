using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Keyboard_Core;

namespace thinkpad_kb
{
    internal class keyboardManager
    {
        KeyboardControl kbC = new KeyboardControl();
        public void setKbLight(int level) {

            kbC.SetKeyboardBackLightStatus(level, null);
        }

        public int getKbLight() { 
            kbC.GetKeyboardBackLightStatus(out int level, null);
            return level;
        }
    }
}
