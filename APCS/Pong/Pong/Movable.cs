using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Pong
{
    interface Movable
    {
        //Paint and Move methods
        void paint(Graphics g);
        int move();
    }
}
