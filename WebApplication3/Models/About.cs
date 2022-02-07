using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication3.Models
{
    public class about
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Subtitle { get; set; }

        public static implicit operator List<object>(about v)
        {
            throw new NotImplementedException();
        }
    }
}
