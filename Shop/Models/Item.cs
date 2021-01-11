using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Models
{
    public class Item
    {
        public int Id { get; set; }
        public string Name{ get; set; }
        public string Descripton { get; set; }
        public byte[] Image { get; set; }
    }
}
