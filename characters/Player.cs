
using System.Collections.Generic;
namespace RPGHero
{
   public class Player : Profession,IInformation
    {
        public const string NAME = "Hero";
      

        public Player(int Health, int Mana, long Gold,LinkedList<EQUIPMENT_TYPES> Equipment,long Experience)
            : base(Health,Mana,Gold,Equipment,Experience)
        {
            
        }

        protected override void SetCharacterClass(PROFESSION_TYPES profession)
        {
            this.CharacterClass = profession;
        }

        public void HealHP()
        {
            this.Health += 10;
        }
        public void HealMP()
        {
            this.Mana += 10;
        }

        public void Print_Character_Info()
        {
            throw new System.NotImplementedException();
        }

        public int Normal_Attack()
        {
            throw new System.NotImplementedException();
        }

        public int Special_Attack()
        {
            throw new System.NotImplementedException();
        }
    }
}
