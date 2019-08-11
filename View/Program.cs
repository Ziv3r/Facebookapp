using System;
using System.Collections.Generic;

namespace View
{
    class Program
    {
        [STAThread]
        public static void Main()
        {
            UI ui = new UI();
            ui.Start();

        }
    }
}
