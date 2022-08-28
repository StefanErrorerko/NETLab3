using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NETLab3.GameItems
{
    internal class Chip100 : Chip
    {
        public override decimal Value { get; }

        public Chip100() : base()
        {
            Value = 100;
        }

        public override string ToString() => string.Format("[Фiшка {0}од.]", Value);
    }
}
