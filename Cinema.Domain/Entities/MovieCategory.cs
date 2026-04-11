using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema.Domain.Entities
{
    public class MovieCategory
    {
        public int Id { get; set; }

        public required string Name { get; set; }
    }
}
