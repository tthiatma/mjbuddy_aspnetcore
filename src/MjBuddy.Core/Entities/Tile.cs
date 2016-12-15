﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MjBuddy.Core.Entities
{
    [Table("AppTiles")]
    public class Tile
    {
        public int Id { get; set; }
        public string Name { get; set; }

    }
}
