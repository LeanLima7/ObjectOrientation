# Object-Oriented using   <img align="center" alt="Rafa-Csharp" height="50" width="60" src="https://cdn.jsdelivr.net/gh/devicons/devicon/icons/csharp/csharp-original.svg">

### Challenge Description ⚙️

Considering the knowledge of the C# programming language, this project develops a simple application where the pillars of object-oriented programming are used.

 ## Abstraction ♻️
 
 It's checking everything we can reuse. 
 
 In the case of this project, this concept is applied in the "Character" class, where all the points that all characters have in common were gathered.
 
 Character.cs: 📁
  - public  class Character.
 
## Inheritance 👨‍👧‍👦👨‍👩‍👧‍👧👩‍👧‍👦

Inheritance is a mechanism that allows features common to several classes to be factored on a class basis, or superclass. From a base of classes, other classes can be specified.

In this project the "Urchin", "Fox" and "Echidna" classes inherit attributes from the "Character" class. The attributes are:

 - string Name = "";
 - string Classification = "";
 - int Age = 0;
 - string Origin = "";
 - List<string> Skill = null.
 
 ## Polymorphism 🧬
 
Polymorphism is the principle by which classes can invoke methods that have the same identification but different behavior.

In this project "Urchin" class characters can only attack or attack with bonuses.

 Urchin.cs: 📁
 - public string Attack();
 - public string Attack(int Bonus);

 ## Encapsulation 💊
 
Encapsulation is a code design principle that guides us to hide the functionality and functioning of our code inside small units (usually methods and functions).

This is where the business rule usually remains.

In this project this concept is applied in several stages, one of which is the rule of the attack bonus of the "Echidna" class.

 Echidna.cs: 📁
  
  ##### <if (Bonus <= 6)>

   - {return this.Name + " attacked with SUPER attack " + Bonus;}
   - else { return this.Name + " attacked with HYPER attack " + Bonus;}




