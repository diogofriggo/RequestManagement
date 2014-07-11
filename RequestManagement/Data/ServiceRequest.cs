using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RequestManagement.Data
{
    public class ServiceRequest
    {
        private int Id { get; set; }
        public Technician Technician { get; set; }
        public User Requester { get; set; }
        public string Description { get; set; }
        public string Cause { get; set; }
        public string Result { get; set; }
        public IList<Activity> PlannedActivities { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime AssignedOn { get; set; }
        public DateTime ClosedOn { get; set; }
        public string Extension { get; set; }
        public string Department { get; set; }
        public RequestStatus Solved { get; set; }
        public string Observations { get; set; }
    }
}