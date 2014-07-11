using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RequestManagement.Data
{
    public class User
    {
        private int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Department { get; set; }
        public string Building { get; set; }
        public string Office { get; set; }
        public int EquipmentAssetNumber { get; set; }
        public DateTime ServiceWindow { get; set; }
        public string Description { get; set; }
    }
}