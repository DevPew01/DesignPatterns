using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternAbstractFactory
{
    public abstract class Herbivore
    {
        protected internal string Name { set; get; }

        public virtual string EatPlant(Plant plant)
        {
            return $"Я {this.Name} я сьел {plant.Name}";
        }
    }

    public class Deer : Herbivore
    {
        public Deer(string Name)
        {
            this.Name = Name;
        }
        public override string EatPlant(Plant plant)
        {
            return $"Я {this.Name} я сьел {plant.Name}";
        }
    }

    public class Cow : Herbivore
    {
        public Cow(string Name)
        {
            this.Name = Name;
        }
        public override string EatPlant(Plant plant)
        {
            return $"Я {this.Name} я сьел {plant.Name}";
        }
    }
}
