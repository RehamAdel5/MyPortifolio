using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class Project
    {
        public string ProjectID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string TechnologyStack { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string UserID { get; set; }
        public User User { get; set; }
    }
}
