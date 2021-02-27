using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Malcaba.WeightWatcher.App.Model
{
    public class PersonalWeight
    {
        public string Name { get; set; }
        public List<WeightHistory> WeightHistory { get; set; }
    }
}
