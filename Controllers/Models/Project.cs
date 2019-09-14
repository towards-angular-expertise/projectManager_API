using System;

namespace Backend.Controllers.Models
{
    public class Project
    {
        public int id { get; set; } 
        public bool isdeleted { get; set; }
        public bool isnotusing { get; set; }
        public string name { get; set; }
        public string url { get; set; }
        public bool active { get; set; }
        public DateTime? startdate { get; set; }
        public DateTime? enddate { get; set; }
        public DateTime? createddate { get; set; }

        public int userid { get; set; } // Foreign key 
        
    }
}