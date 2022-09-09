using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ObjectOrientation.src.Entities
{
    public  class Character
    {
        //public static string Sega = "";

        public Character(string Name = "", string Classification = "", int Age = 0, string Origin = "", List<string> Skill = null)
        {            
            this.Name = Name;
            this.Classification = Classification;
            this.Age = Age;
            this.Origin = Origin;
            this.Skill = Skill;
        }
        
        public string Name;
        public string Classification;
        public int Age;
        public string Origin;
        public List<string> Skill;

        public override string ToString()
        {
            return this.Name + " " + this.Classification + " " + this.Age + " " + this.Origin +  " " + this.Skill;        

        }

       
  
    }


}