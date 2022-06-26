using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NETLab3.GameItems
{
    internal class Chip10 : Chip
    {
        public override decimal Value { get; }

        public Chip10() : base()
        {
            Value = 10;
        }

        public override string ToString() => String.Format("[Фiшка {0}од.]", Value);

    }
}
