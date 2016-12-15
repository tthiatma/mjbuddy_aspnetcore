using MjBuddy.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MjBuddy.Service
{
    public interface ITileData
    {
        Tile Get(int id);
    }
}
