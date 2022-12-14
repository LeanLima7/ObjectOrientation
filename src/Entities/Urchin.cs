using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace ObjectOrientation.src.Entities
{
    public class Urchin : Character
    {
        public Urchin(Character character)
        {
            this.Name = character.Name;
            this.Classification = character.Classification;
            this.Age = character.Age;
            this.Origin = character.Origin;
            this.Skill = character.Skill;
        }

       public string Attack()
        {
            string skillOutput = "";

            foreach( var skills in this.Skill)
            {
                skillOutput += (skillOutput == "" ? "": "\n") + this.Name + " attacks with " + skills;
            }
            return skillOutput;
        }

        public string Attack(int Bonus)
        {
            return this.Name + " attacked with attack bonus " + Bonus;
            
        }


    }
}