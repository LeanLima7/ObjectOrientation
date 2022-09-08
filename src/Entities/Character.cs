using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ObjectOrientation.src.Entities
{
    public class Character
    {
        public Character (String Name, String Classification, int Age, String Origin, String Skill)
        {            
            this.Name = Name;
            this.Classification = Classification;
            this.Age = Age;
            this.Origin = Origin;
            this.Skill = Skill;
        }
    
        public String Name;
        public String Classification;
        public int Age;
        public String Origin;
        public String Skill;

        public override String ToString()
        {
            return this.Name + " " + this.Classification + " " + this.Age + " " + this.Origin +  " " + this.Skill;        

        }

       
  
    }


}