using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RequestManagement.Data
{
    public class Result
    {
        private int Id { get; set; }
        public string Description { get; set; }
        public ResultStatus Status { get; set; }
    }
}
