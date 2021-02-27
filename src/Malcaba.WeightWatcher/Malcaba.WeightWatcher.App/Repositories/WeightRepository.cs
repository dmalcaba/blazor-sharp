using Malcaba.WeightWatcher.App.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;

namespace Malcaba.WeightWatcher.App.Repositories
{
    public class WeightRepository
    {
        public static List<PersonalWeight> GetWeightByName(string name) 
            => PersonalWeightData.Where(x => x.Name == name).ToList();

        public static List<PersonalWeight> PersonalWeightData => new List<PersonalWeight>
        {
            new PersonalWeight
            {
                Name = "Mommy", WeightHistory = new List<WeightHistory>
                {
                    new WeightHistory { WeightDate = new DateTime(2020, 1, 4), WeightLbs = 124 },
                    new WeightHistory { WeightDate = new DateTime(2020, 2, 5), WeightLbs = 124.6 },
                    new WeightHistory { WeightDate = new DateTime(2020, 3, 1), WeightLbs = 124.3 },
                    new WeightHistory { WeightDate = new DateTime(2020, 3, 22), WeightLbs = 122.6 },
                    new WeightHistory { WeightDate = new DateTime(2020, 3, 29), WeightLbs = 121.1 },
                    new WeightHistory { WeightDate = new DateTime(2020, 4, 2), WeightLbs = 122.7 },
                    new WeightHistory { WeightDate = new DateTime(2020, 5, 1), WeightLbs = 123.6 },
                }
            },
            new PersonalWeight
            {
                Name = "Daddy", WeightHistory = new List<WeightHistory>
                {
                    new WeightHistory { WeightDate = new DateTime(2020, 1, 1), WeightLbs = 138.4 },
                    new WeightHistory { WeightDate = new DateTime(2020, 1, 4), WeightLbs = 136.1 },
                    new WeightHistory { WeightDate = new DateTime(2020, 2, 5), WeightLbs = 136.7 },
                    new WeightHistory { WeightDate = new DateTime(2020, 3, 1), WeightLbs = 136.4 },
                    new WeightHistory { WeightDate = new DateTime(2020, 3, 22), WeightLbs = 132.3 },
                    new WeightHistory { WeightDate = new DateTime(2020, 3, 29), WeightLbs = 131.8 },
                    new WeightHistory { WeightDate = new DateTime(2020, 4, 1), WeightLbs = 131.4 },
                    new WeightHistory { WeightDate = new DateTime(2020, 5, 1), WeightLbs = 131.5 },
                }
            }
        };

        public static string PersonalWeightsInJson =>
            JsonSerializer.Serialize(PersonalWeightData);
    }
}
