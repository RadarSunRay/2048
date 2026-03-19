using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2048
{
    public interface IRandom
    {
        public int Next(int minValue, int maxValue);
        public int Next(int maxValue);
    }
}
