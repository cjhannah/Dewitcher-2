using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace dewitcher.Dev
{
    public partial class TextScreen
    {
        // Constructor
        public TextScreen()
        {
            Foreground = Color.White;
            Background = Color.Black;
            X = 0;
            Y = 0;
            UpdateCursor(X, Y);
        }
    }
}
