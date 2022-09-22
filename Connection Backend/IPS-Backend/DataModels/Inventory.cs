using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IPS_Backend.DataModels
{
    public class Inventory
    {  
        public int inventoryID { get; set; }
        public List<Item> items { get; set; }
    }
}
