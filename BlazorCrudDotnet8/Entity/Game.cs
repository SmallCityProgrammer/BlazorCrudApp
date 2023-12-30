using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorCrudDotnet8.Entity
{
    public class Game
    {
        public int Id { get; set; }
        public required string Name { get; set; }
    }
}