using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class Education
    {
        public string EducationID { get; set; }
        public string Degree { get; set; }
        public string Institution { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string UserID { get; set; }
       
        public User User { get; set; }
    }
}
