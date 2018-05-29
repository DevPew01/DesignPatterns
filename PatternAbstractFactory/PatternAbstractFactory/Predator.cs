using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternAbstractFactory
{
    public abstract class Predator
    {
        protected internal string Name { set; get; }
        public virtual string EatHerbivore(Herbivore herbivore)
        {
            return $"Я {this.Name}, я сьел {herbivore.Name}";
        }
    }

    public class Cat : Predator
    {
        public Cat()
        {

        }

        public Cat(string Name)
        {
            this.Name = Name;
        }
        public override string EatHerbivore(Herbivore herbivore)
        {
            return base.EatHerbivore(herbivore);
        }
    }

    public class Bear: Predator
    { 
        public Bear()
        {

        }

        public Bear(string Name)
        {
            this.Name = Name;
        }
        public override string EatHerbivore(Herbivore herbivore)
        {
            return $"Я {this.Name} я сьел {herbivore.Name}";
        }
    }
}
