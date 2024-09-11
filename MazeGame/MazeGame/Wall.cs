using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MazeGame
{
    public class Wall : IMazeObject
    {
        public char Icon { get => '-'; }
        public bool Isolid { get => true; }
    }
}
