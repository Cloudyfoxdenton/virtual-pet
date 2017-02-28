using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Media;
using System.Threading.Tasks;

namespace VirtualPet
{
    public class Pet
    {
        private int hunger = 80;
        private int energy = 50;
        private int poop = 0;
        private int life = 200;
        private int bored = 0;
        private string petName = String.Empty;
        

        public Pet()
        {

        }

        public Pet(string name)
        {
            this.petName = name;
        }

        public Pet(string name, int hungerCount, int energyCount, int poopCount, int lifeCount, int boredCount)
        {
            this.hunger = hungerCount;
            this.energy = energyCount;
            this.poop = poopCount;
            this.life = lifeCount;
            this.bored = boredCount;
        }

        public void Feed()
        {
            hunger += 15;
            energy -= 10;
            life -= 10;
            poop += 10;
            bored += 10;
        }

        public void Clean()
        {
            poop -= 10;
            life -= 5;
            bored += 20;
        }
        public void Kick()
        {
            life -= 5;
            energy -= 20;
            poop += 10;
            hunger -= 10;

        }
        public void ToBed()
        {
            life -= 5;
            energy += 20;
            hunger -= 10;
            poop += 10;
            bored += 10;
        }
        public void Play()
        {
            life -= 5;
            energy -= 20;
            hunger -= 20;
            poop += 10;
            bored -= 20;
        }

        public string PetName
        {
            get { return this.petName; }
           
        }

        public int petHunger
        {
            get { return this.hunger;  }
            set { hunger = value; }
        }

        public int petEnergy
        {
            get { return this.energy; }
            set { energy = value; }
        }
        public int petPoop
        {
            get { return this.poop; }
            set { poop = value; }
        }
        public int petAge
        {
            get { return this.life;  }
            set { life = value; }
        }
        public int petBoredom
        {
            get { return this.bored; }
            set { bored = value; }
        }

        
    }

   
}
