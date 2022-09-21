using System.Collections.Generic;
namespace RPGHero
{
    public abstract class Profession
    {
        protected int Health { get; set; }
        protected int Mana { get; set; }
        protected long Gold { get; set; }
        protected LinkedList<EQUIPMENT_TYPES> Equipment { get; set; }
        protected long Experience { get; set; }
        protected PROFESSION_TYPES CharacterClass { get; set; }

        public Profession(int Health,int Mana, long Gold, LinkedList<EQUIPMENT_TYPES> Equipment, long Experience)
        {
            this.Health = Health;
            this.Mana = Mana;
            this.Gold = Gold;
            this.Equipment = Equipment;
            this.Experience = Experience;
        }

        protected abstract void SetCharacterClass(PROFESSION_TYPES profession);
        

        
    }
}
