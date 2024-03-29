using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RPG.src.Entities
{
    public abstract class Hero
    {

        // classe abstrata de Herois
        public Hero()
        {

        }
        public Hero(string Name, int Level, string HeroType, int Health, int Attack, int Defense)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
            this.Health = Health;
            this.Attack = Attack;
            this.Defense = Defense;
        }

        public string Name { get; set; }
        public int Level { get; set; }
        public string HeroType { get; set; }
        public int Health { get; set; }
        public int Attack {get; set;}
        public int Defense {get; set;}


        // Aprensetação do Heroi
        public virtual string ToString()
        {
            return $"\t\tHeroi\n\tNome: {this.Name} \n\tClasse: {this.HeroType} \n\tNivel: {this.Level} \n\tVida: {this.Health} \n\tAtaque: {this.Attack} \n\tDefesa: {this.Defense}";
        }


        // Classe de ataque do heroi
        public virtual int Ataque()
        {
            return Attack;
        }

        // Classe de Defesa do Heroi
        public virtual int Defesa()
        {
            return Defense;
        }
    }
}