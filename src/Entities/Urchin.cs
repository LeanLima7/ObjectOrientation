using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ObjectOrientation.src.Entities
{
    public class Urchin : Character
    {
        public Urchin(Character Attack)
        {
            this.Name = Name;
            this.Classification = Classification;
            this.Age = Age;
            this.Origin = Origin;
            this.Skill = Skill;
        }

       public String Attack()
        {
            return this.Name + "attack with spin dash";
        }
    }
}