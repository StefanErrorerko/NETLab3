using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NETLab3.GameItems
{
    internal class GameBoard
    {
        //estimated in amount of fields that board consist of
        public double Size { get; init; }

        public GameBoard(double size)
        {
            Size = size;
        }
    }
}
