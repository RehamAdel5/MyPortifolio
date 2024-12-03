using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class Experience
    {
        public string ExperienceID { get; set; }
        public string JobTitle { get; set; }
        public string CompanyName { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string UserID { get; set; }
        public User User { get; set; }
    }
}
