using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Malcaba.WeightWatcher.App.Model
{
    public class WeightHistory
    {
        public DateTime WeightDate { get; set; }
        public double WeightLbs { get; set; }
        public double WeightKg => Math.Round(WeightLbs / 2.2046226218, 2);
    }
}
