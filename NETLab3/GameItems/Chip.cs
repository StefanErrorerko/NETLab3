using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NETLab3.GameItems
{
    internal abstract class Chip
    {
        public abstract decimal Value { get; }

        protected Chip() { }

        public abstract override string ToString();
    }
}
