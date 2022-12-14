# Object-Oriented using   <img align="center" alt="Rafa-Csharp" height="50" width="60" src="https://cdn.jsdelivr.net/gh/devicons/devicon/icons/csharp/csharp-original.svg">

### Challenge Description โ๏ธ<img src="https://user-images.githubusercontent.com/87840459/189416370-797e626c-8d72-4bfb-af73-455995a84c7a.gif" width="30px">
</div>

Considering the knowledge of the C# programming language, this project develops a simple application where the pillars of object-oriented programming are used.

 ## Abstraction โป๏ธ<img src="https://user-images.githubusercontent.com/87840459/189417115-0a061998-c5bb-424e-a047-d9b30aa0367f.gif" width="30px">
<br></div>
 
 It's checking everything we can reuse. 
 
 In the case of this project, this concept is applied in the "Character" class, where all the points that all characters have in common were gathered.
 
 Character.cs: ๐
  - public  class Character.
 
## Inheritance ๐จโ๐งโ๐ฆ๐จโ๐ฉโ๐งโ๐ง๐ฉโ๐งโ๐ฆ<img src="https://user-images.githubusercontent.com/87840459/189427519-f7f9cc56-fa34-4b11-a724-ac8ff76638ef.gif" width="40px">
<br></div>

Inheritance is a mechanism that allows features common to several classes to be factored on a class basis, or superclass. From a base of classes, other classes can be specified.

In this project the "Urchin", "Fox" and "Echidna" classes inherit attributes from the "Character" class. The attributes are:

 - string Name = "";
 - string Classification = "";
 - int Age = 0;
 - string Origin = "";
 - List<string> Skill = null.
 
 ## Polymorphism ๐งฌ<img src="https://user-images.githubusercontent.com/87840459/189417503-0a9732ce-98ac-4595-8314-caeadb71a66a.gif" width="60px">
<br></div>
 
Polymorphism is the principle by which classes can invoke methods that have the same identification but different behavior.

In this project "Urchin" class characters can only attack or attack with bonuses.

 Urchin.cs: ๐
 - public string Attack();
 - public string Attack(int Bonus);

 ## Encapsulation ๐<img src="https://user-images.githubusercontent.com/87840459/189418802-7192be17-10f9-4714-8b62-8c97319f28b8.gif" width="70px">
<br></div>
 
Encapsulation is a code design principle that guides us to hide the functionality and functioning of our code inside small units (usually methods and functions).

This is where the business rule usually remains.

In this project this concept is applied in several stages, one of which is the rule of the attack bonus of the "Echidna" class.

 Echidna.cs: ๐
  
  ##### <if (Bonus <= 6)>

   - {return this.Name + " attacked with SUPER attack " + Bonus;}
   - else { return this.Name + " attacked with HYPER attack " + Bonus;}

      
   ## References ๐๐จ๐พโ๐ป<img src="https://user-images.githubusercontent.com/87840459/189422339-6a95da58-0047-4dc7-ab9d-887b0af101f6.gif" width="60px">
<br>

 The project's characters were inspired by the Sonic the Hedgehog franchise.

 This is a study project proposed through the [Digital Innovation One](https://www.dio.me/?ref=RE6NDV822B) platform.


 [Certificate: ๐](https://www.dio.me/en/certificate/4E02AD64/share)



