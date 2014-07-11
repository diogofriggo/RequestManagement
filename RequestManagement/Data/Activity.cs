using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RequestManagement.Data
{
    public class Activity
    {
        private int Id { get; set; }
        public string Description { get; set; }
        public DateTime EstimatedDuration { get; set; }
        public DateTime ActualDuration { get; set; }
        public double Variation { get; set; } /*percent?*/
    }
}
