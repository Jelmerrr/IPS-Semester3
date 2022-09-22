using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IPS_Backend.DataModels
{
    public class Item
    {
        public int itemID { get; set; }
        public string itemName { get; set; }
        public string itemDescription { get; set; }
        public string itemStats { get; set; }
    }
}
