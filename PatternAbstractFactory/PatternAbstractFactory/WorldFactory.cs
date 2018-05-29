using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternAbstractFactory
{
    public abstract class WorldFactory
    {
        public abstract Herbivore CreateHerbivore();

        public abstract Plant CreatePlant();

        public abstract Predator CreatePredator();
    }

    public class MarsFactory: WorldFactory
    {
        public override Herbivore CreateHerbivore()
        {
            return new Cow("Мурка");
        }

        public override Plant CreatePlant()
        {
            return new Groot("Groot");
        }

        public override Predator CreatePredator()
        {
            return new Bear("Vinni");
        }
    }

    public class PandoraFactoty : WorldFactory
    {
        public override Herbivore CreateHerbivore()
        {
            return new Deer("Bambi");
        }

        public override Plant CreatePlant()
        {
            return new Seawead("Weed");
        }

        public override Predator CreatePredator()
        {
            return new Cat("Matroskin");
        }
    }
    public class World
    {
        Plant plant;
        Herbivore herbi;
        Predator pred;
        public World(WorldFactory factory)
        {
            plant = factory.CreatePlant();
            herbi = factory.CreateHerbivore();
            pred = factory.CreatePredator();
        }
        public void RunFoodChaine()
        {
            Console.WriteLine(plant.Grow());
            Console.WriteLine(herbi.EatPlant(plant));
            Console.WriteLine(pred.EatHerbivore(herbi));
        }
    }
}

