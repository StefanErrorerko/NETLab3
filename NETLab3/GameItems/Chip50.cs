using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NETLab3.GameItems
{
    internal class Chip50 : Chip
    {
        public override decimal Value { get; }

        public Chip50() : base()
        {
            Value = 50;
        }
        public override string ToString() => string.Format("[Фiшка {0}од.]", Value);

    }
}
