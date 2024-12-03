using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class User
    {
        public string UserID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string LinkedInURL { get; set; }
        public string GitHubURL { get; set; }

        // Navigation properties
        public ICollection<Project> Projects { get; set; }
        public ICollection<Skill> Skills { get; set; }
        public ICollection<Education> Educations { get; set; }
        public ICollection<Experience> Experiences { get; set; }
    }
}
