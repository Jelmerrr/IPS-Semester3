using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;

namespace IPS_Backend.DataModels
{
    public class User
    {
        public int userID { get; set; }
        public string userName { get; set; }
        public string userPass { get; set; }
        public List<Inventory> inventories { get; set; }
    }
}
