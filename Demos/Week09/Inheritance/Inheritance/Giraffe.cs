using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Inheritance
{
    class Giraffe : VirtualPet
    {
        double NeckLength;

        public Giraffe(string name, ConsoleColor color, double weight, double neckLength)
            : base(name, color, "Giraffe", weight)
        {
            NeckLength = neckLength;
        }

        public override void DrawAvatar()
        {
            ForegroundColor = Color;
            WriteLine(Avatars.Giraffe);
            ResetColor();
        }
    }
}
