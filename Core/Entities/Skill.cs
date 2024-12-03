using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class Skill
    {
        public string SkillID { get; set; }
        public string SkillName { get; set; }
        public string ProficiencyLevel { get; set; }
        public string UserID { get; set; }
        public User User { get; set; }
    }
}
