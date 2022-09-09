using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientation.src.Entities
{
    public class Echidna : Character
    {
        public Echidna(Character character)
        {
            this.Name = character.Name;
            this.Classification = character.Classification;
            this.Age = character.Age;
            this.Origin = character.Origin;
            this.Skill = character.Skill;
        }
        public String Attack()
        {
            string skillOutput = "";

            foreach (var skills in this.Skill)
            {
                skillOutput += (skillOutput == "" ? "" : "\n") + this.Name + " attacks with " + skills;
            }
            return skillOutput;
        }
    }

}
