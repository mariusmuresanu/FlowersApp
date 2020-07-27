﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlowersApp.Models
{
    public enum FlowerUpkeepDifficulty
    {
        Easy,
        Medium,
        Hard
    }
    public class Flower
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTimeOffset DateAdded { get; set; }
        public long marketPrice { get; set; }
        public FlowerUpkeepDifficulty flowerUpkeepDifficulty { get; set; }
     }
}
